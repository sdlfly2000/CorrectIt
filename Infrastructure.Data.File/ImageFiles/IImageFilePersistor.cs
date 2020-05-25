namespace Infrastructure.Data.File.ImageFiles
{
    public interface IImageFilePersistor
    {
        void SaveToDisk(byte[] imageData);
    }
}