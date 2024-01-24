using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

public static class DataverseNotNullFilterTest
{
    [Fact]
    public static void GetQuery_ExpectNullFilter()
    {
        var source = new DataverseNotNullFilter("Some#Field Name");

        var actual = source.GetQuery();
        const string expected = "Some%23Field+Name ne null";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public static void ToString_ExpectNullFilter()
    {
        var source = new DataverseNotNullFilter("someField");

        var actual = source.ToString();
        const string expected = "someField ne null";

        Assert.Equal(expected, actual);
    }
}