using System;

namespace Common.Core.Cache
{
    public class AspectCacheAttribute : Attribute
    {
        public AspectCacheAttribute(Type iService, Type iResponse)
        {
            IService = iService;
            IResponse = iResponse;
        }

        public Type IService { get; }
        public Type IResponse { get; }
    }
}
