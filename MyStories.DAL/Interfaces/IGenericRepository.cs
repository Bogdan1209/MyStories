using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStories.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        Task CreateAsync (TEntity item);
        Task<TEntity> GetAsync (int itemId);
        IQueryable<TEntity> GetAsync ();
        Task DeleteAsync (TEntity item);
        Task UpdateAsync (TEntity item);
    }
}