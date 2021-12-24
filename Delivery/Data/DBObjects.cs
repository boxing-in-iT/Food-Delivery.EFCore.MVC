using Delivery.Data.models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.category.Any())
                content.category.AddRange(Categories.Select(c => c.Value));

            if (!content.product.Any())
            {
                content.AddRange(
                    new Product
                    {
                        name = "Козацька",
                        desc = "тісто,соус,сир,салямі,печериці свіжі,каперси,мисливські ковбаски,зелень,пармезан",
                        img = "/img/kozacka.jpg",
                        size = "30cm",
                        price = 54,
                        isFavorite = true,
                        Category = Categories["Піца"]
                    },
                    new Product
                    {
                        name = "Козацька",
                        desc = "тісто,соус,сир,салямі,печериці свіжі,каперси,мисливські ковбаски,зелень,пармезан",
                        img = "/img/kozacka.jpg",
                        size = "60cm",
                        price = 104,
                        isFavorite = true,
                        Category = Categories["Піца"]
                    },
                    new Product
                    {
                        name = "Фірмова",
                        desc = "тісто,соус,сир,моцарела,печериці свіжі,помідори,прошуто,зелень",
                        img = "/img/firmova.jpg",
                        size = "30cm",
                        price = 97,
                        isFavorite = true,
                        Category = Categories["Піца"]
                    },
                    new Product
                    {
                        name = "Фірмова",
                        desc = "тісто,соус,сир,моцарела,печериці свіжі,помідори,прошуто,зелень",
                        img = "/img/firmova.jpg",
                        size = "60cm",
                        price = 187,
                        isFavorite = true,
                        Category = Categories["Піца"]
                    },
                    new Product
                    {
                        name = "Маргарита",
                        desc = "тісто,соус,сир,помідори,моцарела,зелень,пармезан",
                        img = "/img/margarita.jpg",
                        size = "30cm",
                        price = 63,
                        isFavorite = true,
                        Category = Categories["Піца"]
                    },
                    new Product
                    {
                        name = "Маргарита",
                        desc = "тісто,соус,сир,помідори,моцарела,зелень,пармезан",
                        img = "/img/margarita.jpg",
                        size = "60cm",
                        price = 104,
                        isFavorite = true,
                        Category = Categories["Піца"]
                    },
                    new Product
                    {
                        name = "Каліфорнійський рол “Токіо”",
                        desc = "вугор, огірок, соус унагі, кунжут, ікра корюшки, сир для суші,імбир,васабі",
                        img = "/img/rolTokio.jpg",
                        size = "185г",
                        price = 115,
                        isFavorite = true,
                        Category = Categories["Суші"]
                    },
                    new Product
                    {
                        name = "Макі з лососем”",
                        desc = "",
                        img = "/img/makiLosos.jpg",
                        size = "125г",
                        price = 55,
                        isFavorite = true,
                        Category = Categories["Суші"]
                    },
                    new Product
                    {
                        name = "Філадельфія рол з вугрем",
                        desc = "вугор, сир для суші, авокадо, ікра корюшки,імбир,васабі",
                        img = "/img/filadelphiaVugor.jpg",
                        size = "225",
                        price = 160,
                        isFavorite = true,
                        Category = Categories["Суші"]
                    },
                    new Product
                    {
                        name = "Тірамісу",
                        desc = "Сир маскарпоне, вершки, печиво савоярді з кавою та амарето, какао",
                        img = "/img/tiramisu.jpg",
                        size = "150",
                        price = 60,
                        isFavorite = true,
                        Category = Categories["Десерти"]
                    },
                    new Product
                    {
                        name = "Торт “Три шоколади”",
                        desc = "шоколадний бісквіт, три шари мусу на основі чорного, молочного та білого бельгійського шоколаду, вкриті шоколадним глясажем",
                        img = "/img/threeChocolate.jpg",
                        size = "130",
                        price = 45,
                        isFavorite = true,
                        Category = Categories["Десерти"]
                    },
                    new Product
                    {
                        name = "Фанта апельсин",
                        desc = "0,5л",
                        img = "/img/fantaOrange.jpg",
                        size = "",
                        price = 26,
                        isFavorite = true,
                        Category = Categories["Напої"]
                    },
                    new Product
                    {
                        name = "Фанта лимон",
                        desc = "0,5л",
                        img = "/img/fantaLemon.jpg",
                        size = "",
                        price = 26,
                        isFavorite = true,
                        Category = Categories["Напої"]
                    },
                    new Product
                    {
                        name = "Несті лимон",
                        desc = "0,5л",
                        img = "/img/nesteaLemon.jpg",
                        size = "",
                        price = 24,
                        isFavorite = true,
                        Category = Categories["Напої"]
                    }
                );
                    
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName="Піца", desc="Смачна",},
                        new Category{categoryName="Суші", desc="Орігінальні",},
                        new Category{categoryName="Десерти", desc="Оближеш пальчики",},
                        new Category{categoryName="Напої", desc="Освіжись",}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }//мы проверяем заполнена ли наша переменная категори, если нет то мы ее просто возвращаем, если она пустая мы создаем список и помещаем категории которые нас интересуют
    }
}
