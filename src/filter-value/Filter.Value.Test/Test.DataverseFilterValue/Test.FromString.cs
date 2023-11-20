using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(TestData.EmptyString, "''")]
    [InlineData(TestData.MixedWhiteSpacesString, "'%09%09+'")]
    [InlineData(TestData.SomeString, "'Some+String'")]
    [InlineData("Tes'tsd''1", "'Tes%27%27tsd%27%27%27%271'")]
    [InlineData("\"Test#123\"", "'%22Test%23123%22'")]
    public static void FromStringConstructor_ExpectActualValueIsEqualToExpectedValue(
        string? sourceValue, string expectedValue)
    {
        var actual = new DataverseFilterValue(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(TestData.EmptyString, "''")]
    [InlineData(TestData.MixedWhiteSpacesString, "'%09%09+'")]
    [InlineData(TestData.SomeString, "'Some+String'")]
    [InlineData("Tes'tsd''1", "'Tes%27%27tsd%27%27%27%271'")]
    [InlineData("\"Test#123\"", "'%22Test%23123%22'")]
    public static void FromString_ExpectActualValueIsEqualToExpectedValue(
        string? sourceValue, string expectedValue)
    {
        var actual = DataverseFilterValue.FromString(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(TestData.EmptyString, "''")]
    [InlineData(TestData.MixedWhiteSpacesString, "'%09%09+'")]
    [InlineData(TestData.SomeString, "'Some+String'")]
    [InlineData("Tes'tsd''1", "'Tes%27%27tsd%27%27%27%271'")]
    [InlineData("\"Test#123\"", "'%22Test%23123%22'")]
    public static void FromStringImplicit_ExpectActualValueIsEqualToExpectedValue(
        string? sourceValue, string expectedValue)
    {
        DataverseFilterValue actual = sourceValue;
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }
}