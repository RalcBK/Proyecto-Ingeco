using System.Collections.Generic;
using Ingeco.Entity;

namespace Ingeco.Service
{
    public interface IFacturaService:IService<Factura>
    {
        IEnumerable<Factura> getFacturasByUserId(int userId);
    }
}