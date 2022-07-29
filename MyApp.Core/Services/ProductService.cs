using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

using MyApp.Core.Data;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly MyAppDataContext _context;
        private readonly NavigationManager _navigation;

        public ProductService(MyAppDataContext context, NavigationManager navigation)
        {
            _context = context;
            _navigation = navigation;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public async Task LoadProduct()
        {
            Products = await _context.Products.ToListAsync();
        }
        public List<ProductType> ProductTypes { get; set; } = new List<ProductType>();
        public async Task LoadProductTypes()
        {
            ProductTypes = await _context.ProductTypes.ToListAsync();
        }
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public async Task LoadCustomers()
        {
            Customers = await _context.Customers.ToListAsync();
        }
    }
}
