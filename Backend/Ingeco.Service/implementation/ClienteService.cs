using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository;

namespace Ingeco.Service.implementation
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public bool Delete(int id)
        {
            return clienteRepository.Delete(id);
        }

        public Cliente Get(int id)
        {
            return clienteRepository.Get(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return clienteRepository.GetAll();
        }

        public bool Save(Cliente entity)
        {
            return clienteRepository.Save(entity);
        }

        public bool Update(Cliente entity)
        {
            return clienteRepository.Update(entity);
        }
    }
}