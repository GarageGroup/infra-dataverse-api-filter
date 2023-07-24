using PrimeFuncPack.UnitTest;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Theory]
    [InlineData(null)]
    [InlineData(TestData.EmptyString)]
    [InlineData(TestData.SomeString)]
    public static void ToString_ExpectSourceValue(
        string? sourceValue)
    {
        var source = InitializeFilterValue(sourceValue!);

        var actual = source.ToString();
        var expected = sourceValue;

        Assert.Equal(expected, actual);
    }
}