using Ingeco.Entity;
using Ingeco.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ingeco.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController:ControllerBase
    {
        private IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                clienteService.GetAll()

            );
        }

        [HttpGet("{id}")]
        public ActionResult GetId(int id)
        {
            return Ok(
                clienteService.Get(id)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cliente entity)
        {
            return Ok(
                clienteService.Save(entity)
            );
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(
                clienteService.Delete(id)
            );
        }
    }
}