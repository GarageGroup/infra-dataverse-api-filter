using System;

namespace GarageGroup.Infra;

public sealed partial class DataverseFilterValue : IEquatable<DataverseFilterValue>
{
    public static readonly DataverseFilterValue Null;

    static DataverseFilterValue()
        =>
        Null = new(NullValue, 0);

    private const string NullValue = "null";

    // Initializes an instance without any processing
    //
    // Note: The unused arg is intended to separate this from the public one
    //
    private DataverseFilterValue(string value, int _)
        =>
        Value = value;

    public string Value { get; }
}