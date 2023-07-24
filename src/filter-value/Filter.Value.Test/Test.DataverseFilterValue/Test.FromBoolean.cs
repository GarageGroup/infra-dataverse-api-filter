using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(false, "false")]
    [InlineData(true, "true")]
    public static void FromBooleanConstructor_ExpectActualValueIsEqualToExpectedValue(
        bool sourceValue, string expectedValue)
    {
        var actual = new DataverseFilterValue(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(false, "false")]
    [InlineData(true, "true")]
    public static void FromBoolean_ExpectActualValueIsEqualToExpectedValue(
        bool sourceValue, string expectedValue)
    {
        var actual = DataverseFilterValue.FromBoolean(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(false, "false")]
    [InlineData(true, "true")]
    public static void FromBooleanImplicit_ExpectActualValueIsEqualToExpectedValue(
        bool sourceValue, string expectedValue)
    {
        DataverseFilterValue actual = sourceValue;
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }
}