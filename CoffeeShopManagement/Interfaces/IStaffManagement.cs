using CoffeeShopManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Interfaces
{
    public interface IStaffManagement
    {
        Task<IEnumerable<Staff>> GetListStaff();
    }
}
