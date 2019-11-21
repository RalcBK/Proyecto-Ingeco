using System.Collections.Generic;
using Ingeco.Entity;

namespace Ingeco.Repository
{
    public interface ICostoGastoRepository: IRepository<CostoGasto>
    {
        IEnumerable<CostoGasto> getCostosFromDescuento(int descuentoId);
        IEnumerable<CostoGasto> getCostosIniciales(int descuentoId);
        IEnumerable<CostoGasto> getCostosFinales(int descuentoId);
    }
}