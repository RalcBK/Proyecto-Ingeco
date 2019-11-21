using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository;

namespace Ingeco.Service.implementation
{
    public class FacturaService : IFacturaService
    {
        private IFacturaRepository facturaRepository;
        public FacturaService(IFacturaRepository facturaRepository)
        {
            this.facturaRepository = facturaRepository;
        }

        public bool Delete(int id)
        {
            return facturaRepository.Delete(id);
        }

        public Factura Get(int id)
        {
            return facturaRepository.Get(id);
        }

        public IEnumerable<Factura> GetAll()
        {
            return facturaRepository.GetAll();
        }

        public IEnumerable<Factura> getFacturasByUserId(int userId)
        {
            return facturaRepository.getFacturasByUserId(userId);
        }

        public bool Save(Factura entity)
        {
            return facturaRepository.Save(entity);
        }

        public bool Update(Factura entity)
        {
            return facturaRepository.Update(entity);
        }
    }
}