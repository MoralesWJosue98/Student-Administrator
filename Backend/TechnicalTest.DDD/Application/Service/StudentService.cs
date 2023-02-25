using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain;
using TechnicalTest.DDD.Domain.Common;
using TechnicalTest.DDD.Domain.DTOs;
using TechnicalTest.DDD.Domain.Entities;
using TechnicalTest.DDD.Domain.Exceptions;
using TechnicalTest.DDD.Domain.Services;

namespace TechnicalTest.DDD.Application.Service
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _autoMapper;

        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _autoMapper = mapper;
        }

        public async Task<StudentDto> AddStudent(StudentDto studentDto)
        {
            var student = _autoMapper.Map<Student>(studentDto);
            await _unitOfWork.StudentRepository.AddAsync(student);
            await _unitOfWork.CompleteAsync();

            return _autoMapper.Map<StudentDto>(student);

        }

        public async Task DeleteStudent(int id)
        {
            var studentExist = await _unitOfWork.StudentRepository.ExistAsync(x => x.Id == id);
            if (!studentExist)
                throw new NotFoundException("The Student Doesn't Exist");

            var student = await _unitOfWork.StudentRepository.GetByIdAsync(id);
            await _unitOfWork.StudentRepository.DeleteAsync(student);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<StudentDto>> GetAllById(Pagination pagination)
        {
            var students = await _unitOfWork.StudentRepository.GetAllAsync(pagination.skip, pagination.limit, entitiesToInclude: new List<string> { "Student" });
            var studentsDTO = _autoMapper.Map<IEnumerable<StudentDto>>(students);

            return studentsDTO;
        }


        public async Task<StudentDto> GetById(int id)
        {
            var studentExist = await _unitOfWork.StudentRepository.ExistAsync(x => x.Id == id);
            if (!studentExist)
                throw new NotFoundException("The Student Doesn't Exist");

            var student = await _unitOfWork.StudentRepository.GetByIdAsync(id);
            var studentDTO = _autoMapper.Map<StudentDto>(student);

            return studentDTO;
        }

        public async Task UpdateStudent(StudentDto studentDto)
        {
            var studentExist = await _unitOfWork.StudentRepository.ExistAsync(x => x.Id == id);
            if (!studentExist)
                throw new NotFoundException("The Student Doesn't Exist");

            var student = _autoMapper.Map<Student>(studentDto);
            await _unitOfWork.StudentRepository.UpdateAsync(student);
            await _unitOfWork.CompleteAsync();

        }
    }
}
