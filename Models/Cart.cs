using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItemWebAPI.Models
{
    public class Cart
    {
        public int CardId { get; set; }
        public int UserId { get; set; }
        public int MenuItemId { get; set; }
        public string menuItemName { get; set; }

    }
}
