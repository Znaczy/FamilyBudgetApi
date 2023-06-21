using FamilyBudget.Api.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController() { }

        [HttpGet("admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult Test1(int id)
        {
            
            return Ok();
        }

        [HttpGet("appuser")]
        [Authorize(Roles = "AppUser")]
        public IActionResult Test2(int id)
        {

            return Ok();
        }
    }
}
