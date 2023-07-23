using System.Web;

namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public DataverseFilterValue(string? value)
        =>
        Value = InnerBuildValue(value);

    public static DataverseFilterValue FromString(string? value)
        =>
        new(value);

    public static implicit operator DataverseFilterValue(string? value)
        =>
        new(value);

    private static string InnerBuildValue(string? source)
    {
        if (source is null)
        {
            return NullValue;
        }

        var encodedValue = HttpUtility.UrlEncode(source.Replace("'", "''"));
        return $"'{encodedValue}'";
    }
}