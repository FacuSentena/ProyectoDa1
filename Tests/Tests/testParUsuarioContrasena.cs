using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;

namespace Tests
{
    [TestClass]
    public class TestParUsuarioContrasena
    {
        [TestMethod]
        public void CreoUnParUsuarioContrasenaNoesNuloYParametrosSeAsignanBien()
        {
            Contrasena contrasena = new Contrasena("Clave123");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "Usuario");
            string sitio = "www.Aulas.com.uy";
            par.Sitio = sitio;
            par.Id = 1;
            par.Nota = "Contrasena de la facultad";
            par.Modificado = false;
            Assert.IsNotNull(par);
            Assert.AreEqual(contrasena, par.Contrasena);
            Assert.AreEqual(par.NombreDeUsuario, "Usuario");
            Assert.AreEqual(1, par.Id);
            Assert.AreEqual(par.Nota, "Contrasena de la facultad");
            Assert.AreEqual(par.Sitio, sitio);
            Assert.IsFalse(par.Modificado);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionNombreUsuarioInvalido))]
        public void CreoUnParUsuarioContrasenaConNombreInvalidoYTiraExcepcion()
        {
            Contrasena contrasena = new Contrasena("Clave123");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "Us");
        }

        [TestMethod]
        public void CreoParUsuarioContrasenaYToStringFuncionaBien()
        {
            Categoria categoriaUno = new Categoria("Universidad");
            ParUsuarioContrasena par = new ParUsuarioContrasena();
            par.Categoria = categoriaUno;
            par.Sitio = "www.Aulas.Com";
            par.AsignarNombreDeUsuario ("UsuarioUno");
            par.Contrasena = new Contrasena("123456");
            par.Contrasena.UltimaModificacion = new DateTime(12 / 11 / 2022);
            string stringAComparar = "Categoria: " + categoriaUno.Nombre + "  Usuario: " + "UsuarioUno" 
             + " Sitio: " + "www.Aulas.Com" + " Ultima modificación: " + par.Contrasena.UltimaModificacion + " Nota: ";
            par.ToString().Equals(stringAComparar);
        }

       [TestMethod]
        public void DosParesSonIgualesYRetornaTrue()
        {
            Contrasena contrasenaUno = new Contrasena("Clave123");
            ParUsuarioContrasena parUno = new ParUsuarioContrasena(contrasenaUno, "usuario");
            string sitioUno = "www.Aulas.com.uy";
            parUno.Sitio = sitioUno;
            Contrasena contrasenaDos = new Contrasena("Clave123");
            ParUsuarioContrasena parDos = new ParUsuarioContrasena(contrasenaDos, "USUARIO");
            string sitioDos = "WWW.AULAS.COM.UY";
            parDos.Sitio = sitioDos;
            Assert.AreEqual(parUno, parDos);
        }

        [TestMethod]
        public void DosParesNoSonIguales()
        {
            Contrasena contrasenaUno = new Contrasena("Clave123");
            ParUsuarioContrasena parUno = new ParUsuarioContrasena(contrasenaUno, "usuario");
            string sitioUno = "www.Aulas.com.uy";
            parUno.Sitio = sitioUno;
            Contrasena contrasenaDos = new Contrasena("Clave123");
            ParUsuarioContrasena parDos = new ParUsuarioContrasena(contrasenaDos, "USUARIO");
            string sitioDos = "www.MercadoLibre.com";
            parDos.Sitio = sitioDos;
            Assert.AreNotEqual(parUno, parDos);
        }

        [TestMethod]
        public void DosParesConUnoNullYNoSonIguales()
        {
            Contrasena contrasenaUno = new Contrasena("Clave123");
            ParUsuarioContrasena parUno = new ParUsuarioContrasena(contrasenaUno, "usuario");
            string sitioUno = "www.Aulas.com.uy";
            parUno.Sitio = sitioUno;
            ParUsuarioContrasena parDos = null;
            Assert.IsFalse(parUno.Equals(parDos));
        }

        [TestMethod]
        public void ObtengoLosDatosDeUnParNoModificadoDeDataBreach()
        {
            Contrasena contrasenaUno = new Contrasena("Clave123");
            ParUsuarioContrasena parUsuarioContrasena = new ParUsuarioContrasena(contrasenaUno, "usuario");
            string sitioUno = "www.Aulas.com.uy";
            parUsuarioContrasena.Sitio = sitioUno;
            Assert.AreEqual(parUsuarioContrasena.DarDatosParaDataBreach(parUsuarioContrasena.Modificado), "Id: " 
                + parUsuarioContrasena.Id + "  Usuario: " + parUsuarioContrasena.NombreDeUsuario + " Sitio: " + parUsuarioContrasena.Sitio + " No modificada");
        }

        [TestMethod]
        public void ObtengoLosDatosDeUnParModificadoDeDataBreach()
        {
            Contrasena contrasenaUno = new Contrasena("Clave123");
            ParUsuarioContrasena parUsuarioContrasena = new ParUsuarioContrasena(contrasenaUno, "usuario");
            string sitioUno = "www.Aulas.com.uy";
            parUsuarioContrasena.Sitio = sitioUno;
            parUsuarioContrasena.Modificado = true;
            Assert.AreEqual(parUsuarioContrasena.DarDatosParaDataBreach(parUsuarioContrasena.Modificado), "Id: "
                + parUsuarioContrasena.Id + "  Usuario: " + parUsuarioContrasena.NombreDeUsuario + " Sitio: " + parUsuarioContrasena.Sitio + " Modificada");
        }
    }
}
