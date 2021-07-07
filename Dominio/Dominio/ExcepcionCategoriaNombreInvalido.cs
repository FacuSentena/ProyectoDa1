using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ExcepcionCategoriaNombreInvalido : Exception
    {
        public ExcepcionCategoriaNombreInvalido() : base("El largo del nombre de la categoria no es valido")
        {

        }
    }
}
