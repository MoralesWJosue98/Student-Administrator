﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.Common;

namespace TechnicalTest.DDD.Domain.Exceptions
{
    public class BaseException : Exception
    {
        public HttpStatusCode StatusCode { get;}

        public BaseException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }   

        public BaseException(HttpStatusCode statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
