using System.Collections.Generic;
using System.Linq;
using Ingeco.Entity;
using Ingeco.Repository.context;

namespace Ingeco.Repository.implementation
{
    public class FacturaRepository:IFacturaRepository
    {
        private ApplicationDbContext context;

        public FacturaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                var obj = context.Facturas.Single(
                    x => x.Id == id
                );
                context.Facturas.Remove(obj);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
            return true;
        }

        public Factura Get(int id)
        {
            var result = new Factura();
            try
            {
                result = context.Facturas.Single(x => x.Id == id);
            }
            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Factura> GetAll()
        {
            var result = new List<Factura>();
            try
            {
                result = context.Facturas.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Factura entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Factura entity)
        {
            try
            {
                var FacturaOriginal = context.Facturas.Single(
                    x => x.Id == entity.Id
                );

                FacturaOriginal.Id = entity.Id;
                FacturaOriginal.Serie = entity.Serie;
                FacturaOriginal.Correlativo = entity.Correlativo;
                FacturaOriginal.FechaVenta = entity.FechaVenta;
                FacturaOriginal.Monto = entity.Monto;
                FacturaOriginal.FechaVencimiento = entity.FechaVencimiento;
                FacturaOriginal.UsuarioId = entity.UsuarioId;
                FacturaOriginal.ClienteId = entity.ClienteId;

                context.Update(FacturaOriginal);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }
    }
}