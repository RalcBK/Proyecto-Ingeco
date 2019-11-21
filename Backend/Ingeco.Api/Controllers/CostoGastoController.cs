using Ingeco.Entity;
using Ingeco.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ingeco.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CostoGastoController:ControllerBase
    {
        private ICostoGastoService costoGastoService;

        public CostoGastoController(ICostoGastoService costoGastoService)
        {
            this.costoGastoService = costoGastoService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                costoGastoService.GetAll()

            );
        }

        [HttpGet("{id}")]
        public ActionResult GetId(int id)
        {
            return Ok(
                costoGastoService.Get(id)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] CostoGasto entity)
        {
            return Ok(
                costoGastoService.Save(entity)
            );
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(
                costoGastoService.Delete(id)
            );
        }
    }
}