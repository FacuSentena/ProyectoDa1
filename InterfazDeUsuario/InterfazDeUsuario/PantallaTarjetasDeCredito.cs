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
    public delegate void ManejarPantallaTarjetasDeCredito();

    public partial class PantallaTarjetasDeCredito : UserControl
    {
        private IRepositorioCategorias<Categoria> categorias;

        private IRepositorioTarjetaDeCredito<TarjetaDeCredito> tarjetasDeCredito;

        private event ManejarPantallaTarjetasDeCredito botonSalirSeleccionado;

        private event ManejarPantallaTarjetasDeCredito botonAgregarSeleccionado;

        private int contadorDeTiempo;

        public PantallaTarjetasDeCredito(IRepositorioCategorias<Categoria> repoCategorias, IRepositorioTarjetaDeCredito<TarjetaDeCredito> repoTarjetaDeCredito)
        {
            InitializeComponent();
            categorias = repoCategorias;
            tarjetasDeCredito = repoTarjetaDeCredito;
            LlenarLista();
        }

        private void LlenarLista()
        {
            ICollection<TarjetaDeCredito> tarjetasSinFormato = (List<TarjetaDeCredito>)tarjetasDeCredito.DarColeccion();
            List<string> tarjetasConFormato = new List<string>();
            foreach (TarjetaDeCredito tarjetaSinFormato in tarjetasSinFormato)
            {
                tarjetasConFormato.Add(tarjetaSinFormato.DarDatosSeguros());
            }
            listaTarjetas.DataSource = tarjetasConFormato;
        }

        private void EditarTarjeta()
        {
            if (CamposValidos())
            {
                int indiceTarjetaAEditar = listaTarjetas.SelectedIndex;
                TarjetaDeCredito tarjetaAEditar = tarjetasDeCredito.DarColeccion().ElementAt(indiceTarjetaAEditar);
                try
                {
                    AsignarDatos(tarjetaAEditar);
                }catch (ExcepcionTarjetaDeCreditoYaExistente)
                {
                    labelErrores.ForeColor = Color.Red;
                    labelErrores.Visible = true;
                }
                panelPrincipal.Controls.Clear();
                panelPrincipal.Controls.Add(panelTarjetas);
                LlenarLista();
            }
            else
            {
                labelErrores.ForeColor = Color.Red;
                labelErrores.Visible = true;
            }
        }

        private void AsignarDatos(TarjetaDeCredito tarjeta)
        {
            tarjetasDeCredito.EditarNombre(tarjeta.Codigo, campoNombre.Text);
            tarjetasDeCredito.EditarTipo(tarjeta.Codigo, campoTipo.Text);
            tarjetasDeCredito.EditarCodigoDeSeguridad(tarjeta.Codigo, campoCodigoSeguridad.Text);
            tarjetasDeCredito.EditarVencimiento(tarjeta.Codigo, campoCodigoVencimiento.Text);
            tarjetasDeCredito.EditarCodigo(tarjeta.Codigo, campoCodigo.Text);
        }

        private bool CamposValidos()
        {
            bool nombreValido = campoNombre.Text.Length >= 3 && campoNombre.Text.Length < 25;
            bool tipoValido = campoTipo.Text.Length >= 4 && campoTipo.Text.Length <= 25;
            bool codigoValido = campoCodigo.Text.Length == 16;
            bool codigoSeguridadValido = campoCodigoSeguridad.Text.Length == 3 || campoCodigoSeguridad.Text.Length == 4;
            return nombreValido && tipoValido && codigoValido && codigoSeguridadValido;
        }

        private void EliminarTarjeta()
        {
            int indiceTarjetaAEditar = listaTarjetas.SelectedIndex;
            TarjetaDeCredito tarjetaAEliminar = tarjetasDeCredito.DarColeccion().ElementAt(indiceTarjetaAEditar);
            tarjetasDeCredito.Eliminar(tarjetaAEliminar);
            LlenarLista();
        }

        public void BotonAgregarPresionado(ManejarPantallaTarjetasDeCredito delegado)
        {
            botonAgregarSeleccionado += delegado;
        }

        public void BotonSalirEsPresionado(ManejarPantallaTarjetasDeCredito delegado)
        {
            botonSalirSeleccionado += delegado;
        }

        private void OcultarDatosTarjeta()
        {
            temporizadorVer.Enabled = false;
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(panelTarjetas);
            contadorDeTiempo = 0;
            listaVerTarjeta.Items.Clear();
        }

        private string ObtenerDatosDeTarjetaAMostrar()
        {
            int indiceDeLaTarjeta = listaTarjetas.SelectedIndex;
            ICollection<TarjetaDeCredito> tarjetasDeLaCategoria = tarjetasDeCredito.DarColeccion();
            TarjetaDeCredito tarjetaDeCreditoAMostrar = tarjetasDeLaCategoria.ElementAt(indiceDeLaTarjeta);
            string datosAMostrar = tarjetaDeCreditoAMostrar.ToString();
            return datosAMostrar;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            botonAgregarSeleccionado();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (listaTarjetas.Items.Count > 0)
                EliminarTarjeta();
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            if (listaTarjetas.Items.Count > 0)
            {
                panelPrincipal.Controls.Clear();
                panelEditar.Visible = true;
                panelPrincipal.Controls.Add(panelEditar);
            }
        }

        private void BotonEditarPanelEditar_Click(object sender, EventArgs e)
        {
            EditarTarjeta();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(panelTarjetas);
        }

        private void BotonSalirPrincipal_Click(object sender, EventArgs e)
        {
            botonSalirSeleccionado();
        }

        private void BotonVer_Click(object sender, EventArgs e)
        {
            if (listaTarjetas.Items.Count > 0)
            {
                temporizadorVer.Enabled = true;
                panelPrincipal.Controls.Clear();
                string datosDeLaTarjeta = ObtenerDatosDeTarjetaAMostrar();
                panelVer.Visible = true;
                panelPrincipal.Controls.Add(panelVer);
                listaVerTarjeta.Items.Add(datosDeLaTarjeta);
            }
        }

        private void TemporizadorVer_Tick(object sender, EventArgs e)
        {
            contadorDeTiempo++;
            labelContarSegundos.Text = contadorDeTiempo.ToString();
            if (contadorDeTiempo == 30)
            {
                OcultarDatosTarjeta();
            }
        }

        private void BotonCerrarPanelVer_Click(object sender, EventArgs e)
        {
            OcultarDatosTarjeta();
        }
    }
}