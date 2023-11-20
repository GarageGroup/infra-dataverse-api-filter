namespace GarageGroup.Infra;

public sealed record class DataverseNullFilter : DataverseFilterBase
{
    private readonly string escapedFieldName;

    public DataverseNullFilter(string fieldName)
        =>
        escapedFieldName = fieldName.Escape();

    public override string GetQuery()
        =>
        $"{escapedFieldName} eq null";

    public override string ToString()
        =>
        base.ToString();
}