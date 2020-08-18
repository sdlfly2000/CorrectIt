using System;

namespace Common.Core.Cache
{
    public class Interceptor<TResponse> where TResponse : class
    {
        private ICache<TResponse> _cache;

        public Interceptor(ICache<TResponse> cache)
        {
            _cache = cache;
        }

        public TResponse Load(string code)
        {
            Before(code);
            return _cache.Load(code);
        }

        private void Before(string code)
        {
            Console.WriteLine(code);
        }
    }
}
