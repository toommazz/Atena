using AtenaApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AtenaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("Admins")]
        [Authorize(Roles = "Admin")]
        public IActionResult AdminsEndPoint()
        {
            var currentUser = GetCurrentUser();

            return Ok($"Hi {currentUser.FirstName}, you are an {currentUser.Role}");
        }

        [HttpGet("Public")]
        public IActionResult Public()
        {
            return Ok("Hi, you're on public property!");
        }

        private User GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;

                return new User
                {
                    Username = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                    EmailAddress = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
                    FirstName = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.GivenName)?.Value,
                    LastName = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Surname)?.Value,
                    Role = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value
                };
            }

            return null;
        }
    }
}

