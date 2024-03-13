using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoniFlexApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet, ActionName("/")]
        public async Task<IActionResult> getAllUsers()
        {
            return new JsonResult(0);
        }

        [HttpGet("{id}"), ActionName("/")]
        public async Task<IActionResult> GetUserById(int? id)
        {
            return new JsonResult(new { id });
        }
    }
}
