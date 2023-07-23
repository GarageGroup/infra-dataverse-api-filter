using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void FromRawString_SourceIsNull_ExpectActualValueIsEmpty()
    {
        var actual = DataverseFilterValue.FromRawString(null!);

        var actualValue = actual.Value;

        Assert.Empty(actualValue);
    }

    [Theory]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.MixedWhiteSpacesString)]
    [InlineData(TestData.SomeString)]
    public static void FromRawString_SourceIsNotNull_ExpectActualValueIsEqualToSourceValue(
        string sourceValue)
    {
        var actual = DataverseFilterValue.FromRawString(sourceValue);

        var actualValue = actual.Value;
        var expectedValue = sourceValue;

        Assert.Equal(expectedValue, actualValue);
    }
}