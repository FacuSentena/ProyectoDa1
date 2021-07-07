using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ExepcionContrasenaInvalida : Exception
    {
        public ExepcionContrasenaInvalida() : base("El largo de la contrasena no es valido")
        {

        }
    }
}
