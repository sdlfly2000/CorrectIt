using Domain.Exercises.Aspects;
using System.Collections.Generic;

namespace Domain.Service.Exercises.Gateways.Loaders
{
    public interface IQuestionAspectLoader
    {
        IQuestionAspect Load(string code);

        List<IQuestionAspect> LoadAll();
    }
}