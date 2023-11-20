using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(TestData.Zero, "0")]
    [InlineData(TestData.MinusFifteen, "-15")]
    [InlineData(TestData.PlusFifteen, "15")]
    public static void FromNullableInt32Constructor_ExpectActualValueIsEqualToExpectedValue(
        int? sourceValue, string expectedValue)
    {
        var actual = new DataverseFilterValue(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(TestData.Zero, "0")]
    [InlineData(TestData.MinusOne, "-1")]
    [InlineData(TestData.PlusFifteen, "15")]
    public static void FromNullableInt32_ExpectActualValueIsEqualToExpectedValue(
        int? sourceValue, string expectedValue)
    {
        var actual = DataverseFilterValue.FromNullableInt32(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(TestData.Zero, "0")]
    [InlineData(TestData.MinusFifteen, "-15")]
    [InlineData(TestData.One, "1")]
    public static void FromNullableInt32Implicit_ExpectActualValueIsEqualToExpectedValue(
        int? sourceValue, string expectedValue)
    {
        DataverseFilterValue actual = sourceValue;
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }
}