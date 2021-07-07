using System;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
    public class ExcepcionNoExisteCategoria : Exception
    {
        public ExcepcionNoExisteCategoria() : base("No existe la categoria en la lista de categorias")
        {

        }
    }
}