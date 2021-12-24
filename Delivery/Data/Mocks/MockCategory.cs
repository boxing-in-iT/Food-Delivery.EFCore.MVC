using Delivery.Data.interfaces;
using Delivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.Mocks
{
    public class MockCategory:IProductsCategory
    {
        public IEnumerable<Category> allCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName="Піца", desc="Смачна",},
                    new Category{categoryName="Суші", desc="Орігінальні",},
                    new Category{categoryName="Десерти", desc="Оближеш пальчики",},
                    new Category{categoryName="Напої", desc="Освіжись",}
                };
            }
        }
    }
}
