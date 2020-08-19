using System;

namespace Common.Core.Cache
{
    public class AspectCacheAttribute : Attribute
    {
        public AspectCacheAttribute(Type iService)
        {
            IService = iService;
        }

        public Type IService { get; }
    }
}
