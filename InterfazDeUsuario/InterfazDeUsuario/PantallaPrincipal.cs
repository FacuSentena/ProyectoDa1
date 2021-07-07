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
namespace InterfazDeUsuario
{
    public delegate void ManejarPanelPantallaPrincipal();

    public partial class PantallaPrincipal : UserControl
    {
        private event ManejarPanelPantallaPrincipal seleccionoBotonAdministrarCategorias;

        private event ManejarPanelPantallaPrincipal seleccionoBotonAdministrarContrasenas;

        private event ManejarPanelPantallaPrincipal seleccionoBotonAdministrarTarjetasDeCredito;

        private event ManejarPanelPantallaPrincipal seleccionoBotonSalir;

        private event ManejarPanelPantallaPrincipal seleccionoBotonVerFortalezasDeContrasenas;

        private event ManejarPanelPantallaPrincipal seleccionoBotonCambiarContrasena;

        private event ManejarPanelPantallaPrincipal seleccionoBotonDataBreach;

        private event ManejarPanelPantallaPrincipal SeleccionoBotonDataBreach;

        private event ManejarPanelPantallaPrincipal SeleccionoBotonVerDataBreach;

        private IRepositorioCategorias<Categoria> categorias;

        private IRepositorioTarjetaDeCredito<TarjetaDeCredito> tarjetasDeCredito;

        private IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> paresUsuarioContrasena;

        public PantallaPrincipal(IRepositorioCategorias<Categoria> repoCategorias,
            IRepositorioTarjetaDeCredito<TarjetaDeCredito> repoTarjetas,
            IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> repoPares)
        {
            InitializeComponent();
            labelErrores.Visible = false;
            paresUsuarioContrasena = repoPares;
            categorias = repoCategorias;
            tarjetasDeCredito = repoTarjetas;
            ActualizarContadores();
        }

        private void ActualizarContadores()
        {
            labelCantidadCategorias.Text = categorias.Contar().ToString();
            labelCantidadContrasenas.Text = paresUsuarioContrasena.Contar().ToString();
            labelCantidadTarjetas.Text = tarjetasDeCredito.Contar().ToString();
        }

        public void BotonVerDataBreachPresionado(ManejarPanelPantallaPrincipal delegado)
        {
            SeleccionoBotonVerDataBreach += delegado;
        }

        public void BotonDataBreachPresionado(ManejarPanelPantallaPrincipal delegado)
        {
            seleccionoBotonDataBreach += delegado;
        }

        public void BotonCambiarContrasenaPresionado(ManejarPanelPantallaPrincipal delegado)
        {
            seleccionoBotonCambiarContrasena += delegado;
        }

        public void BotonAdministrarContrasenasPresionado(ManejarPanelPantallaPrincipal delegado)
        {
            seleccionoBotonAdministrarContrasenas += delegado;
        }
        public void BotonAdministrarCategoriasPresionado(ManejarPanelPantallaPrincipal delegado)
        {
            seleccionoBotonAdministrarCategorias += delegado;
        }

        public void BotonAdministrarTarjetasPresionado(ManejarPanelPantallaPrincipal delegado)
        {
            seleccionoBotonAdministrarTarjetasDeCredito += delegado;
        }

        public void BotonSalirPresionado(ManejarPanelPantallaPrincipal delegado)
        {
            seleccionoBotonSalir += delegado;
        }

        public void BotonVerFortalezasDeContrasenasPresionado(ManejarPanelPantallaPrincipal delegado)
        {
            seleccionoBotonVerFortalezasDeContrasenas += delegado;
        }

        private void BotonAdministrarContrasenas_Click(object sender, EventArgs e)
        {
            if (categorias.Contar() >= 1)
            {
                seleccionoBotonAdministrarContrasenas();
            }
            else
            {
                labelErrores.Visible = true;
                labelErrores.ForeColor = Color.Red;
                labelErrores.Text = "No hay categorías, primero ingrese una para agregar su contraseña ";
            }
        }

        private void BotonAdministrarCategorias_Click(object sender, EventArgs e)
        {
            seleccionoBotonAdministrarCategorias();
        }

        private void BotonVerFortalezaContrasenas_Click(object sender, EventArgs e)
        {
            seleccionoBotonVerFortalezasDeContrasenas();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            seleccionoBotonSalir();
        }

        private void BotonAdministrarTarjetas_Click(object sender, EventArgs e)
        {
            if (categorias.Contar() >= 1)
            {
                seleccionoBotonAdministrarTarjetasDeCredito();
            }
            else
            {
                labelErrores.Visible = true;
                labelErrores.ForeColor = Color.Red;
                labelErrores.Text = "No hay categorías, primero ingrese una para agregar su tarjeta ";
            }
        }

        private void BotonCambiarContrasenaUsuario_Click(object sender, EventArgs e)
        {
            seleccionoBotonCambiarContrasena();
        }

        private void BotonDataBreach_Click(object sender, EventArgs e)
        {
            seleccionoBotonDataBreach();
        }

        private void BotonVerDataBreaches_Click(object sender, EventArgs e)
        {
            SeleccionoBotonVerDataBreach();
        }
    }
}
