using System.Collections.Generic;
using Ingeco.Entity;

namespace Ingeco.Repository
{
    public interface IFacturaRepository:IRepository<Factura>
    {
        IEnumerable<Factura> getFacturasByUserId(int userId);
         
    }
}