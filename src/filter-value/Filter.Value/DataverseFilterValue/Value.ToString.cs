using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public override string ToString()
        =>
        Value;

    [return: MaybeNull, NotNullIfNotNull(nameof(value))]
    public static implicit operator string([AllowNull] DataverseFilterValue value)
        =>
        value?.Value;
}
