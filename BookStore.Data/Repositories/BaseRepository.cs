using BookApp.Data.Interfaces;
using BookApp.Domain.Models;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApp.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly BookAppContext _context;
        protected readonly DbSet<TEntity> _currentSet;


        public BaseRepository(BookAppContext context)
        {
            _context = context;
            _currentSet = _context.Set<TEntity>();
        }

        public virtual void DeleteAll(IEnumerable<TEntity> entities)
        {
            _currentSet.RemoveRange(entities);
        }

        public virtual void Delete(TEntity entity)
        {
            _currentSet.Remove(entity);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _currentSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _currentSet.FindAsync(id);
        }

        public virtual async Task<TEntity> GetByIdWithoutIncludeAsync(int id)
        {
            return await _currentSet.FindAsync(id);
        }

        public virtual async Task InsertAllAsync(IEnumerable<TEntity> entities)
        {
            await _currentSet.AddRangeAsync(entities);
        }

        public virtual async Task InsertAsync(TEntity entity)
        {
            await _currentSet.AddAsync(entity);
        }

        public virtual void UpdateAll(IEnumerable<TEntity> entities)
        {
            _currentSet.UpdateRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            _currentSet.Update(entity);
        }

        public virtual async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
