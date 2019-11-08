using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository;

namespace Ingeco.Service.implementation
{
    public class BancoService : IBancoService
    {
        private IBancoRepository bancoRepository;
        public BancoService(IBancoRepository bancoRepository)
        {
            this.bancoRepository = bancoRepository;
        }
        
        public bool Delete(int id)
        {
            return bancoRepository.Delete(id);
        }

        public Banco Get(int id)
        {
            return bancoRepository.Get(id);
        }

        public IEnumerable<Banco> GetAll()
        {
            return bancoRepository.GetAll();
        }

        public bool Save(Banco entity)
        {
            return bancoRepository.Save(entity);
        }

        public bool Update(Banco entity)
        {
            return bancoRepository.Update(entity);
        }
    }
}