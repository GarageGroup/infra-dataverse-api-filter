using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void EqualsWithObject_ObjectIsNotDataverseFilterValue_ExpectFalse()
    {
        var source = InitializeFilterValue(TestData.SomeString);
        var @object = TestData.SomeString;

        var actual = source.Equals((object?)@object);

        Assert.False(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void EqualsWithObject_ObjectIsNull_ExpectFalse(
        string? sourceValue)
    {
        var source = InitializeFilterValue(sourceValue!);
        var @object = (DataverseFilterValue?)null;

        var actual = source.Equals((object?)@object);

        Assert.False(actual);
    }

    [Theory]
    [InlineData(null, TestData.EmptyString)]
    [InlineData(TestData.EmptyString, null)]
    [InlineData(TestData.EmptyString, TestData.WhiteSpaceString)]
    [InlineData(TestData.SomeString, TestData.UpperSomeString)]
    public static void EqualsWithObject_ObjectValueIsNotEqualToSourceValue_ExpectFalse(
        string? sourceValue, string? otherValue)
    {
        var source = InitializeFilterValue(sourceValue!);
        var @object = InitializeFilterValue(otherValue!);

        var actual = source.Equals((object?)@object);

        Assert.False(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void EqualsWithObject_ObjectValueIsEqualToSourceValue_ExpectTrue(
        string? sourceValue)
    {
        var source = InitializeFilterValue(sourceValue!);
        var @object = InitializeFilterValue(sourceValue!);

        var actual = source.Equals((object?)@object);

        Assert.True(actual);
    }
}