using System;
using System.Runtime.Serialization;

namespace Dominio
{
    public class ExcepcionTarjetaDeCreditoYaExistente : Exception
    {
        public ExcepcionTarjetaDeCreditoYaExistente() : base("Esa tarjeta de credito ya fue agregada")
        {

        }
    }
}

