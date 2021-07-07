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

    public delegate void ManejarPanelPantallaCambiarContrasena();

    public partial class PantallaCambiarContrasena : UserControl
    {
        private IManejadorUsuario<Usuario,ContrasenaMaestra> usuario;

        private event ManejarPanelPantallaCambiarContrasena seleccionoBotonCancelar;

        private event ManejarPanelPantallaCambiarContrasena seleccionoBotonCambiar;

        public PantallaCambiarContrasena(IManejadorUsuario<Usuario,ContrasenaMaestra> manejadorUsuario)
        {
            InitializeComponent();
            usuario = manejadorUsuario;
        }

        public void BotonCancelarPresionado(ManejarPanelPantallaCambiarContrasena delegado)
        {
            seleccionoBotonCancelar += delegado;
        }

        public void BotonCambiarPresionado(ManejarPanelPantallaCambiarContrasena delegado)
        {
            seleccionoBotonCambiar += delegado;
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            seleccionoBotonCancelar();
        }

        private void CambiarClaveMaestra()
        {
            try
            {
                string claveContrasenaVieja = campoContrasenaAntigua.Text;
                ContrasenaMaestra contrasenaVieja = new ContrasenaMaestra(claveContrasenaVieja);
                string claveContrasenaNueva = campoContrasenaNueva.Text;
                ContrasenaMaestra contrasenaNueva = new ContrasenaMaestra(claveContrasenaNueva);
                usuario.CambiarContrasenaMaestra(contrasenaVieja, contrasenaNueva);
                seleccionoBotonCambiar();
            }
            catch (ExepcionContrasenaInvalida)
            {
                labelErrores.Visible = true;
                labelErrores.ForeColor = Color.Red;
                labelErrores.Text = "Datos inválidos";

            }
            catch(ExcepcionContrasenaNoCoincidente)
            {
                labelErrores.Visible = true;
                labelErrores.ForeColor = Color.Red;
                labelErrores.Text = "Las contraseña no coincide con la anterior";
            }
        }

        private void BotonCambiar_Click(object sender, EventArgs e)
        {
            CambiarClaveMaestra();
        }
    }
}
