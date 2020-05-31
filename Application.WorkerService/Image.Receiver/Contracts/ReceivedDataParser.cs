using System;
using System.Text;

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
    ///         [2 bytes]   offset 19+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize:20+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize -> Int16 : CreatedBy (CreatedBySize)
    ///         ...         offset 21+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize:21+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+CreatedBySize -> String: CreatedBy
    ///     ] 
    ///     [
    ///         [4 bytes]   offset 22+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+CreatedBySize:24+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+CreatedBySize -> Int32: Image Data (ImageDataSize)
    ///         ...         offset 26+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+CreatedBySize:26+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+ImageDataSize+CreatedBySize+ImageDataSize -> byte[]: Image Data
    ///     ]
    ///     [
    ///         [4 bytes]   offset 27+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+ImageDataSize+CreatedBySize+ImageDataSize:30+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+ImageDataSize+CreatedBySize+ImageDataSize -> Int32 : ImageWidth
    ///     ]
    ///     [
    ///         [4 bytes]   offset 31+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+ImageDataSize+CreatedBySize+ImageDataSize:34+FileNameSize+ImageCategorySize+ImageCommentsSize+QuestionIdSize+AnswerIdSize+ImageDataSize+CreatedBySize+ImageDataSize -> Int32 : ImageHeight
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
        public string ImageFileName => Encoding.ASCII.GetString(_data, 6, ImageFileNameSize);

        public int ImageCategorySize => BitConverter.ToInt16(_data.AsSpan().Slice(6 + ImageFileNameSize, 2));
        public string ImageCategory => Encoding.ASCII.GetString(_data, 8 + ImageFileNameSize, ImageCategorySize);

        public int ImageCommentsSize => BitConverter.ToInt16(_data.AsSpan().Slice(8 + ImageFileNameSize + ImageCategorySize, 2));
        public string ImageComments => Encoding.ASCII.GetString(_data, 10 + ImageFileNameSize + ImageCategorySize, ImageCommentsSize);

        public int QuestionIdSize => BitConverter.ToInt16(_data.AsSpan().Slice(10 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize, 2));
        public string QuestionId => Encoding.ASCII.GetString(_data, 12 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize, QuestionIdSize);

        public int AnswerIdSize => BitConverter.ToInt16(_data.AsSpan().Slice(12 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize + QuestionIdSize, 2));
        public string AnswerId => Encoding.ASCII.GetString(_data, 14 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize + QuestionIdSize, AnswerIdSize);

        public int ImageCreatedBySize => BitConverter.ToInt16(_data.AsSpan().Slice(14 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize + QuestionIdSize + AnswerIdSize, 2));
        public string ImageCreatedBy => Encoding.ASCII.GetString(_data, 16 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize + QuestionIdSize + AnswerIdSize, ImageCreatedBySize);

        public int ImageDataSize => BitConverter.ToInt32(_data.AsSpan().Slice(16 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize + QuestionIdSize + AnswerIdSize + ImageCreatedBySize, 4));
        public byte[] ImageData => _data.AsSpan().Slice(20 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize + QuestionIdSize + AnswerIdSize + ImageCreatedBySize, ImageDataSize).ToArray();

        public int ImageWidth => BitConverter.ToInt32(_data.AsSpan().Slice(20 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize + QuestionIdSize + AnswerIdSize + ImageCreatedBySize + ImageDataSize, 4));
        public int ImageHeight => BitConverter.ToInt32(_data.AsSpan().Slice(24 + ImageFileNameSize + ImageCategorySize + ImageCommentsSize + QuestionIdSize + AnswerIdSize + ImageCreatedBySize + ImageDataSize, 4));
    }
}
