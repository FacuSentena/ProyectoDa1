using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;

namespace Tests
{
    [TestClass]
    public class TestTarjetaDeCredito
    {
        [TestMethod]
        public void CreoTarjetaDeCreditoYAsignaParametrosCorrectamente()
        {
            Categoria categoria = new Categoria("Categoria");
            string nombre = "NombreDePruebaTarjeta";
            int id = 0;
            TarjetaDeCredito tarjeta = new TarjetaDeCredito(nombre, categoria);
            Assert.AreEqual(tarjeta.Nombre, nombre);
            Assert.AreEqual(tarjeta.Id, id);
            Assert.AreEqual(tarjeta.Categoria, categoria);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionTarjetaDeCreditoNombreInvalido))]
        public void CreoTarjetaEintentoModificarNombreConNombreInvalidoYsaltaExcepcion()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito("visa", categoria);
            string codigo = "1222568744446886";
            tarjeta.AsignarCodigo(codigo);
            tarjeta.ModificarNombre("in");
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionNoExisteTarjetaDeCredito))]
        public void IntentoObtenerCategoriaInexistenteYTiraExepcion()
        {
            Categoria categoria = new Categoria("deportes");
            categoria.ObtenerTarjetaDeCredito("tarjetaInexistente");
        }

        [TestMethod]
        public void AsignoCodigoTarjetaDeCreditoYLargoEsValido()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito("visa",categoria);
            string codigo = "1222568744446886";
            tarjeta.AsignarCodigo(codigo);
            Assert.AreEqual(tarjeta.Codigo, codigo);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionCodigoTarjetaInvalido))]
        public void AsignoCodigoTarjetaDeCreditoYLargoNoEsValido()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito("visa", categoria);
            string codigo = "122256874444688699";
            tarjeta.AsignarCodigo(codigo);
        }

        [TestMethod]
        public void AsignoCodigoSeguridadTarjetaDeCreditoYLargoEsValido()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito("visa", categoria);
            string codigo = "1222568744446886";
            string codigoSeguridad = "123";
            tarjeta.AsignarCodigo(codigo);
            tarjeta.AsignarCodigoDeSeguridad(codigoSeguridad);
            Assert.AreEqual(tarjeta.CodigoDeSeguridad, codigoSeguridad);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionCodigoDeSeguridadTarjetaInvalido))]
        public void AsignoCodigoSeguridadTarjetaDeCreditoLargoNoValidoYTiraExcepcion()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito("visa", categoria);
            string codigo = "1222568744446886";
            string codigoSeguridad = "13";
            tarjeta.AsignarCodigo(codigo);
            tarjeta.AsignarCodigoDeSeguridad(codigoSeguridad);
        }

        [TestMethod]public void CreoTarjetaYMuestraCodigoDeACuatroDigitos()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjetaUno = new TarjetaDeCredito("visa", categoria);
            string codigo = "1222568744446886";
            tarjetaUno.AsignarCodigo(codigo);
            Assert.AreEqual(tarjetaUno.MostrarCodigo(), "1222 5687 4444 6886");
        }

        [TestMethod]
        public void PidoMostrarDatosSegurosYSeMuestranDatosSoloUltimosDigitosDelCodigo()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjetaUno = new TarjetaDeCredito("visa", categoria);
            string codigo = "1222568744446886";
            tarjetaUno.AsignarCodigo(codigo);
            Assert.AreEqual(tarjetaUno.MostrarCodigoSeguro(), "XXXX XXXX XXXX 6886");
        }

        [TestMethod]
        public void CreoTarjetaDeCreditoPidoMostrarDatosSegurosYSeMuestranSeguros()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito("Visa", categoria);
            string codigo = "1222568744446886";
            tarjeta.AsignarCodigo(codigo);
            tarjeta.FechaVencimiento = "12/20";
            tarjeta.Tipo = "Internacional";
            Assert.AreEqual(tarjeta.DarDatosSeguros(), ("Categoría: " + "Categoria1" + " Nombre: " +
                "Visa" + " Tipo: " + "Internacional" + " Código: " + tarjeta.MostrarCodigoSeguro()+" Vencimiento: "+"12/20"));
        }

        [TestMethod]
        public void CreoTarjetaYToStringMuestraDatosCorrectamente()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito("Visa", categoria);
            string codigo = "1222568744446886";
            tarjeta.AsignarCodigo(codigo);
            tarjeta.AsignarCodigoDeSeguridad("123");
            tarjeta.FechaVencimiento = "12/21";
            tarjeta.Nota = "";
            tarjeta.Tipo = "Internacional";
            Assert.AreEqual(tarjeta.ToString(),("Categoría: " +"Categoria1"+" Nombre: "+
             "Visa" + " Tipo: "+ "Internacional" + " Código de Seguridad: " 
             +"123"+ " Código: " + tarjeta.MostrarCodigo()+ " Vencimiento: "+ "12/21"+ " Notas:" + tarjeta.Nota));
        }

        [TestMethod]
        public void CreoDosTarjetasDeCreditoConMismoCodigoYSonIguales()
        {
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjetaUno = new TarjetaDeCredito("visa", categoria);
            string codigo = "1222568744446886";
            tarjetaUno.AsignarCodigo(codigo);
            TarjetaDeCredito tarjetaDos = new TarjetaDeCredito("visa",categoria);
            tarjetaDos.AsignarCodigo(codigo);
            Assert.IsTrue(tarjetaUno.Equals(tarjetaDos));
        }
    }
}