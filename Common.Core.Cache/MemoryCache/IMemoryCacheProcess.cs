﻿namespace Common.Core.Cache.MemoryCache
{
    public interface IMemoryCacheProcess
    {
        object Get(string Code);

        void Set(string Code, object value);
    }
}