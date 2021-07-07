using System;
using System.Runtime.Serialization;

namespace Dominio
{

    public class ExcepcionParUsuarioContrasenaYaExistente : Exception
    {
        public ExcepcionParUsuarioContrasenaYaExistente() : base("Ya existe un usuario con ese nombre para ese sitio")
        {

        }
    }
}
