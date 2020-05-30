using Common.Core.DependencyInjection;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Infrastructure.Data.File.ImageFiles
{
    [ServiceLocate(typeof(IImageFilePersistor))]
    public class ImageFilePersistor : IImageFilePersistor
    {
        public Guid SaveToDisk(byte[] imageData, int imageWidth, int imageHeight)
        {
            var guidName = new Guid();
            var fileName = guidName + ".jpeg";
            var imageDataMemoryStream = new MemoryStream(imageData);
            var image = Image.FromStream(imageDataMemoryStream);
            var bitmap = new Bitmap(image, imageWidth, imageHeight);
            bitmap.Save(fileName, ImageFormat.Jpeg);
                
            return guidName;
        }
    }
}
