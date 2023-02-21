using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DDD.Domain.ValueObjects
{
    public class StudentLastName
    {
        protected StudentLastName()
        { }

        // Encapsulation of the setting or creation of the last name value in the student entity
        public string Value { get; protected set; }

        public static StudentLastName For(string lastNameString)
        {
            var studentLastName = new StudentLastName();
            studentLastName.Value = lastNameString;
            return studentLastName;
        }
        public override string ToString()
        {
            return Value;
        }

    }
}
