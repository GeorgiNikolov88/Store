using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Interfaces
    {
        public static List<List<string>> interfaces = new List<List<string>>
        {
            english,
            bulgarian
        };
        public static List<string> english = new List<string>
        {
            "Please press Enter to continue, or Esc to exit",                                                                    //0
            "Please enter number: ",                                                                                             //1
            "Please enter correct number: ",                                                                                      //2
            "Welcome!",                                                                                                          //3
            "Select оperation: ",                                                                                                //4
            "1) Sell",                                                                                                           //5
            "1) Add new item",                                                                                                    //6
            "3) Edit existing item",                                                                                             //7
            "2) Delete existing item",                                                                                           //8
            "4) Restock",                                                                                                        //9
            "{0}) Exit",                                                                                                         //10
            "Do you want to continue",                                                                                           //11
            "Enter Brand: ",                                                                                                     //12
            "Enter price: ",                                                                                                     //13
            "Enter ammout in Stock: ",                                                                                           //14
            "Select product type:",                                                                                              //15
            "Enter max stock: ",                                                                                                 //16
            "Enter overcharge: ",                                                                                                //17
            "Wrong Password!",                                                                                                   //18
            "Enter Password: ",                                                                                                  //19
            "Enter new type?",                                                                                                   //20
            "Enter the name of the new type: ",                                                                                  //21
            "Delete item?",                                                                                                      //22   
            "Remove {0}?",                                                                                                       //23
            "Item {0} has been removed!",                                                                                        //24
            "No item has been removed!",                                                                                         //25
            "Edit {0}?",                                                                                                         //26
            "Edit brand(If the input is empty the item will not be changed!):",                                                  //27
            "The item has not been changed",                                                                                     //28
            "Edit Price: ",                                                                                                      //29
            "Edit stock ammount: ",                                                                                              //30
            "Edit type: ",                                                                                                       //31
            "Edit max stock: ",                                                                                                  //32
            "Edit overcharge: ",                                                                                                 //33
            "No change has been made!",                                                                                          //34
            "Please enter the number of the type: ",                                                                             //35
            "The type you entered does not exist! Please enter again: ",                                                         //36
            "Brand exists! Do you want to add new one or exit?",                                                                 //37
            "{0} - Ammount: ",                                                                                                     //38
            "Insefficent ammount :{0}-{1}",                                                                                      //39
            "Enter new ammount:",                                                                                                //40
            "Items left -{0} - {1}: {2}",                                                                                        //41
            "{0} - Item/s sold:{1} - {2} | Ammount: {3} | Price: {4}",                                                           //42
            "Transaction Completed!",                                                                                            //43
            "Out of stock!",                                                                                                     //44
            "Items in stock: ",                                                                                                  //45
            "Select Category: ",                                                                                                 //46
            "Select item: ",                                                                                                     //47
            "Item does not exist, please enter item again!",                                                                     //48
            "Add another item to cart?(Enter- yes! / Esc- No!)",                                                                 //49
            "Wrong input!",                                                                                                      //50
            "Select restock method:",                                                                                            //51
            "1) Manual(enter how much items to order), \n2) Automatic(Order the maximum ammouunt of each item).",                 //52
            "Items left: ",                                                                                                      //53
            "Type:{0},\n Brand:{1},\n In stock: {2},\n max stock: {3}",                                                          //54
            "Press Enter to restock.",                                                                                           //55
            "Enter ammount: ",                                                                                                   //56
            "Too many items oredered! Please order less than {0}.",                                                              //57
            "Please enter positive number!",                                                                                     //58
            "Not enough money!",                                                                                                 //59
            "Please enter new value: ",                                                                                          //60
            "Operation completed without restocking!",                                                                           //61
            "Cash for cart so far {0}.",                                                                                         //62
            "3) Items in stock info.",                                                                                           //63
            "1) Single item.",                                                                                                   //64
            "2) All items.",                                                                                                     //65
            "Product type: {0} | Product brand: {1}",                                                                            //66
            "Items in stock: {0} | Max stock: {1}",                                                                              //67
            "Item price: {0} | Item overcharge: {1}",                                                                            //68
            "Enter the number of the type you want to delete: ",                                                                 //69
            "2) Inventory management.",                                                                                          //70
            "Select the number of the type to edit!",                                                                            //71
            "No such type! Do you want to continue?",                                                                            //72
            "Do you want to change {0} to {1}",                                                                                  //73
            "4) Add new food type.",                                                                                             //74
            "5) Delete food type.",                                                                                              //75
            "6) Edit food type.",                                                                                                //76                                                                                      //70
            "Current value: {0}",                                                                                                 //77
            "3) Exit without restocking!"                                                                                    //78

        };
        public static List<string> bulgarian = new List<string>
        {
            "Моля натиснете Enter за да продължите или Esc за да излезете",                                                       //0
            "Моля въведете номер: ",                                                                                              //1
            "Моля въведете правилен номер: ",                                                                                      //2
            "Здравейте!",                                                                                                         //3
            "Изберете действие: ",                                                                                                //4
            "1) Продажба",                                                                                                        //5
            "1) Добавяне на нова стока",                                                                                          //6
            "3) Редактиране на налична стока",                                                                                    //7
            "2) Изтриване на налична стока",                                                                                      //8
            "4) Заявка за нова стока",                                                                                            //9
            "{0}) Изход",                                                                                                         //10
            "Искате ли да продължите?",                                                                                           //11
            "Въведете марка: ",                                                                                                   //12
            "Въведете цена: ",                                                                                                    //13
            "Въведете броя на продукта на склад: ",                                                                               //14
            "Изберете типа на продукта: ",                                                                                        //15
            "Въведете максималния брой на продукта: ",                                                                            //16
            "Въведете надценката: ",                                                                                              //17
            "Грешна Парола!",                                                                                                     //18
            "Въведете парола: ",                                                                                                  //19
            "Въвеждане на нов тип продукт?",                                                                                      //20
            "Въведете името на типa: ",                                                                                           //21
            "Изтриване на продукт?" ,                                                                                             //22 
            "Изтриване на {0}?",                                                                                                  //23
            "{0} беше изтрит!",                                                                                                   //24
            "Няма изтрити продукти!",                                                                                             //25
            "Редактиране на {0}?",                                                                                                //26
            "Редактиране на марката на продукта(Ако не въведете нищо продукта ще остане без промяна!):",                          //27
            "Продукта е непроменен",                                                                                              //28
            "Въведете нова цена: ",                                                                                               //29
            "Редактирайте продуктите на склад: ",                                                                                 //30
            "Редактиране на типа: ",                                                                                              //31
            "Редактиране на максималния брой в наличност: ",                                                                      //32
            "Редактиране на надценка: ",                                                                                          //33
            "Без промяна!",                                                                                                       //34
            "Въведете номера на типа: ",                                                                                          //35
            "Такъв тип не съществува моля въведете отново: ",                                                                     //36
            "Продукт с такова име съществува! Искате ли да продължите или да излезете?",                                          //37
            "{0} - Брой: ",                                                                                                       //38
            "Недостатъчна наличност :{0} - {1}",                                                                                  //39
            "Въведете нов брой: ",                                                                                                //40
            "Брой в наличност -{0} - {1}: {2}",                                                                                   //41
            "{0} - Брой продадени:{1} - {2} | Наличност: {3}  | Цена: {4}",                                                       //42
            "Транзакцията е завършена!",                                                                                          //43
            "Няма останала наличност!",                                                                                           //44
            "Продукти в наличност: ",                                                                                             //45
            "Изберете категория: ",                                                                                               //46
            "Изберете предмет: ",                                                                                                 //47
            "Такъв предмет не съществува моля въведете отново!",                                                                  //48
            "Ще добавите ли нов продукт в количката",                                                                             //49
            "Грешно въедено число!",                                                                                              //50
            "Изберете метод за поръчка на нови стоки:",                                                                           //51
            "1) Ръчен(За всеки предмет да се зададе бройката ръчно), \n2) Автоматичен(Поръчка на максималния възможен брой за всеки предмет)",  //52
            "Оставащи бройки: ",                                                                                                  //53
            "Тип:{0},\nМарка:{1},\nВ наличност: {2},\nМаксимално допустим брой на склад: {3}",                                    //54
            "Натиснете Enter за да поръчата стока!",                                                                              //55
            "Въведете брой: ",                                                                                                    //56
            "Прекалено голяма поръчка, изберете нова {0}",                                                                        //57
            "Моля въведете позитивно число!",                                                                                     //58
            "Недостатъчно пари за поръчка!",                                                                                      //59
            "Въведете нова стойност: ",                                                                                           //60
            "Операцията завършена без заявка за презареждане!",                                                                   //61
            "Цена до тук {0}" ,                                                                                                   //62
            "3) Информация за наличната стока.",                                                                                  //63
            "1) Един предмет.",                                                                                                   //64
            "2) Всички предмети.",                                                                                                //65
            "Тип на продукта: {0} | Марка на продукта: {1}",                                                                      //66
            "Наличен брой: {0} | Максимален брой: {1}",                                                                           //67
            "Цена: {0} | надценка: {1}",                                                                                          //68
            "Въведете номера на типа който искате да изтриете: ",                                                                 //69
            "2) Управление на инвентара.",                                                                                        //70
            "Изберете номера на типа който искате да промените!",                                                                 //71
            "Тип с такова име съществува! Искате ли да продължите или да излезете?",                                              //72
            "Искате ли да промените {0} на {1}",                                                                                  //73
            "4) Добавяне на нов тип продукт.",                                                                                    //74
            "5) Изтриване на тип продукт.",                                                                                       //75
            "6) Редактиране на тип продукт.",                                                                                     //76
            "Текуща стойност: {0}",                                                                                               //77
            "3) Излизане без поръчване на нова стока"                                                                                //78

        };
        public static List<string> SelectInterface() 
        {
            List<string> selectedInterface = new List<string>();
            Console.WriteLine("Enter (1) for English interface.");
            Console.WriteLine("Въведете (2) за български интерфейс.");
            bool correct = int.TryParse(Console.ReadLine(), out int input);
            while (correct == false || input > interfaces.Count || input < 0)
            {
                if (correct == false)
                {
                    Console.WriteLine(english[1]);
                    Console.WriteLine(bulgarian[1]);
                }
                else
                {
                    Console.WriteLine(english[2]);
                    Console.WriteLine(bulgarian[2]);
                }                
                correct = int.TryParse(Console.ReadLine(), out input);
            }
            switch (input)
            {
                case 1:
                    selectedInterface = english;
                    break;
                case 2:
                    selectedInterface = bulgarian;
                    break;
                default:
                    break;
            }
            return selectedInterface;
        }
    }
}
