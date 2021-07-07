
namespace InterfazDeUsuario
{
    partial class PantallaCambiarContrasena
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
            this.components = new System.ComponentModel.Container();
            this.campoContrasenaAntigua = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.campoContrasenaNueva = new System.Windows.Forms.TextBox();
            this.labelContrasenaAntigua = new System.Windows.Forms.Label();
            this.labelContrasenaNueva = new System.Windows.Forms.Label();
            this.botonCambiar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.labelErrores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campoContrasenaAntigua
            // 
            this.campoContrasenaAntigua.Location = new System.Drawing.Point(167, 69);
            this.campoContrasenaAntigua.Name = "campoContrasenaAntigua";
            this.campoContrasenaAntigua.Size = new System.Drawing.Size(100, 20);
            this.campoContrasenaAntigua.TabIndex = 0;
            this.campoContrasenaAntigua.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // campoContrasenaNueva
            // 
            this.campoContrasenaNueva.Location = new System.Drawing.Point(167, 114);
            this.campoContrasenaNueva.Name = "campoContrasenaNueva";
            this.campoContrasenaNueva.Size = new System.Drawing.Size(100, 20);
            this.campoContrasenaNueva.TabIndex = 2;
            this.campoContrasenaNueva.UseSystemPasswordChar = true;
            // 
            // labelContrasenaAntigua
            // 
            this.labelContrasenaAntigua.AutoSize = true;
            this.labelContrasenaAntigua.Location = new System.Drawing.Point(49, 72);
            this.labelContrasenaAntigua.Name = "labelContrasenaAntigua";
            this.labelContrasenaAntigua.Size = new System.Drawing.Size(99, 13);
            this.labelContrasenaAntigua.TabIndex = 3;
            this.labelContrasenaAntigua.Text = "Contraseña antigua";
            // 
            // labelContrasenaNueva
            // 
            this.labelContrasenaNueva.AutoSize = true;
            this.labelContrasenaNueva.Location = new System.Drawing.Point(49, 117);
            this.labelContrasenaNueva.Name = "labelContrasenaNueva";
            this.labelContrasenaNueva.Size = new System.Drawing.Size(94, 13);
            this.labelContrasenaNueva.TabIndex = 4;
            this.labelContrasenaNueva.Text = "Contraseña nueva";
            // 
            // botonCambiar
            // 
            this.botonCambiar.Location = new System.Drawing.Point(192, 193);
            this.botonCambiar.Name = "botonCambiar";
            this.botonCambiar.Size = new System.Drawing.Size(75, 23);
            this.botonCambiar.TabIndex = 5;
            this.botonCambiar.Text = "Cambiar";
            this.botonCambiar.UseVisualStyleBackColor = true;
            this.botonCambiar.Click += new System.EventHandler(this.BotonCambiar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(52, 193);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 6;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(81, 159);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(10, 13);
            this.labelErrores.TabIndex = 7;
            this.labelErrores.Text = "-";
            this.labelErrores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelErrores.Visible = false;
            // 
            // PantallaCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelErrores);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonCambiar);
            this.Controls.Add(this.labelContrasenaNueva);
            this.Controls.Add(this.labelContrasenaAntigua);
            this.Controls.Add(this.campoContrasenaNueva);
            this.Controls.Add(this.campoContrasenaAntigua);
            this.Location = new System.Drawing.Point(130, 80);
            this.Name = "PantallaCambiarContrasena";
            this.Size = new System.Drawing.Size(415, 248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoContrasenaAntigua;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox campoContrasenaNueva;
        private System.Windows.Forms.Label labelContrasenaAntigua;
        private System.Windows.Forms.Label labelContrasenaNueva;
        private System.Windows.Forms.Button botonCambiar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label labelErrores;
    }
}
