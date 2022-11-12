using Microsoft.AspNetCore.Mvc;

namespace WebApiNet7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public User Get(string name, int points)
        {
            return new() { Name = name, Points = points };
        }
    }
}