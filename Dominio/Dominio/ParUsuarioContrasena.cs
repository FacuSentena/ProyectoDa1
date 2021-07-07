using System;

namespace Dominio
{
    public class ParUsuarioContrasena
    {
        public int Id { get; set; }

        public Categoria Categoria { get; set; }

        public string Sitio { get; set; }

        public string NombreDeUsuario { get; set; }

        public Contrasena Contrasena { get; set; }

        public string Nota { get; set; }

        public bool Modificado { get; set; }

        public ParUsuarioContrasena()
        {

        }

        public ParUsuarioContrasena(Contrasena unaContrasena, string unUsuario)
        {
            this.Contrasena = unaContrasena;
            AsignarNombreDeUsuario(unUsuario);
        }

        public void AsignarNombreDeUsuario(string UnNombre)
        {
            if (UnNombre.Length > 4 && UnNombre.Length < 26)
            {
                NombreDeUsuario = UnNombre;
            }
            else
            {
                throw new ExcepcionNombreUsuarioInvalido();
            }
        }


        public override string ToString()
        {
            return "Categoria:_" + Categoria.Nombre + " _Usuario:_" + NombreDeUsuario + "_Sitio:_" + Sitio + "_Ultima modificación:_" + Contrasena.UltimaModificacion+ "_Nota:_"+ this.Nota;
        }

        public string DarDatosParaDataBreach(bool fueModificado)
        {
            if (fueModificado)
            {
                return "Id: "+ Id + "  Usuario: " + NombreDeUsuario + " Sitio: " + Sitio + " Modificada";
            }
            else
            {
                return "Id: " + Id + "  Usuario: " + NombreDeUsuario + " Sitio: " + Sitio + " No modificada";
            }
        }

        public override bool Equals(object obj)
        {
            ParUsuarioContrasena par = obj as ParUsuarioContrasena;
            bool sonIguales = false;
            if (par == null)
            {
                sonIguales = false;
            }
            else
            {
                string nombreUsuarioUnoAMayusculas = this.NombreDeUsuario.ToUpper();
                string nombreDeUsuarioDosAMayusculas = par.NombreDeUsuario.ToUpper();
                string sitioUnoAMayusculas = this.Sitio.ToUpper();
                string sitioDosAMayusculas = par.Sitio.ToUpper();
                if (nombreUsuarioUnoAMayusculas == nombreDeUsuarioDosAMayusculas && sitioUnoAMayusculas == sitioDosAMayusculas)
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
    }
}