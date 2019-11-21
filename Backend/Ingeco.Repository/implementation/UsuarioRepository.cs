using System;
using System.Collections.Generic;
using System.Linq;
using Ingeco.Entity;
using Ingeco.Repository.context;

namespace Ingeco.Repository.implementation
{
    public class UsuarioRepository:IUsuarioRepository
    {
        private ApplicationDbContext context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                var obj = context.Usuarios.Single(
                    x => x.Id == id
                );
                context.Usuarios.Remove(obj);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
            return true;
        }

        public Usuario Get(int id)
        {
            var result = new Usuario();
            try
            {
                result = context.Usuarios.Single(x => x.Id == id);
            }
            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Usuario> GetAll()
        {
            var result = new List<Usuario>();
            try
            {
                result = context.Usuarios.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public Usuario getByEmail(string email)
        {
            var result = new Usuario();
            try
            {
                result = context.Usuarios.SingleOrDefault(x => x.Email == email);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error en getByEmail de repositorio");
                throw;
            }
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public Usuario logIn(string email, string contraseña)
        {
            var result = new Usuario();

            try
            {
                result = context.Usuarios.SingleOrDefault(x => x.Email == email);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error en logIn de repositorio");
                Console.WriteLine(result);
                throw;
            }

            if (result != null)
            {
                if(result.Contraseña != contraseña)
                {
                    Console.WriteLine("Contraseña incorrecta");
                    return null;
                }
                else
                {
                    return result;
                }
            }
            else
            {
                Console.WriteLine("Email incorrecto");
                return result;
            }
        }

        public bool Save(Usuario entity)
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


        public bool Update(Usuario entity)
        {
            try
            {
                var UsuarioOriginal = context.Usuarios.Single(
                    x => x.Id == entity.Id
                );

                UsuarioOriginal.Id = entity.Id;
                UsuarioOriginal.Email = entity.Email;
                UsuarioOriginal.Contraseña = entity.Contraseña;
                UsuarioOriginal.Nombres = entity.Nombres;
                UsuarioOriginal.Apellidos = entity.Apellidos;
                UsuarioOriginal.FechaRegistro = entity.FechaRegistro;

                context.Update(UsuarioOriginal);
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
