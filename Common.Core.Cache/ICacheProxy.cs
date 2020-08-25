namespace Common.Core.DependencyInjection
{
    public interface ICacheProxy<TResponse> where TResponse : class
    {
        void SetCache(string key, TResponse value);

        TResponse GetCache(string key);
    }
}
