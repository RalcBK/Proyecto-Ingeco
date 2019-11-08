using Ingeco.Entity;
using Ingeco.Service;
using Microsoft.AspNetCore.Mvc;

namespace Ingeco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController:ControllerBase
    {
        private IFacturaService facturaService;

        public FacturaController(IFacturaService facturaService)
        {
            this.facturaService = facturaService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                facturaService.GetAll()

            );
        }

        [HttpGet("{id}")]
        public ActionResult GetId(int id)
        {
            return Ok(
                facturaService.Get(id)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Factura entity)
        {
            return Ok(
                facturaService.Save(entity)
            );
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(
                facturaService.Delete(id)
            );
        }
    }
}