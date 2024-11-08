using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

public static partial class DataverseLogicalFilterTest
{
    public static TheoryData<DataverseLogicalFilter, string> QueryTestData
        =>
        new()
        {
            {
                new(
                    DataverseLogicalOperator.And,
                    default),
                string.Empty
            },
            {
                new(
                    DataverseLogicalOperator.And,
                    [
                        new StubDataverseFilter(string.Empty),
                        new StubDataverseFilter(TestData.WhiteSpaceString)
                    ]),
                string.Empty
            },
            {
                new(DataverseLogicalOperator.And)
                {
                    Filters =
                    [
                        new StubDataverseFilter("Some query")
                    ]
                },
                "Some query"
            },
            {
                new(DataverseLogicalOperator.And)
                {
                    Filters =
                    [
                        new StubDataverseFilter(string.Empty),
                        new StubDataverseFilter("Some query"),
                        new StubDataverseFilter(TestData.WhiteSpaceString)
                    ]
                },
                "(Some query)"
            },
            {
                new(DataverseLogicalOperator.And)
                {
                    Filters =
                    [
                        new StubDataverseFilter("Some query1"),
                        new StubDataverseFilter("Query2"),
                        new StubDataverseFilter("Query3")
                    ]
                },
                "(Some query1 and Query2 and Query3)"
            },
            {
                new(DataverseLogicalOperator.Or)
                {
                    Filters = default
                },
                string.Empty
            },
            {
                new(DataverseLogicalOperator.Or)
                {
                    Filters =
                    [
                        new StubDataverseFilter(TestData.MixedWhiteSpacesString),
                        new StubDataverseFilter(TestData.TabString)
                    ]
                },
                string.Empty
            },
            {
                new(DataverseLogicalOperator.Or)
                {
                    Filters =
                    [
                        new StubDataverseFilter("Some query")
                    ]
                },
                "Some query"
            },
            {
                new(DataverseLogicalOperator.Or)
                {
                    Filters =
                    [
                        new StubDataverseFilter(TestData.WhiteSpaceString),
                        new StubDataverseFilter("Some query"),
                        new StubDataverseFilter(null!)
                    ]
                },
                "(Some query)"
            },
            {
                new(DataverseLogicalOperator.Or)
                {
                    Filters =
                    [
                        new StubDataverseFilter("Some query1"),
                        new StubDataverseFilter("Query2"),
                        new StubDataverseFilter("Query3")
                    ]
                },
                "(Some query1 or Query2 or Query3)"
            }
        };
}