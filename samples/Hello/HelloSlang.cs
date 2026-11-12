/*
 * HelloSlang
 *
 * Compiles a small inline Slang vertex shader to SPIR-V and prints its size.
 */

#:property AllowUnsafeBlocks=true
#:package Ahwoo.Brutal.Slang@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Strings@2026.10.2

using Brutal.SlangApi;

Run();

static void Run()
{
    // The global session is a COM proxy that the GC releases, so only the request needs disposing.
    var globalSession = Slang.CreateGlobalSession();

    using var request = globalSession.CreateCompileRequest();
    request.SetCodeGenTarget(CompileTarget.Spirv);

    var translationUnit = request.AddTranslationUnit(SourceLanguage.Slang, "hello"u8);
    request.AddTranslationUnitSourceString(
        translationUnit,
        "hello.slang"u8,
        """
        [shader("vertex")]
        float4 vertexMain(float3 position : POSITION) : SV_Position
        {
            return float4(position, 1.0);
        }
        """u8
    );

    var entryPoint = request.AddEntryPoint(translationUnit, "vertexMain"u8, Stage.Vertex);

    var compileResult = request.Compile();
    if (compileResult.IsFailure)
        throw new SlangException(compileResult, $"Slang compile failed: {request.GetDiagnosticOutput()}");

    unsafe
    {
        request.GetEntryPointCode(entryPoint, out var size);
        Console.WriteLine($"Compiled Slang to {size} of SPIR-V");
    }
}
