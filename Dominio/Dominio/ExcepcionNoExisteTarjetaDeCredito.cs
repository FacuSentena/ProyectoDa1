using System;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
    public class ExcepcionNoExisteTarjetaDeCredito : Exception
    {
        public ExcepcionNoExisteTarjetaDeCredito() : base("No existe esta tarjeta de credito")
        {

        }
    }
}