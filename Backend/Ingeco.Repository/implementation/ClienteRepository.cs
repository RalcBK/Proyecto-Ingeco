using System.Collections.Generic;
using System.Linq;
using Ingeco.Entity;
using Ingeco.Repository.context;

namespace Ingeco.Repository.implementation
{
    public class ClienteRepository:IClienteRepository
    {
        private ApplicationDbContext context;

        public ClienteRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                var obj = context.Clientes.Single(
                    x => x.Id == id
                );
                context.Clientes.Remove(obj);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
            return true;
        }

        public Cliente Get(int id)
        {
            var result = new Cliente();
            try
            {
                result = context.Clientes.Single(x => x.Id == id);
            }
            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Cliente> GetAll()
        {
            var result = new List<Cliente>();
            try
            {
                result = context.Clientes.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Cliente entity)
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

        public bool Update(Cliente entity)
        {
            try
            {
                var ClienteOriginal = context.Clientes.Single(
                    x => x.Id == entity.Id
                );

                ClienteOriginal.Id = entity.Id;
                ClienteOriginal.RUC = entity.RUC;
                ClienteOriginal.RazonSocial = entity.RazonSocial;
                ClienteOriginal.NombreComercial = entity.NombreComercial;
                ClienteOriginal.DomicilioFiscal = entity.DomicilioFiscal;

                context.Update(ClienteOriginal);
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