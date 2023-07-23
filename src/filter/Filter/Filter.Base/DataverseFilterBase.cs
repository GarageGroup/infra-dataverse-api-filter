using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Infra;

public abstract record class DataverseFilterBase : IDataverseFilter
{
    public abstract string GetQuery();

    public override string ToString()
        =>
        GetQuery();

    [return: NotNullIfNotNull(nameof(filter))]
    public static implicit operator string?([AllowNull] DataverseFilterBase filter)
        =>
        filter?.GetQuery();
}