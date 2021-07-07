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
    public delegate void ManejarPantallaVerDataBreach();

    public partial class PantallaVerDataBreaches : UserControl
    {

        IRepositorioFiltraciones<Filtracion, int> filtraciones;

        IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> paresUsuarioContrasena;

        IRepositorioTarjetaDeCredito<TarjetaDeCredito> tarjetasDeCredito;

        private event ManejarPantallaVerDataBreach BotonSalirSeleccionado;

        public PantallaVerDataBreaches(IRepositorioFiltraciones<Filtracion, int> repositorioFiltraciones,
        IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> repositorioPares,
        IRepositorioTarjetaDeCredito<TarjetaDeCredito> repositorioTarjetas)
        {
            InitializeComponent();
            labelSoloModificados.ResetText();
            paresUsuarioContrasena = repositorioPares;
            tarjetasDeCredito = repositorioTarjetas;
            filtraciones = repositorioFiltraciones;
            panelVerDataBreach.Visible = true;
            panelVerExpuestos.Visible = false;
            LLenarLista();
        }

        public void LLenarLista()
        {
            ICollection<Filtracion> historicosDeFiltraciones = filtraciones.DarColeccion();
            listaDataBreach.DataSource = historicosDeFiltraciones;
        }

        private void ObtenerFitlracionSeleccionada()
        {
            int indiceSeleccionado = listaDataBreach.SelectedIndex;
            ICollection<Filtracion> filtracionesDeLaLista = filtraciones.DarColeccion();
            Filtracion filtracionElegida = filtracionesDeLaLista.ElementAt(indiceSeleccionado);
            MostrarParesYTarjetasExpuestas(filtracionElegida);
        }

        private void MostrarParesYTarjetasExpuestas(Filtracion filtracionElegida)
        {
            ICollection<ParUsuarioContrasena> paresExpuestos = filtracionElegida.ParesDeLaFiltracion;
            ICollection<string> paresConInfoDeModificacion = new List<string>();
            foreach (ParUsuarioContrasena parExpuesto in paresExpuestos)
            {
                paresConInfoDeModificacion.Add(parExpuesto.DarDatosParaDataBreach(parExpuesto.Modificado));
            }
            ICollection<TarjetaDeCredito> tarjetasExpuestas = filtracionElegida.TarjetasDeLaFiltracion;
            listaDeParesExpuestos.DataSource = paresConInfoDeModificacion;
            listaDeTarjetasExpuestas.DataSource = tarjetasExpuestas;
        }

        private bool ParFueModificado()
        {
            ParUsuarioContrasena parARevisar = ObtenerParDeLaInterfaz();
            return parARevisar.Modificado;
        }

        private ParUsuarioContrasena ObtenerParDeLaInterfaz()
        {
            string sitioDelPar = ObtenerSitioDelParSeleccionado();
            string nombreDelPar = ObtenerNombreDelParSeleccionado();
            ParUsuarioContrasena parObtenido = paresUsuarioContrasena.Obtener(nombreDelPar, sitioDelPar);
            return parObtenido;
        }

        private string ObtenerNombreDelParSeleccionado()
        {
            int posicionDelNombre = 4;
            string datosMostradosDelPar = listaDeParesExpuestos.SelectedItem.ToString();
            char caracterSeparadorDeAtributos = ' ';
            string[] arregloConDatosDelPar = datosMostradosDelPar.Split(caracterSeparadorDeAtributos);
            string nombreDelParAObtener = arregloConDatosDelPar[posicionDelNombre];
            return nombreDelParAObtener;
        }

        private string ObtenerSitioDelParSeleccionado()
        {
            int posicionDelSitio = 6;
            string datosMostradosDelPar = listaDeParesExpuestos.SelectedItem.ToString();
            char caracterSeparadorDeAtributos = ' ';
            string[] arregloConDatosDelPar = datosMostradosDelPar.Split(caracterSeparadorDeAtributos);
            string sitioDelParAObtener = arregloConDatosDelPar[posicionDelSitio];
            return sitioDelParAObtener;
        }

        private void MostrarPanelVer()
        {
            panelVerDataBreach.Visible = false;
            panelVerExpuestos.Visible = true;
        }

        public void SeleccionoBotonSalir(ManejarPantallaVerDataBreach delegado)
        {
            BotonSalirSeleccionado += delegado;
        }

        private void EditarContrasena()
        {
            try
            {
                Contrasena contrasenaNueva = new Contrasena(campoContrasena.Text);
                string nombreDelParAEditar = ObtenerNombreDelParSeleccionado();
                string sitioDelParAEditar = ObtenerSitioDelParSeleccionado();
                paresUsuarioContrasena.EditarContrasena(nombreDelParAEditar, sitioDelParAEditar, contrasenaNueva);
            }
            catch (ExepcionContrasenaInvalida)
            {
                labelErroresContrasena.Visible = true;
                labelErroresContrasena.ForeColor = Color.Red;
                labelErroresContrasena.Text = "La contraseña no es valida";
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            panelVerExpuestos.Visible = false;
            panelVerDataBreach.Visible = true;
            labelSoloModificados.ResetText();

        }

        private void MostrarPanelEditar()
        {
            if (ParFueModificado())
            {
                labelSoloModificados.Text = "Solo se pueden cambiar contraseñas no modificadas";
                labelSoloModificados.ForeColor = Color.Red;
                labelSoloModificados.BackColor = Color.Black;
            }
            else
            {
                panelVerExpuestos.Visible = false;
                panelEditar.Visible = true;
            }
        }

        private void BotonSalirDataBreach_Click(object sender, EventArgs e)
        {
            BotonSalirSeleccionado();
        }

        private void BotonSeleccionar_Click(object sender, EventArgs e)
        {
            MostrarPanelVer();
            ObtenerFitlracionSeleccionada();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (listaDeParesExpuestos.Items.Count > 0)
            {
                MostrarPanelEditar();
            }
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            EditarContrasena();
            panelEditar.Visible = false;
            LLenarLista();
            panelVerExpuestos.Visible = true;
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            panelVerExpuestos.Visible = true;
            panelEditar.Visible = false;
        }
    }
}
