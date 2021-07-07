using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;

namespace Tests
{
    [TestClass]
    public class TestCategoria
    {
        private Categoria categoriaPorDefecto = new Categoria("Categoria1");

        [TestMethod]
        public void CreoUnaCategoriaYTieneNombreValido()
        {
            string nombre = "Categoria1";
            int id = 0;
            Assert.IsNotNull(categoriaPorDefecto);
            Assert.AreEqual(categoriaPorDefecto.Nombre, nombre);
            Assert.AreEqual(categoriaPorDefecto.Id, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionCategoriaNombreInvalido))]
        public void CreoUnaCategoriaNoTieneNombreValidoYTiraExcepcion()
        {
            Categoria categoriaInvalida = new Categoria("abc");
        }

        [TestMethod]
        public void ModificoNombreDeCategoriaYesValido()
        {
            Categoria categoria = new Categoria("deportes");
            categoria.ModificarNombre("NombreNuevo");
            Assert.AreEqual(categoria.Nombre, "NombreNuevo");
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionCategoriaNombreInvalido))]
        public void ModificoNombreDeCategoriaNoEsValidoYTiraExepcion()
        {
            Categoria categoria = new Categoria("deportes");
            categoria.ModificarNombre("abc");}
        [TestMethod]
        public void CreoCategoriaYNoTieneTarjetasDeCredito()
        {
            Assert.IsFalse(categoriaPorDefecto.TieneTarjetasDeCredito());
        }

        [TestMethod]
        public void AgregoTarjetaDeCreditoYlistaNoEsVacia()
        {
            TarjetaDeCredito tarjetaDeCredito = new TarjetaDeCredito();
            categoriaPorDefecto.AgregarTarjetaDeCredito(tarjetaDeCredito);
            Assert.IsTrue(categoriaPorDefecto.TieneTarjetasDeCredito());
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionTarjetaDeCreditoYaExistente))]
        public void AgregoTarjetaDeCreditoYaExistenteYTiraExcepcion()
        {
            TarjetaDeCredito tarjetaDeCredito = new TarjetaDeCredito("Visa", categoriaPorDefecto);
            tarjetaDeCredito.AsignarCodigo("1111111111111111");
            categoriaPorDefecto.AgregarTarjetaDeCredito(tarjetaDeCredito);
            TarjetaDeCredito tarjetaDeCreditoRepetida = new TarjetaDeCredito("Visa", categoriaPorDefecto);
            tarjetaDeCreditoRepetida.AsignarCodigo("1111111111111111");
            categoriaPorDefecto.AgregarTarjetaDeCredito(tarjetaDeCreditoRepetida);
        }

        [TestMethod] public void CreoCategoriaYNoTieneParesUsuarioContrasena()
        {
            Assert.IsFalse(categoriaPorDefecto.TieneParesUsuarioContrasena());
        }

        [TestMethod]
        public void AgregoParUsuarioContrasenaylistaNoEsVacia()
        {
            Contrasena contrasena = new Contrasena("12345678A");
            ParUsuarioContrasena parUsuarioContrasena = new ParUsuarioContrasena(contrasena, "Usuario");
            categoriaPorDefecto.AgregarParUsuarioContrasena(parUsuarioContrasena);
            Assert.IsTrue(categoriaPorDefecto.TieneParesUsuarioContrasena());
        }

        [TestMethod]
        public void AgregoParUsuarioContrasenaYSeCuentanBien()
        {
            Contrasena contrasena = new Contrasena("12345678A");
            ParUsuarioContrasena parUsuarioContrasena = new ParUsuarioContrasena(contrasena, "Usuario");
            parUsuarioContrasena.Sitio = "sitioPrueba";
            categoriaPorDefecto.AgregarParUsuarioContrasena(parUsuarioContrasena);
            Contrasena contrasena2 = new Contrasena("12145678A");
            ParUsuarioContrasena parUsuarioContrasena2 = new ParUsuarioContrasena(contrasena2, "Usuario2");
            parUsuarioContrasena2.Sitio = "sitioPrueba2";
            categoriaPorDefecto.AgregarParUsuarioContrasena(parUsuarioContrasena2);
            Console.Write(categoriaPorDefecto.ContarParUsuarioContrasena());
            Assert.AreEqual(2, categoriaPorDefecto.ContarParUsuarioContrasena());
        }

        [TestMethod]
        public void AgregoParUsuarioContrasenaYLoObtengo()
        {
            Contrasena contrasena = new Contrasena("12345678A");
            ParUsuarioContrasena parUsuarioContrasena = new ParUsuarioContrasena(contrasena, "Usuario");
            parUsuarioContrasena.Sitio = "Aulas.com";
            categoriaPorDefecto.AgregarParUsuarioContrasena(parUsuarioContrasena);
            Assert.AreEqual(categoriaPorDefecto.ObtenerParUsuarioContrasenaPorUsuarioYSitio("Usuario", "Aulas.com"), parUsuarioContrasena);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionParUsuarioContrasenaYaExistente))]
        public void IntentoAgregarDosParesUsuarioContrasenaIgualesYNoLosAgrega()
        {
            Contrasena contrasena = new Contrasena("12345678A");
            ParUsuarioContrasena parUsuarioContrasenaUno = new ParUsuarioContrasena(contrasena, "usuario1");
            parUsuarioContrasenaUno.Sitio = "www.Aulas.com.uy";
            ParUsuarioContrasena parUsuarioContrasenaDos = new ParUsuarioContrasena(contrasena, "USUARIO1");
            parUsuarioContrasenaDos.Sitio = "WWW.AULAS.COM.UY";
            categoriaPorDefecto.AgregarParUsuarioContrasena(parUsuarioContrasenaUno);
            categoriaPorDefecto.AgregarParUsuarioContrasena(parUsuarioContrasenaDos);
        }

        [TestMethod]
        public void ElminoParUsuarioContrasenaylistaEsVacia(){
            Contrasena contrasena = new Contrasena("12345678A");
            ParUsuarioContrasena parUsuarioContrasena = new ParUsuarioContrasena(contrasena, "Usuario");
            parUsuarioContrasena.Sitio = "www.Aulas.com.uy";
            categoriaPorDefecto.AgregarParUsuarioContrasena(parUsuarioContrasena);
            categoriaPorDefecto.EliminarParUsuarioContrasena(parUsuarioContrasena);
            Assert.IsFalse(categoriaPorDefecto.TieneParesUsuarioContrasena());
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionParUsuarioContrasenaNoExistente))]
        public void ElminoParUsuarioContrasenaInexsistenteYTiraExcepcion()
        {
            Contrasena contrasena = new Contrasena("12345678A");
            ParUsuarioContrasena parUsuarioContrasena = new ParUsuarioContrasena(contrasena, "UsuarioPrueba");
            parUsuarioContrasena.Sitio = "www.Aulas.com.uy";
            categoriaPorDefecto.EliminarParUsuarioContrasena(parUsuarioContrasena);
        }


        [TestMethod]
        public void EliminoTarjetaDeCreditoDeListaConUnElementoYEsVacia(){
            TarjetaDeCredito tarjetaDeCredito = new TarjetaDeCredito();
            categoriaPorDefecto.AgregarTarjetaDeCredito(tarjetaDeCredito);
            categoriaPorDefecto.EliminarTarjetaDeCredito(tarjetaDeCredito);
            Assert.IsFalse(categoriaPorDefecto.TieneTarjetasDeCredito());
        }

        [TestMethod]
        public void CreoUnaCategoriaConNombreYElNombreEsElMismoAlAsignado()
        {
            Categoria categoriaUno = new Categoria("Categoria1");
            Assert.AreEqual(categoriaUno.ToString(), "Categoria1");
        }

        [TestMethod]
        public void CreoDosCategoriasConMismoNombreYDiferenteCaseYSonIguales()
        {
            Categoria categoriaUno = new Categoria("deportes");
            Categoria categoriaDos = new Categoria("DEPORTES");
            Assert.AreEqual(categoriaUno, categoriaDos);
        }

        [TestMethod]
        public void CreoDosCategoriasYUnaEsMayorQueOtraPorNombre()
        {
            Categoria categoriaMayor = new Categoria("Aulas");
            Categoria categoriaMenor = new Categoria("Deportes");
            Assert.IsTrue(categoriaMayor.CompareTo(categoriaMenor)==-1);
        }

        [TestMethod]
        public void CreoDosCategoriasYUnaEsMenorQueOtraPorNombre()
        {
            Categoria categoriaMayor = new Categoria("Basket");
            Categoria categoriaMenor = new Categoria("Atletismo");
            Assert.IsTrue(categoriaMayor.CompareTo(categoriaMenor) == 1);
        }
    }
}
