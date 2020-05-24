using Common.Core.DependencyInjection;
using Domain.Services.QuestionImages.Gateways;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.WorkerService.Image.Receiver.Contracts
{
    [ServiceLocate(typeof(IImageReceivedHandler))]
    public class ImageReceivedHandler : IImageReceivedHandler
    {
        #region Private Variables

        private readonly IQuestionImageGateway _imageGateway;

        private List<byte> _data;

        private int _dataSize = 0;
        private int _dataReceivedSize = 0;
        private bool isWaitForContinueData = false;

        private IReceivedDataParser _parser;

        #endregion

        public ImageReceivedHandler(IQuestionImageGateway imageGateway)
        {
            _imageGateway = imageGateway;

            _data = new List<byte>();
        }

        public void Process(byte[] data)
        {
            if (!isWaitForContinueData)
            {
                _dataSize = GetDataSize(data);
                isWaitForContinueData = true;
            }

            _dataReceivedSize += data.Length;
            _data.AddRange(data);

            if (_dataSize != 0 && _dataReceivedSize >= _dataSize)
            {
                Console.WriteLine(_data.Count);
                Console.WriteLine(Encoding.ASCII.GetString(_data.ToArray().AsSpan<byte>(4)));

                _parser = new ReceivedDataParser(_data.ToArray());
                _imageGateway.

                _dataReceivedSize = 0;
                _data.Clear();
                isWaitForContinueData = false;
            }
        }

        #region Private Methods

        private int GetDataSize(byte[] data)
        {
            return BitConverter.ToInt32(data.AsSpan<byte>().Slice(0, 4));
        }

        #endregion
    }
}
