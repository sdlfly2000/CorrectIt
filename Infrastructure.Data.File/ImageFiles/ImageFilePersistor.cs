using Common.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.File.ImageFiles
{
    [ServiceLocate(typeof(IImageFilePersistor))]
    public class ImageFilePersistor : IImageFilePersistor
    {
        public void SaveToDisk(byte[] imageData)
        {
        }
    }
}
