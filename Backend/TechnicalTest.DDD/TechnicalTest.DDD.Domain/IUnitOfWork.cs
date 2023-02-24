using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.Repositories;

namespace TechnicalTest.DDD.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentRepository { get; set; }

        Task<int> CompleteAsync();

    }
}
