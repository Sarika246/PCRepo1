using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        // GET: api/MenuItem

      //  MenuItem menu = new MenuItem();
      public static List<MenuItem> menuItemList = new List<MenuItem>()
      {
            new MenuItem()
            {
                Id = 1,
                Name = "Sandwich",
                FreeDelivery = true,
                Price = 50,
                DateOfLaunch = Convert.ToDateTime("2020-07-15"),
                Active = true

            },
        new MenuItem()
        {
            Id = 2,
                Name = "Burger",
                FreeDelivery = true,
                Price = 75,
                DateOfLaunch = Convert.ToDateTime("2020-07-15"),
                Active = true

            },
        new MenuItem()
        {
            Id = 3,
                Name = "Pizza",
                FreeDelivery = true,
                Price = 220,
                DateOfLaunch = Convert.ToDateTime("2020-07-22"),
                Active = false
            },
             new MenuItem()
        {
            Id = 4,
                Name = "Roll",
                FreeDelivery = true,
                Price = 80,
                DateOfLaunch = Convert.ToDateTime("2020-07-12"),
                Active = false

            }
    };
        

            [HttpGet]
        public IEnumerable<MenuItem> Get()
        {

            return menuItemList.ToList();

        }

        // GET: api/MenuItem/5
        [HttpGet("{id}", Name = "Get")]
        public string GetMenuById(int id)
        {
            //  return "value";
            MenuItem item = menuItemList.Where(x => x.Id == id).FirstOrDefault();
            string name =item.Name;
            return name;
        }

      
       
    }
}
