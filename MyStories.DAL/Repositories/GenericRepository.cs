using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using MyStories.DAL.Interfaces;
using System.Threading.Tasks;

namespace MyStories.DAL.Repository
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity : class
    {
        AppContext _context;
        DbSet<TEntity> _dbSet;

        public GenericRepository(AppContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task CreateAsync (TEntity item)
        {
            _dbSet.Add(item);
            await _context.SaveChangesAsync();
        }
        public async Task<TEntity> GetAsync (int itemId)
        {
            return await _dbSet.FindAsync(itemId);
        }
        public IQueryable<TEntity> GetAsync ()
        {
            return _dbSet;
        }
        public async Task DeleteAsync (TEntity item)
        {
            _dbSet.Remove(item);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync (TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
    }
}