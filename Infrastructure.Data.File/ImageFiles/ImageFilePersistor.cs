using Common.Core.DependencyInjection;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace Infrastructure.Data.File.ImageFiles
{
    [ServiceLocate(typeof(IImageFilePersistor))]
    public class ImageFilePersistor : IImageFilePersistor
    {
        public Guid SaveToDisk(byte[] imageData, int imageWidth, int imageHeight)
        {
            var guidName = new Guid();
            var fileName = guidName + ".jpeg";

            var imgPtr = Marshal.AllocHGlobal(imageData.Length);            
            Marshal.Copy(imageData, 0, imgPtr, imageData.Length);
            var imgBitmap = new Bitmap(imageWidth, imageHeight, 1, PixelFormat.Format8bppIndexed, imgPtr);

            //imgBitmap.Save(fileName, ImageFormat.Jpeg);

            Marshal.FreeHGlobal(imgPtr);

            return guidName;
        }
    }
}
