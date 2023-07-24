using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseSetFilterTest
{
    [Theory]
    [MemberData(nameof(QueryTestData))]
    public static void GetQuery_ExpectActualValueIsEqualToExpectedOne(
        DataverseSetFilter source, string expected)
    {
        var actual = source.GetQuery();
        Assert.Equal(expected, actual);
    }
}