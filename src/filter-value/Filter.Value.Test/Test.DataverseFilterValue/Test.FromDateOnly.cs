using System;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void FromDateOnlyConstructor_ExpectActualValueIsInCorrectFormat()
    {
        var sourceValue = new DateOnly(2023, 07, 23);
        var actual = new DataverseFilterValue(sourceValue);

        var actualValue = actual.Value;
        const string expectedValue = "2023-07-23";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromDateOnly_ExpectActualValueIsInCorrectFormat()
    {
        var sourceValue = new DateOnly(2021, 12, 19);
        var actual = DataverseFilterValue.FromDateOnly(sourceValue);

        var actualValue = actual.Value;
        const string expectedValue = "2021-12-19";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromDateOnlyImplicit_ExpectActualValueIsInCorrectFormat()
    {
        var sourceValue = new DateOnly(2022, 10, 11);
        DataverseFilterValue actual = sourceValue;

        var actualValue = actual.Value;
        const string expectedValue = "2022-10-11";

        Assert.Equal(expectedValue, actualValue);
    }
}