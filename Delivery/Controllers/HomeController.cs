using Delivery.Data.interfaces;
using Delivery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _productRep;

        public HomeController(IAllProducts productRepository)
        {
            _productRep = productRepository;
        }

        public ViewResult Index()
        {
            var homeproducts = new HomeViewModel
            {
                favProducts = _productRep.getFavProducts
            };

            return View(homeproducts);
        }
    }
}
