namespace Common.Core.Cache
{
    using System.Collections.Generic;

    public interface ICache<TResponse> where TResponse : ICached
    {
        TResponse Load(string code);

        IList<TResponse> LoadAll();
    }
}
