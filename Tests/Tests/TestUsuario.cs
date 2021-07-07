using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;

namespace Tests
{
    [TestClass]
    public class TestUsuario
    {
        [TestMethod]
        public void CreoUsuarioYNoesNulo()
        {
            Usuario usuario = new Usuario();
            int id = 0;
            Assert.IsNotNull(usuario);
            Assert.AreEqual(usuario.Id, id);
        }

        [TestMethod]
        public void UsuarioTieneContrasenaYRetornaTrue()
        {
            ContrasenaMaestra contrasenaUsuario = new ContrasenaMaestra("ABCDEFGHI");
            Usuario usuario = new Usuario(contrasenaUsuario);
            Assert.AreEqual(usuario.ContrasenaMaestra, contrasenaUsuario);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionContrasenaNoCoincidente))]
        public void IntentoCambiarContrasenaMaestraConContrasenaIncorrectaYNoLaCambia()
        {
            ContrasenaMaestra primerContrasenaMaestra = new ContrasenaMaestra("primerContrasenaMaestra");
            Usuario usuario = new Usuario(primerContrasenaMaestra);
            ContrasenaMaestra nuevaContrasenaMaestra = new ContrasenaMaestra("seGundaContrasenaMaestra");
            usuario.CambiarClaveMaestra(nuevaContrasenaMaestra, nuevaContrasenaMaestra);
        }

        [TestMethod]
        public void IntentoCambiarContrasenaMaestraConContrasenaCorrectaYLaCambia()
        {
            ContrasenaMaestra primerContrasenaMaestra = new ContrasenaMaestra("primerContrasenaMaestra");
            Usuario usuario = new Usuario(primerContrasenaMaestra);
            ContrasenaMaestra nuevaContrasenaMaestra = new ContrasenaMaestra("seGundaContrasenaMaestra");
            usuario.CambiarClaveMaestra(primerContrasenaMaestra, nuevaContrasenaMaestra);
            Assert.AreEqual(usuario.ContrasenaMaestra, nuevaContrasenaMaestra);
        }

        [TestMethod]
        public void ObtengoCategoriasUsuarioYLasObtiene()
        {
            Usuario usuario = new Usuario();
            usuario.ObtenerCategorias();
            Assert.IsNotNull(usuario.ObtenerCategorias());
        }

        [TestMethod]
        public void UsuarioNoTieneCategorias()
        {
            Usuario usuario = new Usuario();
            Assert.IsFalse(usuario.TieneCategorias());
        }

        [TestMethod]
        public void AgregoCategoriaYExisteCategoria()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("Categoria1");
            usuario.AgregarCategoria(categoria);
            Assert.IsTrue(usuario.ExisteCategoria("Categoria1"));
        }

        [TestMethod]
        public void BuscoCategoriaNoAgregadaYNoExisteCategoria()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("Categoria1");
            Assert.IsFalse(usuario.ExisteCategoria("Categoria1"));
        }

        [TestMethod]
        public void IntentoObtenerCategoriaPorNombreYLaObtiene()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("Categoria1");
            usuario.AgregarCategoria(categoria);
            Categoria categoriaRecuperada = usuario.ObtenerCategoria("Categoria1");
            Assert.AreEqual(categoria,categoriaRecuperada);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionNoExisteCategoria))]
        public void IntentoObtenerCategoriaPorNombreNoLaObtieneYTiraExcepcion()
        {
            Usuario usuario = new Usuario();
            usuario.ObtenerCategoria("Categoria");
        }

        [TestMethod]
        public void AgregoCategoriaAUsuarioYListaNoEsVacia()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("Categoria1");
            usuario.AgregarCategoria(categoria);
            Assert.IsTrue(usuario.TieneCategorias());
        }

        [TestMethod]
        [ExpectedException (typeof(ExcepcionCategoriaYaExistente))]
        public void IntentoAgregarCategoriaRepetidaYNoLaAgrega()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Categoria categoriaDos = new Categoria("DEPORTES");
            usuario.AgregarCategoria(categoria);
            usuario.AgregarCategoria(categoriaDos); 
        }

        [TestMethod]
        public void AgregoContrasenaYUsuarioLaCuenta()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("AbCdEFghIjK1$$$$$$$$$$$$A");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.AreEqual(1, usuario.ContarParesUsuarioContrasena());
        }

        [TestMethod]
        public void AgregoParUsuarioContrasenaYUsuarioLaObtiene()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("AbCdEFghIjK1$$$$$$$$$$$$A");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.IsTrue(usuario.ObtenerParesUsuarioContrasena().Contains(par));
        }

        [TestMethod]
        public void AgregoTarjetaDeCreditoYUsuarioLaObtiene()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            TarjetaDeCredito tarjetaDeCredito = new TarjetaDeCredito("visa",categoria);
            tarjetaDeCredito.AsignarCodigo("1111111111111111");
            categoria.AgregarTarjetaDeCredito(tarjetaDeCredito);
            usuario.AgregarCategoria(categoria);
           Assert.IsTrue(usuario.ObtenerTarjetasDeCredito().Contains(tarjetaDeCredito));
        }

        [TestMethod]
        public void IntentoAgregarDosCategoriasDistintasYLasAgrega()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Categoria categoriaDos = new Categoria("Bancos");
            usuario.AgregarCategoria(categoria);
            usuario.AgregarCategoria(categoriaDos);
            Assert.AreEqual(usuario.ContarCategorias(), 2);
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaRojoYUsuarioLaCuenta()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("abcde");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.AreEqual(1, usuario.ContarContrasenasPorGrupoDeFortaleza("Rojo"));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaNaranjaYUsuarioLaCuenta()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("ABCDEFGHIJKL");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.AreEqual(1, usuario.ContarContrasenasPorGrupoDeFortaleza("Naranja"));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaAmarilloYUsuarioLaCuenta()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("ABCDEFGHIJK1AAAAAAAAAA");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.AreEqual("Amarillo", contrasena.GrupoDeFortaleza);
            Assert.AreEqual(1, usuario.ContarContrasenasPorGrupoDeFortaleza("Amarillo"));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaVerdeClaroYUsuarioLaCuenta()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("AbCdEFghIjKAaaaaAAA1");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.AreEqual("VerdeClaro", contrasena.GrupoDeFortaleza);
            Assert.AreEqual(1, usuario.ContarContrasenasPorGrupoDeFortaleza("VerdeClaro"));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaVerdeOscuroYUsuarioLaCuenta()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("AbCdEFghIjK1$$$$$$$$$$$$A");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.AreEqual(1, usuario.ContarContrasenasPorGrupoDeFortaleza("VerdeOscuro"));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaRojoYUsuarioLaObtiene()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("abcde");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.IsTrue(usuario.ObtenerParesUsuarioContrasenaPorGrupoDeFortaleza("Rojo").Contains(par));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaNaranjaYUsuarioLaObtiene()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("ABCDEFGHIJKL");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.IsTrue(usuario.ObtenerParesUsuarioContrasenaPorGrupoDeFortaleza("Naranja").Contains(par));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaAmarilloYUsuarioLaObtiene()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("ABCDEFGHIJK1AAAAAAAAAA");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.IsTrue(usuario.ObtenerParesUsuarioContrasenaPorGrupoDeFortaleza("Amarillo").Contains(par));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaVerdeClaroYUsuarioLaObtiene()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("AbCdEFghIjKAaaaaAAA1");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.IsTrue(usuario.ObtenerParesUsuarioContrasenaPorGrupoDeFortaleza("VerdeClaro").Contains(par));
        }

        [TestMethod]
        public void AgregoContrasenaGrupoDeFortalezaVerdeOscuroYUsuarioLaObtiene()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("deportes");
            Contrasena contrasena = new Contrasena("AbCdEFghIjK1$$$$$$$$$$$$A");
            ParUsuarioContrasena par = new ParUsuarioContrasena(contrasena, "usuario1");
            par.Sitio = "www.aulas.com";
            categoria.AgregarParUsuarioContrasena(par);
            usuario.AgregarCategoria(categoria);
            Assert.IsTrue(usuario.ObtenerParesUsuarioContrasenaPorGrupoDeFortaleza("VerdeOscuro").Contains(par));
        }
    }
}
