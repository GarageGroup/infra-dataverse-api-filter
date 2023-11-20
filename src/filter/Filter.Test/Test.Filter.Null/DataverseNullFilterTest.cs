using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

public static class DataverseNullFilterTest
{
    [Fact]
    public static void GetQuery_ExpectNullFilter()
    {
        var source = new DataverseNullFilter("some'Field");

        var actual = source.GetQuery();
        const string expected = "some%27Field eq null";

        Assert.Equal(expected, actual);
    }

    [Fact]
    public static void ToString_ExpectNullFilter()
    {
        var source = new DataverseNullFilter("some field");

        var actual = source.ToString();
        const string expected = "some+field eq null";

        Assert.Equal(expected, actual);
    }
}