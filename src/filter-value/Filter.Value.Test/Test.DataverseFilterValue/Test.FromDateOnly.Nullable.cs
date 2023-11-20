using System;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void FromNullableDateOnlyConstructor_SourceIsNull_ExpectActualValueIsNullValue()
    {
        DateOnly? sourceValue = null;
        var actual = new DataverseFilterValue(sourceValue);

        var actualValue = actual.Value;

        Assert.Equal(NullValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateOnlyConstructor_SourceIsNotNull_ExpectActualValueIsInCorrectFormat()
    {
        DateOnly? sourceValue = new DateOnly(2023, 11, 07);
        var actual = new DataverseFilterValue(sourceValue);

        var actualValue = actual.Value;
        const string expectedValue = "2023-11-07";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateOnly_SourceIsNull_ExpectActualValueIsNullValue()
    {
        var sourceValue = (DateOnly?)null;
        var actual = DataverseFilterValue.FromNullableDateOnly(sourceValue);

        var actualValue = actual.Value;

        Assert.Equal(NullValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateOnly_SourceIsNotNull_ExpectActualValueIsInCorrectFormat()
    {
        var sourceValue = new DateOnly(2022, 03, 21);
        var actual = DataverseFilterValue.FromNullableDateOnly(sourceValue);

        var actualValue = actual.Value;
        const string expectedValue = "2022-03-21";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateOnlyImplicit_SourceIsNull_ExpectActualValueIsInCorrectFormat()
    {
        DateOnly? sourceValue = null;
        DataverseFilterValue actual = sourceValue;

        var actualValue = actual.Value;

        Assert.Equal(NullValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateOnlyImplicit_SourceIsNotNull_ExpectActualValueIsInCorrectFormat()
    {
        DateOnly? sourceValue = new(2023, 01, 15);
        DataverseFilterValue actual = sourceValue;

        var actualValue = actual.Value;
        const string expectedValue = "2023-01-15";

        Assert.Equal(expectedValue, actualValue);
    }
}