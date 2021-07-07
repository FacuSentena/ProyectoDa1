using System;
using System.Runtime.Serialization;

namespace Dominio
{
    public class ExcepcionParUsuarioContrasenaNoExistente : Exception
    {
        public ExcepcionParUsuarioContrasenaNoExistente() : base("El par usuario-contraseña no existe")
        {

        }
    }
}
