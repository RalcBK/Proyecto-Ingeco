using Ingeco.Entity;
using Ingeco.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ingeco.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        IUserValidationService uservalidationService;
        public JWTController(IUserValidationService uservalidationService)
        {
            this.uservalidationService = uservalidationService;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult LogIn([FromBody] Usuario userParam)
        {
            var user = this.uservalidationService.IsValidate(userParam.Email, userParam.Contraseña);
            if (user == null)
            {
                return BadRequest(new
                {
                    message = "UserName or Password is invalid"
                });
            }
            return Ok(user.Token);
        }

        [AllowAnonymous]
        [HttpPost("signup")]
        public IActionResult SignUp([FromBody] Usuario entity)
        {
            var user = this.uservalidationService.signUp(entity.Email, entity.Contraseña, entity.Nombres, entity.Apellidos, entity.FechaRegistro);
            if (user == null)
            {
                return BadRequest(new
                {
                    message = "Something went wrong on signIn"
                });
            }
            return Ok(user.Token);
        }
    }
}