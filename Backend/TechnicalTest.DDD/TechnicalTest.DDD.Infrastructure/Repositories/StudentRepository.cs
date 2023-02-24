using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.Entities;
using TechnicalTest.DDD.Domain.Repositories;

namespace TechnicalTest.DDD.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbSet<Student> set) : base(set) { }

    }
}
