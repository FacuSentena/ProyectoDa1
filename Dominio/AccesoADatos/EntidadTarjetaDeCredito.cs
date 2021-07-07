using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class EntidadTarjetaDeCredito
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nota { get; set; }

        public string CodigoDeSeguridad { get; set; }

        public string FechaVencimiento { get; set; }

        public EntidadCategoria Categoria { get; set; }

        public string Tipo { get; set; }

        public string Nombre { get; set; }

        public bool EstaBorrada { get; set; }

        public virtual ICollection<EntidadFiltracion> Filtraciones { get; set; }
    }
}
