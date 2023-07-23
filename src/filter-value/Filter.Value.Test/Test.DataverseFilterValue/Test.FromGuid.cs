using System;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void FromGuidConstructor_ExpectActualValueIsEqualToExpectedValue()
    {
        var sourceValue = Guid.Parse("09c4c45e-4928-432e-b7d7-d00b953a6b98");
        var actual = new DataverseFilterValue(sourceValue);

        var actualValue = actual.Value;
        var expectedValue = "'09c4c45e-4928-432e-b7d7-d00b953a6b98'";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromGuid_ExpectActualValueIsEqualToExpectedValue()
    {
        var sourceValue = Guid.Parse("900813bb-b2fd-4e0c-a167-2984eb11d0bd");
        var actual = DataverseFilterValue.FromGuid(sourceValue);

        var actualValue = actual.Value;
        var expectedValue = "'900813bb-b2fd-4e0c-a167-2984eb11d0bd'";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromGuidImplicit_ExpectActualValueIsEqualToExpectedValue()
    {
        var sourceValue = Guid.Parse("a86bb2da-d074-4fc8-be7b-8b87b85063b8");
        DataverseFilterValue actual = sourceValue;

        var actualValue = actual.Value;
        var expectedValue = "'a86bb2da-d074-4fc8-be7b-8b87b85063b8'";

        Assert.Equal(expectedValue, actualValue);
    }
}