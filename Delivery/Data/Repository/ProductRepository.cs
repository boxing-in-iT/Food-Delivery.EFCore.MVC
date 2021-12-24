     using Delivery.Data.interfaces;
using Delivery.Data.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent appDBContent;

        public ProductRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Product> getProducts => appDBContent.product.Include(c => c.Category);

        public IEnumerable<Product> getFavProducts => appDBContent.product.Where(p => p.isFavorite).Include(c => c.Category);

        public Product getObjectProduct(int productId) => appDBContent.product.FirstOrDefault(p => p.id == productId);

    }
}
