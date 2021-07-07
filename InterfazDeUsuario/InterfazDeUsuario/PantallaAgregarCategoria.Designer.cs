
namespace InterfazDeUsuario
{
    partial class PantallaAgregarCategoria
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
            this.campoNombreCategoria = new System.Windows.Forms.TextBox();
            this.botonAgregarCategoria = new System.Windows.Forms.Button();
            this.labelAgregarCategoria = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.labelInformarNoAgregado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campoNombreCategoria
            // 
            this.campoNombreCategoria.Location = new System.Drawing.Point(82, 77);
            this.campoNombreCategoria.Name = "campoNombreCategoria";
            this.campoNombreCategoria.Size = new System.Drawing.Size(173, 20);
            this.campoNombreCategoria.TabIndex = 0;
            // 
            // botonAgregarCategoria
            // 
            this.botonAgregarCategoria.Location = new System.Drawing.Point(230, 116);
            this.botonAgregarCategoria.Name = "botonAgregarCategoria";
            this.botonAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarCategoria.TabIndex = 1;
            this.botonAgregarCategoria.Text = "Agregar";
            this.botonAgregarCategoria.UseVisualStyleBackColor = true;
            this.botonAgregarCategoria.Click += new System.EventHandler(this.BotonAgregarCategoria_Click);
            // 
            // labelAgregarCategoria
            // 
            this.labelAgregarCategoria.AutoSize = true;
            this.labelAgregarCategoria.Location = new System.Drawing.Point(120, 47);
            this.labelAgregarCategoria.Name = "labelAgregarCategoria";
            this.labelAgregarCategoria.Size = new System.Drawing.Size(94, 13);
            this.labelAgregarCategoria.TabIndex = 2;
            this.labelAgregarCategoria.Text = "Agregar Categoría";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(32, 116);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // labelInformarNoAgregado
            // 
            this.labelInformarNoAgregado.AutoSize = true;
            this.labelInformarNoAgregado.Location = new System.Drawing.Point(46, 142);
            this.labelInformarNoAgregado.Name = "labelInformarNoAgregado";
            this.labelInformarNoAgregado.Size = new System.Drawing.Size(0, 13);
            this.labelInformarNoAgregado.TabIndex = 4;
            // 
            // PantallaAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelInformarNoAgregado);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.labelAgregarCategoria);
            this.Controls.Add(this.botonAgregarCategoria);
            this.Controls.Add(this.campoNombreCategoria);
            this.Location = new System.Drawing.Point(150, 115);
            this.Name = "PantallaAgregarCategoria";
            this.Size = new System.Drawing.Size(337, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoNombreCategoria;
        private System.Windows.Forms.Button botonAgregarCategoria;
        private System.Windows.Forms.Label labelAgregarCategoria;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label labelInformarNoAgregado;
    }
}
