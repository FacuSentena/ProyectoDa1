using System;
using System.Runtime.Serialization;

namespace Dominio
{
    public class ExcepcionTarjetaDeCreditoNombreInvalido : Exception
    {
        public ExcepcionTarjetaDeCreditoNombreInvalido() : base("Nombre invalido de tarjeta de credito")
        {

        }
    }
}