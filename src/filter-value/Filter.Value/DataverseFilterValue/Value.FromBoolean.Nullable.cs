namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public DataverseFilterValue(bool? value)
        =>
        Value = InnerBuildValue(value);

    public static DataverseFilterValue FromNullableBoolean(bool? value)
        =>
        new(value);

    public static implicit operator DataverseFilterValue(bool? value)
        =>
        new(value);

    private static string InnerBuildValue(bool? source)
        =>
        source is null ? NullValue : InnerBuildValue(source.Value);
}