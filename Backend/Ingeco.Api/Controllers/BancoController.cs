using Ingeco.Entity;
using Ingeco.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ingeco.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {
        private IBancoService bancoService;

        public BancoController(IBancoService bancoService)
        {
            this.bancoService = bancoService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                bancoService.GetAll()
            );
        }

        [HttpGet("{id}")]
        public ActionResult GetId(int id)
        {
            return Ok(
                bancoService.Get(id)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Banco entity)
        {
            return Ok(
                bancoService.Save(entity)
            );
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok(
                bancoService.Delete(id)
            );
        }
    }
}