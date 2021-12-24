using Delivery.Data.interfaces;
using Delivery.Data.models;
using Delivery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductsCategory _allCategories;

        public ProductsController(IAllProducts iAllProducts, IProductsCategory iProductsCat)
        {
            _allProducts = iAllProducts;
            _allCategories = iProductsCat;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                products = _allProducts.getProducts.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("pizza", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.getProducts.Where(i => i.Category.categoryName.Equals("Піца")).OrderBy(i => i.id);
                    currCategory = "Піца";
                }
                else if (string.Equals("sushi", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.getProducts.Where(i => i.Category.categoryName.Equals("Суші")).OrderBy(i => i.id);
                    currCategory = "Суші";
                }
                else if (string.Equals("deserts", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.getProducts.Where(i => i.Category.categoryName.Equals("Десерти")).OrderBy(i => i.id);
                    currCategory = "Десерти";
                }
                else if (string.Equals("drinks", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.getProducts.Where(i => i.Category.categoryName.Equals("Напої")).OrderBy(i => i.id);
                    currCategory = "Напої";
                }




            }
            var productObject = new ProductsListViewModel
            {
                getAllProducts = products,
                currCategory = currCategory
            };

            ViewBag.Title = "Page with products";

            return View(productObject);
        }
    }
}
