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
    public delegate void ManejarPanelIngreso();

    public partial class PantallaIngreso : UserControl
    {
        private event ManejarPanelIngreso ContrasenaUsuarioIngresada;

        private IManejadorUsuario<Usuario, ContrasenaMaestra> usuario;

        public PantallaIngreso(IManejadorUsuario<Usuario, ContrasenaMaestra> unUsuario)
        {
            InitializeComponent();
            usuario = unUsuario;
            LabelErrores.Visible = false;
        }

        public void EscucharEvento(ManejarPanelIngreso delegado)
        {
            ContrasenaUsuarioIngresada += delegado;
        }

        private ContrasenaMaestra ObtenerContrasena()
        {
            string claveContrasenaMaestra = this.campoDeTextoContrasenaMaestra.Text;
            ContrasenaMaestra contrasenaUsuario = new ContrasenaMaestra(claveContrasenaMaestra);
            return contrasenaUsuario;
        }

        private bool CotejarContrasenaDelUsuario(ContrasenaMaestra contrasenaIngresada, IManejadorUsuario<Usuario, ContrasenaMaestra> usuario)
        {
            return contrasenaIngresada.Clave == usuario.ObtenerUsuario().ContrasenaMaestra.Clave;
        }

        private void MostrarLabelDeError(string mensajeDeError)
        {
            this.LabelErrores.Visible = true;
            LabelErrores.ForeColor = Color.Red;
            this.LabelErrores.Text = mensajeDeError;
        }

        private void BotonIngresaContrasenaMaestra_Click(object sender, EventArgs e)
        {
            this.labelContrasenaInvalida.Visible = false;
            ContrasenaMaestra contrasenaUsuario = null;
            try
            {
                contrasenaUsuario = ObtenerContrasena();
            }
            catch (ExepcionContrasenaInvalida)
            {
                MostrarLabelDeError("Contraseña Invalida");
            }
            if (usuario.UsuarioYaPersistido()&&contrasenaUsuario!=null)
            {
                bool contrasenaCoincide = CotejarContrasenaDelUsuario(contrasenaUsuario, usuario);
                if (contrasenaCoincide)
                {
                    MostrarLabelDeError("Contraseña correcta");
                    ContrasenaUsuarioIngresada();
                }
                else
                {
                    MostrarLabelDeError("Contraseña Incorrecta");
                }
            }
            else
            {
                if (contrasenaUsuario != null)
                {
                    Usuario usuarioAPersistir = new Usuario();
                    usuarioAPersistir.ContrasenaMaestra = contrasenaUsuario;
                    usuario.PersistirUsuario(usuarioAPersistir);
                    ContrasenaUsuarioIngresada();
                }
                else
                {
                    MostrarLabelDeError("Contraseña Invalida");
                }
            }
        }
    }
}


