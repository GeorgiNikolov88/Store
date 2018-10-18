using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class InputChecker
    {
        public static ConsoleKey CheckIfEnter()
        {
            ConsoleKey answer = Console.ReadKey(true).Key;
            while (answer != ConsoleKey.Escape && answer != ConsoleKey.Enter)
            {
                Console.WriteLine(Startup.languageInterface[0]);
                answer = Console.ReadKey(true).Key;
            }
            return answer;
        }
        //Проверка коретността за различните типове числени типове 
        public static int CheckIfInt()
        {
            bool correct = int.TryParse(Console.ReadLine(), out int input);
            while (correct == false)
            {
                if (input.ToString() == "")
                {
                    return input = 0;
                }
                Console.Write(Startup.languageInterface[1]);
                correct = int.TryParse(Console.ReadLine(), out input);
            }
            return input;
        }

        public static int CheckIfInt(int maxValue)
        {
            bool correct = int.TryParse(Console.ReadLine(), out int input);
            while (correct == false || input > maxValue || input <= 0)
            {
                Console.Write(Startup.languageInterface[2]);
                correct = int.TryParse(Console.ReadLine(), out input);
            }
            return input;
        }

        public static decimal CheckIfDecimal()
        {
            bool correct = decimal.TryParse(Console.ReadLine(), out decimal input);
            while (correct == false)
            {
                Console.Write(Startup.languageInterface[1]);
                correct = decimal.TryParse(Console.ReadLine(), out input);
            }
            return input;
        }

        public static int CheckTypeInput(int currentValue)
        {
            for (int i = 0; i < Product.foodType.Count; i++)
            {
                Console.WriteLine("{0}-{1}", i, Product.GetListItem(i));
            }
            Console.WriteLine(Startup.languageInterface[20]);
            Console.WriteLine(Startup.languageInterface[0]);
            ConsoleKey answer = InputChecker.CheckIfEnter();
            if (answer == ConsoleKey.Enter)
            {
                Product.AddItemType();
                Console.Clear();
                foreach (var item in Product.foodType)
                {
                    Console.WriteLine(item);
                }
            }
            Console.Write(Startup.languageInterface[15]);
            bool correct = int.TryParse(Console.ReadLine(), out int type);
            if (string.IsNullOrEmpty(type.ToString()) && !correct)
            {
                Console.WriteLine(Startup.languageInterface[34]);
                return currentValue;
            }
            else
            {
                while (correct == false || type > Product.foodType.Count || type < 0)
                {
                    if (correct == false)
                    {
                        Console.WriteLine(Startup.languageInterface[35]);
                        correct = int.TryParse(Console.ReadLine(), out type);
                    }
                    else if (type > Product.foodType.Count || type < 0)
                    {
                        Console.WriteLine(Startup.languageInterface[36]);
                        correct = int.TryParse(Console.ReadLine(), out type);
                    }
                }
                return type;
            }

        }

    }
}
