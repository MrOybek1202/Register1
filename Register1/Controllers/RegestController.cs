using Microsoft.AspNetCore.Mvc;
using Register1.Model;
using Register1.Repostory;

namespace Register1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RegestController : ControllerBase
    {
        private readonly IService _service;

        public RegestController(IService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> SignUpAsync([FromForm] User user)
        {
            bool res = await _service.SignUpAsync(user);
            if (res == false)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> LogInAsync(string email, string password)
        {
            var res = await _service.LogInAsync(email, password);
            if (res == false)
            {
                return NotFound();
            }
            return Ok(res);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDataAsync()
        {
            var res = await _service.GetAllUsersAsync();
            if(res == null)
            {
                return NoContent();

            }
            return Ok(res);
        }
        [HttpGet]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var res = await _service.GetByIDAsync(id);
            if (res == null)
            {
                return NotFound();

            }
            return Ok(res);
        }
        [HttpDelete]
        public async Task<IActionResult> ISDalate(int id)
        {
            bool res = await _service.RemoveUserAsync(id);
            if(res == false)
            {
                return NotFound();

            }
            return Ok(res);
        }
    }

}
