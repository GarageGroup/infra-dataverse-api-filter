using System;
using Xunit;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Test;

partial class DataverseLogicalFilterTest
{
    [Fact]
    public static void Constructor_OperatorIsOutOfRange_ExpectArgumentOutOfRangeException()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(Test);
        Assert.Equal("operator", ex.ParamName);

        static void Test()
            =>
            _ = new DataverseLogicalFilter((DataverseLogicalOperator)(-1), default);
    }

#if NET7_0_OR_GREATER
    [Fact]
    public static void ConstructorWithFilterInitializer_OperatorIsOutOfRange_ExpectArgumentOutOfRangeException()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(Test);
        Assert.Equal("operator", ex.ParamName);

        static void Test()
            =>
            _ = new DataverseLogicalFilter((DataverseLogicalOperator)(-1))
            {
                Filters = default
            };
    }
#endif
}