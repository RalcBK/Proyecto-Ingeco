using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository.dto;

namespace Ingeco.Service
{
    public interface IFacturaService:IService<Factura>
    {
        IEnumerable<FacturaDto> getFacturasByUserId(int userId);
    }
}