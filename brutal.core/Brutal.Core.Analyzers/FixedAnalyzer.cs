using System.Collections.Concurrent;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;

namespace Brutal.Core.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class FixedAnalyzer : DiagnosticAnalyzer
{
    // Keep in mind: you have to list your rules here.
    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
    [Resources.ExpectsFixedBrutalCore0009, Resources.ExpectsFixedBrutalCore0010, Resources.LosesFixedBrutalCore0012];

    public override void Initialize(AnalysisContext context)
    {
        context.EnableConcurrentExecution();
        context.ConfigureGeneratedCodeAnalysis(
            GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics
        );

        context.RegisterCompilationStartAction(static compilationContext =>
        {
            var analysis = new CompilationAnalysis();
            compilationContext.RegisterOperationBlockAction(analysis.AnalyzeOperationBlock);
            compilationContext.RegisterOperationAction(
                analysis.AnalyzeDelegateCreation,
                OperationKind.DelegateCreation
            );
        });
    }

    /// One instance per compilation, so the attribute lookups (which walk override chains and
    /// interface implementations) are computed once per symbol instead of once per use site.
    private sealed class CompilationAnalysis
    {
        private readonly ConcurrentDictionary<ISymbol, bool> _fixedParameters = new(SymbolEqualityComparer.Default);
        private readonly ConcurrentDictionary<ISymbol, bool> _fixedReturns = new(SymbolEqualityComparer.Default);
        private readonly ConcurrentDictionary<ISymbol, bool> _fixedProperties = new(SymbolEqualityComparer.Default);

        public void AnalyzeOperationBlock(OperationBlockAnalysisContext context)
        {
            foreach (var operationBlock in context.OperationBlocks)
            {
                if (!IsControlFlowGraphRoot(operationBlock))
                    continue;
                if (!ContainsFixedSink(operationBlock))
                    continue;

                var graph = context.GetControlFlowGraph(operationBlock);
                AnalyzeGraph(context, graph, context.OwningSymbol as IMethodSymbol);
            }
        }

        /// A delegate whose parameter is unmarked erases an effective [Fixed] on the converted
        /// method: every later call is checked against the delegate's signature, so the
        /// conversion is the only place the loss is still visible.
        public void AnalyzeDelegateCreation(OperationAnalysisContext context)
        {
            var creation = (IDelegateCreationOperation)context.Operation;

            var source = creation.Target switch
            {
                IMethodReferenceOperation methodReference => methodReference.Method,
                IAnonymousFunctionOperation anonymousFunction => anonymousFunction.Symbol,
                _ => null,
            };
            if (source == null)
                return;
            if (creation.Type is not INamedTypeSymbol { DelegateInvokeMethod: { } invoke } delegateType)
                return;

            // A closed extension-method group binds the receiver at creation, so the source has
            // one parameter the delegate does not; align positionally from the end. The bound
            // receiver parameter itself, if [Fixed], is erased outright.
            var offset = source.Parameters.Length - invoke.Parameters.Length;
            if (offset is not (0 or 1))
                return;

            if (offset == 1 && ParameterIsFixed(source.Parameters[0]))
            {
                ReportLoss(context, creation, delegateType, source, source.Parameters[0]);
                return;
            }

            for (var i = 0; i < invoke.Parameters.Length; i++)
            {
                if (!ParameterIsFixed(source.Parameters[i + offset]) || ParameterIsFixed(invoke.Parameters[i]))
                    continue;

                ReportLoss(context, creation, delegateType, source, source.Parameters[i + offset]);
                return;
            }
        }

        private static void ReportLoss(
            OperationAnalysisContext context,
            IDelegateCreationOperation creation,
            INamedTypeSymbol delegateType,
            IMethodSymbol source,
            IParameterSymbol lostParameter
        )
        {
            var sourceName = source.MethodKind is MethodKind.AnonymousFunction or MethodKind.LambdaMethod
                ? "the lambda expression"
                : $"'{source.Name}'";

            context.ReportDiagnostic(
                Diagnostic.Create(
                    Resources.LosesFixedBrutalCore0012,
                    creation.Target.Syntax.GetLocation(),
                    sourceName,
                    delegateType.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat),
                    lostParameter.Name
                )
            );
        }

        private static bool IsControlFlowGraphRoot(IOperation operation) =>
            operation.Kind
                is OperationKind.Block
                    or OperationKind.MethodBody
                    or OperationKind.ConstructorBody
                    or OperationKind.FieldInitializer
                    or OperationKind.PropertyInitializer
                    or OperationKind.ParameterInitializer;

