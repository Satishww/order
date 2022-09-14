using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItemWebAPI.Models
{
    public class MenuItem
    {
        public int menuItemId { get; set; }
        public string name { get; set; }
        public bool freeDelivery { get; set; }
        public int price { get; set; }
        public DateTime dateOfLaunch { get; set; }
        public bool active { get; set; }
    }
}
