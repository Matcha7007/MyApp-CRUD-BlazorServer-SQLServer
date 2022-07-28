using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class Product : BaseEntity
    {
        [MaxLength(200)]
        public string? ProductName { get; set; }
        public List<ProductType> ProductType { get; set; }
    }
}
