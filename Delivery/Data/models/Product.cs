using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.models
{
    public class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public string desc { set; get; }
        public string img { set; get; }
        public string size { set; get; }
        public ushort price { set; get; }
        public bool isFavorite { set; get; }
        public int categoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}
