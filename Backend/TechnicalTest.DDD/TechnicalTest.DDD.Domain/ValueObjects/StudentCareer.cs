﻿using System;
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

        public string Value { get; protected set; }

        internal StudentCareer(string value)
        {
            this.Value = value;
        }
        public static StudentCareer Create(string value)
        {
            return new StudentCareer(value);
        }

    }
}