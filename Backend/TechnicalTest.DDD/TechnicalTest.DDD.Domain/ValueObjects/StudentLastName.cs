﻿using System;
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

        public string Value { get; protected set; }

        internal StudentLastName(string value)
        {
            this.Value = value;
        }
        public static StudentLastName Create(string value)
        {
            return new StudentLastName(value);
        }

    }
}
