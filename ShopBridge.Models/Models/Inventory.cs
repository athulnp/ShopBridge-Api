using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBridge.Models.Models
{
    public class Inventory
    {
        public long ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }
        public string CreatedBy { get; set; }
    }
}
