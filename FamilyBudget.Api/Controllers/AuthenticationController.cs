using FamilyBudget.Api.Dtos;
using FamilyBudget.DataAccess.Entities.Account;
using FamilyBudget.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FamilyBudget.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;

        public AuthenticationController(UserManager<User> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userManager.FindByEmailAsync(loginDto.Login);
            if (user == null)
            {
                return BadRequest("Bad credentials");
            }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (!isPasswordValid)
            {
                return BadRequest("Bad credentials");
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var jwtToken = this._tokenService.CreateToken(user, userRoles);

            return Ok(new
            {
                Username = user.UserName,
                Token = jwtToken
            });
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterUserDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userManager.CreateAsync(new User { UserName = request.UserName, Email = request.Email }, request.Password);

            if (!result.Succeeded)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByNameAsync(request.UserName);

            var addToRoleResult = await _userManager.AddToRoleAsync(user, "AppUser");

            if (!addToRoleResult.Succeeded)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
