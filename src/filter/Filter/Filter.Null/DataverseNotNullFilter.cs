namespace GarageGroup.Infra;

public sealed record class DataverseNotNullFilter : DataverseFilterBase
{
    private readonly string escapedFieldName;

    public DataverseNotNullFilter(string fieldName)
        =>
        escapedFieldName = fieldName.Escape();

    public override string GetQuery()
        =>
        $"{escapedFieldName} ne null";

    public override string ToString()
        =>
        base.ToString();
}