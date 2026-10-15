namespace Brutal.Attributes;

[AttributeUsage(
    AttributeTargets.ReturnValue | AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property
)]
public sealed class FixedAttribute : Attribute { }
