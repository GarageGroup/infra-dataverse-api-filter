using System;

namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public DataverseFilterValue(DateOnly value)
        =>
        Value = InnerBuildValue(value);

    public static DataverseFilterValue FromDateOnly(DateOnly value)
        =>
        new(value);

    public static implicit operator DataverseFilterValue(DateOnly value)
        =>
        new(value);

    private static string InnerBuildValue(DateOnly source)
        =>
        source.ToString("yyyy-MM-dd");
}