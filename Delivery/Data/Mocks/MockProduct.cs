using Delivery.Data.interfaces;
using Delivery.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data.Mocks
{
    public class MockProduct : IAllProducts
    {
        private readonly IProductsCategory productsCategory = new MockCategory();
        public IEnumerable<Product> getProducts
        {
           
            get
            {
                return new List<Product>
                {
                    new Product{
                        name="Козацька",
                        desc="тісто,соус,сир,салямі,печериці свіжі,каперси,мисливські ковбаски,зелень,пармезан",
                        img="/img/kozacka.jpg",
                        size="30cm",
                        price=54,
                        isFavorite=true,
                        Category=productsCategory.allCategories.First()
                    },
                    new Product{
                        name="Козацька",
                        desc="тісто,соус,сир,салямі,печериці свіжі,каперси,мисливські ковбаски,зелень,пармезан",
                        img="/img/kozacka.jpg",
                        size="60cm",
                        price=104,
                        isFavorite=true,
                        Category=productsCategory.allCategories.First()
                    },
                    new Product{
                        name="Фірмова",
                        desc="тісто,соус,сир,моцарела,печериці свіжі,помідори,прошуто,зелень",
                        img="/img/firmova.jpg",
                        size="30cm",
                        price=97,
                        isFavorite=true,
                        Category=productsCategory.allCategories.First()
                    },
                    new Product{
                        name="Фірмова",
                        desc="тісто,соус,сир,моцарела,печериці свіжі,помідори,прошуто,зелень",
                        img="/img/firmova.jpg",
                        size="60cm",
                        price=187,
                        isFavorite=true,
                        Category=productsCategory.allCategories.First()
                    },
                    new Product{
                        name="Маргарита",
                        desc="тісто,соус,сир,помідори,моцарела,зелень,пармезан",
                        img="/img/margarita.jpg",
                        size="30cm",
                        price=63,
                        isFavorite=true,
                        Category=productsCategory.allCategories.First()
                    },
                    new Product{
                        name="Маргарита",
                        desc="тісто,соус,сир,помідори,моцарела,зелень,пармезан",
                        img="/img/margarita.jpg",
                        size="60cm",
                        price=104,
                        isFavorite=true,
                        Category=productsCategory.allCategories.First()
                    },
                    new Product{
                        name="Каліфорнійський рол “Токіо”",
                        desc="вугор, огірок, соус унагі, кунжут, ікра корюшки, сир для суші,імбир,васабі",
                        img="/img/rolTokio.jpg",
                        size="185г",
                        price=115,
                        isFavorite=true,
                        Category=productsCategory.allCategories.ElementAtOrDefault(2)
                    },
                    new Product{
                        name="Макі з лососем”",
                        desc="",
                        img="/img/makiLosos.jpg",
                        size="125г",
                        price=55,
                        isFavorite=true,
                        Category=productsCategory.allCategories.ElementAtOrDefault(2)
                    },
                    new Product{
                        name="Філадельфія рол з вугрем",
                        desc="вугор, сир для суші, авокадо, ікра корюшки,імбир,васабі",
                        img="/img/filadelphiaVugor.jpg",
                        size="225",
                        price=160,
                        isFavorite=true,
                        Category=productsCategory.allCategories.ElementAtOrDefault(2)
                    },
                    new Product{
                        name="Тірамісу",
                        desc="Сир маскарпоне, вершки, печиво савоярді з кавою та амарето, какао",
                        img="/img/tiramisu.jpg",
                        size="150",
                        price=60,
                        isFavorite=true,
                        Category=productsCategory.allCategories.ElementAtOrDefault(3)
                    },
                    new Product{
                        name="Торт “Три шоколади”",
                        desc="шоколадний бісквіт, три шари мусу на основі чорного, молочного та білого бельгійського шоколаду, вкриті шоколадним глясажем",
                        img="/img/threeChocolate.jpg",
                        size="130",
                        price=45,
                        isFavorite=true,
                        Category=productsCategory.allCategories.ElementAtOrDefault(3)
                    },
                    new Product{
                        name="Фанта апельсин",
                        desc="0,5л",
                        img="/img/fantaOrange.jpg",
                        size="",
                        price=26,
                        isFavorite=true,
                        Category=productsCategory.allCategories.Last()
                    },
                    new Product{
                        name="Фанта лимон",
                        desc="0,5л",
                        img="/img/fantaLemon.jpg",
                        size="",
                        price=26,
                        isFavorite=true,
                        Category=productsCategory.allCategories.Last()
                    },
                    new Product{
                        name="Несті лимон",
                        desc="0,5л",
                        img="/img/nesteaLemon.jpg",
                        size="",
                        price=24,
                        isFavorite=true,
                        Category=productsCategory.allCategories.Last()
                    }
                };
            }
             
        }
        public IEnumerable<Product> getFavProducts { get; set; }

        public Product getObjectProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
