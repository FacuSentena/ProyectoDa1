
namespace InterfazDeUsuario
{
    partial class PantallaVerDataBreaches
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
            this.panelVerExpuestos = new System.Windows.Forms.Panel();
            this.labelSoloModificados = new System.Windows.Forms.Label();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.listaDeTarjetasExpuestas = new System.Windows.Forms.ListBox();
            this.labelTarjetasExpuestas = new System.Windows.Forms.Label();
            this.labelParesExpuestos = new System.Windows.Forms.Label();
            this.listaDeParesExpuestos = new System.Windows.Forms.ListBox();
            this.panelVerDataBreach = new System.Windows.Forms.Panel();
            this.botonSalirDataBreach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botonSeleccionar = new System.Windows.Forms.Button();
            this.listaDataBreach = new System.Windows.Forms.ListBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelEditar = new System.Windows.Forms.Panel();
            this.labelErroresContrasena = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.campoContrasena = new System.Windows.Forms.TextBox();
            this.panelVerExpuestos.SuspendLayout();
            this.panelVerDataBreach.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVerExpuestos
            // 
            this.panelVerExpuestos.Controls.Add(this.labelSoloModificados);
            this.panelVerExpuestos.Controls.Add(this.botonModificar);
            this.panelVerExpuestos.Controls.Add(this.botonVolver);
            this.panelVerExpuestos.Controls.Add(this.listaDeTarjetasExpuestas);
            this.panelVerExpuestos.Controls.Add(this.labelTarjetasExpuestas);
            this.panelVerExpuestos.Controls.Add(this.labelParesExpuestos);
            this.panelVerExpuestos.Controls.Add(this.listaDeParesExpuestos);
            this.panelVerExpuestos.Location = new System.Drawing.Point(126, 3);
            this.panelVerExpuestos.Name = "panelVerExpuestos";
            this.panelVerExpuestos.Size = new System.Drawing.Size(341, 416);
            this.panelVerExpuestos.TabIndex = 4;
            this.panelVerExpuestos.Visible = false;
            // 
            // labelSoloModificados
            // 
            this.labelSoloModificados.AutoSize = true;
            this.labelSoloModificados.Location = new System.Drawing.Point(3, 219);
            this.labelSoloModificados.Name = "labelSoloModificados";
            this.labelSoloModificados.Size = new System.Drawing.Size(10, 13);
            this.labelSoloModificados.TabIndex = 6;
            this.labelSoloModificados.Text = "-";
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(230, 191);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(75, 23);
            this.botonModificar.TabIndex = 5;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(17, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 4;
            this.botonVolver.Text = "Salir";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // listaDeTarjetasExpuestas
            // 
            this.listaDeTarjetasExpuestas.FormattingEnabled = true;
            this.listaDeTarjetasExpuestas.HorizontalScrollbar = true;
            this.listaDeTarjetasExpuestas.Location = new System.Drawing.Point(17, 267);
            this.listaDeTarjetasExpuestas.Name = "listaDeTarjetasExpuestas";
            this.listaDeTarjetasExpuestas.Size = new System.Drawing.Size(300, 121);
            this.listaDeTarjetasExpuestas.TabIndex = 3;
            // 
            // labelTarjetasExpuestas
            // 
            this.labelTarjetasExpuestas.AutoSize = true;
            this.labelTarjetasExpuestas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTarjetasExpuestas.ForeColor = System.Drawing.Color.Red;
            this.labelTarjetasExpuestas.Location = new System.Drawing.Point(118, 249);
            this.labelTarjetasExpuestas.Name = "labelTarjetasExpuestas";
            this.labelTarjetasExpuestas.Size = new System.Drawing.Size(98, 15);
            this.labelTarjetasExpuestas.TabIndex = 2;
            this.labelTarjetasExpuestas.Text = "Tarjetas expuestas";
            // 
            // labelParesExpuestos
            // 
            this.labelParesExpuestos.AutoSize = true;
            this.labelParesExpuestos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelParesExpuestos.ForeColor = System.Drawing.Color.Red;
            this.labelParesExpuestos.Location = new System.Drawing.Point(118, 20);
            this.labelParesExpuestos.Name = "labelParesExpuestos";
            this.labelParesExpuestos.Size = new System.Drawing.Size(119, 15);
            this.labelParesExpuestos.TabIndex = 1;
            this.labelParesExpuestos.Text = "Contraseñas expuestas";
            // 
            // listaDeParesExpuestos
            // 
            this.listaDeParesExpuestos.CausesValidation = false;
            this.listaDeParesExpuestos.FormattingEnabled = true;
            this.listaDeParesExpuestos.HorizontalScrollbar = true;
            this.listaDeParesExpuestos.Location = new System.Drawing.Point(21, 38);
            this.listaDeParesExpuestos.Name = "listaDeParesExpuestos";
            this.listaDeParesExpuestos.Size = new System.Drawing.Size(300, 147);
            this.listaDeParesExpuestos.TabIndex = 0;
            // 
            // panelVerDataBreach
            // 
            this.panelVerDataBreach.Controls.Add(this.botonSalirDataBreach);
            this.panelVerDataBreach.Controls.Add(this.label1);
            this.panelVerDataBreach.Controls.Add(this.botonSeleccionar);
            this.panelVerDataBreach.Controls.Add(this.listaDataBreach);
            this.panelVerDataBreach.Location = new System.Drawing.Point(74, 51);
            this.panelVerDataBreach.Name = "panelVerDataBreach";
            this.panelVerDataBreach.Size = new System.Drawing.Size(383, 259);
            this.panelVerDataBreach.TabIndex = 5;
            // 
            // botonSalirDataBreach
            // 
            this.botonSalirDataBreach.Location = new System.Drawing.Point(282, 12);
            this.botonSalirDataBreach.Name = "botonSalirDataBreach";
            this.botonSalirDataBreach.Size = new System.Drawing.Size(75, 23);
            this.botonSalirDataBreach.TabIndex = 7;
            this.botonSalirDataBreach.Text = "Salir";
            this.botonSalirDataBreach.UseVisualStyleBackColor = true;
            this.botonSalirDataBreach.Click += new System.EventHandler(this.BotonSalirDataBreach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Historico Data Breaches";
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.Location = new System.Drawing.Point(282, 219);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.botonSeleccionar.TabIndex = 5;
            this.botonSeleccionar.Text = "Seleccionar";
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.BotonSeleccionar_Click);
            // 
            // listaDataBreach
            // 
            this.listaDataBreach.FormattingEnabled = true;
            this.listaDataBreach.HorizontalScrollbar = true;
            this.listaDataBreach.Location = new System.Drawing.Point(17, 43);
            this.listaDataBreach.Name = "listaDataBreach";
            this.listaDataBreach.Size = new System.Drawing.Size(324, 160);
            this.listaDataBreach.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelEditar);
            this.panelPrincipal.Controls.Add(this.panelVerExpuestos);
            this.panelPrincipal.Controls.Add(this.panelVerDataBreach);
            this.panelPrincipal.Location = new System.Drawing.Point(52, 18);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(566, 419);
            this.panelPrincipal.TabIndex = 6;
            // 
            // panelEditar
            // 
            this.panelEditar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditar.Controls.Add(this.labelErroresContrasena);
            this.panelEditar.Controls.Add(this.label3);
            this.panelEditar.Controls.Add(this.botonCancelar);
            this.panelEditar.Controls.Add(this.botonEditar);
            this.panelEditar.Controls.Add(this.campoContrasena);
            this.panelEditar.Location = new System.Drawing.Point(113, 6);
            this.panelEditar.Name = "panelEditar";
            this.panelEditar.Size = new System.Drawing.Size(318, 198);
            this.panelEditar.TabIndex = 20;
            this.panelEditar.Visible = false;
            // 
            // labelErroresContrasena
            // 
            this.labelErroresContrasena.AutoSize = true;
            this.labelErroresContrasena.Location = new System.Drawing.Point(174, 140);
            this.labelErroresContrasena.Name = "labelErroresContrasena";
            this.labelErroresContrasena.Size = new System.Drawing.Size(10, 13);
            this.labelErroresContrasena.TabIndex = 23;
            this.labelErroresContrasena.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Clave";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(32, 133);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 19;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(207, 135);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 16;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // campoContrasena
            // 
            this.campoContrasena.Location = new System.Drawing.Point(98, 70);
            this.campoContrasena.Name = "campoContrasena";
            this.campoContrasena.Size = new System.Drawing.Size(146, 20);
            this.campoContrasena.TabIndex = 10;
            // 
            // PantallaVerDataBreaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Name = "PantallaVerDataBreaches";
            this.Size = new System.Drawing.Size(664, 469);
            this.panelVerExpuestos.ResumeLayout(false);
            this.panelVerExpuestos.PerformLayout();
            this.panelVerDataBreach.ResumeLayout(false);
            this.panelVerDataBreach.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelEditar.ResumeLayout(false);
            this.panelEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVerExpuestos;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.ListBox listaDeTarjetasExpuestas;
        private System.Windows.Forms.Label labelTarjetasExpuestas;
        private System.Windows.Forms.Label labelParesExpuestos;
        private System.Windows.Forms.ListBox listaDeParesExpuestos;
        private System.Windows.Forms.Panel panelVerDataBreach;
        private System.Windows.Forms.Button botonSeleccionar;
        private System.Windows.Forms.ListBox listaDataBreach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button botonSalirDataBreach;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Label labelSoloModificados;
        private System.Windows.Forms.Panel panelEditar;
        private System.Windows.Forms.Label labelErroresContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.TextBox campoContrasena;
    }
}
