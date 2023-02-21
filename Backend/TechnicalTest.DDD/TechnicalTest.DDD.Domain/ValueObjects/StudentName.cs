using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechnicalTest.DDD.Domain.ValueObjects
{
    
    public class StudentName 
    {
        protected StudentName()
        {}

        // Encapsulation of the setting or creation of the name value in the student entity
        public string Value { get; protected set; }    

        public static StudentName For(string nameString)
        {
            var studentName = new StudentName();
            studentName.Value = nameString;
            return studentName;
        }
        public override string ToString()
        {
            return Value;
        }

    }
}
