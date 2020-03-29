using Domain.Exercises.Aspects;
using System.Collections.Generic;

namespace Domain.Service.Exercises.Loaders
{
    public interface IAnswerAspectLoader
    {
        AnswerAspect Load(string answerCode);
    }
}