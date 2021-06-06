using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<long> Upsert(T item);
        Task<List<T>> GetList();
        Task<T> Get(long inventoryId);
        Task<long> Delete(long inventoryId);
    }
}
