using System;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Configuration;

namespace Common.Core.Cache
{
    using StackExchange.Redis;

    public class AspectCacheAttribute : Attribute
    {
        private static RedisCacheOptions _redisCacheOptions;
        private static RedisCache _redisCache;
        private IConfiguration _configuration;

        public AspectCacheAttribute(IConfiguration configuration)
        {
            _configuration = configuration;

            _redisCacheOptions = new RedisCacheOptions
             {
                ConfigurationOptions = new ConfigurationOptions
               {

               }
             };
            _redisCache = new RedisCache(_redisCacheOptions);
        }

        public static void Cache<T>() where T : ICache
        {

        }
    }
}