        /// The flow pass is priced into every consumer build, so bodies without a [Fixed] sink skip it.
        private bool ContainsFixedSink(IOperation root)
        {
            foreach (var operation in EnumerateOperations(root))
            {
                if (operation is IArgumentOperation argument && ParameterIsFixed(argument.Parameter))
                    return true;
                if (
                    operation is IConversionOperation { OperatorMethod: { } operatorMethod }
                    && operatorMethod.Parameters.Length > 0
                    && ParameterIsFixed(operatorMethod.Parameters[0])
                )
                    return true;
            }

            return false;
        }

        private static IEnumerable<IOperation> EnumerateOperations(IOperation root)
        {
            var pending = new Stack<IOperation>();
            pending.Push(root);
            while (pending.Count > 0)
            {
                var operation = pending.Pop();
                yield return operation;
                foreach (var child in operation.ChildOperations)
                    pending.Push(child);
            }
        }

        private void AnalyzeGraph(OperationBlockAnalysisContext context, ControlFlowGraph graph, IMethodSymbol? owner)
        {
            var blocks = graph.Blocks;
            var flows = new BlockFlow[blocks.Length];
            for (var i = 0; i < flows.Length; i++)
                flows[i] = new BlockFlow();

            var initial = new FlowState();
            if (owner != null)
            {
                foreach (var parameter in owner.Parameters)
                    initial.Symbols[parameter] = ParameterIsFixed(parameter);
            }

            // Forward dataflow to fixpoint. The lattice per variable is { Fixed, NotFixed } with
            // meet = AND, so every update is monotonically downward and the loop terminates.
            bool changed;
            do
            {
                changed = false;
                foreach (var block in blocks)
                {
                    var flow = flows[block.Ordinal];
                    var entry = ComputeEntry(block, blocks, flows, initial);
                    if (entry == null)
                        continue;

                    if (!FlowState.Equal(entry, flow.Entry))
                    {
                        flow.Entry = entry;
                        changed = true;
                    }

                    var transfer = Transfer(block, flow.Entry!.Clone(), report: null);

                    if (!FlowState.Equal(transfer.State, flow.Exit))
                    {
                        flow.Exit = transfer.State;
                        changed = true;
                    }

                    flow.ExceptionMeet = transfer.ExceptionMeet;
                }
            } while (changed);

            foreach (var block in blocks)
            {
                var flow = flows[block.Ordinal];
                if (flow.Entry == null)
                    continue;

                Transfer(block, flow.Entry.Clone(), context.ReportDiagnostic);
            }

            foreach (var localFunction in graph.LocalFunctions)
                AnalyzeGraph(context, graph.GetLocalFunctionControlFlowGraph(localFunction), localFunction);

            foreach (var block in blocks)
            {
                foreach (var rootOperation in BlockRoots(block))
                {
                    foreach (var operation in EnumerateOperations(rootOperation))
                    {
                        if (operation is IFlowAnonymousFunctionOperation anonymousFunction)
                            AnalyzeGraph(
                                context,
                                graph.GetAnonymousFunctionControlFlowGraph(anonymousFunction),
                                anonymousFunction.Symbol
                            );
                    }
                }
            }
        }

        private static IEnumerable<IOperation> BlockRoots(BasicBlock block)
        {
            foreach (var operation in block.Operations)
                yield return operation;
            if (block.BranchValue != null)
                yield return block.BranchValue;
        }

