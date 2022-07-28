using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class ProductType : BaseEntity
    {
        public string TypeName { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
