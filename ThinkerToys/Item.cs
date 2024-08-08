using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkerToys
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public Bitmap Image { get; set; }
        public EventHandler BuyEventHandler { get; set; }

        public Item(string name, int price, string category, Bitmap image, EventHandler buyEventHandler)
        {
            Name = name;
            Price = price;
            Category = category;
            Image = image;
            BuyEventHandler = buyEventHandler;
        }
    }
}
