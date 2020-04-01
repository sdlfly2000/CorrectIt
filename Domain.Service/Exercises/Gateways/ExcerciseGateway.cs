using Common.Core.DependencyInjection;
using Domain.Service.Exercises.Gateways.Criteria;
using Domain.Service.Exercises.Gateways.Loaders;

namespace Domain.Service.Exercises.Gateways
{
    [ServiceLocate(typeof(IExcerciseGateway))]
    public class ExcerciseGateway : IExcerciseGateway
    {
        private readonly IQuestionAspectLoader _questionAspectLoader;

        public ExcerciseGateway(
            IQuestionAspectLoader questionAspectLoader)
        {
            _questionAspectLoader = questionAspectLoader;
        }

        public Exercise Load(GetByQuestionCodeCriterion criterion)
        {
            return new Exercise(_questionAspectLoader.Load(criterion.Code));
        }
    }
}
