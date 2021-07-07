
namespace InterfazDeUsuario
{
    partial class PantallaTarjetasDeCredito
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelVer = new System.Windows.Forms.Panel();
            this.botonCerrarPanelVer = new System.Windows.Forms.Button();
            this.labelContarSegundos = new System.Windows.Forms.Label();
            this.listaVerTarjeta = new System.Windows.Forms.ListBox();
            this.panelTarjetas = new System.Windows.Forms.Panel();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonSalirPrincipal = new System.Windows.Forms.Button();
            this.botonVer = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.listaTarjetas = new System.Windows.Forms.ListBox();
            this.panelEditar = new System.Windows.Forms.Panel();
            this.labelErrores = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.labelVencimiento = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelCodigoDeSeguridad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.botonEditarPanelEditar = new System.Windows.Forms.Button();
            this.campoCodigoVencimiento = new System.Windows.Forms.TextBox();
            this.campoTipo = new System.Windows.Forms.TextBox();
            this.campoCodigo = new System.Windows.Forms.TextBox();
            this.campoCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.temporizadorVer = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipal.SuspendLayout();
            this.panelVer.SuspendLayout();
            this.panelTarjetas.SuspendLayout();
            this.panelEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelTarjetas);
            this.panelPrincipal.Location = new System.Drawing.Point(20, 6);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(775, 333);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelVer
            // 
            this.panelVer.Controls.Add(this.botonCerrarPanelVer);
            this.panelVer.Controls.Add(this.labelContarSegundos);
            this.panelVer.Controls.Add(this.listaVerTarjeta);
            this.panelVer.Location = new System.Drawing.Point(21, 49);
            this.panelVer.Name = "panelVer";
            this.panelVer.Size = new System.Drawing.Size(533, 187);
            this.panelVer.TabIndex = 6;
            this.panelVer.Visible = false;
            // 
            // botonCerrarPanelVer
            // 
            this.botonCerrarPanelVer.Location = new System.Drawing.Point(0, 9);
            this.botonCerrarPanelVer.Name = "botonCerrarPanelVer";
            this.botonCerrarPanelVer.Size = new System.Drawing.Size(75, 23);
            this.botonCerrarPanelVer.TabIndex = 5;
            this.botonCerrarPanelVer.Text = "Salir";
            this.botonCerrarPanelVer.UseVisualStyleBackColor = true;
            this.botonCerrarPanelVer.Click += new System.EventHandler(this.BotonCerrarPanelVer_Click);
            // 
            // labelContarSegundos
            // 
            this.labelContarSegundos.AutoSize = true;
            this.labelContarSegundos.Location = new System.Drawing.Point(191, 12);
            this.labelContarSegundos.Name = "labelContarSegundos";
            this.labelContarSegundos.Size = new System.Drawing.Size(13, 13);
            this.labelContarSegundos.TabIndex = 1;
            this.labelContarSegundos.Text = "--";
            // 
            // listaVerTarjeta
            // 
            this.listaVerTarjeta.FormattingEnabled = true;
            this.listaVerTarjeta.HorizontalScrollbar = true;
            this.listaVerTarjeta.Location = new System.Drawing.Point(3, 45);
            this.listaVerTarjeta.Name = "listaVerTarjeta";
            this.listaVerTarjeta.Size = new System.Drawing.Size(504, 121);
            this.listaVerTarjeta.TabIndex = 0;
            // 
            // panelTarjetas
            // 
            this.panelTarjetas.Controls.Add(this.panelVer);
            this.panelTarjetas.Controls.Add(this.botonEditar);
            this.panelTarjetas.Controls.Add(this.botonSalirPrincipal);
            this.panelTarjetas.Controls.Add(this.botonVer);
            this.panelTarjetas.Controls.Add(this.botonEliminar);
            this.panelTarjetas.Controls.Add(this.botonAgregar);
            this.panelTarjetas.Controls.Add(this.listaTarjetas);
            this.panelTarjetas.Location = new System.Drawing.Point(47, 32);
            this.panelTarjetas.Name = "panelTarjetas";
            this.panelTarjetas.Size = new System.Drawing.Size(568, 279);
            this.panelTarjetas.TabIndex = 0;
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(298, 236);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 3;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // botonSalirPrincipal
            // 
            this.botonSalirPrincipal.Location = new System.Drawing.Point(479, 11);
            this.botonSalirPrincipal.Name = "botonSalirPrincipal";
            this.botonSalirPrincipal.Size = new System.Drawing.Size(75, 23);
            this.botonSalirPrincipal.TabIndex = 4;
            this.botonSalirPrincipal.Text = "Salir";
            this.botonSalirPrincipal.UseVisualStyleBackColor = true;
            this.botonSalirPrincipal.Click += new System.EventHandler(this.BotonSalirPrincipal_Click);
            // 
            // botonVer
            // 
            this.botonVer.Location = new System.Drawing.Point(467, 137);
            this.botonVer.Name = "botonVer";
            this.botonVer.Size = new System.Drawing.Size(75, 23);
            this.botonVer.TabIndex = 5;
            this.botonVer.Text = "Ver";
            this.botonVer.UseVisualStyleBackColor = true;
            this.botonVer.Click += new System.EventHandler(this.BotonVer_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(170, 236);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(35, 236);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 1;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // listaTarjetas
            // 
            this.listaTarjetas.FormattingEnabled = true;
            this.listaTarjetas.HorizontalScrollbar = true;
            this.listaTarjetas.Location = new System.Drawing.Point(3, 11);
            this.listaTarjetas.Name = "listaTarjetas";
            this.listaTarjetas.Size = new System.Drawing.Size(458, 225);
            this.listaTarjetas.TabIndex = 0;
            // 
            // panelEditar
            // 
            this.panelEditar.Controls.Add(this.labelErrores);
            this.panelEditar.Controls.Add(this.botonSalir);
            this.panelEditar.Controls.Add(this.labelVencimiento);
            this.panelEditar.Controls.Add(this.labelTipo);
            this.panelEditar.Controls.Add(this.labelCodigo);
            this.panelEditar.Controls.Add(this.labelCodigoDeSeguridad);
            this.panelEditar.Controls.Add(this.labelNombre);
            this.panelEditar.Controls.Add(this.botonEditarPanelEditar);
            this.panelEditar.Controls.Add(this.campoCodigoVencimiento);
            this.panelEditar.Controls.Add(this.campoTipo);
            this.panelEditar.Controls.Add(this.campoCodigo);
            this.panelEditar.Controls.Add(this.campoCodigoSeguridad);
            this.panelEditar.Controls.Add(this.campoNombre);
            this.panelEditar.Location = new System.Drawing.Point(205, 3);
            this.panelEditar.Name = "panelEditar";
            this.panelEditar.Size = new System.Drawing.Size(303, 314);
            this.panelEditar.TabIndex = 1;
            this.panelEditar.Visible = false;
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(141, 271);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(79, 13);
            this.labelErrores.TabIndex = 12;
            this.labelErrores.Text = "Datos inválidos";
            this.labelErrores.Visible = false;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(10, 266);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 11;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // labelVencimiento
            // 
            this.labelVencimiento.AutoSize = true;
            this.labelVencimiento.Location = new System.Drawing.Point(7, 204);
            this.labelVencimiento.Name = "labelVencimiento";
            this.labelVencimiento.Size = new System.Drawing.Size(65, 13);
            this.labelVencimiento.TabIndex = 10;
            this.labelVencimiento.Text = "Vencimiento";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(7, 94);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 9;
            this.labelTipo.Text = "Tipo";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(7, 130);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 8;
            this.labelCodigo.Text = "Código";
            // 
            // labelCodigoDeSeguridad
            // 
            this.labelCodigoDeSeguridad.AutoSize = true;
            this.labelCodigoDeSeguridad.Location = new System.Drawing.Point(7, 162);
            this.labelCodigoDeSeguridad.Name = "labelCodigoDeSeguridad";
            this.labelCodigoDeSeguridad.Size = new System.Drawing.Size(104, 13);
            this.labelCodigoDeSeguridad.TabIndex = 7;
            this.labelCodigoDeSeguridad.Text = "Código de seguridad";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(7, 56);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // botonEditarPanelEditar
            // 
            this.botonEditarPanelEditar.Location = new System.Drawing.Point(132, 236);
            this.botonEditarPanelEditar.Name = "botonEditarPanelEditar";
            this.botonEditarPanelEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditarPanelEditar.TabIndex = 5;
            this.botonEditarPanelEditar.Text = "Editar";
            this.botonEditarPanelEditar.UseVisualStyleBackColor = true;
            this.botonEditarPanelEditar.Click += new System.EventHandler(this.BotonEditarPanelEditar_Click);
            // 
            // campoCodigoVencimiento
            // 
            this.campoCodigoVencimiento.Location = new System.Drawing.Point(117, 197);
            this.campoCodigoVencimiento.Name = "campoCodigoVencimiento";
            this.campoCodigoVencimiento.Size = new System.Drawing.Size(115, 20);
            this.campoCodigoVencimiento.TabIndex = 4;
            // 
            // campoTipo
            // 
            this.campoTipo.Location = new System.Drawing.Point(117, 91);
            this.campoTipo.Name = "campoTipo";
            this.campoTipo.Size = new System.Drawing.Size(115, 20);
            this.campoTipo.TabIndex = 3;
            // 
            // campoCodigo
            // 
            this.campoCodigo.Location = new System.Drawing.Point(117, 127);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(115, 20);
            this.campoCodigo.TabIndex = 2;
            // 
            // campoCodigoSeguridad
            // 
            this.campoCodigoSeguridad.Location = new System.Drawing.Point(117, 159);
            this.campoCodigoSeguridad.Name = "campoCodigoSeguridad";
            this.campoCodigoSeguridad.Size = new System.Drawing.Size(115, 20);
            this.campoCodigoSeguridad.TabIndex = 1;
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(117, 56);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(115, 20);
            this.campoNombre.TabIndex = 0;
            // 
            // temporizadorVer
            // 
            this.temporizadorVer.Interval = 1000;
            this.temporizadorVer.Tick += new System.EventHandler(this.TemporizadorVer_Tick);
            // 
            // PantallaTarjetasDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEditar);
            this.Controls.Add(this.panelPrincipal);
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "PantallaTarjetasDeCredito";
            this.Size = new System.Drawing.Size(865, 372);
            this.panelPrincipal.ResumeLayout(false);
            this.panelVer.ResumeLayout(false);
            this.panelVer.PerformLayout();
            this.panelTarjetas.ResumeLayout(false);
            this.panelEditar.ResumeLayout(false);
            this.panelEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelTarjetas;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.ListBox listaTarjetas;
        private System.Windows.Forms.Panel panelEditar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label labelVencimiento;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelCodigoDeSeguridad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button botonEditarPanelEditar;
        private System.Windows.Forms.TextBox campoCodigoVencimiento;
        private System.Windows.Forms.TextBox campoTipo;
        private System.Windows.Forms.TextBox campoCodigo;
        private System.Windows.Forms.TextBox campoCodigoSeguridad;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.Button botonSalirPrincipal;
        private System.Windows.Forms.Button botonVer;
        private System.Windows.Forms.Panel panelVer;
        private System.Windows.Forms.Label labelContarSegundos;
        private System.Windows.Forms.ListBox listaVerTarjeta;
        private System.Windows.Forms.Timer temporizadorVer;
        private System.Windows.Forms.Button botonCerrarPanelVer;
    }
}
