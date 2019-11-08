using System.Collections.Generic;
using System.Linq;
using Ingeco.Entity;
using Ingeco.Repository.context;

namespace Ingeco.Repository.implementation
{
    public class DescuentoRepository : IDescuentoRepository
    {
        private ApplicationDbContext context;

        public DescuentoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        public bool Delete(int id)
        {
            try
            {
                var obj = context.Descuentos.Single(
                    x => x.Id == id
                );
                context.Descuentos.Remove(obj);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
            return true;
        }

        public Descuento Get(int id)
        {
            var result = new Descuento();
            try
            {
                result = context.Descuentos.Single(x => x.Id == id);
            }
            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Descuento> GetAll()
        {
            var result = new List<Descuento>();
            try
            {
                result = context.Descuentos.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Descuento entity)
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

        public bool Update(Descuento entity)
        {
            try
            {
                var DescuentoOriginal = context.Descuentos.Single(
                    x => x.Id == entity.Id
                );

                DescuentoOriginal.Id = entity.Id;
                DescuentoOriginal.Fecha = entity.Fecha;
                DescuentoOriginal.Tasa = entity.Tasa;
                DescuentoOriginal.MontoDescontado = entity.MontoDescontado;
                DescuentoOriginal.TEA = entity.TEA;
                DescuentoOriginal.TCEA = entity.TCEA;
                DescuentoOriginal.FacturaId = entity.FacturaId;
                DescuentoOriginal.BancoId = entity.BancoId;

                context.Update(DescuentoOriginal);
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