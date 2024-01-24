using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

public static partial class DataverseComparisonFilterTest
{
    public static TheoryData<DataverseComparisonFilter, string> QueryTestData
        =>
        new()
        {
            {
                new(
                    "Field1",
                    DataverseComparisonOperator.Equal,
                    DataverseFilterValue.FromRawString("SomeValue")),
                "Field1 eq SomeValue"
            },
            {
                new(
                    "_some_file_name",
                    DataverseComparisonOperator.Inequal,
                    DataverseFilterValue.FromRawString("null")),
                "_some_file_name ne null"
            },
            {
                new(
                    "Some Field",
                    DataverseComparisonOperator.Greater,
                    DataverseFilterValue.FromRawString("157")),
                "Some+Field gt 157"
            },
            {
                new(
                    "Some'Field",
                    DataverseComparisonOperator.GreaterOrEqual,
                    DataverseFilterValue.FromRawString("Some value")),
                "Some%27Field ge Some value"
            },
            {
                new(
                    "some_field",
                    DataverseComparisonOperator.Less,
                    DataverseFilterValue.FromRawString("SomeValue")),
                "some_field lt SomeValue"
            },
            {
                new(
                    "some_field",
                    DataverseComparisonOperator.LessOrEqual,
                    DataverseFilterValue.FromRawString("SomeValue")),
                "some_field le SomeValue"
            }
        };
}