        private FlowState? ComputeEntry(
            BasicBlock block,
            ImmutableArray<BasicBlock> blocks,
            BlockFlow[] flows,
            FlowState initial
        )
        {
            if (block.Kind == BasicBlockKind.Entry)
                return initial.Clone();

            FlowState? entry = null;

            foreach (var branch in block.Predecessors)
            {
                var predecessorExit = flows[branch.Source.Ordinal].Exit;
                if (predecessorExit == null)
                    continue;

                var carried = predecessorExit;
                foreach (var finallyRegion in branch.FinallyRegions)
                    carried = ApplyFinallyRegion(carried, finallyRegion, blocks);

                entry = entry == null ? carried.Clone() : FlowState.Meet(entry, carried);
            }

            // A handler has no explicit predecessor edges: an exception can surface it from any point
            // inside the paired try region, so its entry is the meet over every state observed there.
            for (
                var region = block.EnclosingRegion;
                region != null && region.FirstBlockOrdinal == block.Ordinal;
                region = region.EnclosingRegion
            )
            {
                if (
                    region.Kind
                    is not (
                        ControlFlowRegionKind.Catch
                        or ControlFlowRegionKind.Filter
                        or ControlFlowRegionKind.FilterAndHandler
                        or ControlFlowRegionKind.Finally
                    )
                )
                    continue;

                var tryRegion = FindPairedTryRegion(region);
                if (tryRegion == null)
                    continue;

                for (var ordinal = tryRegion.FirstBlockOrdinal; ordinal <= tryRegion.LastBlockOrdinal; ordinal++)
                {
                    var observed = flows[ordinal].ExceptionMeet;
                    if (observed == null)
                        continue;
                    entry = entry == null ? observed.Clone() : FlowState.Meet(entry, observed);
                }
            }

            return entry;
        }

        private static ControlFlowRegion? FindPairedTryRegion(ControlFlowRegion handlerRegion)
        {
            for (var region = handlerRegion.EnclosingRegion; region != null; region = region.EnclosingRegion)
            {
                if (region.Kind is ControlFlowRegionKind.TryAndCatch or ControlFlowRegionKind.TryAndFinally)
                    return region.NestedRegions[0];
            }

            return null;
        }

        /// A branch that leaves through a finally region carries the finally's effects with it.
        /// The region is re-run on the carried state (a local fixpoint over its blocks), so the
        /// normal path keeps its own verdicts instead of inheriting the exception-context meet.
        private FlowState ApplyFinallyRegion(
            FlowState carried,
            ControlFlowRegion finallyRegion,
            ImmutableArray<BasicBlock> blocks
        )
        {
            var first = finallyRegion.FirstBlockOrdinal;
            var last = finallyRegion.LastBlockOrdinal;
            var entries = new FlowState?[last - first + 1];
            var exits = new FlowState?[last - first + 1];

            bool changed;
            do
            {
                changed = false;
                for (var ordinal = first; ordinal <= last; ordinal++)
                {
                    FlowState? entry;
                    if (ordinal == first)
                    {
                        entry = carried.Clone();
                    }
                    else
                    {
                        entry = null;
                        foreach (var branch in blocks[ordinal].Predecessors)
                        {
                            var sourceOrdinal = branch.Source.Ordinal;
                            if (sourceOrdinal < first || sourceOrdinal > last)
                                continue;
                            var predecessorExit = exits[sourceOrdinal - first];
                            if (predecessorExit == null)
                                continue;

                            var inner = predecessorExit;
                            foreach (var nested in branch.FinallyRegions)
                                inner = ApplyFinallyRegion(inner, nested, blocks);

                            entry = entry == null ? inner.Clone() : FlowState.Meet(entry, inner);
                        }
                    }

                    if (entry == null)
                        continue;

                    if (!FlowState.Equal(entry, entries[ordinal - first]))
                    {
                        entries[ordinal - first] = entry;
                        changed = true;
                    }

                    var transfer = Transfer(blocks[ordinal], entries[ordinal - first]!.Clone(), report: null);
                    if (!FlowState.Equal(transfer.State, exits[ordinal - first]))
                    {
                        exits[ordinal - first] = transfer.State;
                        changed = true;
                    }
                }
            } while (changed);

            return exits[last - first] ?? carried;
        }

        private TransferContext Transfer(BasicBlock block, FlowState state, Action<Diagnostic>? report)
        {
            var context = new TransferContext(state, report);

            foreach (var rootOperation in BlockRoots(block))
                Visit(rootOperation, context);

            return context;
        }

