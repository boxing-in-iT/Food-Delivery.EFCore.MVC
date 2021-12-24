using Delivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> favProducts { get; set; }
    }
}
