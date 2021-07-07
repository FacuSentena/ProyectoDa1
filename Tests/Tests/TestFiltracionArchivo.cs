using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class TestFiltracionArchivo
    {

        [TestMethod]
        public void CreoUnaFiltracionTextoYNoEsNull()
        {
            Filtracion filtracionArchivo = new FiltracionArchivo();
            Assert.IsNotNull(filtracionArchivo);
        }

        [TestMethod]
        public void LlamoAlMetodoBuscarFiltracionesDeContrasenasAPartirDeTextoYDevuelveTarjetasExpuestasEnTexto()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("Categoria1");
            Contrasena contrasena = new Contrasena("12345678");
            ParUsuarioContrasena par = new ParUsuarioContrasena();
            par.AsignarNombreDeUsuario("Pablo");
            par.Sitio = "Aulas";
            par.Contrasena = contrasena;
            List<ParUsuarioContrasena> listaDeParesDelSistema = new List<ParUsuarioContrasena>();
            listaDeParesDelSistema.Add(par);
            Filtracion buscador = new FiltracionArchivo();
            buscador.BuscarFiltracionesDeContrasenas(listaDeParesDelSistema, "\t12345678");
            ICollection<ParUsuarioContrasena> listaParesExpuestos = new List<ParUsuarioContrasena>();
            listaParesExpuestos = buscador.ParesDeLaFiltracion;
            Assert.IsTrue(listaParesExpuestos.Contains(par));
        }

        [TestMethod]
        public void LlamoAlMetodoBuscarFiltracionesDeContrasenasAPartirDeTextoSinContrasenasExpuestasYNoDevuelveNingunaContrasena()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("Categoria1");
            Contrasena contrasena = new Contrasena("1234562278");
            ParUsuarioContrasena par = new ParUsuarioContrasena();
            par.AsignarNombreDeUsuario("Pablo");
            par.Sitio = "Aulas";
            par.Contrasena = contrasena;
            List<ParUsuarioContrasena> listaDeParesDelSistema = new List<ParUsuarioContrasena>();
            listaDeParesDelSistema.Add(par);
            Filtracion buscador = new FiltracionArchivo();
            buscador.BuscarFiltracionesDeContrasenas(listaDeParesDelSistema, "\t12345678");
            ICollection<ParUsuarioContrasena> listaParesExpuestos = new List<ParUsuarioContrasena>();
            listaParesExpuestos = buscador.ParesDeLaFiltracion;
            Assert.IsFalse(listaParesExpuestos.Contains(par));
        }

        [TestMethod]
        public void LlamoAlMetodoBuscarFiltracionesDeTarjetasAPartirDeTextoYDevuelveTarjetasExpuestasEnTexto()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito();
            ICollection<TarjetaDeCredito> tarjetasDelSistema = new List<TarjetaDeCredito>();
            tarjeta.AsignarCodigo("4444444444444444");
            tarjeta.AsignarCodigoDeSeguridad("213");
            tarjetasDelSistema.Add(tarjeta);
            usuario.AgregarCategoria(categoria);
            Filtracion buscador = new FiltracionArchivo();
            ICollection<TarjetaDeCredito> listaExpuestos = new List<TarjetaDeCredito>();
            buscador.BuscarFiltracionesDeTarjetas(tarjetasDelSistema, "\t4444 4444 4444 4444");
            listaExpuestos = buscador.TarjetasDeLaFiltracion;
            Assert.IsTrue(listaExpuestos.Contains(tarjeta));
        }

        [TestMethod]
        public void LlamoAlMetodoBuscarFiltracionesDeTarjetasAPartirDeTextoSinTarjetasYNoDevuelveTarjetasExpuestas()
        {
            Usuario usuario = new Usuario();
            Categoria categoria = new Categoria("Categoria1");
            TarjetaDeCredito tarjeta = new TarjetaDeCredito();
            ICollection<TarjetaDeCredito> tarjetasDelSistema = new List<TarjetaDeCredito>();
            tarjeta.AsignarCodigo("4444434444444244");
            tarjeta.AsignarCodigoDeSeguridad("213");
            tarjetasDelSistema.Add(tarjeta);
            usuario.AgregarCategoria(categoria);
            Filtracion buscador = new FiltracionArchivo();
            ICollection<TarjetaDeCredito> listaExpuestos = new List<TarjetaDeCredito>();
            buscador.BuscarFiltracionesDeTarjetas(tarjetasDelSistema, "\t4444 4444 4444 4444");
            listaExpuestos = buscador.TarjetasDeLaFiltracion;
            Assert.IsFalse(listaExpuestos.Contains(tarjeta));
        }
    }
}


