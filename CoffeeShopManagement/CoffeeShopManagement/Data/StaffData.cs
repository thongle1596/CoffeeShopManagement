using CoffeeShopManagement.Models;
using System.Collections.Generic;

namespace CoffeeShopManagement.Data
{
    public static class StaffData
    {
        public static List<Staff> ListStaff()
        {
            var data = new List<Staff>
            {
                new Staff { Id= 1, Name = "Phuc", Title = "Bartender", PhoneNumber = "1234567890", Email= "phuc@coffeeshop.com" },
                new Staff { Id= 2, Name = "Nhat", Title = "Manager", PhoneNumber = "0987654321", Email = "nhat@coffeeshop.com"},
                new Staff { Id= 3, Name = "Sum", Title = "CEO", PhoneNumber = "0986781231", Email = "sum@coffeeshop.com"},
                new Staff { Id= 4, Name = "Minh", Title = "Waiter", PhoneNumber = "0987654322", Email = "minh@coffeeshop.com"},
                new Staff { Id= 5, Name = "Duc", Title = "Waiter", PhoneNumber = "0987654323", Email = "duc@coffeeshop.com"}
            };

            return data;
        }
    }
}
