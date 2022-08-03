using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Entities
{
    public class EmployeeBankBranch : BaseEntity
    {
        public int BranchBankId { get; set; }
        public virtual BranchBank? BranchBank { get; set; }   
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
