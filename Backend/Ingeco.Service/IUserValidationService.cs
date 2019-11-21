using System;
using Ingeco.Entity;

namespace Ingeco.Service
{
    public interface IUserValidationService
    {
        Usuario IsValidate(string email, string password);
        Usuario signUp(string email, string password, string nombres, string appellidos, DateTime fecha);
        
    }
}