        private void Visit(IOperation operation, TransferContext context)
        {
            foreach (var child in operation.ChildOperations)
                Visit(child, context);

            var state = context.State;

            switch (operation)
            {
                case IFlowCaptureOperation capture:
                {
                    state.Captures[capture.Id] = Evaluate(capture.Value, state);
                    switch (capture.Value)
                    {
                        case ILocalReferenceOperation local:
                            state.CaptureTargets[capture.Id] = local.Local;
                            break;
                        case IParameterReferenceOperation parameter:
                            state.CaptureTargets[capture.Id] = parameter.Parameter;
                            break;
                    }
                    context.NoteMutation();
                    break;
                }

                case ISimpleAssignmentOperation assignment:
                    if (assignment.IsRef)
                        BindRefLocal(assignment.Target, assignment.Value, state);
                    else
                        TrackAssignment(assignment.Target, Evaluate(assignment.Value, state), state);
                    context.NoteMutation();
                    break;

                case IVariableDeclaratorOperation declarator:
                {
                    var initializer = declarator.GetVariableInitializer();
                    if (initializer == null)
                        break;
                    if (declarator.Symbol.IsRef)
                        state.RefTargets[declarator.Symbol] = ExtractRefTargets(initializer.Value, state);
                    else
                        state.Symbols[declarator.Symbol] = Evaluate(initializer.Value, state);
                    context.NoteMutation();
                    break;
                }

                case IArgumentOperation argument:
                {
                    if (
                        context.Report != null
                        && ParameterIsFixed(argument.Parameter)
                        && !Evaluate(argument.Value, state)
                    )
                    {
                        var invocation = argument.Parent as IInvocationOperation;
                        var functionName = invocation is not null ? $"'{invocation.TargetMethod.Name}'" : "function";
                        var parameterName = argument.Parameter?.Name ?? "<unknown>";

                        context.Report(
                            Diagnostic.Create(
                                Resources.ExpectsFixedBrutalCore0009,
                                argument.Syntax.GetLocation(),
                                functionName,
                                parameterName
                            )
                        );
                    }

                    // The callee can reassign anything it receives by ref/out, [Fixed] or not:
                    // the attribute promises what goes in, not what the callee leaves behind.
                    if (argument.Parameter?.RefKind is RefKind.Ref or RefKind.Out)
                    {
                        KillThroughReference(argument.Value, state);
                        context.NoteMutation();
                    }
                    break;
                }

                case IConversionOperation { OperatorMethod: { } operatorMethod } conversion
                    when context.Report != null
                        && operatorMethod.Parameters.Length > 0
                        && ParameterIsFixed(operatorMethod.Parameters[0]):
                {
                    if (!Evaluate(conversion.Operand, state))
                    {
                        context.Report(
                            Diagnostic.Create(
                                Resources.ExpectsFixedBrutalCore0010,
                                conversion.Syntax.GetLocation(),
                                conversion.Operand.Type,
                                conversion.Type
                            )
                        );
                    }
                    break;
                }
            }
        }

        private static void TrackAssignment(IOperation target, bool verdict, FlowState state)
        {
            switch (target)
            {
                case ILocalReferenceOperation { Local.IsRef: true } refLocal:
                    WriteThroughRefLocal(refLocal.Local, verdict, state);
                    break;
                case ILocalReferenceOperation local:
                    state.Symbols[local.Local] = verdict;
                    break;
                case IParameterReferenceOperation parameter:
                    state.Symbols[parameter.Parameter] = verdict;
                    break;
                case IFlowCaptureReferenceOperation captureReference:
                    state.Captures[captureReference.Id] = verdict;
                    // Lowering assigns through a capture of the lvalue (`x ??= e`, conditional
                    // access): the write must reach the captured symbol, not just the capture.
                    if (state.CaptureTargets.TryGetValue(captureReference.Id, out var captured))
                    {
                        if (captured is ILocalSymbol { IsRef: true } capturedRefLocal)
                            WriteThroughRefLocal(capturedRefLocal, verdict, state);
                        else
                            state.Symbols[captured] = verdict;
                    }
                    break;
            }
        }

        private static void BindRefLocal(IOperation target, IOperation value, FlowState state)
        {
            if (target is ILocalReferenceOperation { Local.IsRef: true } refLocal)
                state.RefTargets[refLocal.Local] = ExtractRefTargets(value, state);
        }

        /// null means the referent is unknown (a ref return, a ref field): reads through it are
        /// movable, and writes through it cannot be attributed to any tracked symbol.
        private static HashSet<ISymbol>? ExtractRefTargets(IOperation value, FlowState state) =>
            value switch
            {
                ILocalReferenceOperation { Local.IsRef: true } refLocal => state.RefTargets.TryGetValue(
                    refLocal.Local,
                    out var existing
                )
                && existing != null
                    ? new HashSet<ISymbol>(existing, SymbolEqualityComparer.Default)
                    : null,
                ILocalReferenceOperation local => new HashSet<ISymbol>(SymbolEqualityComparer.Default) { local.Local },
                IParameterReferenceOperation parameter => new HashSet<ISymbol>(SymbolEqualityComparer.Default)
                {
                    parameter.Parameter,
                },
                _ => null,
            };

