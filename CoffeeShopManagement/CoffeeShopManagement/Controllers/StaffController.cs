using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoffeeShopManagement.Models;
using CoffeeShopManagement.Interfaces;

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
        public IEnumerable<Staff> GetStaff()
        {
            var listStaff = _staffManagement.GetListStaff();
            return listStaff;
        }
    }
}
