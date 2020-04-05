using Common.Core.DependencyInjection;
using Domain.Exercises;
using Domain.Service.Exercises.Gateways.Criteria;
using Domain.Service.Exercises.Gateways.Loaders;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Service.Exercises.Gateways
{
    [ServiceLocate(typeof(IExerciseGateway))]
    public class ExerciseGateway : IExerciseGateway
    {
        private readonly IQuestionAspectLoader _questionAspectLoader;

        [ServiceLocateConstrcutor]
        public ExerciseGateway(
            IQuestionAspectLoader questionAspectLoader)
        {
            _questionAspectLoader = questionAspectLoader;
        }

        public IExercise Load(GetByQuestionCodeCriterion criterion)
        {
            return new Exercise(_questionAspectLoader.Load(criterion.Code));
        }

        public IList<IExercise> LoadAll()
        {
            var aspects = _questionAspectLoader.LoadAll();

            return aspects.Select(a => new Exercise(a)).ToList<IExercise>();
        }
    }
}
