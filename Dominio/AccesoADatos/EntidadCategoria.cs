using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class EntidadCategoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<EntidadTarjetaDeCredito> Tarjetas { get; set; }

        public virtual ICollection<EntidadParUsuarioContrasena> Pares { get; set; }
    }

}
