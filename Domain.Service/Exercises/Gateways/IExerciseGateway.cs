using Domain.Exercises;
using Domain.Service.Exercises.Gateways.Criteria;
using System.Collections.Generic;

namespace Domain.Service.Exercises.Gateways
{
    public interface IExerciseGateway
    {
        IExercise Load(GetByQuestionCodeCriterion criterion);

        IList<IExercise> LoadAll();
    }
}