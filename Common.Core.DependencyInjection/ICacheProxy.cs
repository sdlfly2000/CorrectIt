namespace Common.Core.DependencyInjection
{
    public interface ICacheProxy<TResponse> where TResponse : class
    {
        TResponse Before(string Code);
    }
}
