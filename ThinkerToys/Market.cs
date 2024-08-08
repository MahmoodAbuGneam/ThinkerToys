using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkerToys
{
    public class Market
    {
        private List<Item> storeItems = new List<Item>();

        public void AddItem(Item item)
        {
            storeItems.Add(item);
        }

        public List<Item> GetAllItems()
        {
            return storeItems;
        }

        public Item GetItem(string itemName)
        {
            return storeItems.FirstOrDefault(item => item.Name == itemName);
        }

        public List<Item> GetItemsByCategory(string category)
        {
            return storeItems.Where(item => item.Category == category).ToList();
        }
    }
}
