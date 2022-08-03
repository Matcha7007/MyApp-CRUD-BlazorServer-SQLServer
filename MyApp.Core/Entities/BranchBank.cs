using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class BranchBank : BaseEntity
    {
        [MaxLength(200)]
        public string? BranchName { get; set; }
        public int BankId { get; set; }
        public virtual Bank? Bank { get; set; }
    }
}
