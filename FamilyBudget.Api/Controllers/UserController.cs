using FamilyBudget.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController() { }

        [HttpGet]
        public async Task<ActionResult<UserDto>> GetUserAsync(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<RegisterUserDto>> RegisterUserAsync(RegisterUserDto user)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<RegisterUserDto>> UpdateUserAsync(UpdateUserDto user)
        {

            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<RegisterUserDto>> DeleteUserAsync(int id)
        {

            return Ok();
        }
    }
}
