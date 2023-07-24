using System;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseSetFilterTest
{
    [Fact]
    public static void Constructor_OperatorIsOutOfRange_ExpectArgumentOutOfRangeException()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(Test);
        Assert.Equal("operator", ex.ParamName);

        static void Test()
            =>
            _ = new DataverseSetFilter("SomeField", (DataverseSetOperator)(-1), default);
    }
}