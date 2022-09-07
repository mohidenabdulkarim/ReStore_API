
using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Iphone xs new",
                    Description="Published on November 26, 2017 Apple, iPhone 7",
                     Type="Mobile",
                      Brand="Apple inc.",
                    PictureUrl="https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1480&q=80",
                    Price=999,
                    QuantityInStock=12
                },
                new Product
                {
                    Name = "Dell XPS 15",
                    Description="Published on July 2, 2020",
                    Type="Laptop",
                    Brand="Dell inc.",
                    PictureUrl="https://images.unsplash.com/photo-1593642632823-8f785ba67e45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2664&q=80",
                    Price=1200,
                    QuantityInStock=9
                },
                new Product
                {
                    Name = "Hoval AC",
                    Description="Published on May 29, 2020 SONY, ILCE-7M3",
                    Type="Air Conditioner",
                    Brand="Hoval inc.",
                    PictureUrl="https://images.unsplash.com/photo-1590756254933-2873d72a83b6?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2340&q=80",
                    Price=1200,
                    QuantityInStock=9
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}