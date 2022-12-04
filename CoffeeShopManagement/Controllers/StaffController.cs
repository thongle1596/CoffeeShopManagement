using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoffeeShopManagement.Models;
using CoffeeShopManagement.Interfaces;
using System.Threading.Tasks;

namespace CoffeeShopManagement.Controllers
{
    [ApiController]
    [Route("api/staff")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffManagement _staffManagement;
        public StaffController(IStaffManagement staffManagement)
        {
            _staffManagement = staffManagement;
        }

        [HttpGet]
        public async Task<IEnumerable<Staff>> GetStaffAsync()
        {
            var listStaff = await _staffManagement.GetListStaff();
            if(listStaff == null)
            {
                Log.Info("List staff Empty");
            }
            else
            {
                Log.Info("Get staff successfully");
            }
            return listStaff;
        }
    }
}
