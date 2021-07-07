namespace InterfazDeUsuario
{
    partial class PantallaIngreso
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
            this.labelContrasenaMaestra = new System.Windows.Forms.Label();
            this.campoDeTextoContrasenaMaestra = new System.Windows.Forms.TextBox();
            this.botonIngresaContrasenaMaestra = new System.Windows.Forms.Button();
            this.labelContrasenaInvalida = new System.Windows.Forms.Label();
            this.panelIngreso = new System.Windows.Forms.Panel();
            this.LabelErrores = new System.Windows.Forms.Label();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.panelIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelContrasenaMaestra
            // 
            this.labelContrasenaMaestra.AutoSize = true;
            this.labelContrasenaMaestra.Location = new System.Drawing.Point(22, 98);
            this.labelContrasenaMaestra.Name = "labelContrasenaMaestra";
            this.labelContrasenaMaestra.Size = new System.Drawing.Size(61, 13);
            this.labelContrasenaMaestra.TabIndex = 0;
            this.labelContrasenaMaestra.Text = "Contrasena";
            // 
            // campoDeTextoContrasenaMaestra
            // 
            this.campoDeTextoContrasenaMaestra.Location = new System.Drawing.Point(101, 95);
            this.campoDeTextoContrasenaMaestra.Name = "campoDeTextoContrasenaMaestra";
            this.campoDeTextoContrasenaMaestra.Size = new System.Drawing.Size(100, 20);
            this.campoDeTextoContrasenaMaestra.TabIndex = 1;
            this.campoDeTextoContrasenaMaestra.UseSystemPasswordChar = true;
            // 
            // botonIngresaContrasenaMaestra
            // 
            this.botonIngresaContrasenaMaestra.Location = new System.Drawing.Point(232, 89);
            this.botonIngresaContrasenaMaestra.Name = "botonIngresaContrasenaMaestra";
            this.botonIngresaContrasenaMaestra.Size = new System.Drawing.Size(78, 31);
            this.botonIngresaContrasenaMaestra.TabIndex = 2;
            this.botonIngresaContrasenaMaestra.Text = "Aceptar";
            this.botonIngresaContrasenaMaestra.UseVisualStyleBackColor = true;
            this.botonIngresaContrasenaMaestra.Click += new System.EventHandler(this.BotonIngresaContrasenaMaestra_Click);
            // 
            // labelContrasenaInvalida
            // 
            this.labelContrasenaInvalida.AutoSize = true;
            this.labelContrasenaInvalida.ForeColor = System.Drawing.Color.Red;
            this.labelContrasenaInvalida.Location = new System.Drawing.Point(163, 46);
            this.labelContrasenaInvalida.Name = "labelContrasenaInvalida";
            this.labelContrasenaInvalida.Size = new System.Drawing.Size(0, 13);
            this.labelContrasenaInvalida.TabIndex = 3;
            // 
            // panelIngreso
            // 
            this.panelIngreso.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelIngreso.Controls.Add(this.LabelErrores);
            this.panelIngreso.Controls.Add(this.labelIngreso);
            this.panelIngreso.Controls.Add(this.labelContrasenaMaestra);
            this.panelIngreso.Controls.Add(this.campoDeTextoContrasenaMaestra);
            this.panelIngreso.Controls.Add(this.botonIngresaContrasenaMaestra);
            this.panelIngreso.Location = new System.Drawing.Point(55, 46);
            this.panelIngreso.Name = "panelIngreso";
            this.panelIngreso.Size = new System.Drawing.Size(363, 207);
            this.panelIngreso.TabIndex = 4;
            // 
            // LabelErrores
            // 
            this.LabelErrores.AutoSize = true;
            this.LabelErrores.Location = new System.Drawing.Point(120, 135);
            this.LabelErrores.Name = "LabelErrores";
            this.LabelErrores.Size = new System.Drawing.Size(10, 13);
            this.LabelErrores.TabIndex = 4;
            this.LabelErrores.Text = "-";
            // 
            // labelIngreso
            // 
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Location = new System.Drawing.Point(78, 51);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(152, 13);
            this.labelIngreso.TabIndex = 3;
            this.labelIngreso.Text = "Ingrese su contraseña maestra";
            // 
            // PantallaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panelIngreso);
            this.Controls.Add(this.labelContrasenaInvalida);
            this.Location = new System.Drawing.Point(78, 48);
            this.Name = "PantallaIngreso";
            this.Size = new System.Drawing.Size(465, 292);
            this.panelIngreso.ResumeLayout(false);
            this.panelIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContrasenaMaestra;
        private System.Windows.Forms.TextBox campoDeTextoContrasenaMaestra;
        private System.Windows.Forms.Button botonIngresaContrasenaMaestra;
        private System.Windows.Forms.Label labelContrasenaInvalida;
        private System.Windows.Forms.Panel panelIngreso;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.Label LabelErrores;
    }
}