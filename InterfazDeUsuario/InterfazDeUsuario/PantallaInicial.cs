using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using AccesoADatos;
namespace InterfazDeUsuario
{
    public partial class PantallaInicial : Form
    {
        public IRepositorioCategorias<Categoria> categorias;

        private IRepositorioTarjetaDeCredito<TarjetaDeCredito> tarjetasDeCredito;

        private IManejadorUsuario<Usuario, ContrasenaMaestra> manejadorUsuario;

        private IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> paresUsuarioContrasena;

        private IRepositorioFiltraciones<Filtracion,int> filtraciones;

        public PantallaInicial()
        {
            InitializeComponent();
            paresUsuarioContrasena = new RepositorioParesBd();
            manejadorUsuario = new ManejadorUsuarioBd();
            AgregarPantallIngreso();
            categorias = new RepositorioCategoriasBd();
            tarjetasDeCredito = new RepositorioTarjetasBd();
            filtraciones = new RepositorioFiltracionesBd();
        }

        private void AgregarPantallIngreso()
        {
            PantallaIngreso pantallaIngreso = new PantallaIngreso(manejadorUsuario);
            pantallaIngreso.EscucharEvento(AgregarPantallaPrincipal);
            panelPantallaPrincipal.Controls.Add(pantallaIngreso);
        }

        private void AgregarPantallaPrincipal()
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal( categorias, tarjetasDeCredito, paresUsuarioContrasena);
            panelPantallaPrincipal.Controls.Clear();
            pantallaPrincipal.BotonAdministrarContrasenasPresionado(AgregarPantallaContrasenas);
            pantallaPrincipal.BotonAdministrarCategoriasPresionado(AgregarPantallaCategorias);
            pantallaPrincipal.BotonSalirPresionado(Salir);
            pantallaPrincipal.BotonVerFortalezasDeContrasenasPresionado(AgregarPantallaVerFortalezasContrasenas);
            pantallaPrincipal.BotonAdministrarTarjetasPresionado(AgregarPantallaTarjetasDeCredito);
            pantallaPrincipal.BotonCambiarContrasenaPresionado(AgregarPantallaCambiarContrasena);
            pantallaPrincipal.BotonDataBreachPresionado(AgregarPantallaIngresoDataBreach);
            pantallaPrincipal.BotonVerDataBreachPresionado(AgregarPantallaVerDataBreach);
            panelPantallaPrincipal.Controls.Add(pantallaPrincipal);
        }

        private void AgregarPantallaVerFortalezasContrasenas()
        {
            PantallaCantidadContrasenasPorGrupo pantallaContrasenasPorGrupo = new PantallaCantidadContrasenasPorGrupo(paresUsuarioContrasena);
            panelPantallaPrincipal.Controls.Clear();
            pantallaContrasenasPorGrupo.BotonSalirPresionado(AgregarPantallaPrincipal);
            pantallaContrasenasPorGrupo.BotonSalirPresionadoAGrupos(AgregarPantallaVerFortalezasContrasenas);
            panelPantallaPrincipal.Controls.Add(pantallaContrasenasPorGrupo);
        }

        private void AgregarPantallaContrasenas()
        {
            PantallaContrasenas pantallaContrasenas = new PantallaContrasenas(paresUsuarioContrasena, categorias,filtraciones);
            panelPantallaPrincipal.Controls.Clear();
            pantallaContrasenas.BotonAgregarParUsuarioContrasenaSeleccionado(AgregarPantallaCrearParUsuarioContrasena);
            pantallaContrasenas.BotonSalirSeleccionado(AgregarPantallaPrincipal);
            panelPantallaPrincipal.Controls.Add(pantallaContrasenas);
        }

        private void AgregarPantallaCrearParUsuarioContrasena()
        {
            PantallaCrearParUsuarioContrasena pantllaCrearParUsuarioContrasena = new PantallaCrearParUsuarioContrasena(paresUsuarioContrasena, categorias,filtraciones);
            panelPantallaPrincipal.Controls.Clear();
            pantllaCrearParUsuarioContrasena.BotonAceptarPresionado(AgregarPantallaContrasenas);
            pantllaCrearParUsuarioContrasena.BotonCanceladoPresionado(AgregarPantallaContrasenas);
            panelPantallaPrincipal.Controls.Add(pantllaCrearParUsuarioContrasena);
        }

