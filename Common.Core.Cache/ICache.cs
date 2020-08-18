namespace Common.Core.Cache
{
    public interface ICache<TResponse> where TResponse : class
    {
        TResponse Load(string code);
    }
}
