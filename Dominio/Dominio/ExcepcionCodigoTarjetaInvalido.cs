using System;
using System.Runtime.Serialization;

namespace Dominio
{
    public class ExcepcionCodigoTarjetaInvalido : Exception
    {
        public ExcepcionCodigoTarjetaInvalido() : base("CodigoDeTarjetaInvalido")
        {

        }
    }
}