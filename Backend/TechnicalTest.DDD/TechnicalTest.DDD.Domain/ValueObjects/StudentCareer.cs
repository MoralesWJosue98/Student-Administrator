using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DDD.Domain.ValueObjects
{
    public class StudentCareer
    {
        protected StudentCareer()
        { }

        // Encapsulation of the setting or creation of the career value in the student entity
        public string Value { get; protected set; }

        public static StudentCareer For(string careerString)
        {
            var studentCareer = new StudentCareer();
            studentCareer.Value = careerString;
            return studentCareer;
        }
        public override string ToString()
        {
            return Value;
        }

    }
}
