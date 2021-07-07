using System;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
    public class ExcepcionNombreUsuarioInvalido : Exception
    {
        public ExcepcionNombreUsuarioInvalido()
        {

        }
    }
}