using System;

namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public DataverseFilterValue(DateTime? value)
        =>
        Value = InnerBuildValue(value);

    public static DataverseFilterValue FromNullableDateTime(DateTime? value)
        =>
        new(value);

    public static implicit operator DataverseFilterValue(DateTime? value)
        =>
        new(value);

    private static string InnerBuildValue(DateTime? source)
        =>
        source is null ? NullValue : InnerBuildValue(source.Value);
}