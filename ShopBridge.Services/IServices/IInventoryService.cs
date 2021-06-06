using ShopBridge.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public interface IInventoryService
    {
        Task<long> UpsertInventory(Inventory item);
        Task<List<Inventory>> GetInventoryList();
        Task<Inventory> GetInventoryDetails(long inventoryId);
        Task<long> DeleteInventory(long inventoryId);
    }
}
