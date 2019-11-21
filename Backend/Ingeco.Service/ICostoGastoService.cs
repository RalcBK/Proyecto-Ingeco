using System.Collections.Generic;
using Ingeco.Entity;

namespace Ingeco.Service
{
    public interface ICostoGastoService:IService<CostoGasto>
    {
        IEnumerable<CostoGasto> getCostosFromDescuento(int descuentoId);
        IEnumerable<CostoGasto> getCostosIniciales(int descuentoId);
        IEnumerable<CostoGasto> getCostosFinales(int descuentoId);
    }
}