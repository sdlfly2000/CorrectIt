using Common.Core.DependencyInjection;
using Domain.Services.QuestionImages.Gateways;
using Domain.Services.QuestionImages.Gateways.Persistors.Contracts;
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
                Console.WriteLine(string.Format("Total Received Data Length: {0}", _data.Count));

                var parser = new ReceivedDataParser(_data.ToArray());

                var questionImageResponse = _imageGateway.Create(new CreateQuestionImageRequest { 
                    ImageCategory = parser.ImageCategory,
                    ImageComments = parser.ImageComments,
                    ImageCreatedBy = parser.ImageCreatedBy,
                    ImageFileName = parser.ImageFileName,
                    QuestionId = new Guid(parser.QuestionId)
                });

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
