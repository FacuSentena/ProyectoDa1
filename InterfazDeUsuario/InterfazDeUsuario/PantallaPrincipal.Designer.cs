
namespace InterfazDeUsuario
{
    partial class PantallaPrincipal
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
            this.botonAdministrarContrasenas = new System.Windows.Forms.Button();
            this.botonAdministrarTarjetas = new System.Windows.Forms.Button();
            this.botonAdministrarCategorias = new System.Windows.Forms.Button();
            this.botonCambiarContrasenaUsuario = new System.Windows.Forms.Button();
            this.botonDataBreach = new System.Windows.Forms.Button();
            this.botonVerFortalezaContrasenas = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.panelBotonesAdministrar = new System.Windows.Forms.Panel();
            this.labelErrores = new System.Windows.Forms.Label();
            this.labelTextoCantidadCategorias = new System.Windows.Forms.Label();
            this.panelContadores = new System.Windows.Forms.Panel();
            this.labelCantidadContrasenas = new System.Windows.Forms.Label();
            this.labelCantidadTarjetas = new System.Windows.Forms.Label();
            this.labelCantidadCategorias = new System.Windows.Forms.Label();
            this.labelTextoCantidadTarjets = new System.Windows.Forms.Label();
            this.labelTextoCantidadContrasenas = new System.Windows.Forms.Label();
            this.botonVerDataBreaches = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBotonesAdministrar.SuspendLayout();
            this.panelContadores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonAdministrarContrasenas
            // 
            this.botonAdministrarContrasenas.Location = new System.Drawing.Point(4, 22);
            this.botonAdministrarContrasenas.Name = "botonAdministrarContrasenas";
            this.botonAdministrarContrasenas.Size = new System.Drawing.Size(117, 52);
            this.botonAdministrarContrasenas.TabIndex = 0;
            this.botonAdministrarContrasenas.Text = "Administrar Contraseñas";
            this.botonAdministrarContrasenas.UseVisualStyleBackColor = true;
            this.botonAdministrarContrasenas.Click += new System.EventHandler(this.BotonAdministrarContrasenas_Click);
            // 
            // botonAdministrarTarjetas
            // 
            this.botonAdministrarTarjetas.Location = new System.Drawing.Point(247, 22);
            this.botonAdministrarTarjetas.Name = "botonAdministrarTarjetas";
            this.botonAdministrarTarjetas.Size = new System.Drawing.Size(122, 52);
            this.botonAdministrarTarjetas.TabIndex = 1;
            this.botonAdministrarTarjetas.Text = "Administrar Tarjetas de Credito";
            this.botonAdministrarTarjetas.UseVisualStyleBackColor = true;
            this.botonAdministrarTarjetas.Click += new System.EventHandler(this.BotonAdministrarTarjetas_Click);
            // 
            // botonAdministrarCategorias
            // 
            this.botonAdministrarCategorias.Location = new System.Drawing.Point(127, 22);
            this.botonAdministrarCategorias.Name = "botonAdministrarCategorias";
            this.botonAdministrarCategorias.Size = new System.Drawing.Size(114, 52);
            this.botonAdministrarCategorias.TabIndex = 2;
            this.botonAdministrarCategorias.Text = "Administrar Categorías";
            this.botonAdministrarCategorias.UseVisualStyleBackColor = true;
            this.botonAdministrarCategorias.Click += new System.EventHandler(this.BotonAdministrarCategorias_Click);
            // 
            // botonCambiarContrasenaUsuario
            // 
            this.botonCambiarContrasenaUsuario.Location = new System.Drawing.Point(9, 74);
            this.botonCambiarContrasenaUsuario.Name = "botonCambiarContrasenaUsuario";
            this.botonCambiarContrasenaUsuario.Size = new System.Drawing.Size(107, 57);
            this.botonCambiarContrasenaUsuario.TabIndex = 3;
            this.botonCambiarContrasenaUsuario.Text = "Cambiar contraseña maestra";
            this.botonCambiarContrasenaUsuario.UseVisualStyleBackColor = true;
            this.botonCambiarContrasenaUsuario.Click += new System.EventHandler(this.BotonCambiarContrasenaUsuario_Click);
            // 
            // botonDataBreach
            // 
            this.botonDataBreach.Location = new System.Drawing.Point(16, 3);
            this.botonDataBreach.Name = "botonDataBreach";
            this.botonDataBreach.Size = new System.Drawing.Size(79, 45);
            this.botonDataBreach.TabIndex = 4;
            this.botonDataBreach.Text = "Ingresar data breaches";
            this.botonDataBreach.UseVisualStyleBackColor = true;
            this.botonDataBreach.Click += new System.EventHandler(this.BotonDataBreach_Click);
            // 
            // botonVerFortalezaContrasenas
            // 
            this.botonVerFortalezaContrasenas.Location = new System.Drawing.Point(9, 9);
            this.botonVerFortalezaContrasenas.Name = "botonVerFortalezaContrasenas";
            this.botonVerFortalezaContrasenas.Size = new System.Drawing.Size(107, 52);
            this.botonVerFortalezaContrasenas.TabIndex = 5;
            this.botonVerFortalezaContrasenas.Text = "Ver fortalezas de contraseñas";
            this.botonVerFortalezaContrasenas.UseVisualStyleBackColor = true;
            this.botonVerFortalezaContrasenas.Click += new System.EventHandler(this.BotonVerFortalezaContrasenas_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(520, 299);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(107, 49);
            this.botonSalir.TabIndex = 6;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // panelBotonesAdministrar
            // 
            this.panelBotonesAdministrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelBotonesAdministrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotonesAdministrar.Controls.Add(this.botonAdministrarContrasenas);
            this.panelBotonesAdministrar.Controls.Add(this.botonAdministrarCategorias);
            this.panelBotonesAdministrar.Controls.Add(this.botonAdministrarTarjetas);
            this.panelBotonesAdministrar.Location = new System.Drawing.Point(195, 19);
            this.panelBotonesAdministrar.Name = "panelBotonesAdministrar";
            this.panelBotonesAdministrar.Size = new System.Drawing.Size(388, 102);
            this.panelBotonesAdministrar.TabIndex = 7;
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(212, 130);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(10, 13);
            this.labelErrores.TabIndex = 8;
            this.labelErrores.Text = "-";
            // 
            // labelTextoCantidadCategorias
            // 
            this.labelTextoCantidadCategorias.AutoSize = true;
            this.labelTextoCantidadCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoCantidadCategorias.Location = new System.Drawing.Point(16, 16);
            this.labelTextoCantidadCategorias.Name = "labelTextoCantidadCategorias";
            this.labelTextoCantidadCategorias.Size = new System.Drawing.Size(154, 17);
            this.labelTextoCantidadCategorias.TabIndex = 9;
            this.labelTextoCantidadCategorias.Text = "Cantidad de categorías";
            // 
            // panelContadores
            // 
            this.panelContadores.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContadores.Controls.Add(this.labelCantidadContrasenas);
            this.panelContadores.Controls.Add(this.labelCantidadTarjetas);
            this.panelContadores.Controls.Add(this.labelCantidadCategorias);
            this.panelContadores.Controls.Add(this.labelTextoCantidadTarjets);
            this.panelContadores.Controls.Add(this.labelTextoCantidadContrasenas);
            this.panelContadores.Controls.Add(this.labelTextoCantidadCategorias);
            this.panelContadores.Location = new System.Drawing.Point(215, 169);
            this.panelContadores.Name = "panelContadores";
            this.panelContadores.Size = new System.Drawing.Size(283, 138);
            this.panelContadores.TabIndex = 10;
            // 
            // labelCantidadContrasenas
            // 
            this.labelCantidadContrasenas.AutoSize = true;
            this.labelCantidadContrasenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadContrasenas.Location = new System.Drawing.Point(238, 49);
            this.labelCantidadContrasenas.Name = "labelCantidadContrasenas";
            this.labelCantidadContrasenas.Size = new System.Drawing.Size(16, 17);
            this.labelCantidadContrasenas.TabIndex = 14;
            this.labelCantidadContrasenas.Text = "0";
            // 
            // labelCantidadTarjetas
            // 
            this.labelCantidadTarjetas.AutoSize = true;
            this.labelCantidadTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadTarjetas.Location = new System.Drawing.Point(238, 83);
            this.labelCantidadTarjetas.Name = "labelCantidadTarjetas";
            this.labelCantidadTarjetas.Size = new System.Drawing.Size(16, 17);
            this.labelCantidadTarjetas.TabIndex = 13;
            this.labelCantidadTarjetas.Text = "0";
            // 
            // labelCantidadCategorias
            // 
            this.labelCantidadCategorias.AutoSize = true;
            this.labelCantidadCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadCategorias.Location = new System.Drawing.Point(238, 20);
            this.labelCantidadCategorias.Name = "labelCantidadCategorias";
            this.labelCantidadCategorias.Size = new System.Drawing.Size(16, 17);
            this.labelCantidadCategorias.TabIndex = 12;
            this.labelCantidadCategorias.Text = "0";
            // 
            // labelTextoCantidadTarjets
            // 
            this.labelTextoCantidadTarjets.AutoSize = true;
            this.labelTextoCantidadTarjets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoCantidadTarjets.Location = new System.Drawing.Point(16, 83);
            this.labelTextoCantidadTarjets.Name = "labelTextoCantidadTarjets";
            this.labelTextoCantidadTarjets.Size = new System.Drawing.Size(202, 17);
            this.labelTextoCantidadTarjets.TabIndex = 11;
            this.labelTextoCantidadTarjets.Text = "Cantidad de tarjetas de crédito";
            // 
            // labelTextoCantidadContrasenas
            // 
            this.labelTextoCantidadContrasenas.AutoSize = true;
            this.labelTextoCantidadContrasenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoCantidadContrasenas.Location = new System.Drawing.Point(16, 49);
            this.labelTextoCantidadContrasenas.Name = "labelTextoCantidadContrasenas";
            this.labelTextoCantidadContrasenas.Size = new System.Drawing.Size(166, 17);
            this.labelTextoCantidadContrasenas.TabIndex = 10;
            this.labelTextoCantidadContrasenas.Text = "Cantidad de contraseñas";
            // 
            // botonVerDataBreaches
            // 
            this.botonVerDataBreaches.Location = new System.Drawing.Point(16, 67);
            this.botonVerDataBreaches.Name = "botonVerDataBreaches";
            this.botonVerDataBreaches.Size = new System.Drawing.Size(79, 55);
            this.botonVerDataBreaches.TabIndex = 11;
            this.botonVerDataBreaches.Text = "Ver históricos de data breaches";
            this.botonVerDataBreaches.UseVisualStyleBackColor = true;
            this.botonVerDataBreaches.Click += new System.EventHandler(this.BotonVerDataBreaches_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.botonVerDataBreaches);
            this.panel1.Controls.Add(this.botonDataBreach);
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 132);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.botonCambiarContrasenaUsuario);
            this.panel2.Controls.Add(this.botonVerFortalezaContrasenas);
            this.panel2.Location = new System.Drawing.Point(10, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 152);
            this.panel2.TabIndex = 13;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panelContadores);
            this.Controls.Add(this.labelErrores);
            this.Controls.Add(this.panelBotonesAdministrar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(30, 46);
            this.Name = "PantallaPrincipal";
            this.Size = new System.Drawing.Size(649, 364);
            this.panelBotonesAdministrar.ResumeLayout(false);
            this.panelContadores.ResumeLayout(false);
            this.panelContadores.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAdministrarContrasenas;
        private System.Windows.Forms.Button botonAdministrarTarjetas;
        private System.Windows.Forms.Button botonAdministrarCategorias;
        private System.Windows.Forms.Button botonCambiarContrasenaUsuario;
        private System.Windows.Forms.Button botonDataBreach;
        private System.Windows.Forms.Button botonVerFortalezaContrasenas;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Panel panelBotonesAdministrar;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.Label labelTextoCantidadCategorias;
        private System.Windows.Forms.Panel panelContadores;
        private System.Windows.Forms.Label labelCantidadContrasenas;
        private System.Windows.Forms.Label labelCantidadTarjetas;
        private System.Windows.Forms.Label labelCantidadCategorias;
        private System.Windows.Forms.Label labelTextoCantidadTarjets;
        private System.Windows.Forms.Label labelTextoCantidadContrasenas;
        private System.Windows.Forms.Button botonVerDataBreaches;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
