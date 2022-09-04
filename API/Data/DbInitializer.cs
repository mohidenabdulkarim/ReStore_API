
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
                    Name = "Phone",
                    Description="This is smart phone",
                    Type="Mobile",
                    Brand="Apple inc.",
                    PictureUrl="images/phone.jpg",
                    Price=999,
                    QuantityInStock=12
                },
                new Product
                {
                    Name = "Laptop",
                    Description="This is Apple Laptop",
                    Type="Laptop",
                    Brand="Apple inc.",
                    PictureUrl="images/laptop.jpg",
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