using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AccesoADatos
{
    public class EntidadContrasena
    {
        public int Id { get; set; }

        public string Clave { get; set; }

        public string GrupoDeFortaleza { get; set; }

        public DateTime UltimaModificacion { get; set; }
    }
}
