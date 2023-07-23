using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseComparisonFilterTest
{
    [Theory]
    [MemberData(nameof(QueryTestData))]
    public static void GetQuery_ExpectActualValueIsEqualToExpectedOne(
        DataverseComparisonFilter source, string expected)
    {
        var actual = source.GetQuery();
        Assert.Equal(expected, actual);
    }
}