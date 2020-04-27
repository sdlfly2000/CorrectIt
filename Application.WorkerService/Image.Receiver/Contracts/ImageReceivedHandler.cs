using Common.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.WorkerService.Image.Receiver.Contracts
{
    [ServiceLocate(typeof(IImageReceivedHandler))]
    public class ImageReceivedHandler : IImageReceivedHandler
    {
        #region Private Variables
        private readonly List<byte> _data;

        private int _dataSize;
        private int _dataReceivedSize;        
        #endregion

        public ImageReceivedHandler()
        {
            _dataSize = 60;
            _data = new List<byte>();
        }

        public void Process(byte[] data)
        {
            _dataReceivedSize += data.Length;
            _data.AddRange(data);

            if (_dataReceivedSize >= _dataSize)
            {
                Console.WriteLine(_data.Count);
                Console.WriteLine(Encoding.ASCII.GetString(_data.ToArray()));
                _dataReceivedSize = 0;
                _data.Clear();
            }
        }
    }
}
