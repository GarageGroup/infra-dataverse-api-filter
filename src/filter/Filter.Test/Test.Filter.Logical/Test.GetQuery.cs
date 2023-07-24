using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseLogicalFilterTest
{
    [Theory]
    [MemberData(nameof(QueryTestData))]
    public static void GetQuery_ExpectActualValueIsEqualToExpectedOne(
        DataverseLogicalFilter source, string expected)
    {
        var actual = source.GetQuery();
        Assert.Equal(expected, actual);
    }
}