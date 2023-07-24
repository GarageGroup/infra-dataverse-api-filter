using System.Collections.Generic;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

public static partial class DataverseSetFilterTest
{
    public static IEnumerable<object[]> QueryTestData
        =>
        new[]
        {
            new object[]
            {
                new DataverseSetFilter(
                    "SomeField",
                    DataverseSetOperator.In,
                    default),
                string.Empty
            },
            new object[]
            {
                new DataverseSetFilter(
                    "Some Field",
                    DataverseSetOperator.In,
                    new[]
                    {
                        DataverseFilterValue.FromRawString("Some value")
                    }),
                "Some+Field eq Some value"
            },
            new object[]
            {
                new DataverseSetFilter(
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
            new object[]
            {
                new DataverseSetFilter(
                    "SomeField",
                    DataverseSetOperator.NotIn,
                    default),
                string.Empty
            },
            new object[]
            {
                new DataverseSetFilter(
                    "SomeField",
                    DataverseSetOperator.NotIn,
                    new[]
                    {
                        DataverseFilterValue.FromRawString("Some value")
                    }),
                "SomeField ne Some value"
            },
            new object[]
            {
                new DataverseSetFilter(
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