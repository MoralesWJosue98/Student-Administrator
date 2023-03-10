using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain;
using TechnicalTest.DDD.Domain.Repositories;
using TechnicalTest.DDD.Infrastructure.Database;

namespace TechnicalTest.DDD.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public IStudentRepository StudentRepository { get; set; }   

        public UnitOfWork(DatabaseContext databaseContext, IStudentRepository studentRepository)
        {
            _databaseContext = databaseContext;

            StudentRepository= studentRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _databaseContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _databaseContext.Dispose();
        }
    }
}
