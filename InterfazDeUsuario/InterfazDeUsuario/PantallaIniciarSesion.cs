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
    public delegate void ManejarPaneIniciarSesion();

    public partial class PantallaIniciarSesion : UserControl
    {
        private Usuario usuario;

        private ManejarPaneIniciarSesion contrasenaIngresada;

        public PantallaIniciarSesion(Usuario unUsuario)
        {
            InitializeComponent();
            usuario = unUsuario;
            labelContrasenaIncorrecta.Visible = false;
        }

        public void ContrasenaFueIngresada(ManejarPaneIniciarSesion delegado)
        {
            contrasenaIngresada += delegado;
        }
        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (usuario.ContrasenaMaestra.Clave == campoTextoCotrasena.Text)
            {
                contrasenaIngresada();
            }
            else
            {
                labelContrasenaIncorrecta.Text = "Contraseña incorrecta";
                labelContrasenaIncorrecta.ForeColor = Color.Red;
                labelContrasenaIncorrecta.Visible = true;
            }
        }
    }
}
