using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class EntidadParUsuarioContrasena
    {
        public int Id { get; set; }

        public string NombreDeUsuario { get; set; }

        public string Sitio { get; set; }

        public EntidadCategoria Categoria { get; set; }

        public EntidadContrasena Contrasena { get; set; }

        public string Nota { get; set; }

        public bool EstaBorrada { get; set; }

        public bool FueModificada { get; set; }

        public virtual ICollection<EntidadFiltracion> Filtraciones { get; set; }
    }
}
