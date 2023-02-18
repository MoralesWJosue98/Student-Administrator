using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.ValueObjects;

namespace TechnicalTest.DDD.Domain.Entities
{
    public class Student
    {
        public StudentName Name { get; private set; }    
        
        public void SetName(StudentName name)
        {
            Name = name;
        }
        public StudentLastName LastName { get; set; }    

        public void SetLastName(StudentLastName lastName)
        {
            LastName = lastName;
        }

        public StudentCareer Career { get; set; }

        public void SetStudentCareer(StudentCareer studentCareer)
        {
            Career = studentCareer;
        }

        public StudentAdmissionDate AdmissionDate { get; set; } 
        public void SetStudentAdmissionDate(StudentAdmissionDate admissionDate)
        {
            AdmissionDate = admissionDate;
        }
    }
}
