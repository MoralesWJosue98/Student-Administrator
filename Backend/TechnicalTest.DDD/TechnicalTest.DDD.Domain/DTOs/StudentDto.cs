using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DDD.Domain.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string LastName { get; set; }
        public string Career { get; set; }
        public string AdmissionDate { get; set; }   


    }
}
