using System;

namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public DataverseFilterValue(Guid? value)
        =>
        Value = InnerBuildValue(value);

    public static DataverseFilterValue FromNullableGuid(Guid? value)
        =>
        new(value);

    public static implicit operator DataverseFilterValue(Guid? value)
        =>
        new(value);

    private static string InnerBuildValue(Guid? source)
        =>
        source is null ? NullValue : InnerBuildValue(source.Value);
}