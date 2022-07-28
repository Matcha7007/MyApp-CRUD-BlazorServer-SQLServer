using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

using MyApp.Core.Data;
using MyApp.Core.Dtos;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Services
{
    public class RMService : IRMService
    {
        private readonly MyAppDataContext _context;
        private readonly NavigationManager _navigation;

        public RMService(MyAppDataContext context, NavigationManager navigation)
        {
            _context = context;
            _navigation = navigation;
        }

        public IEnumerable<RMServiceDTo> GetAll()
        {
            var data = from v in _context.Banks.AsQueryable()
                       join bb in _context.BranchBanks.AsQueryable() on v.Id equals bb.BankId
                       join eb in _context.EmployeeBankBranches.AsQueryable() on bb.Id equals eb.BranchBankId
                       join e in _context.Employees.AsQueryable() on eb.EmployeeId equals e.Id
                       select new RMServiceDTo()
                       {
                           BankName = v.BankName,
                           BranchName = bb.BranchName,
                           SalesCode = e.SalesCode,
                           SalesName = e.SalesName,
                           NIP = e.NIP,
                           Phone = e.Phone,
                           Email = e.Email
                       };
            return data;
            //var data = _context.Banks.ToList();
            //return data;
        }
    }
}
