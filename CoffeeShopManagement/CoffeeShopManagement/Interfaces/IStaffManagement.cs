using CoffeeShopManagement.Models;
using System.Collections.Generic;

namespace CoffeeShopManagement.Interfaces
{
    public interface IStaffManagement
    {
        IEnumerable<Staff> GetListStaff();
    }
}
