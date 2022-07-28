using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class GenerateUrl : BaseEntity
    {
        public int CustomerProductTypeId { get; set; }
        public virtual CustomerProductType CustomerProductType { get; set; }
        public string Url { get; set; }
    }
}
