using System;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void FromNullableDateTimeConstructor_SourceIsNull_ExpectActualValueIsNullValue()
    {
        DateTime? sourceValue = null;
        var actual = new DataverseFilterValue(sourceValue);

        var actualValue = actual.Value;

        Assert.Equal(NullValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateTimeConstructor_SourceIsNotNull_ExpectActualValueIsInCorrectFormat()
    {
        DateTime? sourceValue = new DateTime(2019, 03, 27, 05, 35, 55, 701);
        var actual = new DataverseFilterValue(sourceValue);

        var actualValue = actual.Value;
        const string expectedValue = "2019-03-27T05:35:55.701Z";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateTime_SourceIsNull_ExpectActualValueIsNullValue()
    {
        var sourceValue = (DateTime?)null;
        var actual = DataverseFilterValue.FromNullableDateTime(sourceValue);

        var actualValue = actual.Value;

        Assert.Equal(NullValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateTime_SourceIsNotNull_ExpectActualValueIsInCorrectFormat()
    {
        var sourceValue = new DateTime(2023, 09, 30, 21, 57, 19, 200);
        var actual = DataverseFilterValue.FromNullableDateTime(sourceValue);

        var actualValue = actual.Value;
        const string expectedValue = "2023-09-30T21:57:19.200Z";

        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateTimeImplicit_SourceIsNull_ExpectActualValueIsInCorrectFormat()
    {
        DateTime? sourceValue = null;
        DataverseFilterValue actual = sourceValue;

        var actualValue = actual.Value;

        Assert.Equal(NullValue, actualValue);
    }

    [Fact]
    public static void FromNullableDateTimeImplicit_SourceIsNotNull_ExpectActualValueIsInCorrectFormat()
    {
        DateTime? sourceValue = new(2023, 05, 17, 12, 25, 57, 000);
        DataverseFilterValue actual = sourceValue;

        var actualValue = actual.Value;
        const string expectedValue = "2023-05-17T12:25:57.000Z";

        Assert.Equal(expectedValue, actualValue);
    }
}