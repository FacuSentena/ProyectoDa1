using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class EntidadUsuario
    {
        public int Id { get; set; }

        public EntidadContrasenaMaestra ConstrasenaMaestra { get; set; }

        public virtual ICollection<EntidadCategoria> Categorias { get; set; }
    }
}
