using System;
using System.Runtime.Serialization;

namespace Dominio
{
    public class ExcepcionCategoriaYaExistente : Exception
    {
        public ExcepcionCategoriaYaExistente() : base("Ya existe una categoria con ese nombre")
        {

        }
    }
}