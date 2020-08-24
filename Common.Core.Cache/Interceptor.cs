using System;

namespace Common.Core.Cache
{
    using System.Collections.Generic;

    public class Interceptor<T> where T : ICached
    {
        private readonly ICache<T> _cache;

        public Interceptor(ICache<T> cache)
        {
            _cache = cache;
        }

        public T Load(string code)
        {
            Before(code);
            return _cache.Load(code);
        }

        public IList<T> LoadAll()
        {
            Before("TEST");
            return _cache.LoadAll();
        }

        private void Before(string code)
        {
            Console.WriteLine(code);
        }
    }
}
