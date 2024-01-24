using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

public static partial class DataverseSetFilterTest
{
    public static TheoryData<DataverseSetFilter, string> QueryTestData
        =>
        new()
        {
            {
                new(
                    "SomeField",
                    DataverseSetOperator.In,
                    default),
                string.Empty
            },
            {
                new(
                    "Some Field",
                    DataverseSetOperator.In,
                    new[]
                    {
                        DataverseFilterValue.FromRawString("Some value")
                    }),
                "Some+Field eq Some value"
            },
            {
                new(
                    "SomeField",
                    DataverseSetOperator.In,
                    new[]
                    {
                        DataverseFilterValue.FromRawString("One"),
                        DataverseFilterValue.FromRawString("Two"),
                        DataverseFilterValue.FromRawString("Three")
                    }),
                "(SomeField eq One or SomeField eq Two or SomeField eq Three)"
            },
            {
                new(
                    "SomeField",
                    DataverseSetOperator.NotIn,
                    default),
                string.Empty
            },
            {
                new(
                    "SomeField",
                    DataverseSetOperator.NotIn,
                    new[]
                    {
                        DataverseFilterValue.FromRawString("Some value")
                    }),
                "SomeField ne Some value"
            },
            {
                new(
                    "Some'Field",
                    DataverseSetOperator.NotIn,
                    new[]
                    {
                        DataverseFilterValue.FromRawString("One"),
                        DataverseFilterValue.FromRawString("Two"),
                        DataverseFilterValue.FromRawString("Three")
                    }),
                "(Some%27Field ne One and Some%27Field ne Two and Some%27Field ne Three)"
            }
        };
}