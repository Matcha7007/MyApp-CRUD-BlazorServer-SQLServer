using Microsoft.AspNetCore.Components;

using MyApp.Core.Data;
using MyApp.Core.Dtos;
using MyApp.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Services
{
    public class URLRepoService : IURLRepoService
    {
        private readonly MyAppDataContext _context;
        private readonly NavigationManager _navigation;

        public URLRepoService(MyAppDataContext context, NavigationManager navigation)
        {
            _context = context;
            _navigation = navigation;
        }

        public IEnumerable<URLRepoServiceDto> GetAll()
        {
            var data = from c in _context.Customers.AsQueryable()
                       join cp in _context.CustomerProductTypes.AsQueryable() on c.Id equals cp.CustomerId
                       join pt in _context.ProductTypes.AsQueryable() on cp.ProductTypeId equals pt.Id
                       join e in _context.Employees.AsQueryable() on cp.EmployeeId equals e.Id
                       join gu in _context.GenerateUrls.AsQueryable() on c.Id equals gu.CustomerId
                       join p in _context.Products.AsQueryable() on gu.ProductId equals p.Id
                       select new URLRepoServiceDto()
                       {
                           SalesCode = e.SalesCode,
                           SalesName = e.SalesName,
                           NIP = e.NIP,
                           ProductName = p.ProductName,
                           ProductType = pt.TypeName,
                           CustomerName = c.CustomerName,
                           CreatedAt = gu.CreatedOn.ToString(),
                           Url = gu.Url
                       };
            return data;
        }
    }
}

//select e.SalesCode, e.SalesName, e.NIP, p.ProductName, pt.TypeName, c.CustomerName, gu.CreatedOn, gu.Url from Customers c
//inner join CustomerProductTypes cp on c.Id = cp.CustomerId
//inner join ProductTypes pt on cp.ProductTypeId = pt.Id
//inner join Employees e on cp.EmployeeId = e.Id
//inner join GenerateUrls gu on gu.CustomerId = c.Id
//inner join Products p on gu.ProductId = p.Id