using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.Entities;
using TechnicalTest.DDD.Domain.Repositories;

namespace TechnicalTest.DDD.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbSet<TEntity> _entities;

        public Repository(DbSet<TEntity> entities>)
        {
            _entities = entities;
        }

        Task IRepository<TEntity>.AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task IRepository<TEntity>.DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<TEntity>> IRepository<TEntity>.GetAllAsync(int skip, int limit, IEnumerable<Expression<Func<TEntity, bool>>> predicates, IEnumerable<string> entitiesToInclude)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IRepository<TEntity>.GetByIdAsync(int id, IEnumerable<string> entitiesToInclude)
        {
            throw new NotImplementedException();
        }

        Task IRepository<TEntity>.UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
