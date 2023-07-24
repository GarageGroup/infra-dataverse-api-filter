using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseFilterBaseTest
{
    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.WhiteSpaceString)]
    [InlineData(TestData.SomeString)]
    public static void ToString_ExpectQueryValue(
        string? queryValue)
    {
        var source = new StubDataverseFilterBase(queryValue!);

        var actual = source.ToString();
        var expected = queryValue;

        Assert.Equal(expected, actual);
    }
}