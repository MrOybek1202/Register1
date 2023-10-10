using Microsoft.AspNetCore.Mvc;
using Register1.Model;
using Register1.Repostory;

namespace Register1.Controllers
{
    [ApiController]
    [Route("api/[controler]/[action]")]
    public class RegestController : Controller
    {
        private readonly Servace _service;

        public RegestController(Servace service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> SignUp([FromForm] User user)
        {
            bool res = await _service.SignUpAsync(user);
            if (res == false)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> LogIn(string email, string password)
        {
            var res = await _service.LogIn(email, password);
            if (res == false)
            {
                return NotFound();
            }
            return Ok();
        }
    }

}
