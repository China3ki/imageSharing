using imageSharing.Entities;
using imageSharing.Services;
using imageSharing.Shared.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace imageSharing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController(ImagesharingContext ctx, AccountService accountService, IPasswordHasher<User> hasher) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterDto registerDto)
        {
            bool accountExist = await accountService.CheckIfAccountExist(registerDto.Email);
            if (accountExist) return NotFound("User with that email already exist!");
            User user = new()
            {
                Nickname = registerDto.Nickname,
                Email = registerDto.Email,
                Date = DateOnly.FromDateTime(DateTime.Now)
            };
            // Hash password
            string hashedPassword = hasher.HashPassword(user, registerDto.Password);
            user.Password = hashedPassword;

            ctx.Add<User>(user);
            await ctx.SaveChangesAsync();
            return Created();
        }
    }
}
