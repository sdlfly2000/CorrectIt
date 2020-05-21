using System;
using System.Collections.Generic;

namespace Application.WorkerService.Image.Receiver.Contracts
{

    /// <summary>
    /// The structure of data received from mobile is,
    /// [
    ///     [4 bytes]       offset 0:3              -> Int32    : whole data size
    ///     [
    ///         [2 bytes]   offset 4:5              -> Int16    : File Name Size (FileNameSize)
    ///         ...         offset 6:6+FileNameSize -> String   : File Name
    ///     ]
    ///     [
    ///         [2 bytes]   offset 7+FileNameSize:8+FileNameSize                    -> Int16    : ImageCategory (ImageCategorySize)
    ///         ...         offset 9+FileNameSize:9+FileNameSize+ImageCategorySize  -> String   : Image Category
    ///     ]
    ///     [
    ///         [2 bytes]   offset 10+FileNameSize+ImageCategorySize:11+FileNameSize+ImageCategorySize  -> Int16    : ImageComments (ImageCommentsSize)
    ///         ...         offset 12+FileNameSize+ImageCategorySize:12+FileNameSize+ImageCategorySize+ImageCommentsSize -> String: Image Comments
    ///     ]
    ///     [
    ///         [2 bytes]   offset 13+FileNameSize+ImageCategorySize+ImageCommentsSize:14+FileNameSize+ImageCategorySize+ImageCommentsSize -> Int16 : QuestionId (QuestionIdSize)
    ///         ...         offset 15+FileNameSize+ImageCategorySize+ImageCommentsSize:15+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize -> String: Question Id
    ///     ]
    ///     [
    ///         [2 bytes]   offset 16+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize:17+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize -> Int16 : AnswerId (AnswerIdSize)
    ///         ...         offset 18+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize:18+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize -> String: Answer Id
    ///     ]
    ///     [
    ///         [4 bytes]   offset 19+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize:22+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize -> Int32: Image Data (ImageDataSize)
    ///         ...         23+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize:23+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+ImageDataSize
    ///     ] 
    /// ]
    /// </summary>
    public class ReceivedDataParser : IReceivedDataParser
    {
        private readonly byte[] _data;

        public ReceivedDataParser(byte[] data)
        {
            _data = data;
        }

        public int ImageFileNameSize => BitConverter.ToInt16(_data.AsSpan().Slice(4,2));
        public string ImaageFileName => BitConverter.ToString(_data, 6, ImageFileNameSize);

        public int ImageCategorySize => BitConverter.ToInt16(_data.AsSpan().Slice(4,2));
        public string ImageCategory => BitConverter.ToString(_data, 6, ImageFileNameSize);



    }
}
