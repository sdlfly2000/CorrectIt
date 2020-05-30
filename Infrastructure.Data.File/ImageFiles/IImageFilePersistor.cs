using System;

namespace Infrastructure.Data.File.ImageFiles
{
    public interface IImageFilePersistor
    {
        Guid SaveToDisk(byte[] imageData, int imageWidth, int imageHeight);
    }
}