using System;
using System.Collections.Generic;

namespace Dominio
{
    public class FiltracionTexto : Filtracion
    {
        public FiltracionTexto() 
        {
            ParesDeLaFiltracion = new List<ParUsuarioContrasena>();
            TarjetasDeLaFiltracion = new List<TarjetaDeCredito>();
        }

        public override void BuscarFiltracionesDeContrasenas(ICollection<ParUsuarioContrasena> paresTotales, string datosExpuestos)
        {
            string[] datosEnArray = ContenerEnArray(datosExpuestos);
            List<ParUsuarioContrasena> paresExpuestos = new List<ParUsuarioContrasena>();
            foreach (string dato in datosEnArray)
            {
                ParUsuarioContrasena parConContrasenaCoincidente = BuscarParesCoincidentes(dato, paresTotales);
                if (parConContrasenaCoincidente != null)
                {
                    paresExpuestos.Add(parConContrasenaCoincidente);
                }
            }
            ParesDeLaFiltracion = paresExpuestos;
        }

        public override void BuscarFiltracionesDeTarjetas(ICollection<TarjetaDeCredito> tarjetasTotales, string datosExpuestos)
        {
            string[] datosEnArray = ContenerEnArray(datosExpuestos);
            List<TarjetaDeCredito> tarjetasExpuestas = new List<TarjetaDeCredito>();
            foreach (string dato in datosEnArray)
            {
                TarjetaDeCredito tarjetaCoincidente = BuscarTarjetasCoincidentes(dato, tarjetasTotales);
                if (tarjetaCoincidente != null)
                {
                    tarjetasExpuestas.Add(tarjetaCoincidente);
                }
            }
            TarjetasDeLaFiltracion = tarjetasExpuestas;
        }

        private string[] ContenerEnArray(string datosSinProcesar)
        {
            char guionSeparador = '-';
            return datosSinProcesar.Split(guionSeparador);

        }

        private TarjetaDeCredito BuscarTarjetasCoincidentes(string dato, ICollection<TarjetaDeCredito> tarjetas)
        {
            string espacioEnBlanco = " ";
            if (dato.Contains(espacioEnBlanco))
            {
                dato = DarCodigoDeTarjetaSinEspacios(dato);
            }
            ICollection<TarjetaDeCredito> listaDeTarjetas;
            listaDeTarjetas = tarjetas;
            foreach (TarjetaDeCredito tarjeta in listaDeTarjetas)
            {
                if (tarjeta.Codigo == dato)
                {
                    return tarjeta;
                }
            }
            return null;
        }

        private string DarCodigoDeTarjetaSinEspacios(string posibleCodigoExpuesto)
        {
            string[] codigoDeACuatroDigitos = posibleCodigoExpuesto.Split(' ');
            string posibleCodigoExpuestoSinEspacios = codigoDeACuatroDigitos[0]
                + codigoDeACuatroDigitos[1] + codigoDeACuatroDigitos[2] + codigoDeACuatroDigitos[3];
            return posibleCodigoExpuestoSinEspacios;
        }

        private ParUsuarioContrasena BuscarParesCoincidentes(string dato, ICollection<ParUsuarioContrasena> pares)
        {
            ICollection<ParUsuarioContrasena> listaDePares;
            listaDePares = pares;
            foreach (ParUsuarioContrasena par in listaDePares)
            {
                if (par.Contrasena.Clave == dato)
                {
                    return par;
                }
            }
            return null;
        }
    }
}