using MyApp.Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task LoadProduct();
        List<ProductType> ProductTypes { get; set; }
        Task LoadProductTypes();
        List<Customer> Customers { get; set; }
        Task LoadCustomers();
    }
}
