using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Inventory
{
    class Inventory
    {
        public static void JsonDeSerialaize()
        {
            InventoryManage manage = new InventoryManage();

            string filePath = @"C:\Users\ven\source\repos\InventoryManagement\InventoryManagement\json1.json";
            //Converting stream of bytes into object using Deserialize object
            InventoryManage utility = JsonConvert.DeserializeObject<InventoryManage>(File.ReadAllText(filePath));
            Console.WriteLine("1.Display Inventory\n2.Add To Inventory\n3.Remove From Inventory\n4.Update To Inventory\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //To Display Inventory
                case 1:
                    Console.WriteLine("1.Rice\n2.Pulse\n3.Wheat\nEnter your option");
                    int displayOption = Convert.ToInt32(Console.ReadLine());
                    switch (displayOption)
                    {
                        case 1:
                            manage.DisplayInventory(utility.RiceList);
                            break;
                        case 2:
                            manage.DisplayInventory(utility.PulseList);
                            break;
                        case 3:
                            manage.DisplayInventory(utility.WheatList);
                            break;
                        default:
                            Console.WriteLine("Enter a valid option!!!");
                            break;
                    }
                    break;
                case 2:
                    //Add to inventory
                    Console.WriteLine("1.Add Record to Rice\n2.Add Record to Pulse\n3.Add record to Wheat\nEnter your option");
                    int optionOne = Convert.ToInt32(Console.ReadLine());
                    switch (optionOne)
                    {
                        case 1:
                            utility.RiceList = manage.AddToInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            utility.PulseList = manage.AddToInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            utility.WheatList = manage.AddToInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            Console.WriteLine("Enter a valid option!!!");
                            break;
                    }
                    break;

                case 3:
                    //Remove from inventory
                    Console.WriteLine("\n1.Remove record from Rice 2.Remove record from Pulse\n 3.Remove record from Wheat");
                    int optionTwo = Convert.ToInt32(Console.ReadLine());
                    switch (optionTwo)
                    {
                        case 1:
                            manage.DisplayInventory(utility.RiceList);
                            utility.RiceList = manage.RemoveFromInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            manage.DisplayInventory(utility.PulseList);
                            utility.PulseList = manage.RemoveFromInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            manage.DisplayInventory(utility.WheatList);
                            utility.WheatList = manage.RemoveFromInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            Console.WriteLine("Enter a valid option!!!");
                            break;
                    }

                    break;
                case 4:
                    //Update to inventory
                    Console.WriteLine("\n1.Update record to Rice 2.Update record to Pulse\n 3.Update record to Wheat");
                    int optionThree = Convert.ToInt32(Console.ReadLine());
                    switch (optionThree)
                    {
                        case 1:
                            manage.DisplayInventory(utility.RiceList);
                            utility.RiceList = manage.UpdateToInventory(utility.RiceList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;

                        case 2:
                            manage.DisplayInventory(utility.PulseList);
                            utility.PulseList = manage.UpdateToInventory(utility.PulseList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;

                        case 3:
                            manage.DisplayInventory(utility.WheatList);
                            utility.WheatList = manage.UpdateToInventory(utility.WheatList);
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            Console.WriteLine("Enter a valid option!!!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Enter a valid option!!!");
                    break;

            }
        }
    }
}
