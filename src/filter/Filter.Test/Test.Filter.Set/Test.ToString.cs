using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseSetFilterTest
{
    [Theory]
    [MemberData(nameof(QueryTestData))]
    public static void ToString_ExpectActualValueIsEqualToExpectedOne(
        DataverseSetFilter source, string expected)
    {
        var actual = source.ToString();
        Assert.Equal(expected, actual);
    }
}