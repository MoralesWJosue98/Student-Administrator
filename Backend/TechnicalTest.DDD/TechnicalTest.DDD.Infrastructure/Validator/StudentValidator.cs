using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.DTOs;

namespace TechnicalTest.DDD.Infrastructure.Validator
{
    public class StudentValidator : AbstractValidator<StudentDto>
    {
        public StudentValidator() {
            RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("Specify Student ID");
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Specify Student Name");
            RuleFor(x => x.LastName).NotEmpty().NotNull().WithMessage("Specify Student Last Name");
            RuleFor(x => x.Career).NotEmpty().WithMessage("Specify Student Career");
            RuleFor(x => x.AdmissionDate).NotEmpty().WithMessage("Specify Student Admission Date");
        }
    }
}
