using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository;

namespace Ingeco.Service.implementation
{
    public class CostoGastoService : ICostoGastoService
    {
        private ICostoGastoRepository costoGastoRepository;
        public CostoGastoService(ICostoGastoRepository costoGastoRepository)
        {
            this.costoGastoRepository = costoGastoRepository;
        }

        public bool Delete(int id)
        {
            return costoGastoRepository.Delete(id);
        }

        public CostoGasto Get(int id)
        {
            return costoGastoRepository.Get(id);
        }

        public IEnumerable<CostoGasto> GetAll()
        {
            return costoGastoRepository.GetAll();
        }

        public bool Save(CostoGasto entity)
        {
            return costoGastoRepository.Save(entity);
        }

        public bool Update(CostoGasto entity)
        {
            return costoGastoRepository.Update(entity);
        }
    }
}