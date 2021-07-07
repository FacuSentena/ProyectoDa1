using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositorioFiltraciones<Filtracion, D>
    {
        ICollection<Filtracion> DarColeccion();

        Filtracion Obtener(D id);

        void Agregar(Filtracion buscador);

        ICollection<ParUsuarioContrasena> DarTodasContrasenasFiltradas();

        ICollection<TarjetaDeCredito> DarTodasTarjetasFiltradas();
    }
}
