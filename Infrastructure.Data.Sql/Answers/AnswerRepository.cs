using Common.Core.Data.Sql;
using Common.Core.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Sql.Answers
{
    [ServiceLocate(typeof(IAnswerRepository))]
    public class AnswerRepository : IAnswerRepository
    {
        private readonly ICorrectItDbContext _context;

        public AnswerRepository(ICorrectItDbContext context)
        {
            _context = context;
        }

        IEnumerable<AnswerEntity> IRepository<AnswerEntity>.LoadAll()
        {
            return _context.Answers.ToList();
        }
    }
}
