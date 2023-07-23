using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void EqualsWithOther_OtherIsNull_ExpectFalse(
        string? sourceValue)
    {
        var source = InitializeFilterValue(sourceValue!);
        var other = (DataverseFilterValue?)null;

        var actual = source.Equals(other);

        Assert.False(actual);
    }

    [Theory]
    [InlineData(null, TestData.EmptyString)]
    [InlineData(TestData.EmptyString, null)]
    [InlineData(TestData.EmptyString, TestData.WhiteSpaceString)]
    [InlineData(TestData.SomeString, TestData.UpperSomeString)]
    public static void EqualsWithOther_OtherValueIsNotEqualToSourceValue_ExpectFalse(
        string? sourceValue, string? otherValue)
    {
        var source = InitializeFilterValue(sourceValue!);
        var other = InitializeFilterValue(otherValue!);

        var actual = source.Equals(other);

        Assert.False(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void EqualsWithOther_OtherValueIsEqualToSourceValue_ExpectTrue(
        string? sourceValue)
    {
        var source = InitializeFilterValue(sourceValue!);
        var other = InitializeFilterValue(sourceValue!);

        var actual = source.Equals(other);

        Assert.True(actual);
    }
}