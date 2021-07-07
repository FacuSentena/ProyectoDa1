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
    public delegate void ManejarPanelPantallaCrearParUsuarioContrasena();

    public partial class PantallaCrearParUsuarioContrasena : UserControl
    {
        private GeneradorDeClave generadorDeClave;

        private IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> paresUsuarioContrasena;

        private IRepositorioCategorias<Categoria> categorias;

        private IRepositorioFiltraciones<Filtracion, int> filtraciones;

        private ParUsuarioContrasena par;

        private event ManejarPanelPantallaCrearParUsuarioContrasena ParCreado;

        private event ManejarPanelPantallaCrearParUsuarioContrasena BotonCancelado;

        public PantallaCrearParUsuarioContrasena(IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> repoPares,
            IRepositorioCategorias<Categoria> repoCategorias,
            IRepositorioFiltraciones<Filtracion, int> repoFiltraciones)
        {
            InitializeComponent();
            paresUsuarioContrasena = repoPares;
            categorias = repoCategorias;
            par = new ParUsuarioContrasena();
            filtraciones = repoFiltraciones;
            comboCategorias.DataSource = categorias.DarColeccion();
            labelLanzarErrores.Visible = false;
            panelSugerencia.Visible = false;
        }

        public void BotonAceptarPresionado(ManejarPanelPantallaCrearParUsuarioContrasena delegado)
        {
            ParCreado += delegado;
        }

        public void BotonCanceladoPresionado(ManejarPanelPantallaCrearParUsuarioContrasena delegado)
        {
            BotonCancelado += delegado;
        }

        private Contrasena GenerarContrasena()
        {
            generadorDeClave = new GeneradorDeClave();
            generadorDeClave.LargoDeLaContrasena = Convert.ToInt32(selectorLargoContrasena.Value);
            generadorDeClave.MayusculasSeleccionado = cajaSeleccionMayucsculas.Checked;
            generadorDeClave.SimbolosSeleccionado = cajaSeleccionSimbolos.Checked;
            generadorDeClave.MinusculasSeleccionado = cajaSeleccionMinusculas.Checked;
            generadorDeClave.NumerosSeleccionado = cajaSeleccionDigitos.Checked;
            Contrasena contrasena = new Contrasena();
            try
            {
                contrasena = generadorDeClave.GenerarContrasenaEnBaseASeleccionados();
            }
            catch (ExepcionContrasenaInvalida)
            {

            }
            contrasena.AsignarGrupoDeFortaleza();
            return contrasena;
        }

        private void AgregarPar()
        {
            ObtenerCamposDelPar();
            try
            {
                if (par.Contrasena != null && par.NombreDeUsuario != null && par.Sitio != null)
                {
                    paresUsuarioContrasena.Agregar(par);
                    MostrarPanelSugerenciasDelPar(par);
                }
            }
            catch (ExcepcionParUsuarioContrasenaYaExistente)
            {
                labelLanzarErrores.Text = "Usuario ya agregado";
                labelLanzarErrores.ForeColor = Color.Red;
                labelLanzarErrores.Visible = true;
            }
        }

        private void MostrarPanelSugerenciasDelPar(ParUsuarioContrasena parASugerir)
        {
            panelPrincipal.Controls.Clear();
            panelSugerencia.Visible = true;
            panelPrincipal.Controls.Add(panelSugerencia);
            VerificarContrasenaDuplicada(parASugerir);
            MostrarGrupoSeguridadDeLaContrasena(parASugerir);
            VerificarExposicionEnDataBreaches(parASugerir);
        }

        private void VerificarExposicionEnDataBreaches(ParUsuarioContrasena parAChequearExposicion)
        {
            bool estaExpuesto = false;
            ICollection<ParUsuarioContrasena> totalDeParesExpuestos = filtraciones.DarTodasContrasenasFiltradas();
            foreach (ParUsuarioContrasena parFiltrado in totalDeParesExpuestos)
            {
                if (parFiltrado.Contrasena.Clave == parAChequearExposicion.Contrasena.Clave)
                {
                    estaExpuesto = true;
                }
            }
            if (estaExpuesto)
            {
                labelDataBreach.Text = "Cuidado: La contraseña que agregegó aparece en un data breach";
                labelDataBreach.ForeColor = Color.Red;
                labelDataBreach.BackColor = Color.Black;
            }
            else
            {
                labelDataBreach.Text = "La contraseña que agregegó no aparece en nignun data breach";
                labelDataBreach.ForeColor = Color.Green;
                labelDataBreach.BackColor = Color.Black;
            }
        }

        private void MostrarGrupoSeguridadDeLaContrasena(ParUsuarioContrasena parAChequearNivel)
        {
            if (parAChequearNivel.Contrasena.GrupoDeFortaleza == "VerdeClaro")
            {
                labelNivel.Text = "El nivel de seguridad de su contraseña es seguro (Verde claro)";
                labelNivel.ForeColor = Color.Green;
                labelNivel.BackColor = Color.Black;
            }
            else if (parAChequearNivel.Contrasena.GrupoDeFortaleza == "VerdeOscuro")
            {
                labelNivel.Text = "El nivel de seguridad de su contraseña es seguro (Verde oscuro)";
                labelNivel.ForeColor = Color.Green;
                labelNivel.BackColor = Color.Black;
            }
            else
            {
                labelNivel.Text = "El nivel de seguridad de su contraseña no es muy seguro ( " + parAChequearNivel.Contrasena.GrupoDeFortaleza + ") ";
                labelNivel.ForeColor = Color.Red;
                labelNivel.BackColor = Color.Black;
            }
        }

        private void VerificarContrasenaDuplicada(ParUsuarioContrasena parASugerir)
        {
            bool claveYaExiste = paresUsuarioContrasena.ContrasenaYaExistente(parASugerir);
            if (claveYaExiste)
            {
                labelNoHayIguales.Text = "El usuario ya tiene una contraseña con el mismo texto ";
                labelNoHayIguales.ForeColor = Color.Red;
                labelNoHayIguales.BackColor = Color.Black;
            }
            else
            {
                labelNoHayIguales.Text = "El texto de la contraseña no se encuentra en ninguna otra";
                labelNoHayIguales.ForeColor = Color.Green;
                labelNoHayIguales.BackColor = Color.Black;
            }
        }

        private void ObtenerCamposDelPar()
        {
            try
            {
                string nombreCategoria = comboCategorias.Text;
                par.Categoria = categorias.Obtener(nombreCategoria);
                par.Sitio = campoDeTextoAgregarSitio.Text;
                par.Nota = campoTextoNotas.Text;
                par.AsignarNombreDeUsuario(campoDeTextoAgregarUsuario.Text);
            }
            catch (ExcepcionNombreUsuarioInvalido)
            {
                labelLanzarErrores.Text = "El nombre del sitio o el usuario no son validos";
                labelLanzarErrores.ForeColor = Color.Red;
                labelLanzarErrores.Visible = true;
            }
            if (par.Contrasena == null)
            {
                if (campoDeTextoIngresarClave.Text.Length >= 5 && campoDeTextoIngresarClave.Text.Length < 26)
                {
                    string clave = campoDeTextoIngresarClave.Text;
                    par.Contrasena = new Contrasena(clave);
                }
                else
                {
                    labelLanzarErrores.Text = "Ingrese una clave valida";
                    labelLanzarErrores.ForeColor = Color.Red;
                    labelLanzarErrores.Visible = true;
                }
            }
        }

        private void BotonGenerarContrasena_Click(object sender, EventArgs e)
        {
            bool algunCampoSeleccionado = cajaSeleccionMayucsculas.Checked || cajaSeleccionSimbolos.Checked
                || cajaSeleccionMinusculas.Checked || cajaSeleccionDigitos.Checked;
            int largo = Convert.ToInt32(selectorLargoContrasena.Value);

            if (algunCampoSeleccionado && largo > 4 && largo < 26)
            {
                par.Contrasena = GenerarContrasena();
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            AgregarPar();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            BotonCancelado();
        }

        private void LabelContinuar_Click(object sender, EventArgs e)
        {
            labelNoHayIguales.ResetText();
            labelNivel.ResetText();
            ParCreado();
        }
    }
}