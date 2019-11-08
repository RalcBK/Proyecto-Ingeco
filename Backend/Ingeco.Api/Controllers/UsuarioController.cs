using Ingeco.Entity;
using Ingeco.Service;
using Microsoft.AspNetCore.Mvc;

namespace Ingeco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController:ControllerBase
    {
        private IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                usuarioService.GetAll()

            );
        }

        [HttpGet("{id}")]
        public ActionResult GetId(int id)
        {
            return Ok(
                usuarioService.Get(id)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario entity)
        {
            return Ok(
                usuarioService.Save(entity)
            );
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(
                usuarioService.Delete(id)
            );
        }
    }
}