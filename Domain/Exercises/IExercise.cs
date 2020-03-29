using Domain.Exercises.Aspects;
using System.Collections.Generic;

namespace Domain.Exercises
{
    public interface IExercise : IQuestionAspect
    {
        List<IAnswer> Answers { get; set; }
    }
}
