using System.Collections.Generic;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

public static partial class DataverseComparisonFilterTest
{
    public static IEnumerable<object[]> QueryTestData
        =>
        new[]
        {
            new object[]
            {
                new DataverseComparisonFilter(
                    "Field1",
                    DataverseComparisonOperator.Equal,
                    DataverseFilterValue.FromRawString("SomeValue")),
                "Field1 eq SomeValue"
            },
            new object[]
            {
                new DataverseComparisonFilter(
                    "_some_file_name",
                    DataverseComparisonOperator.Inequal,
                    DataverseFilterValue.FromRawString("null")),
                "_some_file_name ne null"
            },
            new object[]
            {
                new DataverseComparisonFilter(
                    "Some Field",
                    DataverseComparisonOperator.Greater,
                    DataverseFilterValue.FromRawString("157")),
                "Some+Field gt 157"
            },
            new object[]
            {
                new DataverseComparisonFilter(
                    "Some'Field",
                    DataverseComparisonOperator.GreaterOrEqual,
                    DataverseFilterValue.FromRawString("Some value")),
                "Some%27Field ge Some value"
            },
            new object[]
            {
                new DataverseComparisonFilter(
                    "some_field",
                    DataverseComparisonOperator.Less,
                    DataverseFilterValue.FromRawString("SomeValue")),
                "some_field lt SomeValue"
            },
            new object[]
            {
                new DataverseComparisonFilter(
                    "some_field",
                    DataverseComparisonOperator.LessOrEqual,
                    DataverseFilterValue.FromRawString("SomeValue")),
                "some_field le SomeValue"
            }
        };
}