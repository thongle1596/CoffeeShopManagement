using CoffeeShopManagement.Data;
using CoffeeShopManagement.Interfaces;
using CoffeeShopManagement.Models;
using System.Collections.Generic;

namespace CoffeeShopManagement.Services
{
    public class StaffManagement : IStaffManagement
    {
        public IEnumerable<Staff> GetListStaff()
        {
            var listStaffs = StaffData.ListStaff();
            Log.Info("Get staff successfully");
            return listStaffs;
        }
    }
}
