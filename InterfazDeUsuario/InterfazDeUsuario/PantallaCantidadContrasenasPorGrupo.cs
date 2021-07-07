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
    public delegate void ManejarPanelPantallaCantidadContrasenas();

    public partial class PantallaCantidadContrasenasPorGrupo : UserControl
    {
        private IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> paresUsuarioContrasena;

        private event ManejarPanelPantallaCantidadContrasenas seleccionoBotonSalir;

        private event ManejarPanelPantallaCantidadContrasenas seleccionoBotonSalirAGrupos;

        public PantallaCantidadContrasenasPorGrupo(IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> repoPares)
        {
            InitializeComponent();
            paresUsuarioContrasena = repoPares;
            CargarLabelsDeGrupos();
        }

        private void CargarLabelsDeGrupos()
        {
            AgregarCantidadContrasenasRojas();
            AgregarCantidadContrasenasNaranjas();
            AgregarCantidadContrasenasAmarillas();
            AgregarCantidadContrasenasVerdeClaras();
            AgregarCantidadContrasenasVerdeOscuras();
        }

        private void AgregarCantidadContrasenasRojas()
        {
            labelCantidadRojas.Text = paresUsuarioContrasena.ObtenerParesPorGrupoDeSeguridad("Rojo").Count().ToString();
        }

        private void AgregarCantidadContrasenasNaranjas()
        {
            labelCantidadNaranjas.Text = paresUsuarioContrasena.ObtenerParesPorGrupoDeSeguridad("Naranja").Count().ToString();
        }

        private void AgregarCantidadContrasenasAmarillas()
        {
            labelCantidadAmarillas.Text = paresUsuarioContrasena.ObtenerParesPorGrupoDeSeguridad("Amarillo").Count().ToString();
        }

        private void AgregarCantidadContrasenasVerdeClaras()
        {
            labelCantidadVerdeClaro.Text = paresUsuarioContrasena.ObtenerParesPorGrupoDeSeguridad("VerdeClaro").Count().ToString();
        }

        private void AgregarCantidadContrasenasVerdeOscuras()
        {
            labelCantidadVerdeOscuro.Text = paresUsuarioContrasena.ObtenerParesPorGrupoDeSeguridad("VerdeOscuro").Count().ToString();
        }

        private void BotonVerRojas_Click(object sender, EventArgs e)
        {
            MostrarContrasenas("Rojo");
            BotonSalirAGrupos.Visible = true;
            BotonSalir.Visible = false;
        }

        private void BotonVerNaranjas_Click(object sender, EventArgs e)
        {
            MostrarContrasenas("Naranja");
            BotonSalirAGrupos.Visible = true;
            BotonSalir.Visible = false;
        }

        private void BotonVerAmarillas_Click(object sender, EventArgs e)
        {
            MostrarContrasenas("Amarillo");
            BotonSalirAGrupos.Visible = true;
            BotonSalir.Visible = false;
        }

        private void BotonVerVerdesClaras_Click(object sender, EventArgs e)
        {
            MostrarContrasenas("VerdeClaro");
            BotonSalirAGrupos.Visible = true;
            BotonSalir.Visible = false;
        }

        private void BotonVerVerdesOscuras_Click(object sender, EventArgs e)
        {
            MostrarContrasenas("VerdeOscuro");
            BotonSalirAGrupos.Visible = true;
            BotonSalir.Visible = false;
        }

        private void MostrarContrasenas(string colorDeFortaleza)
        {
            panelPrincipal.Controls.Clear();
            listaMostrarContrasenas.DataSource = paresUsuarioContrasena.ObtenerParesPorGrupoDeSeguridad(colorDeFortaleza);
            listaMostrarContrasenas.Visible = true;
            panelVerContrasenas.Visible = true;
            panelPrincipal.Controls.Add(panelVerContrasenas);
        }

        private void MostrarEditor()
        {
            panelPrincipal.Controls.Clear();
            panelEditar.Visible = true;
            panelPrincipal.Controls.Add(panelEditar);
        }

        private void EditarContrasena()
        {
            ParUsuarioContrasena parAEditar = ObtenerUsuarioDeListaInterfaz();
            try
            {
                string claveDeLaNuevaContrasena = campoContrasena.Text;
                Contrasena contrasenaNueva = new Contrasena(claveDeLaNuevaContrasena);
                string nombreDelParAEditar = parAEditar.NombreDeUsuario;
                string sitioDelParAEditar = parAEditar.Sitio;
                paresUsuarioContrasena.EditarContrasena(nombreDelParAEditar, sitioDelParAEditar, contrasenaNueva);

            }
            catch (ExepcionContrasenaInvalida)
            {
                labelErroresContrasena.Visible = true;
                labelErroresContrasena.ForeColor = Color.Red;
                labelErroresContrasena.Text = "La contraseña no es valida";
            }
        }

        private ParUsuarioContrasena ObtenerUsuarioDeListaInterfaz()
        {
            char espacioSeparadorDelToString = ' ';
            string parEnString = (listaMostrarContrasenas.SelectedItem.ToString());
            string[] parEnArray = parEnString.Split(espacioSeparadorDelToString);
            int indiceNombre = 5;
            int indiceSitio = 7;
            int indiceCategoria = 2;
            ParUsuarioContrasena parParaBusqueda = new ParUsuarioContrasena();
            parParaBusqueda.NombreDeUsuario = parEnArray[indiceNombre];
            parParaBusqueda.Sitio = parEnArray[indiceSitio];
            parParaBusqueda.Categoria = new Categoria(parEnArray[indiceCategoria]);
            return parParaBusqueda;
        }

        public void BotonSalirPresionado(ManejarPanelPantallaCantidadContrasenas del)
        {
            seleccionoBotonSalir += del;
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            seleccionoBotonSalir();
        }

        public void BotonSalirPresionadoAGrupos(ManejarPanelPantallaCantidadContrasenas delegado)
        {
            seleccionoBotonSalirAGrupos += delegado;
        }

        private void BotonSalirAGrupos_Click(object sender, EventArgs e)
        {
            seleccionoBotonSalirAGrupos();
        }

        private void BotonEditarDeLista_Click(object sender, EventArgs e)
        {
            MostrarEditor();
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            EditarContrasena();
            seleccionoBotonSalirAGrupos();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            seleccionoBotonSalirAGrupos();
        }
    }
}

