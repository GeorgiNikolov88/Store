using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Store
{
    class ExportAndInport
    {
        //Метод за записване на всички елементи от списъка с обекти и наличните пари в текстови файл
        public static void ExportStoreDataToFiles(List<Product> productList)
        {            
            using (StreamWriter writer = new StreamWriter("files/Products.txt"))
            { 
                foreach (var product in productList)
                {
                    writer.WriteLine("{0},{1},{2},{3},{4},{5}",Regex.Replace(product.Brand, @"\s+", "_"), product.Price, product.InStock, product.Type, product.MaxStock,product.Overcharge);
                }
                
            }
            using (StreamWriter writer = new StreamWriter("files/ShopCash.txt"))
            {
                writer.WriteLine(Startup.shopCash);
            }
            using (StreamWriter writer = new StreamWriter("files/ProductTypes.txt"))
            {
                foreach (var foodType in Product.foodType)
                {
                    writer.WriteLine(foodType);
                }
            }
        }

        //Внасяне на инвентара на магазина и наличните пари от текстови файл
        public List<Product> ImportStoreDataFromFiles()
        {            
            List<Product> productList = new List<Product>();
            string line;
            using (StreamReader reader = new StreamReader("files/Products.txt"))
            {
                while ((line = reader.ReadLine())!= null)
                {
                    string[] words = line.Split(",");                    
                    if (words[0] != "")
                    {
                        productList.Add(new Product(words[0], Convert.ToDecimal(words[1]), Convert.ToInt32(words[2]), Convert.ToInt32(words[3]), Convert.ToInt32(words[4]), Convert.ToDecimal(words[5])));
                    }                    
                }
            }
            using (StreamReader reader = new StreamReader("files/ShopCash.txt"))
            {
                Startup.shopCash = Convert.ToDecimal(reader.ReadLine());
            }
            using (StreamReader reader = new StreamReader("files/ProductTypes.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        Product.foodType.Add(line);
                    }
                }
            }
                return productList;
        }
    }
}
