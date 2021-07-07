using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ContrasenaMaestra : Contrasena
    {

        public ContrasenaMaestra(string unaClave) : base(unaClave)
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
