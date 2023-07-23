using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GarageGroup.Infra;

partial class DataverseFilterValue
{
    public static bool Equals(DataverseFilterValue? left, DataverseFilterValue? right)
        =>
        left is null ? right is null : left.Equals(right);

    public static bool operator ==(DataverseFilterValue? left, DataverseFilterValue? right)
        =>
        Equals(left, right);

    public static bool operator !=(DataverseFilterValue? left, DataverseFilterValue? right)
        =>
        Equals(left, right) is false;

    public override bool Equals([NotNullWhen(true)] object? obj)
        =>
        obj is DataverseFilterValue other && Equals(other);

    public bool Equals(DataverseFilterValue? other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return ValueComparer.Equals(Value, other.Value);
    }

    public override int GetHashCode()
        =>
        HashCode.Combine(
            EqualityContractComparer.GetHashCode(EqualityContract),
            ValueComparer.GetHashCode(Value));

    private static Type EqualityContract
        =>
        typeof(DataverseFilterValue);

    private static EqualityComparer<Type> EqualityContractComparer
        =>
        EqualityComparer<Type>.Default;

    private static StringComparer ValueComparer
        =>
        StringComparer.Ordinal;
}