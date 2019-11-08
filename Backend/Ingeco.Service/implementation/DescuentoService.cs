using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository;

namespace Ingeco.Service.implementation
{
    public class DescuentoService : IDescuentoService
    {
        private IDescuentoRepository descuentoRepository;
        public DescuentoService(IDescuentoRepository descuentoRepository)
        {
            this.descuentoRepository = descuentoRepository;
        }

        public bool Delete(int id)
        {
            return descuentoRepository.Delete(id);
        }

        public Descuento Get(int id)
        {
            return descuentoRepository.Get(id);
        }

        public IEnumerable<Descuento> GetAll()
        {
            return descuentoRepository.GetAll();
        }

        public bool Save(Descuento entity)
        {
            return descuentoRepository.Save(entity);
        }

        public bool Update(Descuento entity)
        {
            return descuentoRepository.Update(entity);
        }
    }
}