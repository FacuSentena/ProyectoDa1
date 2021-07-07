
namespace InterfazDeUsuario
{
    partial class PantallaContrasenas
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
            this.listaParesUsuarioContrasena = new System.Windows.Forms.ListBox();
            this.botonAgregarPar = new System.Windows.Forms.Button();
            this.botonEliminarPar = new System.Windows.Forms.Button();
            this.botonEditarPar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.labelNoHayElementos = new System.Windows.Forms.Label();
            this.panelContrasenas = new System.Windows.Forms.Panel();
            this.panelSugerencia = new System.Windows.Forms.Panel();
            this.labelContinuar = new System.Windows.Forms.Button();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelNoHayIguales = new System.Windows.Forms.Label();
            this.labelDataBreach = new System.Windows.Forms.Label();
            this.labelTituloSugerencia = new System.Windows.Forms.Label();
            this.panelMostrarContrasena = new System.Windows.Forms.Panel();
            this.BotonSalirVerContrasenas = new System.Windows.Forms.Button();
            this.labelTiempoRestante = new System.Windows.Forms.Label();
            this.listaSoloContrasena = new System.Windows.Forms.ListBox();
            this.botonVer = new System.Windows.Forms.Button();
            this.panelEditar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.selectorLargo = new System.Windows.Forms.NumericUpDown();
            this.labelErrores = new System.Windows.Forms.Label();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonGenerar = new System.Windows.Forms.Button();
            this.cajaSimbolos = new System.Windows.Forms.CheckBox();
            this.cajaDigitos = new System.Windows.Forms.CheckBox();
            this.cajaMinusculas = new System.Windows.Forms.CheckBox();
            this.cajaMayusculas = new System.Windows.Forms.CheckBox();
            this.campoContrasena = new System.Windows.Forms.TextBox();
            this.campoSitio = new System.Windows.Forms.TextBox();
            this.campoNuevoNombre = new System.Windows.Forms.TextBox();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.panelContrasenas.SuspendLayout();
            this.panelSugerencia.SuspendLayout();
            this.panelMostrarContrasena.SuspendLayout();
            this.panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorLargo)).BeginInit();
            this.panelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaParesUsuarioContrasena
            // 
            this.listaParesUsuarioContrasena.FormattingEnabled = true;
            this.listaParesUsuarioContrasena.HorizontalScrollbar = true;
            this.listaParesUsuarioContrasena.Location = new System.Drawing.Point(24, 52);
            this.listaParesUsuarioContrasena.Name = "listaParesUsuarioContrasena";
            this.listaParesUsuarioContrasena.Size = new System.Drawing.Size(437, 186);
            this.listaParesUsuarioContrasena.Sorted = true;
            this.listaParesUsuarioContrasena.TabIndex = 0;
            // 
            // botonAgregarPar
            // 
            this.botonAgregarPar.Location = new System.Drawing.Point(37, 251);
            this.botonAgregarPar.Name = "botonAgregarPar";
            this.botonAgregarPar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarPar.TabIndex = 1;
            this.botonAgregarPar.Text = "Agregar";
            this.botonAgregarPar.UseVisualStyleBackColor = true;
            this.botonAgregarPar.Click += new System.EventHandler(this.BotonAgregarPar_Click);
            // 
            // botonEliminarPar
            // 
            this.botonEliminarPar.Location = new System.Drawing.Point(131, 251);
            this.botonEliminarPar.Name = "botonEliminarPar";
            this.botonEliminarPar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminarPar.TabIndex = 2;
            this.botonEliminarPar.Text = "Eliminar";
            this.botonEliminarPar.UseVisualStyleBackColor = true;
            this.botonEliminarPar.Click += new System.EventHandler(this.BotonEliminarPar_Click);
            // 
            // botonEditarPar
            // 
            this.botonEditarPar.Location = new System.Drawing.Point(224, 251);
            this.botonEditarPar.Name = "botonEditarPar";
            this.botonEditarPar.Size = new System.Drawing.Size(75, 23);
            this.botonEditarPar.TabIndex = 3;
            this.botonEditarPar.Text = "Editar";
            this.botonEditarPar.UseVisualStyleBackColor = true;
            this.botonEditarPar.Click += new System.EventHandler(this.BotonEditarPar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(24, 301);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // labelNoHayElementos
            // 
            this.labelNoHayElementos.AutoSize = true;
            this.labelNoHayElementos.Location = new System.Drawing.Point(180, 21);
            this.labelNoHayElementos.Name = "labelNoHayElementos";
            this.labelNoHayElementos.Size = new System.Drawing.Size(146, 13);
            this.labelNoHayElementos.TabIndex = 5;
            this.labelNoHayElementos.Text = "No hay elementos para borrar";
            // 
            // panelContrasenas
            // 
            this.panelContrasenas.Controls.Add(this.listaParesUsuarioContrasena);
            this.panelContrasenas.Controls.Add(this.panelSugerencia);
            this.panelContrasenas.Controls.Add(this.panelMostrarContrasena);
            this.panelContrasenas.Controls.Add(this.botonVer);
            this.panelContrasenas.Controls.Add(this.botonSalir);
            this.panelContrasenas.Controls.Add(this.labelNoHayElementos);
            this.panelContrasenas.Controls.Add(this.botonAgregarPar);
            this.panelContrasenas.Controls.Add(this.botonEliminarPar);
            this.panelContrasenas.Controls.Add(this.botonEditarPar);
            this.panelContrasenas.Controls.Add(this.panelEditar);
            this.panelContrasenas.Location = new System.Drawing.Point(42, 29);
            this.panelContrasenas.Name = "panelContrasenas";
            this.panelContrasenas.Size = new System.Drawing.Size(686, 335);
            this.panelContrasenas.TabIndex = 6;
            // 
            // panelSugerencia
            // 
            this.panelSugerencia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSugerencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSugerencia.Controls.Add(this.labelContinuar);
            this.panelSugerencia.Controls.Add(this.labelNivel);
            this.panelSugerencia.Controls.Add(this.labelNoHayIguales);
            this.panelSugerencia.Controls.Add(this.labelDataBreach);
            this.panelSugerencia.Controls.Add(this.labelTituloSugerencia);
            this.panelSugerencia.Location = new System.Drawing.Point(106, 0);
            this.panelSugerencia.Name = "panelSugerencia";
            this.panelSugerencia.Size = new System.Drawing.Size(408, 250);
            this.panelSugerencia.TabIndex = 19;
            this.panelSugerencia.Visible = false;
            // 
            // labelContinuar
            // 
            this.labelContinuar.Location = new System.Drawing.Point(160, 204);
            this.labelContinuar.Name = "labelContinuar";
            this.labelContinuar.Size = new System.Drawing.Size(75, 23);
            this.labelContinuar.TabIndex = 4;
            this.labelContinuar.Text = "Continuar";
            this.labelContinuar.UseVisualStyleBackColor = true;
            this.labelContinuar.Click += new System.EventHandler(this.LabelContinuar_Click);
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Location = new System.Drawing.Point(14, 175);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(10, 13);
            this.labelNivel.TabIndex = 3;
            this.labelNivel.Text = "-";
            // 
            // labelNoHayIguales
            // 
            this.labelNoHayIguales.AutoSize = true;
            this.labelNoHayIguales.Location = new System.Drawing.Point(14, 111);
            this.labelNoHayIguales.Name = "labelNoHayIguales";
            this.labelNoHayIguales.Size = new System.Drawing.Size(10, 13);
            this.labelNoHayIguales.TabIndex = 2;
            this.labelNoHayIguales.Text = "-";
            // 
            // labelDataBreach
            // 
            this.labelDataBreach.AutoSize = true;
            this.labelDataBreach.Location = new System.Drawing.Point(14, 47);
            this.labelDataBreach.Name = "labelDataBreach";
            this.labelDataBreach.Size = new System.Drawing.Size(10, 13);
            this.labelDataBreach.TabIndex = 1;
            this.labelDataBreach.Text = "-";
            // 
            // labelTituloSugerencia
            // 
            this.labelTituloSugerencia.AutoSize = true;
            this.labelTituloSugerencia.Location = new System.Drawing.Point(103, 7);
            this.labelTituloSugerencia.Name = "labelTituloSugerencia";
            this.labelTituloSugerencia.Size = new System.Drawing.Size(165, 13);
            this.labelTituloSugerencia.TabIndex = 0;
            this.labelTituloSugerencia.Text = "Reporte de contraseña ingresada";
            // 
            // panelMostrarContrasena
            // 
            this.panelMostrarContrasena.Controls.Add(this.BotonSalirVerContrasenas);
            this.panelMostrarContrasena.Controls.Add(this.labelTiempoRestante);
            this.panelMostrarContrasena.Controls.Add(this.listaSoloContrasena);
            this.panelMostrarContrasena.Location = new System.Drawing.Point(118, 37);
            this.panelMostrarContrasena.Name = "panelMostrarContrasena";
            this.panelMostrarContrasena.Size = new System.Drawing.Size(345, 251);
            this.panelMostrarContrasena.TabIndex = 9;
            this.panelMostrarContrasena.Visible = false;
            // 
            // BotonSalirVerContrasenas
            // 
            this.BotonSalirVerContrasenas.Location = new System.Drawing.Point(17, 219);
            this.BotonSalirVerContrasenas.Name = "BotonSalirVerContrasenas";
            this.BotonSalirVerContrasenas.Size = new System.Drawing.Size(75, 23);
            this.BotonSalirVerContrasenas.TabIndex = 10;
            this.BotonSalirVerContrasenas.Text = "Salir";
            this.BotonSalirVerContrasenas.UseVisualStyleBackColor = true;
            this.BotonSalirVerContrasenas.Click += new System.EventHandler(this.BotonSalirVerContrasenas_Click);
            // 
            // labelTiempoRestante
            // 
            this.labelTiempoRestante.AutoSize = true;
            this.labelTiempoRestante.Location = new System.Drawing.Point(159, 12);
            this.labelTiempoRestante.Name = "labelTiempoRestante";
            this.labelTiempoRestante.Size = new System.Drawing.Size(13, 13);
            this.labelTiempoRestante.TabIndex = 1;
            this.labelTiempoRestante.Text = "--";
            // 
            // listaSoloContrasena
            // 
            this.listaSoloContrasena.FormattingEnabled = true;
            this.listaSoloContrasena.Location = new System.Drawing.Point(51, 34);
            this.listaSoloContrasena.Name = "listaSoloContrasena";
            this.listaSoloContrasena.Size = new System.Drawing.Size(230, 173);
            this.listaSoloContrasena.TabIndex = 0;
            // 
            // botonVer
            // 
            this.botonVer.Location = new System.Drawing.Point(486, 215);
            this.botonVer.Name = "botonVer";
            this.botonVer.Size = new System.Drawing.Size(75, 23);
            this.botonVer.TabIndex = 6;
            this.botonVer.Text = "Ver";
            this.botonVer.UseVisualStyleBackColor = true;
            this.botonVer.Click += new System.EventHandler(this.BotonVer_Click);
            // 
            // panelEditar
            // 
            this.panelEditar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditar.Controls.Add(this.label3);
            this.panelEditar.Controls.Add(this.label2);
            this.panelEditar.Controls.Add(this.label1);
            this.panelEditar.Controls.Add(this.botonCancelar);
            this.panelEditar.Controls.Add(this.selectorLargo);
            this.panelEditar.Controls.Add(this.labelErrores);
            this.panelEditar.Controls.Add(this.botonEditar);
            this.panelEditar.Controls.Add(this.botonGenerar);
            this.panelEditar.Controls.Add(this.cajaSimbolos);
            this.panelEditar.Controls.Add(this.cajaDigitos);
            this.panelEditar.Controls.Add(this.cajaMinusculas);
            this.panelEditar.Controls.Add(this.cajaMayusculas);
            this.panelEditar.Controls.Add(this.campoContrasena);
            this.panelEditar.Controls.Add(this.campoSitio);
            this.panelEditar.Controls.Add(this.campoNuevoNombre);
            this.panelEditar.Location = new System.Drawing.Point(155, 20);
            this.panelEditar.Name = "panelEditar";
            this.panelEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelEditar.Size = new System.Drawing.Size(273, 293);
            this.panelEditar.TabIndex = 7;
            this.panelEditar.TabStop = true;
            this.panelEditar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sitio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(0, 260);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 19;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // selectorLargo
            // 
            this.selectorLargo.Location = new System.Drawing.Point(141, 154);
            this.selectorLargo.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.selectorLargo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.selectorLargo.Name = "selectorLargo";
            this.selectorLargo.Size = new System.Drawing.Size(40, 20);
            this.selectorLargo.TabIndex = 18;
            this.selectorLargo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(89, 235);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(13, 13);
            this.labelErrores.TabIndex = 17;
            this.labelErrores.Text = "--";
            this.labelErrores.Visible = false;
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(178, 254);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 16;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // botonGenerar
            // 
            this.botonGenerar.Location = new System.Drawing.Point(116, 189);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(75, 23);
            this.botonGenerar.TabIndex = 15;
            this.botonGenerar.Text = "Generar";
            this.botonGenerar.UseVisualStyleBackColor = true;
            // 
            // cajaSimbolos
            // 
            this.cajaSimbolos.AutoSize = true;
            this.cajaSimbolos.Location = new System.Drawing.Point(20, 235);
            this.cajaSimbolos.Name = "cajaSimbolos";
            this.cajaSimbolos.Size = new System.Drawing.Size(70, 17);
            this.cajaSimbolos.TabIndex = 14;
            this.cajaSimbolos.Text = "Símbolos";
            this.cajaSimbolos.UseVisualStyleBackColor = true;
            // 
            // cajaDigitos
            // 
            this.cajaDigitos.AutoSize = true;
            this.cajaDigitos.Location = new System.Drawing.Point(20, 212);
            this.cajaDigitos.Name = "cajaDigitos";
            this.cajaDigitos.Size = new System.Drawing.Size(60, 17);
            this.cajaDigitos.TabIndex = 13;
            this.cajaDigitos.Text = "Dígitos";
            this.cajaDigitos.UseVisualStyleBackColor = true;
            // 
            // cajaMinusculas
            // 
            this.cajaMinusculas.AutoSize = true;
            this.cajaMinusculas.Location = new System.Drawing.Point(20, 189);
            this.cajaMinusculas.Name = "cajaMinusculas";
            this.cajaMinusculas.Size = new System.Drawing.Size(79, 17);
            this.cajaMinusculas.TabIndex = 12;
            this.cajaMinusculas.Text = "Minúsculas";
            this.cajaMinusculas.UseVisualStyleBackColor = true;
            // 
            // cajaMayusculas
            // 
            this.cajaMayusculas.AutoSize = true;
            this.cajaMayusculas.Location = new System.Drawing.Point(20, 166);
            this.cajaMayusculas.Name = "cajaMayusculas";
            this.cajaMayusculas.Size = new System.Drawing.Size(82, 17);
            this.cajaMayusculas.TabIndex = 11;
            this.cajaMayusculas.Text = "Mayúsculas";
            this.cajaMayusculas.UseVisualStyleBackColor = true;
            // 
            // campoContrasena
            // 
            this.campoContrasena.Location = new System.Drawing.Point(70, 128);
            this.campoContrasena.Name = "campoContrasena";
            this.campoContrasena.Size = new System.Drawing.Size(100, 20);
            this.campoContrasena.TabIndex = 10;
            this.campoContrasena.UseSystemPasswordChar = true;
            // 
            // campoSitio
            // 
            this.campoSitio.Location = new System.Drawing.Point(70, 82);
            this.campoSitio.Name = "campoSitio";
            this.campoSitio.Size = new System.Drawing.Size(100, 20);
            this.campoSitio.TabIndex = 9;
            // 
            // campoNuevoNombre
            // 
            this.campoNuevoNombre.Location = new System.Drawing.Point(70, 37);
            this.campoNuevoNombre.Name = "campoNuevoNombre";
            this.campoNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.campoNuevoNombre.TabIndex = 1;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.panelContrasenas);
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(779, 471);
            this.panelGeneral.TabIndex = 8;
            // 
            // temporizador
            // 
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.TimerTemporizador_Tick);
            // 
            // PantallaContrasenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGeneral);
            this.Name = "PantallaContrasenas";
            this.Size = new System.Drawing.Size(900, 576);
            this.panelContrasenas.ResumeLayout(false);
            this.panelContrasenas.PerformLayout();
            this.panelSugerencia.ResumeLayout(false);
            this.panelSugerencia.PerformLayout();
            this.panelMostrarContrasena.ResumeLayout(false);
            this.panelMostrarContrasena.PerformLayout();
            this.panelEditar.ResumeLayout(false);
            this.panelEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorLargo)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaParesUsuarioContrasena;
        private System.Windows.Forms.Button botonAgregarPar;
        private System.Windows.Forms.Button botonEliminarPar;
        private System.Windows.Forms.Button botonEditarPar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label labelNoHayElementos;
        private System.Windows.Forms.Panel panelContrasenas;
        private System.Windows.Forms.Panel panelEditar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.CheckBox cajaSimbolos;
        private System.Windows.Forms.CheckBox cajaDigitos;
        private System.Windows.Forms.CheckBox cajaMinusculas;
        private System.Windows.Forms.CheckBox cajaMayusculas;
        private System.Windows.Forms.TextBox campoContrasena;
        private System.Windows.Forms.TextBox campoSitio;
        private System.Windows.Forms.TextBox campoNuevoNombre;
        private System.Windows.Forms.NumericUpDown selectorLargo;
        private System.Windows.Forms.Label labelErrores;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonVer;
        private System.Windows.Forms.Panel panelMostrarContrasena;
        private System.Windows.Forms.ListBox listaSoloContrasena;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.Label labelTiempoRestante;
        private System.Windows.Forms.Button BotonSalirVerContrasenas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSugerencia;
        private System.Windows.Forms.Button labelContinuar;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelNoHayIguales;
        private System.Windows.Forms.Label labelDataBreach;
        private System.Windows.Forms.Label labelTituloSugerencia;
    }
}
