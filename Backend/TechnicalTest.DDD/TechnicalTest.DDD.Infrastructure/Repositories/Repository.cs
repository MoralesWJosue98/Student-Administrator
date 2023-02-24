using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.Entities;
using TechnicalTest.DDD.Domain.Repositories;
using TechnicalTest.DDD.Infrastructure.Helpers;

namespace TechnicalTest.DDD.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbSet<TEntity> _entities;

        public Repository(DbSet<TEntity> entities)
        {
            _entities = entities;
        }

        public async Task AddAsync(TEntity entity)
        { 
            await _entities.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { Delete(entity); });
        }

        public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.AnyAsync(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(int skip, int limit, IEnumerable<Expression<Func<TEntity, bool>>> predicates, IEnumerable<string> entitiesToInclude)
        {
           return await _entities.Filter(predicates)
                .Skip(skip)
                .Take(limit).Include(entitiesToInclude).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id, IEnumerable<string> entitiesToInclude)
        {
            return await _entities.Include(entitiesToInclude).FirstOrDefaultAsync(baseEntity => baseEntity.Id == id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _entities.Update(entity); });
        }
    }
}
