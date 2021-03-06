﻿using System.Collections.Generic;
using System.Linq;
using Domain.Exercises.Aspects;
using Domain.Service.Exercises.Gateways.Loaders;
using Domain.Service.Exercises.Gateways.Loaders.Mappers;
using Infrastructure.Data.Sql.Questions;

namespace Domain.Service.Exercises.Loaders
{
    public class QuestionAspectLoader : IQuestionAspectLoader
    {
        private IQuestionRepository _repository;
        private IQuestionAspectMapper _mapper;

        public QuestionAspectLoader(
            IQuestionAspectMapper mappper,
            IQuestionRepository repository)
        {
            _repository = repository;
            _mapper = mappper;
        }

        public virtual IQuestionAspect Load(string code)
        {
            return _mapper.Map(_repository.LoadAll().FirstOrDefault(q => q.QuestionId.ToString().Equals(code)));
        }
        
        public virtual IList<IQuestionAspect> LoadAll()
        {
            var entities = _repository.LoadAll();

            return entities.Select(e => _mapper.Map(e)).ToList<IQuestionAspect>();
        }
    }
}
