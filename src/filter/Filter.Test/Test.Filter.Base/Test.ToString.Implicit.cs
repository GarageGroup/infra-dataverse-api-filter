using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseFilterBaseTest
{
    [Fact]
    public static void ToStringImplicit_FilterIsNull_ExpectNull()
    {
        var source = (StubDataverseFilterBase?)null;

        string? actual = source;

        Assert.Null(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.WhiteSpaceString)]
    [InlineData(TestData.SomeString)]
    public static void ToStringImplicit_FilterIsNotNull_ExpectFilterQuery(
        string? filterQuery)
    {
        var source = new StubDataverseFilterBase(filterQuery!);

        string? actual = source;
        var expected = filterQuery;

        Assert.Equal(expected, actual);
    }
}