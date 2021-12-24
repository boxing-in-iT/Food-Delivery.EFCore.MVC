using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.models
{
    public class DeliveryCart
    {
        private readonly AppDBContent appDBContent;

        public DeliveryCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string DeliverCartId { get; set; }
        public List<DeliveryCartItem> listDeliveryItems { get; set; }

        public static DeliveryCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string deliveryCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", deliveryCartId);

            return new DeliveryCart(context) { DeliverCartId = deliveryCartId };
        }

        public void AddToCart(Product product)
        {
            appDBContent.deliveryCartItem.Add(new DeliveryCartItem
            {
                CartId = DeliverCartId,
                product = product,
                price = product.price
            });
            appDBContent.SaveChanges();
        }

        public List<DeliveryCartItem> getDeliverItems()
        {
            return appDBContent.deliveryCartItem.Where(c => c.CartId == DeliverCartId).Include(s => s.product).ToList();
        }

    }
}
