using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class CRUDProduct
    {
        Product product = new Product();
        //bool correct;
        //Метод за създаване на нов обект
        //static List<string> languageInterface = Startup.languageInterface;
        public Product CreateNewProduct(List<Product> list, List<string> langageInterface)
        {
            Console.Write(langageInterface[12]);
            string brand = CheckIfItemExists(Console.ReadLine(), list);
            if (brand == string.Empty)
            {
                return product;
            }
            Console.Write(langageInterface[13]);
            decimal price =InputChecker.CheckIfDecimal();
            Console.Write(langageInterface[14]);
            int inStock = InputChecker.CheckIfInt();
            Console.WriteLine(langageInterface[15]);
            int type = InputChecker.CheckTypeInput(0);
            Console.Write(langageInterface[16]);            
            int maxStock = InputChecker.CheckIfInt();
            Console.Write(langageInterface[17]);
            decimal overcharge = InputChecker.CheckIfDecimal();
            product = new Product(brand, price, inStock, type, maxStock, overcharge);            
            return product;
        }

        //Метод за редактиране на даден обект от списъка с продукти в магазина
        public Product EditProduct(List<Product> list)
        {
            string itemToEdit = SellAndRestock.FindItem(list);
            while (itemToEdit == "Out of stock!")
            {
                Console.WriteLine(Startup.languageInterface[36]);
                itemToEdit = SellAndRestock.FindItem(list);                
            }
            Console.WriteLine(Startup.languageInterface[26], itemToEdit);
            ConsoleKey check = InputChecker.CheckIfEnter();
            if (check == ConsoleKey.Enter)
            {
                foreach (var item in list)
                {
                    if (item.Brand == itemToEdit)
                    {
                        Console.WriteLine(Startup.languageInterface[12]);
                        item.Brand = EditItemProperty(item.Brand);                          
                        Console.WriteLine(Startup.languageInterface[29]);
                        item.Price = EditItemProperty(item.Price);
                        Console.WriteLine(Startup.languageInterface[30]);
                        item.InStock = EditItemProperty(item.InStock);
                        Console.WriteLine(Startup.languageInterface[31]);                        
                        item.Type = InputChecker.CheckTypeInput(item.Type); 
                        Console.WriteLine(Startup.languageInterface[32]);
                        item.MaxStock = EditItemProperty(item.MaxStock);
                        Console.WriteLine(Startup.languageInterface[33]);
                        item.Overcharge = EditItemProperty(item.Overcharge);
                    }
                }
            }
            else
            {
                Console.WriteLine(Startup.languageInterface[34]);
            }
            return product;
        }

        //Метод за изтриване на обект от списъка с продукти
        public List<Product> DeleteItem(List<Product> list)
        {
            Console.WriteLine(Startup.languageInterface[22]);
            ConsoleKey check = InputChecker.CheckIfEnter();
            if (check == ConsoleKey.Enter)
            {                
                int index = SellAndRestock.FindItemIndex(list);
                Console.WriteLine(Startup.languageInterface[23], list[index].Brand);
                check = InputChecker.CheckIfEnter();
                if (check == ConsoleKey.Enter)
                {
                    Console.WriteLine(Startup.languageInterface[24], list[index].Brand);
                    list.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine(Startup.languageInterface[25], list[index].Brand);
                    return list;
                }

            }
            else
            {
                Console.WriteLine(Startup.languageInterface[25]);
            }
            return list;
        }        

        //Проверка за съществуването да даден хранителен тип от foodType списъка в Product.cs
        

        //Проверка дали обекта съществува
        private string CheckIfItemExists(string brand, List<Product> list)
        {
            foreach (var item in list)
            {
                while (brand == item.Brand)
                {
                    Console.WriteLine(Startup.languageInterface[37]);
                    Console.WriteLine(Startup.languageInterface[0]);
                    ConsoleKey answer = InputChecker.CheckIfEnter();
                    if (answer == ConsoleKey.Enter)
                    {
                        brand = Console.ReadLine();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            return brand;
        }

        public static string CheckIfItemExists(string foodType, List<string> list)
        {
            foreach (var item in list)
            {
                while (foodType.ToLower() == item.ToLower())
                {
                    Console.WriteLine(Startup.languageInterface[72]);
                    Console.WriteLine(Startup.languageInterface[0]);
                    ConsoleKey answer = InputChecker.CheckIfEnter();
                    if (answer == ConsoleKey.Enter)
                    {
                        foodType = Console.ReadLine();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            return foodType;
        }

        //Edit item properties overloads
        private string EditItemProperty(string property)
        {
            string tempProperty = property;
            Console.Write(Startup.languageInterface[27]);
            property = Console.ReadLine();
            if (property == "")
            {
                Console.WriteLine(Startup.languageInterface[34]);                
            }

            return tempProperty;
        }

        private int EditItemProperty(int property)
        {
            Console.WriteLine(Startup.languageInterface[77], property);
            bool correct = int.TryParse(Console.ReadLine(), out int input);
            if (string.IsNullOrEmpty(input.ToString()) || input == property)
            {
                Console.WriteLine(Startup.languageInterface[34]);
                return property;
            }
            else
            {
                while (correct == false)
                {
                    if (input.ToString() == "" || input == property)
                    {
                        Console.WriteLine(Startup.languageInterface[34]);
                        return property;
                    }
                    Console.Write(Startup.languageInterface[1]);
                    correct = int.TryParse(Console.ReadLine(), out input);
                }
            }
            return input;
        }

        private decimal EditItemProperty(decimal property)
        {
            Console.WriteLine(Startup.languageInterface[77],property);
            bool correct = decimal.TryParse(Console.ReadLine(), out decimal input);
            if (string.IsNullOrEmpty(input.ToString()) || input == property)
            {
                Console.WriteLine(Startup.languageInterface[34]);
                return property;
            }
            else
            {
                while (correct == false)
                {
                    if (input.ToString() == "" || input == property)
                    {
                        Console.WriteLine(Startup.languageInterface[34]);
                        return property;
                    }
                    Console.Write(Startup.languageInterface[1]);
                    correct = decimal.TryParse(Console.ReadLine(), out input);
                }
            }
            return input;
        }
    }
}
