using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.DTOs;
using TechnicalTest.DDD.Domain.Entities;

namespace TechnicalTest.DDD.Infrastructure.Mappers
{
    public class MappingStudent : Profile
    {
        public MappingStudent()
        {
            CreateMap<StudentDto, Student>().ReverseMap();
        }
    }
}
