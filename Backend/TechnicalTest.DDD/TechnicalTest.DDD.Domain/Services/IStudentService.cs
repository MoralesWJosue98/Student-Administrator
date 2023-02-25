using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.Common;
using TechnicalTest.DDD.Domain.DTOs;

namespace TechnicalTest.DDD.Domain.Services
{
    public interface IStudentService
    {
        Task<StudentDto> GetById(int id);
        Task<IEnumerable<StudentDto>> GetAllById(Pagination pagination);
        Task<StudentDto> AddStudent(StudentDto studentDto);
        Task UpdateStudent(StudentDto studentDto);
        Task DeleteStudent(int id);
    }
}
