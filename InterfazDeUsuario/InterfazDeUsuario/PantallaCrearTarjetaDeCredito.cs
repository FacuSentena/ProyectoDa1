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
    public delegate void ManejarPantallaCrearTarjetas();

    public partial class PantallaCrearTarjetaDeCredito : UserControl
    {
        private IRepositorioCategorias<Categoria> categorias;

        private IRepositorioTarjetaDeCredito<TarjetaDeCredito> tarjetas;

        private TarjetaDeCredito tarjeta;

        private event ManejarPantallaCrearTarjetas BotonAgregarSeleccionado;

        private event ManejarPantallaCrearTarjetas botonSalirSeleccionado;

        public PantallaCrearTarjetaDeCredito(IRepositorioCategorias<Categoria> repoCategorias, IRepositorioTarjetaDeCredito<TarjetaDeCredito> repoTarjetas)
        {
            InitializeComponent();
            categorias = repoCategorias;
            tarjetas = repoTarjetas;
            CargarCombo();
        }

        private void CargarCombo()
        {
            comboCategoria.DataSource = categorias.DarColeccion();
        }

        private void AgregarTarjeta()
        {
            tarjeta = new TarjetaDeCredito();
            if (CamposValidos())
            {
                AsignarDatos(tarjeta);
                try
                {
                    Categoria categoriaDeLaTarjeta = tarjeta.Categoria;
                    categoriaDeLaTarjeta.AgregarTarjetaDeCredito(tarjeta);
                    tarjetas.Agregar(tarjeta,categoriaDeLaTarjeta.Nombre);
                    BotonAgregarSeleccionado();
                }
                catch (ExcepcionTarjetaDeCreditoYaExistente)
                {
                    labelErrores.Visible = true;
                    labelErrores.ForeColor = Color.Red;
                    labelErrores.Text = "Tarjeta ya existente";

                }
            }
            else
            {
                labelErrores.Visible = true;
                labelErrores.ForeColor = Color.Red;
                labelErrores.Text = "Datos invalidos";
            }
        }

        private void AsignarDatos(TarjetaDeCredito tarjeta)
        {
            tarjeta.Categoria = categorias.Obtener(comboCategoria.Text);
            tarjeta.Nombre = campoNombre.Text;
            tarjeta.Tipo = campoTipo.Text;
            tarjeta.AsignarCodigo(campoCodigo.Text);
            tarjeta.AsignarCodigoDeSeguridad(campoCodigoDeSeguridad.Text);
            tarjeta.FechaVencimiento = campoVencimiento.Text;
            tarjeta.Nota = campoNotas.Text;
        }

        private bool CamposValidos()
        {
            bool nombreValido = campoNombre.Text.Length >= 3 && campoNombre.Text.Length < 25;
            bool tipoValido = campoTipo.Text.Length >= 4 && campoTipo.Text.Length < 25;
            bool codigoValido = campoCodigo.Text.Length == 16;
            bool codigoSeguridadValido = campoCodigoDeSeguridad.Text.Length == 3 || campoCodigoDeSeguridad.Text.Length == 4;
            return nombreValido && tipoValido && codigoValido && codigoSeguridadValido;
        }

        public void BotonTarjetaAgregadaPresionado(ManejarPantallaCrearTarjetas delegado)
        {
            BotonAgregarSeleccionado += delegado;
        }

        public void BotonSalirPresionado(ManejarPantallaCrearTarjetas delegado)
        {
            botonSalirSeleccionado += delegado;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            AgregarTarjeta();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            botonSalirSeleccionado();
        }
    }
}
