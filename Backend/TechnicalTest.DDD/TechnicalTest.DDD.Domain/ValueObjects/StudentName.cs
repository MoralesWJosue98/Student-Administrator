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

        internal StudentName(string value)
        {
            this.Value = value;
        }
        public static StudentName Create(string value)
        {
            return new StudentName(value);
        }

    }
}
