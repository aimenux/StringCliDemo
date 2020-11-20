using System;
using System.Reflection;

namespace App.Extensions
{
    public static class ReflectionExtensions
    {
        public static string GetVersion(this Type type)
        {
            return type
                .Assembly
                ?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
        }
    }
}
