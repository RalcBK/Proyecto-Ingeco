using Ingeco.Entity;
using Ingeco.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ingeco.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DescuentoController:ControllerBase
    {
        private IDescuentoService descuentoService;

        public DescuentoController(IDescuentoService descuentoService)
        {
            this.descuentoService = descuentoService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                descuentoService.GetAll()

            );
        }

        [HttpGet("{id}")]
        public ActionResult GetId(int id)
        {
            return Ok(
                descuentoService.Get(id)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Descuento entity)
        {
            return Ok(
                descuentoService.Save(entity)
            );
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(
                descuentoService.Delete(id)
            );
        }
    }
}