using System;
using System.Threading.Tasks;
using Ingeco.Entity;
using Ingeco.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ingeco.Api.Controllers
{
    [Authorize]
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
                facturaService.getFacturasByUserId(Int32.Parse(User.Identity.Name))

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
            Console.WriteLine("Asignando ID");
            Console.WriteLine(User.Identity.Name);
            entity.UsuarioId = Int32.Parse(User.Identity.Name);
            Console.WriteLine("Asigno bien");
            Console.WriteLine(entity.UsuarioId);
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