using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

partial class DataverseFilterValueTest
{
    [Fact]
    public static void Null_ExpectActualValueIsEqualToNullValue()
    {
        var actual = DataverseFilterValue.Null;

        var actualValue = actual.Value;
        const string expectedValue = "null";

        Assert.Equal(expectedValue, actualValue);
    }
}