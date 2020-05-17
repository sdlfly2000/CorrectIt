using Common.Core.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Sql.Questions
{
    [ServiceLocate(typeof(IQuestionRepository))]
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ICorrectItDbContext _context;

        public QuestionRepository(ICorrectItDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.Commit();
        }

        public void Create(QuestionEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<QuestionEntity> LoadAll()
        {
            return _context.Questions.ToList();
        }

        public void Persist(QuestionEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(QuestionEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
