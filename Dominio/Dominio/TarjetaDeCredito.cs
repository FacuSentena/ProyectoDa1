using System;
using System.Collections.Generic;

namespace Dominio
{
    public class TarjetaDeCredito
    {
        public int Id { get; set;}

        public string Codigo { get; set; }

        public string Nota { get; set; }

        public string CodigoDeSeguridad { get; set; }

        public string FechaVencimiento { get; set; }

        public Categoria Categoria { get; set; }

        public string Tipo { get; set; }

        public string Nombre { get; set; }

        public TarjetaDeCredito()
        {

        }

        public TarjetaDeCredito(string unNombre, Categoria unaCategoria)
        {
            this.Nombre = unNombre;
            this.Categoria = unaCategoria;
        }

        public void ModificarNombre(string unNombre)
        {
            if (this.NombreTarjetaDeCreditoValido(unNombre))
            {
                this.Nombre = unNombre;
            }
            else
            {
                throw new ExcepcionTarjetaDeCreditoNombreInvalido();
            }
        }

        private bool NombreTarjetaDeCreditoValido(string unNombre)
        {
            return unNombre.Length >= 3 && unNombre.Length < 25;
        }

        public void AsignarCodigo(string unCodigo)
        {
            if (unCodigo.Length == 16)
            {
                this.Codigo = unCodigo;
            }
            else
            {
                throw new ExcepcionCodigoTarjetaInvalido();
            }
        }

        public void AsignarCodigoDeSeguridad(string codigoSeguridad)
        {
            if (codigoSeguridad.Length == 3 || codigoSeguridad.Length == 4)
            {
                this.CodigoDeSeguridad = codigoSeguridad;
            }
            else
            {
                throw new ExcepcionCodigoDeSeguridadTarjetaInvalido();
            }
        }

        public string DarDatosSeguros()
        {
            return "Categoría: " + this.Categoria + " Nombre: " + this.Nombre
                + " Tipo: " + this.Tipo + " Código: " + this.MostrarCodigoSeguro() + " Vencimiento: " + this.FechaVencimiento;
        }

        public string MostrarCodigoSeguro()
        {
            string codigoSinOcultar = MostrarCodigo();
            char[] codigoSinOcultarEnArray = codigoSinOcultar.ToCharArray();
            int ultimaPosicionOculta = 13;
            for (int posicionAOcultar = 0; posicionAOcultar <= ultimaPosicionOculta; posicionAOcultar++)
            {
                if (codigoSinOcultarEnArray[posicionAOcultar] != ' ')
                {
                    codigoSinOcultarEnArray[posicionAOcultar] = 'X';
                }
            }
            string codigoOculto = new string(codigoSinOcultarEnArray);
            return codigoOculto;
        }

        public string MostrarCodigo()
        {
            string primerTira = ObtenerTiraDeCaracteres(Codigo, 0, 3);
            string segundaTira = ObtenerTiraDeCaracteres(Codigo, 4, 7);
            string tercerTira = ObtenerTiraDeCaracteres(Codigo, 8, 11);
            string ultimaTira = ObtenerTiraDeCaracteres(Codigo, 12, 15);
            return primerTira + " " + segundaTira + " " + tercerTira + " " + ultimaTira;
        }

        private string ObtenerTiraDeCaracteres(string stringADividir, int posicionInicio, int posicionLimite)
        {
            string stringDividido = "";
            for (int i = posicionInicio; i <= posicionLimite; i++)
            {
                stringDividido += stringADividir[i];
            }
            return stringDividido;
        }


        public override string ToString()
        {
            return "Categoría: " + this.Categoria + " Nombre: " + this.Nombre
             + " Tipo: " + this.Tipo + " Código de Seguridad: "
             + this.CodigoDeSeguridad + " Código: " + this.MostrarCodigo() + " Vencimiento: " + this.FechaVencimiento + " Notas:" + this.Nota;
        }

        public override bool Equals(object obj)
        {
            TarjetaDeCredito tarjeta = obj as TarjetaDeCredito;

            if (tarjeta == null) return false;

            return this.Codigo == (tarjeta.Codigo);
        }
    }
}