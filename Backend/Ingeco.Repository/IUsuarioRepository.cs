using System;
using Ingeco.Entity;

namespace Ingeco.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario logIn(string email, string contraseña);
        Usuario getByEmail(string email);
    }
}