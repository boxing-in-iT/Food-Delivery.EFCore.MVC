using Delivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> allCategories { get; }
    }
}
