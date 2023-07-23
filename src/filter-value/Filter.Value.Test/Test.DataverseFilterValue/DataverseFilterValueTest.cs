using System;
using System.Diagnostics;
using System.Reflection;

namespace GarageGroup.Infra.Dataverse.Api.Filter.Value.Test;

public static partial class DataverseFilterValueTest
{
    private static DataverseFilterValue InitializeFilterValue(string value)
    {
        const BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;

        var constructor = typeof(DataverseFilterValue).GetConstructor(bindingFlags, null, new[] { typeof(string), typeof(int) }, null);
        Debug.Assert(constructor is not null);

        var filterValue = constructor.Invoke(new object[] { value, 0 }) as DataverseFilterValue;
        Debug.Assert(filterValue is not null);

        return filterValue;
    }

    private static Guid? ParseNullableGuid(string? sourceValue)
        =>
        string.IsNullOrEmpty(sourceValue) ? null : Guid.Parse(sourceValue);
}