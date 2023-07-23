using System;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseComparisonFilterTest
{
    [Fact]
    public static void Constructor_OperatorIsOutOfRange_ExpectArgumentOutOfRangeException()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(Test);
        Assert.Equal("operator", ex.ParamName);

        static void Test()
            =>
            _ = new DataverseComparisonFilter("SomeName", (DataverseComparisonOperator)(-1), "SomeValue");
    }
}