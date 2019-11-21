using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository.dto;

namespace Ingeco.Service
{
    public interface IDescuentoService:IService<Descuento>
    {
        IEnumerable<DescuentoDto> getDescuentosFromFactura(int userId);
        float getTceaTotal(int usuarioId);
    }
}