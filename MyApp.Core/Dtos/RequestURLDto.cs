using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Dtos
{
    public class RequestURLDto
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public int CustomerId { get; set; }
    }
}
