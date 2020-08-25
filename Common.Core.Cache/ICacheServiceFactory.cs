namespace Common.Core.Cache
{
    public interface ICacheServiceFactory
    {
        object Get(string Code);

        void Set(string Code, object value);
    }
}
