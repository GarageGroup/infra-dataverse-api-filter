using System.Collections.Generic;
using PrimeFuncPack.UnitTest;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

public static partial class DataverseLogicalFilterTest
{
    public static IEnumerable<object[]> QueryTestData
        =>
        new[]
        {
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.And,
                    default),
                string.Empty
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.And,
                    new IDataverseFilter[]
                    {
                        new StubDataverseFilter(string.Empty),
                        new StubDataverseFilter(TestData.WhiteSpaceString)
                    }),
                string.Empty
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.And,
                    new IDataverseFilter[]
                    {
                        new StubDataverseFilter("Some query")
                    }),
                "Some query"
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.And,
                    new IDataverseFilter[]
                    {
                        new StubDataverseFilter(string.Empty),
                        new StubDataverseFilter("Some query"),
                        new StubDataverseFilter(TestData.WhiteSpaceString)
                    }),
                "(Some query)"
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.And,
                    new IDataverseFilter[]
                    {
                        new StubDataverseFilter("Some query1"),
                        new StubDataverseFilter("Query2"),
                        new StubDataverseFilter("Query3")
                    }),
                "(Some query1 and Query2 and Query3)"
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.Or,
                    default),
                string.Empty
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.Or,
                    new IDataverseFilter[]
                    {
                        new StubDataverseFilter(TestData.MixedWhiteSpacesString),
                        new StubDataverseFilter(TestData.TabString)
                    }),
                string.Empty
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.Or,
                    new IDataverseFilter[]
                    {
                        new StubDataverseFilter("Some query")
                    }),
                "Some query"
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.Or,
                    new IDataverseFilter[]
                    {
                        new StubDataverseFilter(TestData.WhiteSpaceString),
                        new StubDataverseFilter("Some query"),
                        new StubDataverseFilter(null!)
                    }),
                "(Some query)"
            },
            new object[]
            {
                new DataverseLogicalFilter(
                    DataverseLogicalOperator.Or,
                    new IDataverseFilter[]
                    {
                        new StubDataverseFilter("Some query1"),
                        new StubDataverseFilter("Query2"),
                        new StubDataverseFilter("Query3")
                    }),
                "(Some query1 or Query2 or Query3)"
            }
        };
}