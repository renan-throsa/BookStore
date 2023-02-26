using BookApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApp.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task<TEntity> GetByIdWithoutIncludeAsync(int id);

        Task InsertAllAsync(IEnumerable<TEntity> entities);

        Task InsertAsync(TEntity entity);

        Task SaveChangesAsync();

        void Update(TEntity entity);

        void UpdateAll(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        void DeleteAll(IEnumerable<TEntity> entities);



    }
}
