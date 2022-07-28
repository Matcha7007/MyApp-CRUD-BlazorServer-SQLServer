using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class Employee : BaseEntity
    {
        [MaxLength(10)]
        public string NIP { get; set; }
        [MaxLength(13)]
        public string? Phone { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string SalesCode { get; set; }
        [MaxLength(100)]
        public string SalesName { get; set; }
    }
}
