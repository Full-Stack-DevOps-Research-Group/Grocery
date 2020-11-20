using GroceryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Repositories
{
    public interface IGroceryRepository
    {
        IEnumerable<GroceryItem> GetItems();
        GroceryItem GetItemByID(int id);
        void AddItem(GroceryItem item);
        void DeleteItem(int id);
        void SaveChanges();
    }
}
