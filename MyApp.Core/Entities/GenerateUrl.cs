using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class GenerateUrl : BaseEntity
    {
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int ProductTypeId { get; set; }
        public virtual ProductType? ProductType { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public string? Url { get; set; }
    }
}
