using Common.Core.Data.Sql;
using Common.Core.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.Sql.Images
{
    [ServiceLocate(typeof(IImageRepository))]
    public class ImageRepository : IImageRepository
    {
        private readonly ICorrectItDbContext _context;

        public ImageRepository(ICorrectItDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.Commit();
        }

        public void Create(ImageEntity entity)
        {
            _context.Images.Add(entity);
        }

        public void Persist(ImageEntity entity)
        {
            var image = _context.Images.Find(entity.ImageId);
            if (image != null)
            {
                Update(entity);
            }
            else
            {
                Create(entity);
            }
            Commit();
        }

        public void Update(ImageEntity entity)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<ImageEntity> IRepository<ImageEntity>.LoadAll()
        {
            return _context.Images.ToList();
        }
    }
}
