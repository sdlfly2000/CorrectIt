using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Core.Data.Sql
{
    public interface IRepository<TEntity>
        where TEntity: class
    {
        IEnumerable<TEntity> LoadAll();
    }
}
