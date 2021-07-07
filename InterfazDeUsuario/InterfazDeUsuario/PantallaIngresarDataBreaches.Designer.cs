
namespace InterfazDeUsuario
{
    partial class PantallaIngresarDataBreaches
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
            this.campoDatosExpuestos = new System.Windows.Forms.TextBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelTxt = new System.Windows.Forms.Panel();
            this.labelInformacion = new System.Windows.Forms.Label();
            this.botonBuscarEnArhivo = new System.Windows.Forms.Button();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.dialogoAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.panelPrincipal.SuspendLayout();
            this.panelTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // campoDatosExpuestos
            // 
            this.campoDatosExpuestos.Location = new System.Drawing.Point(54, 41);
            this.campoDatosExpuestos.Multiline = true;
            this.campoDatosExpuestos.Name = "campoDatosExpuestos";
            this.campoDatosExpuestos.Size = new System.Drawing.Size(205, 235);
            this.campoDatosExpuestos.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelTxt);
            this.panelPrincipal.Controls.Add(this.botonSalir);
            this.panelPrincipal.Location = new System.Drawing.Point(32, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(374, 400);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelTxt
            // 
            this.panelTxt.Controls.Add(this.labelInformacion);
            this.panelTxt.Controls.Add(this.botonBuscarEnArhivo);
            this.panelTxt.Controls.Add(this.campoDatosExpuestos);
            this.panelTxt.Controls.Add(this.botonIngresar);
            this.panelTxt.Location = new System.Drawing.Point(31, 54);
            this.panelTxt.Name = "panelTxt";
            this.panelTxt.Size = new System.Drawing.Size(296, 329);
            this.panelTxt.TabIndex = 2;
            // 
            // labelInformacion
            // 
            this.labelInformacion.AutoSize = true;
            this.labelInformacion.Location = new System.Drawing.Point(124, 16);
            this.labelInformacion.Name = "labelInformacion";
            this.labelInformacion.Size = new System.Drawing.Size(10, 13);
            this.labelInformacion.TabIndex = 6;
            this.labelInformacion.Text = "-";
            // 
            // botonBuscarEnArhivo
            // 
            this.botonBuscarEnArhivo.Location = new System.Drawing.Point(20, 282);
            this.botonBuscarEnArhivo.Name = "botonBuscarEnArhivo";
            this.botonBuscarEnArhivo.Size = new System.Drawing.Size(127, 23);
            this.botonBuscarEnArhivo.TabIndex = 5;
            this.botonBuscarEnArhivo.Text = "Buscar desde archivo";
            this.botonBuscarEnArhivo.UseVisualStyleBackColor = true;
            this.botonBuscarEnArhivo.Click += new System.EventHandler(this.BotonBuscarEnArhivo_Click);
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(205, 282);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(75, 23);
            this.botonIngresar.TabIndex = 1;
            this.botonIngresar.Text = "Ingresar ";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.BotonIngresar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(3, 3);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // dialogoAbrirArchivo
            // 
            this.dialogoAbrirArchivo.FileName = "openFileDialog1";
            // 
            // PantallaIngresarDataBreaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Name = "PantallaIngresarDataBreaches";
            this.Size = new System.Drawing.Size(449, 415);
            this.panelPrincipal.ResumeLayout(false);
            this.panelTxt.ResumeLayout(false);
            this.panelTxt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox campoDatosExpuestos;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelTxt;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Button botonBuscarEnArhivo;
        private System.Windows.Forms.OpenFileDialog dialogoAbrirArchivo;
        private System.Windows.Forms.Label labelInformacion;
    }
}
