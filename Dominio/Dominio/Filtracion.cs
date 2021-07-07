using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Filtracion
    {
        public Filtracion()
        {

        }

        public virtual int Id { get; set; }

        public virtual DateTime FechaCreacion { get; set; }

        public virtual ICollection<ParUsuarioContrasena> ParesDeLaFiltracion { get; set; }

        public virtual ICollection<TarjetaDeCredito> TarjetasDeLaFiltracion { get; set; }

        public virtual void BuscarFiltracionesDeContrasenas(ICollection<ParUsuarioContrasena> paresTotales, string datosExpuestos)
        {

        }

        public ICollection<Contrasena> MostrarContrasenasFiltradas()
        {
            ICollection<Contrasena> contrasenasARetornar = new List<Contrasena>();
            foreach (ParUsuarioContrasena par in this.ParesDeLaFiltracion)
            {
                contrasenasARetornar.Add(par.Contrasena);
            }
            return contrasenasARetornar;
        }

        public virtual void BuscarFiltracionesDeTarjetas(ICollection<TarjetaDeCredito> tarjetasTotales, string datosExpuestos)
        {

        }

        public override string ToString()
        {
            return "Id: " + this.Id + "  Fecha: " + this.FechaCreacion;
        }
    }
}
