using CoffeeShopManagement.Data;
using CoffeeShopManagement.Interfaces;
using CoffeeShopManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Services
{
    public class StaffManagement : IStaffManagement
    {
        public async Task<IEnumerable<Staff>> GetListStaff()
        {
            var listStaffs = StaffData.ListStaff();
            return listStaffs;
        }
    }
}
