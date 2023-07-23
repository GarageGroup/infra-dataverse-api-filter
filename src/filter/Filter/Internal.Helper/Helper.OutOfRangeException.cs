using System;

namespace GarageGroup.Infra;

partial class DataverseFilterHelper
{
    internal static ArgumentOutOfRangeException CreateOutOfRangeException<T>(this T orderType, string? paramName)
        where T : Enum
        =>
        new(paramName, $"An unexpected {typeof(T).FullName} value: {orderType}");
}