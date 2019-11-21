using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository.dto;

namespace Ingeco.Repository
{
    public interface IDescuentoRepository : IRepository<Descuento>
    {
        IEnumerable<DescuentoDto> getDescuentosFromFactura(int usuarioId);
    }
}