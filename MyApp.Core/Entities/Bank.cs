using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class Bank : BaseEntity
    {
        [MaxLength(200)]
        public string? BankName { get; set; }
        public virtual List<BranchBank> BankBranch { get; set; }
    }
}
