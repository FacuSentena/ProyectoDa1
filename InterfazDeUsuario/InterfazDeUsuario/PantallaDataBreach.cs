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
    public delegate void ManejarPantallaDataBreach();

    public partial class PantallaDataBreach : UserControl
    {
        private Usuario usuario;

        private IBuscadorDeFiltraciones buscadorDeFiltraciones;

        private List<ParUsuarioContrasena> paresExpuestos;

        private List<TarjetaDeCredito> tarjetasExpuestas;

        private event ManejarPantallaDataBreach botonSalirSeleccionado;

        public PantallaDataBreach(Usuario unUsuario)
        {
            InitializeComponent();
            usuario = unUsuario;
            buscadorDeFiltraciones = new BuscadorDeFiltracionesTexto();
        }

        private string ObtenerDatosDelCampoEnString()
        {
            string datosEnString = "";
            foreach (var linea in campoDatosExpuestos.Lines)
            {
                datosEnString += linea + "-";
            }
            return datosEnString;
        }

        private void MostrarParesExpuestos(List<ParUsuarioContrasena> paresExpuestos)
        {
            MostrarPanelExpuestos();
            if (paresExpuestos.Count == 0)
            {
                labelParesExpuestos.Text = ("No hay contraseñas expuestas");

            }
            else
            {
                listaParesExpuestos.DataSource = paresExpuestos;
            }
        }

        private void MostrarTarjetasExpuestas(List<TarjetaDeCredito> tarjetasExpuestas)
        {
            MostrarPanelExpuestos();
            if (tarjetasExpuestas.Count == 0)
            {
                labelTarjetasExpuestas.Text = "No hay tarjetas expuestas";

            }
            else
            {
                listaTarjetasExpuestas.DataSource = tarjetasExpuestas;
            }
        }

        private void MostrarPanelExpuestos()
        {
            labelParesExpuestos.Text = "Contraseñas expuestas:";
            labelTarjetasExpuestas.Text = "Tarjetas expuestas:";
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(panelVerExpuestos);
            panelVerExpuestos.Visible = true;
        }
        private void OcultarPanelExpuestos()
        {
            panelVerExpuestos.Visible = false;
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(panelVerificar);
            paresExpuestos.Clear();
            tarjetasExpuestas.Clear();
        }

        private void BotonVerificar_Click(object sender, EventArgs e)
        {
            string datosDelCampo = ObtenerDatosDelCampoEnString();
            paresExpuestos = buscadorDeFiltraciones.BuscarFiltracionesDeContrasenas(usuario, datosDelCampo);
            tarjetasExpuestas = buscadorDeFiltraciones.BuscarFiltracionesDeTarjetas(usuario, datosDelCampo);
            MostrarParesExpuestos(paresExpuestos);
            MostrarTarjetasExpuestas(tarjetasExpuestas);
        }

        public void BotonSalirEsSeleccionado(ManejarPantallaDataBreach delegado)
        {
            botonSalirSeleccionado += delegado;
        }

        private void BotonSalirVer_Click(object sender, EventArgs e)
        {
            OcultarPanelExpuestos();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            botonSalirSeleccionado();
        }
    }
}
