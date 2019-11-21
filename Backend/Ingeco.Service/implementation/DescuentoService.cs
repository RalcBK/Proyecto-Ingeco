using System;
using System.Collections.Generic;
using System.Linq;
using Ingeco.Entity;
using Ingeco.Repository;
using Ingeco.Repository.dto;

namespace Ingeco.Service.implementation
{
    public class DescuentoService : IDescuentoService
    {
        private IDescuentoRepository descuentoRepository;
        private IFacturaService facturaService;
        public DescuentoService(IDescuentoRepository descuentoRepository, IFacturaService facturaService)
        {
            this.descuentoRepository = descuentoRepository;
            this.facturaService = facturaService;
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

        public IEnumerable<DescuentoDto> getDescuentosFromFactura(int userId)
        {
            return descuentoRepository.getDescuentosFromFactura(userId);
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