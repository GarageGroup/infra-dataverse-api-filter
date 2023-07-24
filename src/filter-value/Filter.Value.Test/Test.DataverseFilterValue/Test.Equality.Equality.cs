using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void Equality_LeftIsNullAndRightIsNotNull_ExpectFalse(
        string? rightValue)
    {
        var left = (DataverseFilterValue?)null;
        var right = InitializeFilterValue(rightValue!);

        var actual = left == right;

        Assert.False(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void Equality_LeftIsNotNullAndRightIsNull_ExpectFalse(
        string? leftValue)
    {
        var left = InitializeFilterValue(leftValue!);
        var right = (DataverseFilterValue?)null;

        var actual = left == right;

        Assert.False(actual);
    }

    [Theory]
    [InlineData(null, TestData.EmptyString)]
    [InlineData(TestData.EmptyString, null)]
    [InlineData(TestData.EmptyString, TestData.WhiteSpaceString)]
    [InlineData(TestData.SomeString, TestData.UpperSomeString)]
    public static void Equality_LeftrValueIsNotEqualToRightValue_ExpectFalse(
        string? leftValue, string? rightValue)
    {
        var left = InitializeFilterValue(leftValue!);
        var right = InitializeFilterValue(rightValue!);

        var actual = left == right;

        Assert.False(actual);
    }

    [Fact]
    public static void Equality_LeftIsNullAndRightIsNull_ExpectTrue()
    {
        var left = (DataverseFilterValue?)null;
        var right = (DataverseFilterValue?)null;

        var actual = left == right;

        Assert.True(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void Equality_LeftValueIsEqualToRightValue_ExpectTrue(
        string? sourceValue)
    {
        var left = InitializeFilterValue(sourceValue!);
        var right = InitializeFilterValue(sourceValue!);

        var actual = left == right;

        Assert.True(actual);
    }
}