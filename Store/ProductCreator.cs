using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class ProductCreator
    {
        public List<Product> Products()
        {
            List<Product> products = new List<Product>();
            Product ZavodskiHlqb = new Product
            {
                Brand = "Zavodski",
                Price = 5m,
                InStock = 20,
                Type = 0,
                MaxStock = 25
            };
            Product Voda500Ml = new Product
            {
                Brand = "Hisar 500 ml",
                Price = 0.6m,
                InStock = 25,
                Type = 3,
                MaxStock = 50
            };
            Product Voda1l = new Product
            {
                Brand = "Hisar 1 Liter",
                Price = 1m,
                InStock = 25,
                Type = 3,
                MaxStock = 50
            };
            products.Add(ZavodskiHlqb);
            products.Add(Voda500Ml);
            products.Add(Voda1l);
            return products;

        }

    }
}
