using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DDD.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // Establishing the operations that will be needed
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int id, IEnumerable<string> entitiesToInclude = null);
        Task<IEnumerable<TEntity>> GetAllAsync(int skip, int limit, IEnumerable<Expression<Func<TEntity,bool>>> predicates = null, IEnumerable<string> entitiesToInclude = null);

    }
}
