
namespace InterfazDeUsuario
{
    partial class PantallaCategorias
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaCategorias = new System.Windows.Forms.ListBox();
            this.botonAgregarCategoria = new System.Windows.Forms.Button();
            this.botonModificarCategoria = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.panelListCategorias = new System.Windows.Forms.Panel();
            this.panelEditarCategorias = new System.Windows.Forms.Panel();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.labelNuevoNombre = new System.Windows.Forms.Label();
            this.campoNuevoNombre = new System.Windows.Forms.TextBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelListCategorias.SuspendLayout();
            this.panelEditarCategorias.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaCategorias
            // 
            this.listaCategorias.FormattingEnabled = true;
            this.listaCategorias.Location = new System.Drawing.Point(45, 55);
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.Size = new System.Drawing.Size(252, 186);
            this.listaCategorias.TabIndex = 0;
            // 
            // botonAgregarCategoria
            // 
            this.botonAgregarCategoria.Location = new System.Drawing.Point(45, 247);
            this.botonAgregarCategoria.Name = "botonAgregarCategoria";
            this.botonAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarCategoria.TabIndex = 1;
            this.botonAgregarCategoria.Text = "Agregar";
            this.botonAgregarCategoria.UseVisualStyleBackColor = true;
            this.botonAgregarCategoria.Click += new System.EventHandler(this.BotonAgregarCategoria_Click);
            // 
            // botonModificarCategoria
            // 
            this.botonModificarCategoria.Location = new System.Drawing.Point(196, 247);
            this.botonModificarCategoria.Name = "botonModificarCategoria";
            this.botonModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.botonModificarCategoria.TabIndex = 2;
            this.botonModificarCategoria.Text = "Modificar";
            this.botonModificarCategoria.UseVisualStyleBackColor = true;
            this.botonModificarCategoria.Click += new System.EventHandler(this.BotonModificarCategoria_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(3, 12);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // panelListCategorias
            // 
            this.panelListCategorias.Controls.Add(this.panelEditarCategorias);
            this.panelListCategorias.Controls.Add(this.listaCategorias);
            this.panelListCategorias.Controls.Add(this.botonSalir);
            this.panelListCategorias.Controls.Add(this.botonAgregarCategoria);
            this.panelListCategorias.Controls.Add(this.botonModificarCategoria);
            this.panelListCategorias.Location = new System.Drawing.Point(38, 19);
            this.panelListCategorias.Name = "panelListCategorias";
            this.panelListCategorias.Size = new System.Drawing.Size(399, 319);
            this.panelListCategorias.TabIndex = 4;
            // 
            // panelEditarCategorias
            // 
            this.panelEditarCategorias.Controls.Add(this.botonCancelar);
            this.panelEditarCategorias.Controls.Add(this.botonEditar);
            this.panelEditarCategorias.Controls.Add(this.labelNuevoNombre);
            this.panelEditarCategorias.Controls.Add(this.campoNuevoNombre);
            this.panelEditarCategorias.Location = new System.Drawing.Point(70, 82);
            this.panelEditarCategorias.Name = "panelEditarCategorias";
            this.panelEditarCategorias.Size = new System.Drawing.Size(249, 137);
            this.panelEditarCategorias.TabIndex = 6;
            this.panelEditarCategorias.Visible = false;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(17, 86);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 3;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(139, 86);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 2;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // labelNuevoNombre
            // 
            this.labelNuevoNombre.AutoSize = true;
            this.labelNuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoNombre.Location = new System.Drawing.Point(14, 37);
            this.labelNuevoNombre.Name = "labelNuevoNombre";
            this.labelNuevoNombre.Size = new System.Drawing.Size(88, 15);
            this.labelNuevoNombre.TabIndex = 1;
            this.labelNuevoNombre.Text = "Nuevo nombre";
            // 
            // campoNuevoNombre
            // 
            this.campoNuevoNombre.Location = new System.Drawing.Point(113, 36);
            this.campoNuevoNombre.Name = "campoNuevoNombre";
            this.campoNuevoNombre.Size = new System.Drawing.Size(114, 20);
            this.campoNuevoNombre.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelListCategorias);
            this.panelPrincipal.Location = new System.Drawing.Point(73, 30);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(469, 353);
            this.panelPrincipal.TabIndex = 5;
            // 
            // PantallaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Location = new System.Drawing.Point(48, 9);
            this.Name = "PantallaCategorias";
            this.Size = new System.Drawing.Size(611, 409);
            this.panelListCategorias.ResumeLayout(false);
            this.panelEditarCategorias.ResumeLayout(false);
            this.panelEditarCategorias.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaCategorias;
        private System.Windows.Forms.Button botonAgregarCategoria;
        private System.Windows.Forms.Button botonModificarCategoria;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Panel panelListCategorias;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelEditarCategorias;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Label labelNuevoNombre;
        private System.Windows.Forms.TextBox campoNuevoNombre;
    }
}
