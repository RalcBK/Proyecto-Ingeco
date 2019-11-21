using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Ingeco.Entity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Ingeco.Service.implementation
{
    public class UserValidationService: IUserValidationService
    {
        private IUsuarioService usuarioService;
        private readonly AppSettings _appSettings;

        public UserValidationService(IOptions<AppSettings> appSettings, IUsuarioService usuarioService)
        {
            this._appSettings = appSettings.Value;
            this.usuarioService = usuarioService;
        }


        public Usuario IsValidate(string email, string password)
        {
            var user = usuarioService.logIn(email, password);
            if (user == null)
            {
                return null;
            }
            var key = Encoding.ASCII.GetBytes(this._appSettings.Secret);
            var jwtToken = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), 
                SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(jwtToken);
            user.Token = tokenHandler.WriteToken(token);
            return user;
        }

        public Usuario signUp(string email, string password, string nombres, string apellidos, DateTime fecha)
        {
            var exists = usuarioService.getByEmail(email);
            if (exists != null)
            {
                return null;
            }
            var usuario = new Usuario();
            usuario.Email = email;
            usuario.Contraseña = password;
            usuario.Nombres = nombres;
            usuario.Apellidos = apellidos;
            usuario.FechaRegistro = fecha;
            var flag = usuarioService.Save(usuario);

            if (flag)
            {
                var user = usuarioService.getByEmail(email);
                var key = Encoding.ASCII.GetBytes(this._appSettings.Secret);
                var jwtToken = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(jwtToken);
                user.Token = tokenHandler.WriteToken(token);
                return user;
            }
            else
            {
                Console.WriteLine("Problema al guardar usuario, UserValidationService");
                return null;
            }
        }
    }
}