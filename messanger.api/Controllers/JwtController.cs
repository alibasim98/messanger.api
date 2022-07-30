using messanger.core.Data;
using messanger.core.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace messanger.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        private readonly IJwtService jwtService;
        public JwtController(IJwtService _jwtService)
        {
            jwtService = _jwtService;
        }
        [HttpPost]
        public IActionResult Authen([FromBody] logins_api login)
        {
            var token = jwtService.Auth(login);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }


    }
}
