using System.Reflection;
using Microsoft.Extensions.Caching.Memory;

namespace Common.Core.AOP
{
    using System.Linq;

    public class CacheAction : IAopAction
    {
        private readonly IMemoryCache _memoryCache;

        public CacheAction(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public object BeforeAction(MethodInfo targetMethod, object[] args)
        {
            return _memoryCache.Get(args[0]);
        }

        public object AfterAction(MethodInfo targetMethod, object[] args)
        {
            var obj = args.Last();

            return obj;
        }
    }
}