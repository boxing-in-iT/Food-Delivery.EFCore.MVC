using Delivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> getProducts { get; }
        IEnumerable<Product> getFavProducts { get; }
        Product getObjectProduct(int productId);
    }
}
