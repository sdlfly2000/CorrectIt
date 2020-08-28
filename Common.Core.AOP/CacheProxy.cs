using System;
using System.Reflection;

namespace Common.Core.AOP
{
    public class CacheProxy : DispatchProxy
    {
        public object Wrapped { get; set; }
        public Func<MethodInfo, object[], object> GetCache { get; set; }
        public Func<MethodInfo, object, object> SetCache { get; set; }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            var obj = GetCache(targetMethod, args);

            if (obj != null)
            {
                return obj;
            }

            obj = targetMethod.Invoke(Wrapped, args);

            return SetCache(targetMethod, obj);
        }
    }
}
