using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseComparisonFilterTest
{
    [Theory]
    [MemberData(nameof(QueryTestData))]
    public static void ToString_ExpectActualValueIsEqualToExpectedOne(
        DataverseComparisonFilter source, string expected)
    {
        var actual = source.ToString();
        Assert.Equal(expected, actual);
    }
}