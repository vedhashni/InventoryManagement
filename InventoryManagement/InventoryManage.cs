using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Inventory
{
    public class InventoryManage : IManage
    {
        public List<Rice> RiceList { get; set; }

        public List<Pulse> PulseList { get; set; }

        public List<Wheat> WheatList { get; set; }

        public class Rice
        {
            public string Name { get; set; }

            public int Price { get; set; }

            public int Kg { get; set; }

            public string Type { get; set; }
        }


        public class Wheat
        {
            public string Name { get; set; }

            public int Price { get; set; }

            public int Kg { get; set; }

            public string Type { get; set; }
        }

        public class Pulse
        {
            public string Name { get; set; }

            public int Price { get; set; }

            public int Kg { get; set; }

            public string Type { get; set; }
        }
        public List<InventoryManage.Rice> AddToInventory(List<InventoryManage.Rice> riceList)
        {
            InventoryManage.Rice riceoption = new InventoryManage.Rice();
            Console.WriteLine("Enter name of rice : ");
            riceoption.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of rice : ");
            riceoption.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in rice  : ");
            riceoption.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of rice : ");
            riceoption.Type = Console.ReadLine();
            riceList.Add(riceoption);
            return riceList;
        }
        //Adding a details to PulseList
        public List<InventoryManage.Pulse> AddToInventory(List<InventoryManage.Pulse> pulseList)
        {
            InventoryManage.Pulse pulseoption = new InventoryManage.Pulse();
            Console.WriteLine("Enter name of pulse : ");
            pulseoption.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of pulse : ");
            pulseoption.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in pulse  : ");
            pulseoption.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of pulse : ");
            pulseoption.Type = Console.ReadLine();
            pulseList.Add(pulseoption);
            return pulseList;
        }
        //Adding a details to WheatList
        public List<InventoryManage.Wheat> AddToInventory(List<InventoryManage.Wheat> wheatList)
        {
            InventoryManage.Wheat wheatoption = new InventoryManage.Wheat();
            Console.WriteLine("Enter name of wheat : ");
            wheatoption.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of wheat : ");
            wheatoption.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in wheat  : ");
            wheatoption.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of wheat : ");
            wheatoption.Type = Console.ReadLine();
            wheatList.Add(wheatoption);
            return wheatList;
        }
        //Update data to RiceList
        public List<InventoryManage.Rice> UpdateToInventory(List<InventoryManage.Rice> riceList)
        {
            InventoryManage.Rice riceoption = new InventoryManage.Rice();

            Console.WriteLine("Enter name of rice to be update");
            string Name = Console.ReadLine();

            riceList.Remove(riceList.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Enter name of rice : ");
            riceoption.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of rice : ");
            riceoption.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in rice  : ");
            riceoption.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of rice : ");
            riceoption.Type = Console.ReadLine();
            riceList.Add(riceoption);
            return riceList;
        }
        //Update data to PulseList
        public List<InventoryManage.Pulse> UpdateToInventory(List<InventoryManage.Pulse> pulseList)
        {
            InventoryManage.Pulse pulseoption = new InventoryManage.Pulse();

            Console.WriteLine("Enter name of pulse to be update");
            string Name = Console.ReadLine();

            pulseList.Remove(pulseList.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Enter name of rice : ");
            pulseoption.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of rice : ");
            pulseoption.Price = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter weight of kg in rice  : ");
            pulseoption.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of rice : ");
            pulseoption.Type = Console.ReadLine();
            pulseList.Add(pulseoption);
            return pulseList;
        }
        //Update data to WheatList
        public List<InventoryManage.Wheat> UpdateToInventory(List<InventoryManage.Wheat> wheatList)
        {
            InventoryManage.Wheat wheatoption = new InventoryManage.Wheat();
            Console.WriteLine("Enter name of wheat to be update");
            string Name = Console.ReadLine();

            wheatList.Remove(wheatList.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("Enter name of rice : ");
            wheatoption.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of rice : ");
            wheatoption.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight of kg in rice  : ");
            wheatoption.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of rice : ");
            wheatoption.Type = Console.ReadLine();
            wheatList.Add(wheatoption);
            return wheatList;
        }
        //Removing the data from RiceList
        public List<InventoryManage.Rice> RemoveFromInventory(List<InventoryManage.Rice> riceList)
        {
            InventoryManage.Rice riceoption = new InventoryManage.Rice();
            Console.WriteLine("Enter name of rice to be deleted");
            string Name = Console.ReadLine();

            riceList.Remove(riceList.Find(ut => ut.Name.Equals(Name)));
            return riceList;
        }
        //Removing the data from PulseList
        public List<InventoryManage.Pulse> RemoveFromInventory(List<InventoryManage.Pulse> pulseList)
        {
            InventoryManage.Pulse pulseoption = new InventoryManage.Pulse();
            Console.WriteLine("Enter name of pulse to be deleted");
            string Name = Console.ReadLine();

            pulseList.Remove(pulseList.Find(ut => ut.Name.Equals(Name)));
            return pulseList;
        }
        //Removing the data from WheatList
        public List<InventoryManage.Wheat> RemoveFromInventory(List<InventoryManage.Wheat> wheatList)
        {
            InventoryManage.Wheat wheatoption = new InventoryManage.Wheat();
            Console.WriteLine("Enter name of wheat to be deleted");
            string Name = Console.ReadLine();

            wheatList.Remove(wheatList.Find(ut => ut.Name.Equals(Name)));
            return wheatList;
        }
        //   Displaying the ricelist

        public void DisplayInventory(List<InventoryManage.Rice> riceList)
        {
            
            int totalInventoryRice = 0;
            foreach (InventoryManage.Rice i in riceList)
            {
                Console.WriteLine("\n name = " + i.Name + "\nweight= " + i.Kg + "\n Price= " + i.Price + "\ntype= " + i.Type);
                totalInventoryRice += ManageInventory(i.Kg, i.Price);
            }
            Console.WriteLine("\n Total Inventory Rice cost :" + totalInventoryRice);
        }
        // Displaying the pulselist
        public void DisplayInventory(List<InventoryManage.Pulse> pulseList)
        {
            
            int totalInventoryPulse = 0;
            foreach (InventoryManage.Pulse i in pulseList)
            {
                Console.WriteLine("\n name = " + i.Name + "\nweight= " + i.Kg + "\n Price= " + i.Price + "\ntype= " + i.Type);
                totalInventoryPulse += ManageInventory(i.Kg, i.Price);
            }
            Console.WriteLine("\n Total Inventory Pulse cost :" + totalInventoryPulse);
        }
        //Displaying the wheatlist
        public void DisplayInventory(List<InventoryManage.Wheat> wheatList)
        {
            
            int totalInventoryWheat = 0;
            foreach (InventoryManage.Wheat i in wheatList)
            {
                Console.WriteLine("\n name = " + i.Name + "\nweight= " + i.Kg + "\n Price= " + i.Price + "\ntype= " + i.Type);
                totalInventoryWheat += ManageInventory(i.Kg, i.Price);
                
            }
            Console.WriteLine("\n Total Inventory Wheat cost :" + totalInventoryWheat);
        }
        //calculating the total price
        public int ManageInventory(int Kg, int Price)
        {

            return Kg * Price;
        }

    }
}
