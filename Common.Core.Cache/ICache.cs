namespace Common.Core.Cache
{
    public interface ICache<TResponse> where TResponse : ICached
    {
        TResponse Load(string code);
    }
}
