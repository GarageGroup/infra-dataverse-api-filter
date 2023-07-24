using System.Text;

namespace GarageGroup.Infra;

public sealed record class DataverseComparisonFilter : DataverseFilterBase
{
    private readonly string escapedFieldName;

    private readonly string operatorValue;

    public DataverseComparisonFilter(string fieldName, DataverseComparisonOperator @operator, DataverseFilterValue fieldValue)
    {
        FieldName = fieldName ?? string.Empty;
        escapedFieldName = fieldName.Escape();

        Operator = @operator;
        operatorValue = Operator switch
        {
            DataverseComparisonOperator.Equal => "eq",
            DataverseComparisonOperator.Inequal => "ne",
            DataverseComparisonOperator.Greater => "gt",
            DataverseComparisonOperator.GreaterOrEqual => "ge",
            DataverseComparisonOperator.Less => "lt",
            DataverseComparisonOperator.LessOrEqual => "le",
            _ => throw Operator.CreateOutOfRangeException(nameof(@operator))
        };

        FieldValue = fieldValue;
    }

    public string FieldName { get; }

    public DataverseComparisonOperator Operator { get; }

    public DataverseFilterValue FieldValue { get; }

    public override string GetQuery()
        =>
        new StringBuilder(
            escapedFieldName)
        .Append(
            ' ')
        .Append(
            operatorValue)
        .Append(
            ' ')
        .Append(
            FieldValue.Value)
        .ToString();

    public override string ToString()
        =>
        base.ToString();
}