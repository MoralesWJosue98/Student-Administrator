using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTest.DDD.Domain.Common;

namespace TechnicalTest.DDD.Domain.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException() : base(HttpStatusCode.NotFound) { }

        public NotFoundException(string message) : base(HttpStatusCode.NotFound, message)
        {
        }

    }
}
