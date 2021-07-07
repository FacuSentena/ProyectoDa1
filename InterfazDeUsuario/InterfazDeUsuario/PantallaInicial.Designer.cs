
namespace InterfazDeUsuario
{
    partial class PantallaInicial
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPantallaPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPantallaPrincipal
            // 
            this.panelPantallaPrincipal.Location = new System.Drawing.Point(168, 32);
            this.panelPantallaPrincipal.Name = "panelPantallaPrincipal";
            this.panelPantallaPrincipal.Size = new System.Drawing.Size(679, 454);
            this.panelPantallaPrincipal.TabIndex = 0;
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 516);
            this.Controls.Add(this.panelPantallaPrincipal);
            this.Name = "PantallaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Contraseñas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPantallaPrincipal;
    }
}

