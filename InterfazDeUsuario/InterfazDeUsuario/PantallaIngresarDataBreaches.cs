using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
namespace InterfazDeUsuario
{
    public delegate void ManejarPantallaDataBreach();

    public partial class PantallaIngresarDataBreaches : UserControl
    {
        private IRepositorioTarjetaDeCredito<TarjetaDeCredito> tarjetasDeCredito;

        private IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> paresUsuarioContrasena;

        IRepositorioFiltraciones<Filtracion, int> filtraciones;

        private event ManejarPantallaDataBreach BotonSalirSeleccionado;

        public PantallaIngresarDataBreaches(IRepositorioFiltraciones<Filtracion, int> repositorioFiltraciones,
            IRepositorioTarjetaDeCredito<TarjetaDeCredito> repositorioTarjetasDeCredito,
            IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> repositorioParesUsuarioContrasena)
        {
            InitializeComponent();
            paresUsuarioContrasena = repositorioParesUsuarioContrasena;
            tarjetasDeCredito = repositorioTarjetasDeCredito;
            filtraciones = repositorioFiltraciones;
            labelInformacion.ResetText();
        }

        private string ObtenerDatosDelCampoEnString()
        {
            string datosEnString = "";
            string guionSeparadorDeLineas = "-";
            foreach (var linea in campoDatosExpuestos.Lines)
            {
                datosEnString += linea + guionSeparadorDeLineas;
            }
            return datosEnString;
        }

        private string ObtenerDatosDelArchivoSeleccionado()
        {
            dialogoAbrirArchivo.ShowDialog();
            string nombreArchivo = dialogoAbrirArchivo.FileName.ToString();
            try
            {
                StreamReader stream = new StreamReader(nombreArchivo);
                if (ArchivoEsDeTexto(nombreArchivo))
                {
                    string datosDelArchivo = stream.ReadLine();
                    stream.Close();
                    labelInformacion.ResetText();
                    return datosDelArchivo;
                }
                else
                {
                    stream.Close();
                    MostrarLabelErrorLectura();
                    return "Vacio";
                }
            }
            catch (Exception)
            {
                MostrarLabelErrorLectura();
                return "Vacio";
            }
        }

        private void MostrarLabelErrorLectura()
        {
            labelInformacion.Text = "Error al seleccionar arhivo";
            labelInformacion.ForeColor = Color.Red;
            labelInformacion.BackColor = Color.Black;
        }

        private bool ArchivoEsDeTexto(string nombreDelArchivo)
        {
            char ultimoDigito = nombreDelArchivo.ElementAt(nombreDelArchivo.Length - 1);
            char penultimoDigito = nombreDelArchivo.ElementAt(nombreDelArchivo.Length - 2);
            char antepenultimoDigito = nombreDelArchivo.ElementAt(nombreDelArchivo.Length - 3);
            if (ultimoDigito == 't' && penultimoDigito == 'x' && antepenultimoDigito == 't')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void BotonSalirEsSeleccionado(ManejarPantallaDataBreach delegado)
        {
            BotonSalirSeleccionado += delegado;
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            BotonSalirSeleccionado();
        }

        private void BotonIngresarEnCaja_Click(object sender, EventArgs e)
        {
            panelTxt.Visible = true;
        }

        private void BotonBuscarEnArhivo_Click(object sender, EventArgs e)
        {
            Filtracion filtracionArchivo = new FiltracionArchivo();
            filtracionArchivo.FechaCreacion = DateTime.Now;
            ICollection<ParUsuarioContrasena> paresDelRepositorio = paresUsuarioContrasena.DarColeccion();
            ICollection<TarjetaDeCredito> tarjetasDelRepositorio = tarjetasDeCredito.DarColeccion();
            string datosDelArchivo = ObtenerDatosDelArchivoSeleccionado();
            if (datosDelArchivo != "Vacio")
            {
                filtracionArchivo.BuscarFiltracionesDeContrasenas(paresDelRepositorio, datosDelArchivo);
                filtracionArchivo.BuscarFiltracionesDeTarjetas(tarjetasDelRepositorio, datosDelArchivo);
                filtraciones.Agregar(filtracionArchivo);
                labelInformacion.ForeColor = Color.Green;
                labelInformacion.Text = "DataBreach ingresado al sistema";
            }
        }

        private void BotonSalirDataBreachTxt_Click(object sender, EventArgs e)
        {
            panelTxt.Visible = false;
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            Filtracion filtracionTexto = new FiltracionTexto();
            filtracionTexto.FechaCreacion = DateTime.Now;
            ICollection<ParUsuarioContrasena> paresDelRepositorio = paresUsuarioContrasena.DarColeccion();
            ICollection<TarjetaDeCredito> tarjetasDelRepositorio = tarjetasDeCredito.DarColeccion();
            string datosDelCampo = ObtenerDatosDelCampoEnString();
            filtracionTexto.BuscarFiltracionesDeContrasenas(paresDelRepositorio, datosDelCampo);
            filtracionTexto.BuscarFiltracionesDeTarjetas(tarjetasDelRepositorio, datosDelCampo);
            filtraciones.Agregar(filtracionTexto);
            labelInformacion.ForeColor = Color.Green;
            labelInformacion.Text = "DataBreach ingresado al sistema";
        }
    }
}
