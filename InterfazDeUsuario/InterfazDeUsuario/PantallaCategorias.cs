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
    public delegate void ManejarPanelCategorias();

    public partial class PantallaCategorias : UserControl
    {
        private IRepositorioCategorias<Categoria> categorias;

        private event ManejarPanelCategorias BotonAgregarPresionado;

        private event ManejarPanelCategorias BotonSalirPresionado;

        public PantallaCategorias(IRepositorioCategorias<Categoria> repoCategorias)
        {
            categorias = repoCategorias;
            InitializeComponent();
            LlenarLista();
        }

        private void EditarNombreCategoria()
        {
            string nombreCategoriaABuscar = listaCategorias.SelectedItem.ToString();
            string nuevoNombre = campoNuevoNombre.Text;
            if (nuevoNombre.Length > 3 && nuevoNombre.Length < 15)
            {
                categorias.Editar(nombreCategoriaABuscar, nuevoNombre);
            }
        }

        public void LlenarLista()
        {
            listaCategorias.DataSource = categorias.DarColeccion();
        }

        public void BotonAgregarCategoriaPresionado(ManejarPanelCategorias delegado)
        {
            BotonAgregarPresionado += delegado;
        }

        public void BotonSalirDeCategoriaPresionado(ManejarPanelCategorias delegado)
        {
            BotonSalirPresionado += delegado;
        }

        private void BotonAgregarCategoria_Click(object sender, EventArgs e)
        {
            BotonAgregarPresionado();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            BotonSalirPresionado();
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            EditarNombreCategoria();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(panelListCategorias);
            LlenarLista();
            campoNuevoNombre.ResetText();
        }

        private void BotonModificarCategoria_Click(object sender, EventArgs e)
        {
            if (listaCategorias.Items.Count > 0)
            {
                panelPrincipal.Controls.Clear();
                panelPrincipal.Controls.Add(panelEditarCategorias);
                panelEditarCategorias.Visible = true;
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(panelListCategorias);
            LlenarLista();
        }
    }
}