using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void ToStringImplicit_SourceIsNull_ExpectNull()
    {
        var source = (DataverseFilterValue?)null;

        string? actual = source;

        Assert.Null(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void ToStringImplicit_SourceIsNotNull_ExpectSourceValue(
        string? sourceValue)
    {
        var source = InitializeFilterValue(sourceValue!);

        string actual = source;
        var expected = sourceValue;

        Assert.Equal(expected, actual);
    }
}