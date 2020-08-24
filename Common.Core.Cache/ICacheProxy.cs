namespace Common.Core.DependencyInjection
{
    public interface ICacheProxy<TResponse> where TResponse : class
    {
        TResponse Before(string Code);

        TResponse SetCache(string key, TResponse value);

        TResponse GetCache(string key);
    }
}
