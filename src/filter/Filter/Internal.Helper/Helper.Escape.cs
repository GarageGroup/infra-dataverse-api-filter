using System.Diagnostics.CodeAnalysis;
using System.Web;

namespace GarageGroup.Infra;

partial class DataverseFilterHelper
{
    internal static string Escape([AllowNull] this string source)
    {
        if (string.IsNullOrEmpty(source))
        {
            return string.Empty;
        }

        return HttpUtility.UrlEncode(source);
    }
}