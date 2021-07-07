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
    public delegate void ManejarPanelContrasenas();

    public partial class PantallaContrasenas : UserControl
    {
        private GeneradorDeClave generadorDeClave;

        private IRepositorioCategorias<Categoria> categorias;

        private IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> paresUsuarioContrasena;

        private IRepositorioFiltraciones<Filtracion, int> filtraciones;

        private event ManejarPanelContrasenas SeleccionoAgregarParUsuarioContrasena;

        private event ManejarPanelContrasenas SeleccionoBotonSalir;

        private int contadorDeTiempo;

        public PantallaContrasenas(IRepositorioParesUsuarioContrasena<ParUsuarioContrasena, Contrasena> repoPares,
            IRepositorioCategorias<Categoria> repoCategorias,
            IRepositorioFiltraciones<Filtracion, int> repoFiltraciones)
        {
            InitializeComponent();
            paresUsuarioContrasena = repoPares;
            categorias = repoCategorias;
            filtraciones = repoFiltraciones;
            LLenarLista();
            labelNoHayElementos.Visible = false;
        }

        public void LLenarLista()
        {
            ICollection<ParUsuarioContrasena> paresEnLista = paresUsuarioContrasena.DarColeccion();
            listaParesUsuarioContrasena.DataSource = paresEnLista;
        }

        private void EditarPar()
        {
            ParUsuarioContrasena parParaBusqueda = ObtenerUsuarioDeListaInterfaz();
            ParUsuarioContrasena parAEditar = paresUsuarioContrasena.Obtener(parParaBusqueda.NombreDeUsuario, parParaBusqueda.Sitio);
            AsignarNuevosDatos(parAEditar);
        }

        private void EliminarPar()
        {
            if (listaParesUsuarioContrasena.Items.Count > 0)
            {
                ParUsuarioContrasena parDeLaLista = ObtenerUsuarioDeListaInterfaz();
                paresUsuarioContrasena.Eliminar(parDeLaLista.NombreDeUsuario, parDeLaLista.Sitio);
                LLenarLista();
                labelNoHayElementos.Visible = false;
            }
            else
            {
                labelNoHayElementos.ForeColor = Color.Red;
                labelNoHayElementos.Visible = true;
            }
        }

        private void MostrarPanelSugerenciasDelPar(ParUsuarioContrasena parASugerir)
        {
            panelGeneral.Controls.Clear();
            panelSugerencia.Visible = true;
            panelGeneral.Controls.Add(panelSugerencia);
            VerificarContrasenaDuplicada(parASugerir);
            MostrarGrupoSeguridad(parASugerir);
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

        private void MostrarGrupoSeguridad(ParUsuarioContrasena parAChequearNivel)
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

        private void AsignarNuevosDatos(ParUsuarioContrasena par)
        {
            bool usuarioYSitioDisponibles = false;
            if (VerificarNombreYSitioAPar(par.NombreDeUsuario, par.Sitio))
            {
                Contrasena contrasenaObtenida = ObtenerContrasena();
                if (contrasenaObtenida != null)
                {
                    try
                    {
                        paresUsuarioContrasena.EditarNombreYSitio(par, campoNuevoNombre.Text, campoSitio.Text);
                        usuarioYSitioDisponibles = true;
                    }
                    catch (ExcepcionParUsuarioContrasenaYaExistente)
                    {
                        labelErrores.Text = "Nombre de usuario y sitio no disponibles";
                        labelErrores.ForeColor = Color.Red;
                        labelErrores.Visible = true;
                        usuarioYSitioDisponibles = false;
                    }
                    if (usuarioYSitioDisponibles)
                    {
                        paresUsuarioContrasena.EditarContrasena(campoNuevoNombre.Text, campoSitio.Text, contrasenaObtenida);
                        MostrarPanelSugerenciasDelPar(par);
                    }
                }
            }
        }

        private bool VerificarNombreYSitioAPar(string nombrePar, string sitioPar)
        {
            ParUsuarioContrasena parDeValidacion = new ParUsuarioContrasena();
            bool valido = false;
            if (campoSitio.Text.Length > 0 && campoNuevoNombre.Text.Length > 0)
            {
                string nuevoSitio = campoSitio.Text;
                string nuevoNombre = campoNuevoNombre.Text;
                try
                {
                    parDeValidacion.Sitio = nuevoSitio;
                    parDeValidacion.AsignarNombreDeUsuario(nuevoNombre);
                    valido = true;
                }
                catch (ExcepcionNombreUsuarioInvalido)
                {
                    labelErrores.Text = "Nombre de usuario o sitio inválidos";
                    labelErrores.ForeColor = Color.Red;
                    labelErrores.Visible = true;
                    valido = false;
                }
            }
            return valido;
        }

        private Contrasena ObtenerContrasena()
        {
            Contrasena contrasena = null;
            bool algunaCajaSeleccionada = cajaDigitos.Checked || cajaMayusculas.Checked
                || cajaMinusculas.Checked || cajaSimbolos.Checked;
            bool campoValido = campoContrasena.Text.Length > 5 && campoContrasena.Text.Length < 25;
            if (campoValido)
            {
                contrasena = new Contrasena(campoContrasena.Text);
                contrasena.UltimaModificacion = DateTime.Now;
            }
            else if (!campoValido && algunaCajaSeleccionada)
            {
                contrasena = GenerarContrasena();
            }
            return contrasena;
        }

        private Contrasena GenerarContrasena()
        {
            generadorDeClave = new GeneradorDeClave();
            generadorDeClave.LargoDeLaContrasena = Convert.ToInt32(selectorLargo.Value);
            generadorDeClave.MayusculasSeleccionado = cajaMayusculas.Checked;
            generadorDeClave.SimbolosSeleccionado = cajaSimbolos.Checked;
            generadorDeClave.MinusculasSeleccionado = cajaMinusculas.Checked;
            generadorDeClave.NumerosSeleccionado = cajaDigitos.Checked;
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

        public void BotonAgregarParUsuarioContrasenaSeleccionado(ManejarPanelContrasenas delegado)
        {
            SeleccionoAgregarParUsuarioContrasena += delegado;
        }

        public void BotonSalirSeleccionado(ManejarPanelContrasenas delegado)
        {
            SeleccionoBotonSalir += delegado;
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            EditarPar();
        }

        private void CerrarVentana()
        {
            LLenarLista();
            panelGeneral.Controls.Clear();
            panelGeneral.Controls.Add(panelContrasenas);
        }

        private ParUsuarioContrasena ObtenerUsuarioDeListaInterfaz()
        {
            string parEnString = (listaParesUsuarioContrasena.SelectedItem.ToString());
            char separadorDeAtributos = '_';
            string[] parEnArray = parEnString.Split(separadorDeAtributos);
            int indiceNombre = 3;
            int indiceSitio = 5;
            int indiceCategoria = 1;
            ParUsuarioContrasena parParaBusqueda = new ParUsuarioContrasena();
            parParaBusqueda.NombreDeUsuario = parEnArray[indiceNombre];
            parParaBusqueda.Sitio = parEnArray[indiceSitio];
            parParaBusqueda.Categoria = new Categoria(parEnArray[indiceCategoria]);
            return parParaBusqueda;
        }

        private string ObtenerClaveAMostrar()
        {
            ParUsuarioContrasena parDeLaListaDeInterfaz = ObtenerUsuarioDeListaInterfaz();
            string nombreDelUsuarioParaBuscar = parDeLaListaDeInterfaz.NombreDeUsuario;
            string sitioDelUsuarioParaBuscar = parDeLaListaDeInterfaz.Sitio;
            ParUsuarioContrasena parDeLaContrasena = paresUsuarioContrasena.Obtener(nombreDelUsuarioParaBuscar, sitioDelUsuarioParaBuscar);
            return parDeLaContrasena.Contrasena.Clave;
        }

        private void TimerTemporizador_Tick(object sender, EventArgs e)
        {
            contadorDeTiempo++;
            labelTiempoRestante.Text = contadorDeTiempo.ToString();
            if (contadorDeTiempo == 30)
            {
                OcultarVistaContrasena();
            }
        }

        private void OcultarVistaContrasena()
        {
            temporizador.Enabled = false;
            panelGeneral.Controls.Clear();
            panelMostrarContrasena.Visible = false;
            panelGeneral.Controls.Add(panelContrasenas);
            listaSoloContrasena.Items.Clear();
            contadorDeTiempo = 0;
        }

        private void BotonSalirVerContrasenas_Click(object sender, EventArgs e)
        {
            OcultarVistaContrasena();
        }

        private void BotonAgregarPar_Click(object sender, EventArgs e)
        {
            SeleccionoAgregarParUsuarioContrasena();
        }

        private void BotonEditarPar_Click(object sender, EventArgs e)
        {
            if (listaParesUsuarioContrasena.Items.Count > 0)
            {
                labelErrores.Visible = false; ; ;
                panelGeneral.Controls.Clear();
                panelGeneral.Controls.Add(panelEditar);
                panelEditar.Visible = true;
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            SeleccionoBotonSalir();
        }

        private void BotonEliminarPar_Click(object sender, EventArgs e)
        {
            EliminarPar();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            panelGeneral.Controls.Clear();
            panelGeneral.Controls.Add(panelContrasenas);
        }

        private void BotonVer_Click(object sender, EventArgs e)
        {
            if (listaParesUsuarioContrasena.Items.Count > 0)
            {
                temporizador.Enabled = true;
                panelGeneral.Controls.Clear();
                string claveAMostar = ObtenerClaveAMostrar();
                panelMostrarContrasena.Visible = true;
                panelGeneral.Controls.Add(panelMostrarContrasena);
                listaSoloContrasena.Items.Add(claveAMostar);
            }
        }

        private void LabelContinuar_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }
    }
}