        private void AgregarPantallaTarjetasDeCredito()
        {
            PantallaTarjetasDeCredito pantallaTarjetas = new PantallaTarjetasDeCredito(categorias, tarjetasDeCredito);
            panelPantallaPrincipal.Controls.Clear();
            pantallaTarjetas.BotonAgregarPresionado(AgregarPantallaCrearTarjeta);
            pantallaTarjetas.BotonSalirEsPresionado(AgregarPantallaPrincipal);
            pantallaTarjetas.BotonSalirEsPresionado(AgregarPantallaPrincipal);
            panelPantallaPrincipal.Controls.Add(pantallaTarjetas);
        }

        private void AgregarPantallaCrearTarjeta()
        {
            PantallaCrearTarjetaDeCredito pantallaCrearTarjetas = new PantallaCrearTarjetaDeCredito(categorias, tarjetasDeCredito);
            panelPantallaPrincipal.Controls.Clear();
            pantallaCrearTarjetas.BotonTarjetaAgregadaPresionado(AgregarPantallaTarjetasDeCredito);
            pantallaCrearTarjetas.BotonSalirPresionado(AgregarPantallaTarjetasDeCredito);
            panelPantallaPrincipal.Controls.Add(pantallaCrearTarjetas);
        }

        private void AgregarPantallaCategorias()
        {
            PantallaCategorias pantallaCategorias = new PantallaCategorias(categorias);
            panelPantallaPrincipal.Controls.Clear();
            pantallaCategorias.BotonSalirDeCategoriaPresionado(AgregarPantallaPrincipal);
            pantallaCategorias.BotonAgregarCategoriaPresionado(AgregarPantallaCrearCategoria);
            panelPantallaPrincipal.Controls.Add(pantallaCategorias);
        }

        private void AgregarPantallaCrearCategoria()
        {
            PantallaAgregarCategoria pantallaAgregarCategoria = new PantallaAgregarCategoria(categorias);
            panelPantallaPrincipal.Controls.Clear();
            pantallaAgregarCategoria.BotonAgregarOSalirPresionado(AgregarPantallaCategorias);
            panelPantallaPrincipal.Controls.Add(pantallaAgregarCategoria);
        }

        private void AgregarPantallaCambiarContrasena()
        {
            PantallaCambiarContrasena pantallaCambiarContrasena = new PantallaCambiarContrasena(manejadorUsuario);
            panelPantallaPrincipal.Controls.Clear();
            pantallaCambiarContrasena.BotonCancelarPresionado(AgregarPantallaPrincipal);
            pantallaCambiarContrasena.BotonCambiarPresionado(AgregarPantallaPrincipal);
            panelPantallaPrincipal.Controls.Add(pantallaCambiarContrasena);
        }

        private void AgregarPantallaVerDataBreach()
        {
            PantallaVerDataBreaches pantallaVerDataBreaches = new PantallaVerDataBreaches(filtraciones,paresUsuarioContrasena,tarjetasDeCredito);
            panelPantallaPrincipal.Controls.Clear();
            pantallaVerDataBreaches.SeleccionoBotonSalir(AgregarPantallaPrincipal);
            panelPantallaPrincipal.Controls.Add(pantallaVerDataBreaches);
        }

        private void AgregarPantallaIngresoDataBreach()
        {
            PantallaIngresarDataBreaches pantallaIngresoDataBreach = new PantallaIngresarDataBreaches(filtraciones,tarjetasDeCredito, paresUsuarioContrasena);
            panelPantallaPrincipal.Controls.Clear();
            pantallaIngresoDataBreach.BotonSalirEsSeleccionado(AgregarPantallaPrincipal);
            panelPantallaPrincipal.Controls.Add(pantallaIngresoDataBreach);
        }

        private void Salir()
        {
            this.Close();
        }
    }
}