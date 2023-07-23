namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public static DataverseFilterValue FromRawString(string value)
        =>
        new(value ?? string.Empty, 0);
}