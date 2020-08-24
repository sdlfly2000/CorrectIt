using Domain.Exercises.Aspects;
using System.Collections.Generic;
using Common.Core.Cache;

namespace Domain.Service.Exercises.Gateways.Loaders
{
    public interface IQuestionAspectLoader
    {
        IQuestionAspect Load(string code);

        IList<IQuestionAspect> LoadAll();
    }
}