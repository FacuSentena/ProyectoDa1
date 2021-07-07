using System;
using System.Collections.Generic;

namespace Dominio
{
    public interface IFiltracion
    {
        DateTime ObtenerId();

        void AsignarId(DateTime id);

        void BuscarFiltracionesDeContrasenas(ICollection<ParUsuarioContrasena> paresTotales, string unTexto);

        void BuscarFiltracionesDeTarjetas(ICollection<TarjetaDeCredito> tarjetasTotales, string unTexto);
    }
}