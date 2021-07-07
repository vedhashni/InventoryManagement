using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Inventory
{
    interface IManage
    {
        List<InventoryManage.Rice> AddToInventory(List<InventoryManage.Rice> riceList);
        List<InventoryManage.Pulse> AddToInventory(List<InventoryManage.Pulse> pulseList);
        List<InventoryManage.Wheat> AddToInventory(List<InventoryManage.Wheat> wheatList);
        List<InventoryManage.Rice> UpdateToInventory(List<InventoryManage.Rice> riceList);
        List<InventoryManage.Pulse> UpdateToInventory(List<InventoryManage.Pulse> pulseList);
        List<InventoryManage.Wheat> UpdateToInventory(List<InventoryManage.Wheat> wheatList);
        List<InventoryManage.Rice> RemoveFromInventory(List<InventoryManage.Rice> riceList);
        List<InventoryManage.Pulse> RemoveFromInventory(List<InventoryManage.Pulse> pulseList);

        List<InventoryManage.Wheat> RemoveFromInventory(List<InventoryManage.Wheat> wheatList);
         void DisplayInventory(List<InventoryManage.Rice> riceList);
         void DisplayInventory(List<InventoryManage.Pulse> pulseList);
         void DisplayInventory(List<InventoryManage.Wheat> wheatList);
        int ManageInventory(int Kg, int Price);
    }
}
