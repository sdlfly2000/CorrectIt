using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Common.Core.Cache
{
    public static class CacheModule
    {
        private static IServiceCollection _services;

        public static void RegisterCache(IServiceCollection services)
        {
            _services = services;
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

            foreach(var cacheType in cacheTypes)
            {
                var iService = (cacheType as AspectCacheAttribute).IService;
                var iResponse = (cacheType as AspectCacheAttribute).IResponse;
                var response = Activator.CreateInstance(iResponse);
                _services.AddTransient(iService, (provider) =>
                {
                    var target = provider.GetService(iService);
                    return new Interceptor<>();
                });
            }     
        }

        #endregion
    }
}
