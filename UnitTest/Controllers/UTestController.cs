using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Models;

namespace UnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UTestController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateStaff([FromBody] UTest staff)
        {
            // Your implementation to create a new staff in the database using Dapper or other ORM
            // Example code:
            string result = Add(staff.Name, staff.Email, staff.MobileNumber);

            return Ok(result);
        }

        private string Add(string name, string email, string mobileNumber)
        {
            return name + email + mobileNumber;
        }
    }
}
