using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(false, "false")]
    [InlineData(true, "true")]
    public static void FromNullableBooleanConstructor_ExpectActualValueIsEqualToExpectedValue(
        bool? sourceValue, string expectedValue)
    {
        var actual = new DataverseFilterValue(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(false, "false")]
    [InlineData(true, "true")]
    public static void FromNullableBoolean_ExpectActualValueIsEqualToExpectedValue(
        bool? sourceValue, string expectedValue)
    {
        var actual = DataverseFilterValue.FromNullableBoolean(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(null, NullValue)]
    [InlineData(false, "false")]
    [InlineData(true, "true")]
    public static void FromNullableBooleanImplicit_ExpectActualValueIsEqualToExpectedValue(
        bool? sourceValue, string expectedValue)
    {
        DataverseFilterValue actual = sourceValue;
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }
}