        /// A write through a ref local with one candidate referent is a strong update; with several,
        /// only a movable verdict is applied (to every candidate), because a fixed verdict landed in
        /// exactly one of them and we cannot tell which.
        private static void WriteThroughRefLocal(ILocalSymbol refLocal, bool verdict, FlowState state)
        {
            if (!state.RefTargets.TryGetValue(refLocal, out var targets) || targets == null)
                return;
            if (targets.Count != 1 && verdict)
                return;

            foreach (var target in targets)
                state.Symbols[target] = verdict;
        }

        private bool ReadThroughRefLocal(ILocalSymbol refLocal, FlowState state)
        {
            if (!state.RefTargets.TryGetValue(refLocal, out var targets) || targets == null)
                return false;

            foreach (var target in targets)
            {
                var verdict = target switch
                {
                    ILocalSymbol local => local.IsFixed
                        || (state.Symbols.TryGetValue(local, out var tracked) && tracked),
                    IParameterSymbol parameter => state.Symbols.TryGetValue(parameter, out var tracked)
                        ? tracked
                        : ParameterIsFixed(parameter),
                    _ => false,
                };
                if (!verdict)
                    return false;
            }

            return targets.Count > 0;
        }

        private static void KillThroughReference(IOperation value, FlowState state)
        {
            switch (value)
            {
                case ILocalReferenceOperation { Local.IsRef: true } refLocal:
                    WriteThroughRefLocal(refLocal.Local, false, state);
                    break;
                case ILocalReferenceOperation local:
                    state.Symbols[local.Local] = false;
                    break;
                case IParameterReferenceOperation parameter:
                    state.Symbols[parameter.Parameter] = false;
                    break;
            }
        }

        private bool Evaluate(IOperation? operation, FlowState state)
        {
            if (operation == null)
                return false;

            // These cases are presumed to be fixed.
            if (operation.ConstantValue.HasValue)
                return true;
            if (operation.Syntax is LiteralExpressionSyntax)
                return true;
            if (operation.Syntax is StackAllocArrayCreationExpressionSyntax)
                return true;
            if (operation.Syntax is ImplicitStackAllocArrayCreationExpressionSyntax)
                return true;

            // An empty span has no memory to move, and `[]` is how a caller says "no buffer".
            if (operation.Syntax is CollectionExpressionSyntax { Elements.Count: 0 })
                return true;

            switch (operation)
            {
                case IAddressOfOperation:
                    return true;
                case IDefaultValueOperation:
                    return true;
                case IFlowCaptureReferenceOperation captureReference:
                    return state.Captures.TryGetValue(captureReference.Id, out var captured) && captured;
                case ILocalReferenceOperation { Local.IsRef: true } refLocal:
                    return ReadThroughRefLocal(refLocal.Local, state);
                case ILocalReferenceOperation local:
                    // A pointer bound by a `fixed (T* p = ...)` statement is pinned for the entire
                    // body of the statement, regardless of what the initializer was.
                    return local.Local.IsFixed || (state.Symbols.TryGetValue(local.Local, out var tracked) && tracked);
                case IParameterReferenceOperation parameter:
                    return state.Symbols.TryGetValue(parameter.Parameter, out var parameterState)
                        ? parameterState
                        : ParameterIsFixed(parameter.Parameter);
                case IFieldReferenceOperation fieldReference:
                    return ContainsFixed(fieldReference.Field.GetAttributes());
                case IPropertyReferenceOperation propertyReference:
                    // Span<T>.Empty has no memory to move, like the empty collection expression.
                    return PropertyIsFixed(propertyReference.Property)
                        || (
                            propertyReference.Property.Name == "Empty"
                            && IsBclSpan(propertyReference.Property.ContainingType)
                        );
                case IInvocationOperation invocation:
                    return MethodReturnsFixed(invocation.TargetMethod) || InvocationIsViewOfFixed(invocation, state);
                case IImplicitIndexerReferenceOperation implicitIndexer:
                    // The span range indexer (`buffer[..n]`) is a view: the same memory, so the
                    // receiver's verdict carries over.
                    return IsBclSpan(implicitIndexer.Type)
                        && IsBclSpan(implicitIndexer.Instance.Type)
                        && Evaluate(implicitIndexer.Instance, state);
                case IObjectCreationOperation creation:
                    return SpanCreationOverPointerIsFixed(creation, state);
                case IConversionOperation conversion:
                    if (conversion.OperatorMethod is { } operatorMethod && MethodReturnsFixed(operatorMethod))
                        return true;
                    return Evaluate(conversion.Operand, state);
                case IArrayElementReferenceOperation arrayElement:
                    return Evaluate(arrayElement.ArrayReference, state);
                // Pointer arithmetic stays inside the allocation the pointer came from.
                case IBinaryOperation binary when binary.Type is IPointerTypeSymbol:
                    return binary.LeftOperand.Type is IPointerTypeSymbol
                        ? Evaluate(binary.LeftOperand, state)
                        : Evaluate(binary.RightOperand, state);
                case IIncrementOrDecrementOperation increment when increment.Type is IPointerTypeSymbol:
                    return Evaluate(increment.Target, state);
                case IConditionalOperation conditional:
                    return Evaluate(conditional.WhenTrue, state) && Evaluate(conditional.WhenFalse, state);
                default:
                    return false;
            }
        }

