using Delivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> getAllProducts { get; set; }
        public string currCategory { get; set; }
    }
}
