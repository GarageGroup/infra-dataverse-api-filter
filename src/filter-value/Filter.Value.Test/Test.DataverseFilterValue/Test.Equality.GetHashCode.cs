using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(TestData.EmptyString, TestData.WhiteSpaceString)]
    [InlineData(TestData.SomeString, TestData.UpperSomeString)]
    public static void GetHashCode_FirstValueIsNotEqualToSecondValue_ExpectDifferentHashCodes(
        string firstValue, string secondValue)
    {
        var first = InitializeFilterValue(firstValue!);
        var second = InitializeFilterValue(secondValue!);

        var firstHashCode = first.GetHashCode();
        var secondHashCode = second.GetHashCode();

        var actual = firstHashCode == secondHashCode;
        Assert.False(actual);
    }

    [Theory]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void GetHashCode_FirstValueIsNotEqualToSecondValue_ExpectEqualHashCodes(
        string sourceValue)
    {
        var first = InitializeFilterValue(sourceValue);
        var second = InitializeFilterValue(sourceValue);

        var firstHashCode = first.GetHashCode();
        var secondHashCode = second.GetHashCode();

        var actual = firstHashCode == secondHashCode;
        Assert.True(actual);
    }
}