        /// A view over fixed memory is the same memory: Slice and any other span instance member
        /// returning a span take the receiver's verdict, as does string.AsSpan. Array AsSpan and
        /// MemoryMarshal-style factories stay movable because the analyzer cannot see what they wrap.
        private bool InvocationIsViewOfFixed(IInvocationOperation invocation, FlowState state)
        {
            var method = invocation.TargetMethod;

            if (invocation.Instance != null && IsBclSpan(method.ContainingType) && IsBclSpan(method.ReturnType))
                return Evaluate(invocation.Instance, state);

            if (method.Name != "AsSpan" || method.ContainingType is not { Name: "MemoryExtensions" } containingType)
                return false;
            if (!IsSystemNamespace(containingType.ContainingNamespace))
                return false;

            if (method.ReducedFrom is { } reducedFrom)
            {
                return reducedFrom.Parameters.Length > 0
                    && reducedFrom.Parameters[0].Type.SpecialType == SpecialType.System_String
                    && Evaluate(invocation.Instance, state);
            }

            return method.Parameters.Length > 0
                && method.Parameters[0].Type.SpecialType == SpecialType.System_String
                && invocation.Arguments.Length > 0
                && Evaluate(invocation.Arguments[0].Value, state);
        }

        private bool SpanCreationOverPointerIsFixed(IObjectCreationOperation creation, FlowState state)
        {
            if (!IsBclSpan(creation.Type))
                return false;
            if (creation.Constructor is not { Parameters.Length: > 0 } constructor)
                return false;
            if (constructor.Parameters[0].Type is not IPointerTypeSymbol)
                return false;

            foreach (var argument in creation.Arguments)
            {
                if (argument.Parameter?.Ordinal == 0)
                    return Evaluate(argument.Value, state);
            }

            return false;
        }

        private static bool IsBclSpan(ITypeSymbol? type) =>
            type is INamedTypeSymbol { Name: "Span" or "ReadOnlySpan", Arity: 1 } named
            && IsSystemNamespace(named.ContainingNamespace);

        private static bool IsSystemNamespace(INamespaceSymbol? containingNamespace) =>
            containingNamespace is { Name: "System", ContainingNamespace.IsGlobalNamespace: true };

        private bool ParameterIsFixed(IParameterSymbol? parameter)
        {
            if (parameter == null)
                return false;
            return _fixedParameters.GetOrAdd(
                parameter,
                static symbol => ComputeParameterIsFixed((IParameterSymbol)symbol)
            );
        }

        /// The attribute is effective when declared on the parameter itself, on the same parameter of
        /// any overridden method, on any interface method the containing method implements, or on the
        /// original definition of a reduced extension method.
        private static bool ComputeParameterIsFixed(IParameterSymbol parameter)
        {
            if (ContainsFixed(parameter.GetAttributes()))
                return true;
            if (parameter.ContainingSymbol is not IMethodSymbol method)
                return false;

            foreach (var related in RelatedMethods(method))
            {
                if (
                    related.Parameters.Length > parameter.Ordinal
                    && ContainsFixed(related.Parameters[parameter.Ordinal].GetAttributes())
                )
                    return true;
            }

            // A reduced extension method's parameter list drops the receiver, shifting ordinals by one.
            return method.ReducedFrom is { } reducedFrom
                && reducedFrom.Parameters.Length > parameter.Ordinal + 1
                && ContainsFixed(reducedFrom.Parameters[parameter.Ordinal + 1].GetAttributes());
        }

