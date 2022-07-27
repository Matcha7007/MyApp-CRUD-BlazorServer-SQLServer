using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        [MaxLength(100)]
        public string? CreatedBy { get; set; }
        [MaxLength(100)]
        public string? ModifiedBy { get; set; }
    }
}
