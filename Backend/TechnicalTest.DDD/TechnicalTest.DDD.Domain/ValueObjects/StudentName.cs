using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DDD.Domain.ValueObjects
{
    
    public class StudentName
    {
        protected StudentName()
        {}

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
