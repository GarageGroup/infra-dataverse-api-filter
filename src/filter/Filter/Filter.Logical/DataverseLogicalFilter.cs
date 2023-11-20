using System;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Infra;

public sealed record class DataverseLogicalFilter : DataverseFilterBase
{
    private readonly string operatorValue;

    public DataverseLogicalFilter(DataverseLogicalOperator @operator)
    {
        Operator = @operator;
        operatorValue = GetOperatorValue(@operator);
    }

    [SetsRequiredMembers]
    public DataverseLogicalFilter(DataverseLogicalOperator @operator, FlatArray<IDataverseFilter> filters)
    {
        Operator = @operator;
        operatorValue = GetOperatorValue(@operator);
        Filters = filters;
    }

    public DataverseLogicalOperator Operator { get; }

    public required FlatArray<IDataverseFilter> Filters { get; init; }

    public override string GetQuery()
    {
        if (Filters.IsEmpty)
        {
            return string.Empty;
        }

        if (Filters.Length is 1)
        {
            return Filters[0].GetQuery();
        }

        var builder = new StringBuilder();

        foreach (var innerFilter in Filters)
        {
            var filterQuery = innerFilter.GetQuery();
            if (string.IsNullOrWhiteSpace(filterQuery))
            {
                continue;
            }

            if (builder.Length > 0)
            {
                builder = builder.Append(' ').Append(operatorValue).Append(' ');
            }
            else
            {
                builder = builder.Append('(');
            }

            builder.Append(filterQuery);
        }

        if (builder.Length > 0)
        {
            builder = builder.Append(')');
        }

        return builder.ToString();
    }

    public override string ToString()
        =>
        base.ToString();

    private static string GetOperatorValue(DataverseLogicalOperator @operator)
        =>
        @operator switch
        {
            DataverseLogicalOperator.And => "and",
            DataverseLogicalOperator.Or => "or",
            _ => throw @operator.CreateOutOfRangeException(nameof(@operator))
        };
}