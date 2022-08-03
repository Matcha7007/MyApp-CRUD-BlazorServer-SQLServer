using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class Customer : BaseEntity
    {
        [MaxLength(200)]
        public string? CustomerName { get; set; }
        [MaxLength(100)]
        public string? CustomerEmail { get; set; }
        [MaxLength(13)]
        public string? CustomerPhone { get; set; }
    }
}
