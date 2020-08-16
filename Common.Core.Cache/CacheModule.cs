using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Common.Core.Cache
{
    public static class CacheModule
    {
        public static void RegisterCache()
        {
            RegisterDomain("Domain.Services");
        }

        #region Private Methods

        private static void RegisterDomain(string domain)
        {
            var asm = Assembly.Load(domain);

            var methods = asm.GetExportedTypes()
                .Where(t => !t.IsInterface)
                .Select(impl => impl.GetMethods())
                .ToList();

            var cacheMethods = new List<Attribute>();

            foreach (var method in methods)
            {
                cacheMethods.AddRange(method
                    .Select(m => m.GetCustomAttribute(typeof(AspectCacheAttribute)))
                    .Where(a => a != null)
                    .ToList());
            }

            var cacheTypes = cacheMethods.Cast<AspectCacheAttribute>().ToList();

        }

        #endregion
    }
}
