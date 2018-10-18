using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Store
{
    class SellAndRestock
    {
        static decimal shoppingCardCost;
        public List<Product> Sell(List<Product> list)
        {            
            List<string> shoppingCart = ShoppingCart(list);
            foreach (var brandName in shoppingCart)
            {
                if (brandName != "Out of stock!")
                {                    
                    Console.Write(Startup.languageInterface[38], brandName);
                    //int.TryParse(Console.ReadLine(), out int ammount);
                    int ammount = InputChecker.CheckIfInt();
                    foreach (var item in list)
                    {
                        if (item.Brand == brandName)
                        {
                            while (item.InStock < ammount)
                            {
                                Console.WriteLine(Startup.languageInterface[39], brandName, item.InStock);
                                Console.Write(Startup.languageInterface[40]);
                                //int.TryParse(Console.ReadLine(), out ammount);
                                ammount = InputChecker.CheckIfInt(item.InStock);
                            }
                            item.InStock -= ammount;
                            shoppingCardCost = shoppingCardCost + (item.Price * ammount) + ((item.Price*item.Overcharge) * ammount);
                            Startup.shopCash = Startup.shopCash + (item.Price * ammount) + ((item.Price * item.Overcharge) * ammount);
                            Console.WriteLine(Startup.languageInterface[41], Product.GetListItem(item.Type), brandName, item.InStock);
                            using (StreamWriter sw = new StreamWriter("files/log.txt", true))
                            {
                                sw.WriteLine(Startup.languageInterface[42], DateTime.Now, Product.GetListItem(item.Type), brandName, ammount, (item.Price * ammount) + ((item.Price * item.Overcharge) * ammount));
                            }
                            Console.WriteLine(Startup.languageInterface[62], shoppingCardCost);                            
                        }
                    }
                    Console.WriteLine(Startup.languageInterface[43]);
                }
                else
                {
                    Console.WriteLine(Startup.languageInterface[44]);
                }
            }
            return list;
        }

        internal static string FindItem(List<Product> list)
        {
            string itemBrand;
            List<int> types = new List<int>();
            List<string> brands = new List<string>();
            int i = 0;
            foreach (var item in list)
            {
                if (!types.Contains(item.Type))
                {
                    types.Add(item.Type);
                }
            }
            Console.WriteLine(Startup.languageInterface[45]);
            foreach (var type in types)
            {
                Console.WriteLine("{0} - {1}", type, Product.GetListItem(type));
            }
            Console.Write(Startup.languageInterface[46]);
            int input = InputChecker.CheckIfInt();
            foreach (var item in list)
            {
                if (item.Type == input)
                {
                    if (item.InStock != 0)
                    {
                        brands.Add(item.Brand);
                    }
                }
            }
            if (brands.Count > 0)
            {
                foreach (var brand in brands)
                {
                    Console.WriteLine("{0}:{1}", i, brand);
                    i++;
                }
                Console.Write(Startup.languageInterface[47]);
                input = InputChecker.CheckIfInt(brands.Count -1);
                while (input >= brands.Count || input < 0 )
                {
                    Console.WriteLine(Startup.languageInterface[48]);
                    int.TryParse(Console.ReadLine(), out input);
                }
                itemBrand = brands[input];
            }
            else
            {
                itemBrand = "Out of stock!";
            }
            return itemBrand;
        }

        internal static int FindItemIndex(List<Product> list)
        {
            string itemToFind = FindItem(list);
            //int index = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (itemToFind == list[i].Brand)
            //    {
            //        index = i;
            //    }
            //}
            
            int index = list.FindIndex(a => a.Brand == itemToFind);
            return index;
        }

        private List<string> ShoppingCart(List<Product> list)
        {
            string itemBrand = string.Empty;
            ConsoleKey answer = ConsoleKey.Enter;
            List < string > shoppingCart = new List<string>();
            answer = ConsoleKey.Enter;
            while (answer != ConsoleKey.Escape)
            {
                itemBrand = FindItem(list);
                if (itemBrand != null && itemBrand != "Out of stock!")
                {
                    shoppingCart.Add(itemBrand);
                    Console.WriteLine(Startup.languageInterface[49]);
                    Console.WriteLine(Startup.languageInterface[0]);                    
                    answer = InputChecker.CheckIfEnter();
                }
                else
                {
                    Console.WriteLine(Startup.languageInterface[50]);
                }
            }
            return shoppingCart;
        }

        public List<Product> Restock(List<Product> list)
        {
            Console.WriteLine(Startup.languageInterface[51]);
            Console.WriteLine(Startup.languageInterface[52]);
            Console.WriteLine(Startup.languageInterface[78]);
            //int.TryParse(Console.ReadLine(), out int input);
            int input = InputChecker.CheckIfInt(3);
            switch (input)
            {
                case 1:
                    foreach (var product in list)
                    {
                        Console.Clear();
                        Console.WriteLine(Startup.languageInterface[53]);
                        Console.WriteLine(Startup.languageInterface[54], Product.GetListItem(product.Type), product.Brand, product.InStock, product.MaxStock);
                        Console.WriteLine(Startup.languageInterface[55]);
                        ConsoleKey answer = Console.ReadKey(true).Key;
                        if (answer == ConsoleKey.Enter)
                        {
                            Console.WriteLine(Startup.languageInterface[56]);
                            int order = InputChecker.CheckIfInt();
                            while (order + product.InStock > product.MaxStock || order < 0 || order * product.Price > Startup.shopCash)
                            {
                                if (order + product.InStock > product.MaxStock)
                                {
                                    Console.WriteLine(Startup.languageInterface[57], product.MaxStock);
                                }
                                else if (order<0)
                                {
                                    Console.WriteLine(Startup.languageInterface[58]);
                                }
                                else if (order * product.Price > Startup.shopCash)
                                {
                                    Console.WriteLine(Startup.languageInterface[59]);
                                }
                                Console.Write( Startup.languageInterface[60]);
                                order = InputChecker.CheckIfInt();
                            }
                            Startup.shopCash = Startup.shopCash - order * product.Price;
                            product.InStock = order + product.InStock;
                        }
                    }
                    break;
                case 2:
                    foreach (var product in list)
                    {
                        int ammount = product.MaxStock - product.InStock;
                        if (Startup.shopCash > ammount * product.Price)
                        {
                            Startup.shopCash = Startup.shopCash - ammount * product.Price;
                            product.InStock = product.MaxStock;
                        }
                        else
                        {
                            Console.WriteLine(Startup.languageInterface[59]);
                        }    
                    }
                    break;
                default: 
                    
                    break;
            }
            Console.Clear();
            Console.WriteLine(Startup.languageInterface[61]);
            return list;
        }

        public void DisplayProducts(List<Product> list)
        {
            Console.WriteLine(Startup.languageInterface[64]);
            Console.WriteLine(Startup.languageInterface[65]);
            int input = InputChecker.CheckIfInt();
            while (input>2 || input<0)
            {
                input = InputChecker.CheckIfInt();
            }            
            switch (input)
            {
                case 1:
                    int index = FindItemIndex(list);                    
                    Console.WriteLine(Startup.languageInterface[66], Product.foodType[list[index].Type], list[index].Brand);
                    Console.WriteLine(Startup.languageInterface[67], list[index].InStock, list[index].MaxStock);
                    Console.WriteLine(Startup.languageInterface[68], list[index].Price, list[index].Overcharge);
                    Console.WriteLine();
                    break;
                case 2:
                    foreach (var item in list)
                    {
                        Console.WriteLine(Startup.languageInterface[66] , Product.foodType[item.Type], item.Brand);
                        Console.WriteLine(Startup.languageInterface[67] , item.InStock, item.MaxStock);
                        Console.WriteLine(Startup.languageInterface[68] , item.Price, item.Overcharge);
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine(Startup.languageInterface[50]);
                    break;
            }
            InputChecker.CheckIfEnter();
            Console.WriteLine();
            Console.WriteLine(Startup.languageInterface[0]);
            Console.Clear();
        }
    }
}
