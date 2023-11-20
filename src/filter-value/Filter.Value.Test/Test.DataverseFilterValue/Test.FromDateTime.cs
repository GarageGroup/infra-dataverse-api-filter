using System;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void FromDateTimeConstructor_ExpectActualValueIsInCorrectFormat()
    {
        var sourceValue = new DateTime(2021, 10, 03, 20, 15, 54, 357);
        var actual = new DataverseFilterValue(sourceValue);

        var actualValue = actual.Value;
        const string expectedValue = "2021-10-03T20:15:54.357Z";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromDateTime_ExpectActualValueIsInCorrectFormat()
    {
        var sourceValue = new DateTime(2023, 02, 15, 01, 30, 21, 000);
        var actual = DataverseFilterValue.FromDateTime(sourceValue);

        var actualValue = actual.Value;
        const string expectedValue = "2023-02-15T01:30:21.000Z";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromDateTimeImplicit_ExpectActualValueIsInCorrectFormat()
    {
        var sourceValue = new DateTime(2022, 06, 27, 11, 53, 17, 201);
        DataverseFilterValue actual = sourceValue;

        var actualValue = actual.Value;
        const string expectedValue = "2022-06-27T11:53:17.201Z";

        Assert.Equal(expectedValue, actualValue);
    }
}