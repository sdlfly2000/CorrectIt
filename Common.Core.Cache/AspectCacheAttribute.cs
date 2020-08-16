using System;

namespace Common.Core.Cache
{
    public class AspectCacheAttribute : Attribute
    {
        public AspectCacheAttribute(Type cache)
        {
            Cache = cache;
        }

        public Type Cache { get; }
    }
}
