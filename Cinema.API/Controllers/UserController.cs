using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken token)
        {
            var user = _mapper.Map<User>(request);
            var response = await _UserService.CreateAsync(user, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }

    }
}
