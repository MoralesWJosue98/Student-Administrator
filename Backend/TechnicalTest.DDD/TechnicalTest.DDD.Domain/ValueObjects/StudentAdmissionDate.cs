using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DDD.Domain.ValueObjects
{
    public class StudentAdmissionDate
    {
        protected StudentAdmissionDate()
        { }

        // Encapsulation of the setting or creation of the admission date value in the student entity
        public DateTime Value { get; protected set; }

        public static StudentAdmissionDate For(DateTime dateDate)
        {
            var studentDate = new StudentAdmissionDate();
            studentDate.Value = dateDate;
            return studentDate;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
