using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseLogicalFilterTest
{
    [Theory]
    [MemberData(nameof(QueryTestData))]
    public static void ToString_ExpectActualValueIsEqualToExpectedOne(
        DataverseLogicalFilter source, string expected)
    {
        var actual = source.ToString();
        Assert.Equal(expected, actual);
    }
}