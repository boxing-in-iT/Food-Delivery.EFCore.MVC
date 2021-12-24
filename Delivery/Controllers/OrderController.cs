using Delivery.Data.interfaces;
using Delivery.Data.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly DeliveryCart deliveryCart;

        public OrderController(IAllOrders allOrders, DeliveryCart deliveryCart)
        {
            this.allOrders = allOrders;
            this.deliveryCart = deliveryCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            deliveryCart.listDeliveryItems = deliveryCart.getDeliverItems();

            if (deliveryCart.listDeliveryItems.Count == 0)
            {
                ModelState.AddModelError("", "Ви не вибрали жодного товару");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Замовлення успішно оброблено";
            return View();
        }
    }
}
