using Ingeco.Entity;

namespace Ingeco.Service
{
    public interface IUsuarioService:IService<Usuario>
    {
        Usuario logIn(string email, string contraseña);
        Usuario getByEmail(string email);
    }
}