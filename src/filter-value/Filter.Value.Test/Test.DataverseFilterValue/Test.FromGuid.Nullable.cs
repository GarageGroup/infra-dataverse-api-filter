using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(null, "null")]
    [InlineData("0870417c-d193-4709-a470-aaf446e98ca1", "'0870417c-d193-4709-a470-aaf446e98ca1'")]
    public static void FromNullableGuidConstructor_ExpectActualValueIsEqualToExpectedValue(
        string? sourceGuid, string expectedValue)
    {
        var sourceValue = ParseNullableGuid(sourceGuid);

        var actual = new DataverseFilterValue(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(null, "null")]
    [InlineData("445a2311-5e65-4e5b-b4aa-48b06623bc53", "'445a2311-5e65-4e5b-b4aa-48b06623bc53'")]
    public static void FromNullableGuid_ExpectActualValueIsEqualToExpectedValue(
        string? sourceGuid, string expectedValue)
    {
        var sourceValue = ParseNullableGuid(sourceGuid);

        var actual = DataverseFilterValue.FromNullableGuid(sourceValue);
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(null, "null")]
    [InlineData("fd34b6f0-21f5-4c93-b560-ce47329e2c05", "'fd34b6f0-21f5-4c93-b560-ce47329e2c05'")]
    public static void FromNullableGuidImplicit_ExpectActualValueIsEqualToExpectedValue(
        string? sourceGuid, string expectedValue)
    {
        var sourceValue = ParseNullableGuid(sourceGuid);

        DataverseFilterValue actual = sourceValue;
        var actualValue = actual.Value;

        Assert.Equal(expectedValue, actualValue);
    }
}