using Delivery.Data.interfaces;
using Delivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly DeliveryCart deliveryCart;

        public OrdersRepository(AppDBContent appDBContent, DeliveryCart deliveryCart)
        {
            this.appDBContent = appDBContent;
            this.deliveryCart = deliveryCart;
        }

        public void createOrder(Order order)
        {
            order.ordertime = DateTime.Now;
            appDBContent.Order.Add(order);

            appDBContent.SaveChanges();

            var items = deliveryCart.listDeliveryItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    productId = el.product.id,
                    orderId = order.id,
                    price = el.product.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
