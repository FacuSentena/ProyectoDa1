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
    public delegate void ManejarPanelCrearCategorias();

    public partial class PantallaAgregarCategoria : UserControl
    {
        private IRepositorioCategorias<Categoria> categorias;

        private ManejarPanelCrearCategorias botonSeleccionado;

        public PantallaAgregarCategoria(IRepositorioCategorias<Categoria> repoCategorias)
        {
            InitializeComponent();
            categorias = repoCategorias;
            labelInformarNoAgregado.Visible = false;
        }

        public void BotonAgregarOSalirPresionado(ManejarPanelCrearCategorias delegado)
        {
            botonSeleccionado += delegado;
        }

        private void AgregarCategoria()
        {
            Categoria categoriaACrear;
            try
            {
                string nombre = this.campoNombreCategoria.Text;
                categoriaACrear = new Categoria(nombre);
                categorias.Agregar(categoriaACrear);
                this.labelInformarNoAgregado.Visible = false;
                botonSeleccionado();
            }
            catch (Exception)
            {
                labelInformarNoAgregado.Visible = true;
                labelInformarNoAgregado.ForeColor = Color.Red;
                labelInformarNoAgregado.Text = "Cateogria con nombre de largo invalido o ya existente";
            }
        }

        private void BotonAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            botonSeleccionado();
        }
    }
}
