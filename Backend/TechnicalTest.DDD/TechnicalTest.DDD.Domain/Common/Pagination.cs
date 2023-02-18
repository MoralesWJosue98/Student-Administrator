using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DDD.Domain.Common
{
    public class Pagination
    {
        public int skip { get; set; } = 0;
        public int limit { get; set; } = 10;
    }
}