        private bool MethodReturnsFixed(IMethodSymbol? method)
        {
            if (method == null)
                return false;
            return _fixedReturns.GetOrAdd(method, static symbol => ComputeMethodReturnsFixed((IMethodSymbol)symbol));
        }

        private static bool ComputeMethodReturnsFixed(IMethodSymbol method)
        {
            if (ContainsFixed(method.GetReturnTypeAttributes()))
                return true;

            foreach (var related in RelatedMethods(method))
            {
                if (ContainsFixed(related.GetReturnTypeAttributes()))
                    return true;
            }

            return method.ReducedFrom is { } reducedFrom && ContainsFixed(reducedFrom.GetReturnTypeAttributes());
        }

        private bool PropertyIsFixed(IPropertySymbol? property)
        {
            if (property == null)
                return false;
            return _fixedProperties.GetOrAdd(
                property,
                static symbol => ComputePropertyIsFixed((IPropertySymbol)symbol)
            );
        }

        private static bool ComputePropertyIsFixed(IPropertySymbol property)
        {
            if (PropertyCarriesFixed(property))
                return true;

            for (
                var overridden = property.OverriddenProperty;
                overridden != null;
                overridden = overridden.OverriddenProperty
            )
            {
                if (PropertyCarriesFixed(overridden))
                    return true;
            }

            foreach (var interfaceProperty in ImplementedInterfaceMembers<IPropertySymbol>(property))
            {
                if (PropertyCarriesFixed(interfaceProperty))
                    return true;
            }

            return false;
        }

        private static bool PropertyCarriesFixed(IPropertySymbol property) =>
            ContainsFixed(property.GetAttributes())
            || (property.GetMethod is { } getter && ContainsFixed(getter.GetReturnTypeAttributes()));

        private static IEnumerable<IMethodSymbol> RelatedMethods(IMethodSymbol method)
        {
            for (var overridden = method.OverriddenMethod; overridden != null; overridden = overridden.OverriddenMethod)
                yield return overridden;

            foreach (var interfaceMethod in ImplementedInterfaceMembers<IMethodSymbol>(method))
                yield return interfaceMethod;
        }

        private static IEnumerable<TMember> ImplementedInterfaceMembers<TMember>(TMember member)
            where TMember : class, ISymbol
        {
            switch (member)
            {
                case IMethodSymbol method:
                    foreach (var explicitImplementation in method.ExplicitInterfaceImplementations)
                        yield return (TMember)(ISymbol)explicitImplementation;
                    break;
                case IPropertySymbol property:
                    foreach (var explicitImplementation in property.ExplicitInterfaceImplementations)
                        yield return (TMember)(ISymbol)explicitImplementation;
                    break;
            }

            var containingType = member.ContainingType;
            if (containingType == null)
                yield break;

            foreach (var interfaceType in containingType.AllInterfaces)
            {
                // Implicit implementations share the member's name, so only candidates under that
                // name need the (expensive) implementation lookup.
                foreach (var interfaceMember in interfaceType.GetMembers(member.Name))
                {
                    if (interfaceMember is not TMember candidate)
                        continue;

                    var implementation = containingType.FindImplementationForInterfaceMember(candidate);
                    if (
                        SymbolEqualityComparer.Default.Equals(implementation, member)
                        || SymbolEqualityComparer.Default.Equals(
                            implementation?.OriginalDefinition,
                            member.OriginalDefinition
                        )
                    )
                        yield return candidate;
                }
            }
        }

        private static bool ContainsFixed(ImmutableArray<AttributeData> attributes)
        {
            foreach (var a in attributes)
            {
                if (
                    a.AttributeClass?.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)
                    == "global::Brutal.Attributes.FixedAttribute"
                )
                    return true;
            }

