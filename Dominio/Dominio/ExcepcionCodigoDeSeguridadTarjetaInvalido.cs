using System;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
    public class ExcepcionCodigoDeSeguridadTarjetaInvalido : Exception
    {
        public ExcepcionCodigoDeSeguridadTarjetaInvalido() : base("Codigo de Seguridad invalido")
        {

        }
    }
}