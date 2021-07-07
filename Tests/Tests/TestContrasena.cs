using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;

namespace Tests
{
    [TestClass]
    public class TestContrasena
    {

        [TestMethod]
        public void CreoContrasenaNoEsNULLYtieneClave()
        {
            Contrasena contrasena = new Contrasena("ContrasenaEjemplo");
            string contenido = "ContrasenaEjemplo";
            int id = 0;
            Assert.IsNotNull(contrasena);
            Assert.AreEqual(contrasena.Clave, contenido);
            Assert.AreEqual(contrasena.Id, id);
        }

        [TestMethod]
        public void DosContrasenasSonIgualesYDaTrue()
        {
            Contrasena contrasena = new Contrasena("Contrasena1");
            Contrasena contrasena2 = new Contrasena("Contrasena1");
            Assert.IsTrue(contrasena.Equals(contrasena2));
        }

        [TestMethod]
        public void CreoContrasenaMaestraValidaYNoEsNull()
        {
            ContrasenaMaestra contrasenaMaestra = new ContrasenaMaestra("12345678A");
            Assert.IsNotNull(contrasenaMaestra);
            contrasenaMaestra.Equals("12345678A");
        }

        [TestMethod]
        [ExpectedException (typeof(ExepcionContrasenaInvalida))]
        public void CreoContrasenaMaestraNoValidaYDevuelveError()
        {
            ContrasenaMaestra contrasenaMaestra = new ContrasenaMaestra("123");
        }

        [TestMethod]
        public void CreoContrasenaYSuClaveTieneLargoValido()
        {
            Contrasena contrasena = new Contrasena("ABCDEFG");
            string contenido = "ABCDEFG";
            Assert.AreEqual(contrasena.Clave, contenido);
        }

        [TestMethod]
        [ExpectedException(typeof(ExepcionContrasenaInvalida))]
        public void CreoContrasenaNoValidaYDevuelveError()
        {
            Contrasena contrasena = new Contrasena("ABD");
        }

        [TestMethod]
        public void CambioClaveContrasenaPorUnaValidaYSeCambia()
        {
            Contrasena contrasena = new Contrasena("ABDEF");
            contrasena.CambiarClave("CONTRASENAMARILLA");
            Assert.AreEqual(contrasena.Clave, "CONTRASENAMARILLA");
        }

        [TestMethod]
        [ExpectedException(typeof(ExepcionContrasenaInvalida))]
        public void CambioClaveContrasenaPorUnaNoValidaYDevuelveError()
        {
            Contrasena contrasena = new Contrasena("ABDEF");
            contrasena.CambiarClave("con");
        }

        [TestMethod]public void PidoNivelDeContrasenaYEsRojo()
        {
            Contrasena contrasena = new Contrasena("abcded");
            Assert.AreEqual(contrasena.AsignarGrupoDeFortaleza(), "Rojo");
        }

        [TestMethod]
        public void PidoNivelDeContrasenaYEsNaranja()
        {
            Contrasena contrasena = new Contrasena("abcdefghijk");
            Assert.AreEqual(contrasena.AsignarGrupoDeFortaleza(), "Naranja");
        }

        [TestMethod]
        public void PidoNivelDeContrasenaYEsAmarillo()
        {
            Contrasena contrasena = new Contrasena("CONTRASENAMARILLA");
            Assert.AreEqual(contrasena.AsignarGrupoDeFortaleza(), "Amarillo");
        }

        [TestMethod]
        public void PidoNivelDeContrasenaYEsVerdeClaro()
        {
            Contrasena contrasena = new Contrasena("cONTRASENAVerdeClaro");
            Assert.AreEqual(contrasena.AsignarGrupoDeFortaleza(), "VerdeClaro");
        }

        [TestMethod]
        public void PidoNivelDeContrasenaYEsVerdeOscuro()
        {
            Contrasena contrasena = new Contrasena("CONTRASENAVerdeOscuro1!");
            Assert.AreEqual(contrasena.AsignarGrupoDeFortaleza(), "VerdeOscuro");
        }

        [TestMethod]
        public void GeneroClaveMaysuculasSeisCaracteresYEsRoja()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave= contrasena.GenerarClaveMayusculas(6);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Rojo");
        }

        [TestMethod]
        public void GeneroClaveMinuculasSeisCaracteresYEsRoja()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMinusculas(6);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Rojo");
        }

        [TestMethod]
        public void GeneroClaveNumerosSeisCaracteresYEsRoja()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveNumeros(6);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Rojo");
        }

        [TestMethod]
        public void GeneroClaveSimbolosSeisCaracteresYEsRoja()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveSimbolos(6);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Rojo");
        }

        [TestMethod]
        public void GeneroClaveMayusculasYMinusculasQuinceCaracteresYEsVerdeClaro()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMayusculasYMinusculas(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "VerdeClaro");
        }

        [TestMethod]
        public void GeneroClaveMayusculasYSimbolosQuinceCaracteresYEsAmarillo()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMayusculasYSimbolos(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Amarillo");
        }

        [TestMethod]
        public void GeneroClaveMayusculasYNumerosQuinceCaracteresYEsAmarillo()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMayusculasYNumeros(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Amarillo");
        }

        [TestMethod]
        public void GeneroClaveMinusculasYNumerosQuinceCaracteresYEsAmarillo()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMinusculasYNumeros(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Amarillo");
        }

        [TestMethod]
        public void GeneroClaveMinusculasYSimbolosQuinceCaracteresYEsAmarillo()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMinusculasYSimbolos(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Amarillo");
        }

        [TestMethod]
        public void GeneroClaveNumerosYSimbolosQuinceCaracteresYEsAmarillo()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveNumerosYSimbolos(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "Amarillo");
        }

        [TestMethod]
        public void GeneroClaveMayusculasMinusculasYSimbolosQuinceCaracteresYEsVerdeClaro()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMayusculasMinusculasYSimbolos(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "VerdeClaro");
        }

        [TestMethod]
        public void GeneroClaveMayusculasMinusculasYNumerosQuinceCaracteresYEsVerdeClaro()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMayusculasMinusculasYNumeros(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "VerdeClaro");
        }

        [TestMethod]
        public void GeneroClaveMayusculasNumerosYSimbolosQuinceCaracteresYEsVerdeClaro()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMayusculasNumerosYSimbolos(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "VerdeClaro");
        }

        [TestMethod]
        public void GeneroClaveMinusculasNumerosYSimbolosQuinceCaracteresYEsVerdeClaro()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMinusculasNumerosYSimbolos(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "VerdeClaro");
        }

        [TestMethod]
        public void GeneroClaveMayusculasMinusculasNumerosYSimbolosQuinceCaracteresYEsVerdeOscuro()
        {
            Contrasena contrasena = new Contrasena();
            contrasena.Clave = contrasena.GenerarClaveMayusculasMinusculasNumerosYSimbolos(15);
            contrasena.GrupoDeFortaleza = contrasena.AsignarGrupoDeFortaleza();
            Assert.AreEqual(contrasena.GrupoDeFortaleza, "VerdeOscuro");
        }
    }
}
