using System;

namespace GarageGroup.Infra;

public sealed record class DataverseSetFilter : DataverseFilterBase
{
    private readonly DataverseLogicalOperator logicalOperator;

    private readonly DataverseComparisonOperator comparisonOperator;

    public DataverseSetFilter(string fieldName, DataverseSetOperator @operator, FlatArray<DataverseFilterValue> fieldValues)
    {
        FieldName = fieldName ?? string.Empty;

        Operator = @operator;
        (logicalOperator, comparisonOperator) = @operator switch
        {
            DataverseSetOperator.In => (DataverseLogicalOperator.Or, DataverseComparisonOperator.Equal),
            DataverseSetOperator.NotIn => (DataverseLogicalOperator.And, DataverseComparisonOperator.Inequal),
            _ => throw @operator.CreateOutOfRangeException(nameof(@operator))
        };

        FieldValues = fieldValues;
    }

    public string FieldName { get; }

    public DataverseSetOperator Operator { get; }

    public FlatArray<DataverseFilterValue> FieldValues { get; }

    public override string GetQuery()
    {
        if (FieldValues.IsEmpty)
        {
            return string.Empty;
        }

        var innerFilterBuilder = FlatArray<IDataverseFilter>.Builder.OfLength(FieldValues.Length);

        for (var i = 0; i < FieldValues.Length; i++)
        {
            innerFilterBuilder[i] = new DataverseComparisonFilter(FieldName, comparisonOperator, FieldValues[i]);
        }

        return new DataverseLogicalFilter(logicalOperator, innerFilterBuilder.MoveToFlatArray()).GetQuery();
    }

    public override string ToString()
        =>
        base.ToString();
}