using System.Collections.Generic;
using Ingeco.Entity;
using Ingeco.Repository;

namespace Ingeco.Service.implementation
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public bool Delete(int id)
        {
            return usuarioRepository.Delete(id);
        }

        public Usuario Get(int id)
        {
            return usuarioRepository.Get(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return usuarioRepository.GetAll();
        }

        public Usuario getByEmail(string email)
        {
            return usuarioRepository.getByEmail(email);
        }

        public Usuario logIn(string email, string contraseña)
        {
            return usuarioRepository.logIn(email, contraseña);
        }

        public bool Save(Usuario entity)
        {
            return usuarioRepository.Save(entity);
        }

        public bool Update(Usuario entity)
        {
            return usuarioRepository.Update(entity);
        }
    }
}