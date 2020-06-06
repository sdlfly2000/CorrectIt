using Common.Core.DependencyInjection;
using System;
using OpenCvSharp;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

namespace Infrastructure.Data.File.ImageFiles
{
    [ServiceLocate(typeof(IImageFilePersistor))]
    public class ImageFilePersistor : IImageFilePersistor
    {
        private readonly IConfiguration _configuration;
        private string keyImageFileFolder = "FeatureFlags:ImageFileFolder";

        public ImageFilePersistor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Guid SaveToDisk(byte[] imageData, int imageWidth, int imageHeight)
        {
            var guidName = Guid.NewGuid();
            var folder = GetFolderName();
            var fileName = folder + guidName + ".jpeg";
            var imgPtr = Marshal.AllocHGlobal(imageWidth * imageHeight * 3);
            try
            {
                Marshal.Copy(imageData, 0, imgPtr, imageWidth * imageHeight * 3);
                var imageMat = new Mat(imageWidth, imageHeight, MatType.CV_8UC3, imgPtr);

                imageMat.SaveImage(fileName);

                return guidName;
            }
            finally
            {
                Marshal.FreeHGlobal(imgPtr);
            }
        }

        #region Private Methods

        private string GetFolderName()
        {
            return _configuration.GetValue<string>(keyImageFileFolder);
        }

        #endregion
    }
}
