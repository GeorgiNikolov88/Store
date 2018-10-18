using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Store
{
    class Product
    {
        string _brand;
        decimal _price;
        int _inStock;
        int _type;
        //public static List<string> foodType = new List<string> { "bread", "vegeable", "meat", "water", "chocolate" };
        public static List<string> foodType = new List<string>();
        int _maxStock;
        decimal _overcharge;
        private const string password = "1";

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int InStock
        {
            get { return _inStock; }
            set { _inStock = value; }
        }
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int MaxStock
        {
            get { return _maxStock; }
            set
            {
                //Console.Write("Enter password: ");
                //ConsoleKeyInfo inf;
                //StringBuilder input = new StringBuilder();
                //inf = Console.ReadKey(true);
                //while (inf.Key != ConsoleKey.Enter)
                //{
                //    input.Append(inf.KeyChar);
                //    inf = Console.ReadKey(true);
                //}
                //string password = "1";
                //if (input.ToString() == password)
                //{
                _maxStock = value;
                //}
                //Console.WriteLine();
            }
        }
        public decimal Overcharge
        {
            get { return _overcharge; }
            set { _overcharge = value; }
        }

        public static void AddItemType()
        {
            Console.Clear();
            Console.WriteLine(Startup.languageInterface[19]);
            string insertPassword = Console.ReadLine();
            ConsoleKey answer = ConsoleKey.Enter;
            while (answer != ConsoleKey.Escape)
            {

                if (insertPassword == "1")
                {
                    Console.WriteLine(Startup.languageInterface[21]);
                    string addition = CRUDProduct.CheckIfItemExists(Console.ReadLine(), foodType);
                    if (addition != string.Empty)
                    {
                        foodType.Add(addition);
                        answer = ConsoleKey.Escape;
                    }
                    else
                    {
                        return;
                    }
                    
                }
                else
                {
                    Console.WriteLine(Startup.languageInterface[18]);
                    Console.WriteLine(Startup.languageInterface[0]);
                    answer = InputChecker.CheckIfEnter();
                    Console.Write(Startup.languageInterface[19]);
                    insertPassword = Console.ReadLine();
                }
            }
        }

        public static void RemoveItemType()
        {
            Console.Clear();
            Console.WriteLine(Startup.languageInterface[19]);
            string insertPassword = Console.ReadLine();
            ConsoleKey answer = ConsoleKey.Enter;
            while (answer != ConsoleKey.Escape)
            {
                if (insertPassword == "1")
                {
                    for (int i = 0; i < foodType.Count; i++)
                    {
                        Console.WriteLine("{0}) {1}", i, foodType[i]);
                    }
                    Console.WriteLine(Startup.languageInterface[69]);
                    int itemToRemove = InputChecker.CheckIfInt(foodType.Count);
                    Console.WriteLine(Startup.languageInterface[23], foodType[itemToRemove]);
                    answer = InputChecker.CheckIfEnter();
                    if (answer == ConsoleKey.Enter)
                    {
                        foodType.RemoveAt(itemToRemove);
                        answer = ConsoleKey.Escape;
                    }

                }
                else
                {
                    Console.WriteLine(Startup.languageInterface[18]);
                    Console.WriteLine(Startup.languageInterface[0]);
                    answer = InputChecker.CheckIfEnter();
                    Console.Write(Startup.languageInterface[19]);
                    insertPassword = Console.ReadLine();
                }
            }
        }

        public static void EditProductType()
        {
            Console.WriteLine(Startup.languageInterface[19]);
            string insertPassword = Console.ReadLine();
            ConsoleKey answer = ConsoleKey.Enter;
            while (answer != ConsoleKey.Escape)
            {
                if (insertPassword == "1")
                {
                    Console.Clear();
                    for (int i = 0; i < foodType.Count; i++)
                    {
                        Console.WriteLine("{0}) {1}", i, foodType[i]);
                    }
                    Console.WriteLine(Startup.languageInterface[71]);
                    int itemToEdit = InputChecker.CheckIfInt(foodType.Count);
                    Console.WriteLine(Startup.languageInterface[21]);
                    string newName = CRUDProduct.CheckIfItemExists(Console.ReadLine(),foodType);
                    if (newName != string.Empty)
                    {
                        Console.WriteLine(Startup.languageInterface[73], foodType[itemToEdit] , newName);
                        Console.WriteLine(Startup.languageInterface[0]);
                        if (InputChecker.CheckIfEnter() == ConsoleKey.Enter)
                        {
                            foodType[itemToEdit] = newName;
                        }
                        else
                        {
                            Console.WriteLine(Startup.languageInterface[34]);
                        }
                        answer = ConsoleKey.Escape;
                    }
                }
                else
                {
                    Console.WriteLine(Startup.languageInterface[18]);
                    Console.WriteLine(Startup.languageInterface[0]);
                    answer = InputChecker.CheckIfEnter();
                    Console.Write(Startup.languageInterface[19]);
                    insertPassword = Console.ReadLine();
                }
            }

        }

        public static string GetListItem(int index)
        {
            return foodType[index];
        }

        public Product(string brand, decimal price, int inStock, int type, int maxStock, decimal overcharge)
        {
            this.Brand = brand;
            this.Price = price;
            this.InStock = inStock;
            this.Type = type;
            this.MaxStock = maxStock;
            this.Overcharge = overcharge;
        }

        public Product()
        {
        }

    }
}
