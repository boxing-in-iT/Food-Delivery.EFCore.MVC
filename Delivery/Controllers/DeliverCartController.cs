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
    public class DeliverCartController : Controller
    {
        private readonly IAllProducts _productRep;
        private readonly DeliveryCart _deliveryCart;

        public DeliverCartController(IAllProducts productRepository, DeliveryCart deliveryCart)
        {
            _productRep = productRepository;
            _deliveryCart = deliveryCart;
        }

        public ViewResult Index()
        {
            var items = _deliveryCart.getDeliverItems();
            _deliveryCart.listDeliveryItems = items;

            var obj = new DeliveryCartViewModel
            {
                deliveryCart = _deliveryCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _productRep.getProducts.FirstOrDefault(i => i.id == id);

            if (item != null)
            {
                _deliveryCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