            return false;
        }
    }

    private sealed class TransferContext
    {
        public readonly FlowState State;
        public FlowState ExceptionMeet;
        public readonly Action<Diagnostic>? Report;

        public TransferContext(FlowState state, Action<Diagnostic>? report)
        {
            State = state;
            ExceptionMeet = state.Clone();
            Report = report;
        }

        /// Called after every state change, so a handler entry sees every intermediate state a
        /// mid-operation exception could expose, not just the block and root-operation boundaries.
        public void NoteMutation() => ExceptionMeet = FlowState.Meet(ExceptionMeet, State);
    }

    private sealed class BlockFlow
    {
        public FlowState? Entry;
        public FlowState? Exit;
        public FlowState? ExceptionMeet;
    }

    private sealed class FlowState
    {
        public readonly Dictionary<ISymbol, bool> Symbols;
        public readonly Dictionary<CaptureId, bool> Captures;

        /// The lvalue a flow capture stands for, when it is a tracked local or parameter, so an
        /// assignment through the capture reaches the symbol.
        public readonly Dictionary<CaptureId, ISymbol> CaptureTargets;

        /// Possible referents per ref local; a null set means the referent is unknown.
        public readonly Dictionary<ISymbol, HashSet<ISymbol>?> RefTargets;

        public FlowState()
        {
            Symbols = new Dictionary<ISymbol, bool>(SymbolEqualityComparer.Default);
            Captures = new Dictionary<CaptureId, bool>();
            CaptureTargets = new Dictionary<CaptureId, ISymbol>();
            RefTargets = new Dictionary<ISymbol, HashSet<ISymbol>?>(SymbolEqualityComparer.Default);
        }

        private FlowState(FlowState source)
        {
            Symbols = new Dictionary<ISymbol, bool>(source.Symbols, SymbolEqualityComparer.Default);
            Captures = new Dictionary<CaptureId, bool>(source.Captures);
            CaptureTargets = new Dictionary<CaptureId, ISymbol>(source.CaptureTargets);
            RefTargets = new Dictionary<ISymbol, HashSet<ISymbol>?>(SymbolEqualityComparer.Default);
            foreach (var pair in source.RefTargets)
                RefTargets[pair.Key] =
                    pair.Value == null ? null : new HashSet<ISymbol>(pair.Value, SymbolEqualityComparer.Default);
        }

        public FlowState Clone() => new(this);

        // A symbol missing from one side is unconstrained there, so the other side's verdict wins.
        public static FlowState Meet(FlowState left, FlowState right)
        {
            var result = left.Clone();
            foreach (var pair in right.Symbols)
                result.Symbols[pair.Key] =
                    !result.Symbols.TryGetValue(pair.Key, out var existing) || existing ? pair.Value : false;
            foreach (var pair in right.Captures)
                result.Captures[pair.Key] =
                    !result.Captures.TryGetValue(pair.Key, out var existing) || existing ? pair.Value : false;
            foreach (var pair in right.CaptureTargets)
            {
                if (!result.CaptureTargets.TryGetValue(pair.Key, out var existing))
                    result.CaptureTargets[pair.Key] = pair.Value;
                else if (!SymbolEqualityComparer.Default.Equals(existing, pair.Value))
                    result.CaptureTargets.Remove(pair.Key);
            }
            foreach (var pair in right.RefTargets)
            {
                if (!result.RefTargets.TryGetValue(pair.Key, out var existing))
                {
                    result.RefTargets[pair.Key] =
                        pair.Value == null ? null : new HashSet<ISymbol>(pair.Value, SymbolEqualityComparer.Default);
                }
                else if (existing == null || pair.Value == null)
                {
                    result.RefTargets[pair.Key] = null;
                }
                else
                {
                    existing.UnionWith(pair.Value);
                }
            }
            return result;
        }

        public static bool Equal(FlowState? left, FlowState? right)
        {
            if (ReferenceEquals(left, right))
                return true;
            if (left == null || right == null)
                return false;
            if (
                left.Symbols.Count != right.Symbols.Count
                || left.Captures.Count != right.Captures.Count
                || left.CaptureTargets.Count != right.CaptureTargets.Count
                || left.RefTargets.Count != right.RefTargets.Count
            )
                return false;

            foreach (var pair in left.Symbols)
            {
                if (!right.Symbols.TryGetValue(pair.Key, out var other) || other != pair.Value)
                    return false;
            }

            foreach (var pair in left.Captures)
            {
                if (!right.Captures.TryGetValue(pair.Key, out var other) || other != pair.Value)
                    return false;
            }

            foreach (var pair in left.CaptureTargets)
            {
                if (
                    !right.CaptureTargets.TryGetValue(pair.Key, out var other)
                    || !SymbolEqualityComparer.Default.Equals(other, pair.Value)
                )
                    return false;
            }

            foreach (var pair in left.RefTargets)
            {
                if (!right.RefTargets.TryGetValue(pair.Key, out var other))
                    return false;
                if (pair.Value == null || other == null)
                {
                    if (pair.Value != other)
                        return false;
                }
                else if (!pair.Value.SetEquals(other))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
