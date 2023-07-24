using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void Inequality_LeftIsNullAndRightIsNotNull_ExpectTrue(
        string? rightValue)
    {
        var left = (DataverseFilterValue?)null;
        var right = InitializeFilterValue(rightValue!);

        var actual = left != right;

        Assert.True(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void Inequality_LeftIsNotNullAndRightIsNull_ExpectTrue(
        string? leftValue)
    {
        var left = InitializeFilterValue(leftValue!);
        var right = (DataverseFilterValue?)null;

        var actual = left != right;

        Assert.True(actual);
    }

    [Theory]
    [InlineData(null, TestData.EmptyString)]
    [InlineData(TestData.EmptyString, TestData.WhiteSpaceString)]
    [InlineData(TestData.SomeString, TestData.UpperSomeString)]
    public static void Inequality_LeftrValueIsNotEqualToRightValue_ExpectTrue(
        string? leftValue, string? rightValue)
    {
        var left = InitializeFilterValue(leftValue!);
        var right = InitializeFilterValue(rightValue!);

        var actual = left != right;

        Assert.True(actual);
    }

    [Fact]
    public static void Inequality_LeftIsNullAndRightIsNull_ExpectFalse()
    {
        var left = (DataverseFilterValue?)null;
        var right = (DataverseFilterValue?)null;

        var actual = left != right;

        Assert.False(actual);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void Inequality_LeftValueIsEqualToRightValue_ExpectFalse(
        string? sourceValue)
    {
        var left = InitializeFilterValue(sourceValue!);
        var right = InitializeFilterValue(sourceValue!);

        var actual = left != right;

        Assert.False(actual);
    }
}