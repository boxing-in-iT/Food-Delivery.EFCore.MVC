using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.models
{
    public class DeliveryCartItem
    {
        public int id { get; set; }
        public Product product { get; set; }
        public int price { get; set; }
        public string CartId { get; set; }
    }
}
