using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository.dto;

namespace Ingeco.Repository
{
    public interface IFacturaRepository:IRepository<Factura>
    {
        IEnumerable<FacturaDto> getFacturasByUserId(int userId);
         
    }
}