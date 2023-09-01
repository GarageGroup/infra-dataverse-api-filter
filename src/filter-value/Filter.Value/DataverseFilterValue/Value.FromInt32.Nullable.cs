namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public DataverseFilterValue(int? value)
        =>
        Value = InnerBuildValue(value);

    public static DataverseFilterValue FromNullableInt32(int? value)
        =>
        new(value);

    public static implicit operator DataverseFilterValue(int? value)
        =>
        new(value);

    private static string InnerBuildValue(int? source)
        =>
        source is null ? NullValue : InnerBuildValue(source.Value);
}