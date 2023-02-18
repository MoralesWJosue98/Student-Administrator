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

        public DateTime Value { get; protected set; }

        internal StudentAdmissionDate(DateTime value)
        {
            this.Value = value;
        }
        public static StudentAdmissionDate Create(DateTime value)
        {
            return new StudentAdmissionDate(value);
        }
    }
}
