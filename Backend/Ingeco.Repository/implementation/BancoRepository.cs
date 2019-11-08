using System.Collections.Generic;
using System.Linq;
using Ingeco.Entity;
using Ingeco.Repository.context;

namespace Ingeco.Repository.implementation
{
    public class BancoRepository : IBancoRepository
    {
        private ApplicationDbContext context;

        public BancoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                var obj = context.Bancos.Single(
                    x => x.Id == id
                );
                context.Bancos.Remove(obj);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
            return true;
        }

        public Banco Get(int id)
        {
            var result = new Banco();
            try
            {
                result = context.Bancos.Single(x => x.Id == id);
            }
            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Banco> GetAll()
        {
            var result = new List<Banco>();
            try
            {
                result = context.Bancos.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Banco entity)
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

        public bool Update(Banco entity)
        {
            try
            {
                var BancoOriginal = context.Bancos.Single(
                    x => x.Id == entity.Id
                );

                BancoOriginal.Id = entity.Id;
                BancoOriginal.Nombre = entity.Nombre;
                BancoOriginal.RUC = entity.RUC;
                BancoOriginal.RazonSocial = entity.RazonSocial;

                context.Update(BancoOriginal);
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