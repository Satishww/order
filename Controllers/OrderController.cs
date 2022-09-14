using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderItemWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OrderItemWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [Route("{id}")]
        public IActionResult Post(int id)
        {

            Cart cartItem = new Cart()
            { CardId = 1, UserId = 1, MenuItemId=id };

            string baseAddress = $"https://localhost:44314/api/menuitem/{id}";

            HttpClient client = new HttpClient();
            var response = client.GetAsync(baseAddress).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                MenuItem mItem = new MenuItem();
                mItem = JsonConvert.DeserializeObject<MenuItem>(data);
                cartItem.menuItemName = mItem.name;
                return Created("api/order", cartItem);
            }
            else
                return BadRequest();

            

        }
    }
}
