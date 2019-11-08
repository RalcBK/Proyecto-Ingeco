using System.Collections.Generic;
using System.Linq;
using Ingeco.Entity;
using Ingeco.Repository.context;

namespace Ingeco.Repository.implementation
{
    public class CostoGastoRepository : ICostoGastoRepository
    {
        private ApplicationDbContext context;

        public CostoGastoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                var obj = context.CostosGastos.Single(
                    x => x.Id == id
                );
                context.CostosGastos.Remove(obj);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
            return true;
        }

        public CostoGasto Get(int id)
        {
            var result = new CostoGasto();
            try
            {
                result = context.CostosGastos.Single(x => x.Id == id);
            }
            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<CostoGasto> GetAll()
        {
            var result = new List<CostoGasto>();
            try
            {
                result = context.CostosGastos.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(CostoGasto entity)
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

        public bool Update(CostoGasto entity)
        {
            try
            {
                var CostoGastoOriginal = context.CostosGastos.Single(
                    x => x.Id == entity.Id
                );

                CostoGastoOriginal.Id = entity.Id;
                CostoGastoOriginal.Nombre = entity.Nombre;
                CostoGastoOriginal.Monto = entity.Monto;
                CostoGastoOriginal.Inicio = entity.Inicio;

                context.Update(CostoGastoOriginal);
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