using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    class ContextoGestorBd : DbContext
    {
        public ContextoGestorBd() : base("name=BdGestor")
        {

        }

        public DbSet<EntidadUsuario> Usuarios { get; set; }

        public DbSet<EntidadCategoria> Categorias { get; set; }

        public DbSet<EntidadContrasena> Contrasenas { get; set; }

        public DbSet<EntidadContrasenaMaestra> ContrasenaMaestras { get; set; }

        public DbSet<EntidadParUsuarioContrasena> Pares { get; set; }

        public DbSet<EntidadTarjetaDeCredito> Tarjetas { get; set; }

        public DbSet<EntidadFiltracion> Filtraciones { get; set; }
    }
}
