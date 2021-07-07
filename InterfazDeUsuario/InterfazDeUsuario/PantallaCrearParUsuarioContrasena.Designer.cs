
namespace InterfazDeUsuario
{
    partial class PantallaCrearParUsuarioContrasena
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
            this.campoDeTextoAgregarSitio = new System.Windows.Forms.TextBox();
            this.campoDeTextoAgregarUsuario = new System.Windows.Forms.TextBox();
            this.panelCrearContrasena = new System.Windows.Forms.Panel();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.labelLargo = new System.Windows.Forms.Label();
            this.botonGenerarContrasena = new System.Windows.Forms.Button();
            this.cajaSeleccionSimbolos = new System.Windows.Forms.CheckBox();
            this.cajaSeleccionDigitos = new System.Windows.Forms.CheckBox();
            this.cajaSeleccionMinusculas = new System.Windows.Forms.CheckBox();
            this.cajaSeleccionMayucsculas = new System.Windows.Forms.CheckBox();
            this.selectorLargoContrasena = new System.Windows.Forms.NumericUpDown();
            this.campoDeTextoIngresarClave = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSitio = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.campoTextoNotas = new System.Windows.Forms.TextBox();
            this.labelNotas = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.comboCategorias = new System.Windows.Forms.ComboBox();
            this.labelLanzarErrores = new System.Windows.Forms.Label();
            this.panelCreacion = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelSugerencia = new System.Windows.Forms.Panel();
            this.labelContinuar = new System.Windows.Forms.Button();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelNoHayIguales = new System.Windows.Forms.Label();
            this.labelDataBreach = new System.Windows.Forms.Label();
            this.labelTituloSugerencia = new System.Windows.Forms.Label();
            this.panelCrearContrasena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorLargoContrasena)).BeginInit();
            this.panelCreacion.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelSugerencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // campoDeTextoAgregarSitio
            // 
            this.campoDeTextoAgregarSitio.Location = new System.Drawing.Point(124, 57);
            this.campoDeTextoAgregarSitio.Name = "campoDeTextoAgregarSitio";
            this.campoDeTextoAgregarSitio.Size = new System.Drawing.Size(100, 20);
            this.campoDeTextoAgregarSitio.TabIndex = 1;
            // 
            // campoDeTextoAgregarUsuario
            // 
            this.campoDeTextoAgregarUsuario.Location = new System.Drawing.Point(124, 104);
            this.campoDeTextoAgregarUsuario.Name = "campoDeTextoAgregarUsuario";
            this.campoDeTextoAgregarUsuario.Size = new System.Drawing.Size(100, 20);
            this.campoDeTextoAgregarUsuario.TabIndex = 2;
            // 
            // panelCrearContrasena
            // 
            this.panelCrearContrasena.BackColor = System.Drawing.SystemColors.Control;
            this.panelCrearContrasena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCrearContrasena.Controls.Add(this.labelContrasena);
            this.panelCrearContrasena.Controls.Add(this.labelLargo);
            this.panelCrearContrasena.Controls.Add(this.botonGenerarContrasena);
            this.panelCrearContrasena.Controls.Add(this.cajaSeleccionSimbolos);
            this.panelCrearContrasena.Controls.Add(this.cajaSeleccionDigitos);
            this.panelCrearContrasena.Controls.Add(this.cajaSeleccionMinusculas);
            this.panelCrearContrasena.Controls.Add(this.cajaSeleccionMayucsculas);
            this.panelCrearContrasena.Controls.Add(this.selectorLargoContrasena);
            this.panelCrearContrasena.Controls.Add(this.campoDeTextoIngresarClave);
            this.panelCrearContrasena.Location = new System.Drawing.Point(78, 130);
            this.panelCrearContrasena.Name = "panelCrearContrasena";
            this.panelCrearContrasena.Size = new System.Drawing.Size(180, 223);
            this.panelCrearContrasena.TabIndex = 3;
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(3, 10);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(61, 13);
            this.labelContrasena.TabIndex = 9;
            this.labelContrasena.Text = "Contraseña";
            // 
            // labelLargo
            // 
            this.labelLargo.AutoSize = true;
            this.labelLargo.Location = new System.Drawing.Point(7, 41);
            this.labelLargo.Name = "labelLargo";
            this.labelLargo.Size = new System.Drawing.Size(34, 13);
            this.labelLargo.TabIndex = 8;
            this.labelLargo.Text = "Largo";
            // 
            // botonGenerarContrasena
            // 
            this.botonGenerarContrasena.Location = new System.Drawing.Point(82, 172);
            this.botonGenerarContrasena.Name = "botonGenerarContrasena";
            this.botonGenerarContrasena.Size = new System.Drawing.Size(75, 23);
            this.botonGenerarContrasena.TabIndex = 4;
            this.botonGenerarContrasena.Text = "Generar";
            this.botonGenerarContrasena.UseVisualStyleBackColor = true;
            this.botonGenerarContrasena.Click += new System.EventHandler(this.BotonGenerarContrasena_Click);
            // 
            // cajaSeleccionSimbolos
            // 
            this.cajaSeleccionSimbolos.AutoSize = true;
            this.cajaSeleccionSimbolos.Location = new System.Drawing.Point(44, 149);
            this.cajaSeleccionSimbolos.Name = "cajaSeleccionSimbolos";
            this.cajaSeleccionSimbolos.Size = new System.Drawing.Size(68, 17);
            this.cajaSeleccionSimbolos.TabIndex = 7;
            this.cajaSeleccionSimbolos.Text = "Simbolos";
            this.cajaSeleccionSimbolos.UseVisualStyleBackColor = true;
            // 
            // cajaSeleccionDigitos
            // 
            this.cajaSeleccionDigitos.AutoSize = true;
            this.cajaSeleccionDigitos.Location = new System.Drawing.Point(44, 126);
            this.cajaSeleccionDigitos.Name = "cajaSeleccionDigitos";
            this.cajaSeleccionDigitos.Size = new System.Drawing.Size(58, 17);
            this.cajaSeleccionDigitos.TabIndex = 6;
            this.cajaSeleccionDigitos.Text = "Digitos";
            this.cajaSeleccionDigitos.UseVisualStyleBackColor = true;
            // 
            // cajaSeleccionMinusculas
            // 
            this.cajaSeleccionMinusculas.AutoSize = true;
            this.cajaSeleccionMinusculas.Location = new System.Drawing.Point(44, 103);
            this.cajaSeleccionMinusculas.Name = "cajaSeleccionMinusculas";
            this.cajaSeleccionMinusculas.Size = new System.Drawing.Size(79, 17);
            this.cajaSeleccionMinusculas.TabIndex = 5;
            this.cajaSeleccionMinusculas.Text = "Minusculas";
            this.cajaSeleccionMinusculas.UseVisualStyleBackColor = true;
            // 
            // cajaSeleccionMayucsculas
            // 
            this.cajaSeleccionMayucsculas.AutoSize = true;
            this.cajaSeleccionMayucsculas.Location = new System.Drawing.Point(46, 79);
            this.cajaSeleccionMayucsculas.Name = "cajaSeleccionMayucsculas";
            this.cajaSeleccionMayucsculas.Size = new System.Drawing.Size(82, 17);
            this.cajaSeleccionMayucsculas.TabIndex = 4;
            this.cajaSeleccionMayucsculas.Text = "Mayusculas";
            this.cajaSeleccionMayucsculas.UseVisualStyleBackColor = true;
            // 
            // selectorLargoContrasena
            // 
            this.selectorLargoContrasena.Location = new System.Drawing.Point(47, 39);
            this.selectorLargoContrasena.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.selectorLargoContrasena.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.selectorLargoContrasena.Name = "selectorLargoContrasena";
            this.selectorLargoContrasena.Size = new System.Drawing.Size(120, 20);
            this.selectorLargoContrasena.TabIndex = 3;
            this.selectorLargoContrasena.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // campoDeTextoIngresarClave
            // 
            this.campoDeTextoIngresarClave.Location = new System.Drawing.Point(70, 10);
            this.campoDeTextoIngresarClave.Name = "campoDeTextoIngresarClave";
            this.campoDeTextoIngresarClave.Size = new System.Drawing.Size(100, 20);
            this.campoDeTextoIngresarClave.TabIndex = 2;
            this.campoDeTextoIngresarClave.UseSystemPasswordChar = true;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(63, 107);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelSitio
            // 
            this.labelSitio.AutoSize = true;
            this.labelSitio.Location = new System.Drawing.Point(63, 60);
            this.labelSitio.Name = "labelSitio";
            this.labelSitio.Size = new System.Drawing.Size(27, 13);
            this.labelSitio.TabIndex = 7;
            this.labelSitio.Text = "Sitio";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(63, 23);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(54, 13);
            this.labelCategoria.TabIndex = 8;
            this.labelCategoria.Text = "Categoría";
            // 
            // campoTextoNotas
            // 
            this.campoTextoNotas.Location = new System.Drawing.Point(96, 359);
            this.campoTextoNotas.Multiline = true;
            this.campoTextoNotas.Name = "campoTextoNotas";
            this.campoTextoNotas.Size = new System.Drawing.Size(152, 61);
            this.campoTextoNotas.TabIndex = 9;
            // 
            // labelNotas
            // 
            this.labelNotas.AutoSize = true;
            this.labelNotas.Location = new System.Drawing.Point(22, 381);
            this.labelNotas.Name = "labelNotas";
            this.labelNotas.Size = new System.Drawing.Size(35, 13);
            this.labelNotas.TabIndex = 10;
            this.labelNotas.Text = "Notas";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(270, 397);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 11;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(15, 422);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 12;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // comboCategorias
            // 
            this.comboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorias.FormattingEnabled = true;
            this.comboCategorias.Location = new System.Drawing.Point(122, 20);
            this.comboCategorias.Name = "comboCategorias";
            this.comboCategorias.Size = new System.Drawing.Size(121, 21);
            this.comboCategorias.TabIndex = 14;
            // 
            // labelLanzarErrores
            // 
            this.labelLanzarErrores.AutoSize = true;
            this.labelLanzarErrores.Location = new System.Drawing.Point(109, 432);
            this.labelLanzarErrores.Name = "labelLanzarErrores";
            this.labelLanzarErrores.Size = new System.Drawing.Size(35, 13);
            this.labelLanzarErrores.TabIndex = 15;
            this.labelLanzarErrores.Text = "label1";
            // 
            // panelCreacion
            // 
            this.panelCreacion.Controls.Add(this.panelCrearContrasena);
            this.panelCreacion.Controls.Add(this.labelLanzarErrores);
            this.panelCreacion.Controls.Add(this.campoDeTextoAgregarSitio);
            this.panelCreacion.Controls.Add(this.comboCategorias);
            this.panelCreacion.Controls.Add(this.campoDeTextoAgregarUsuario);
            this.panelCreacion.Controls.Add(this.botonSalir);
            this.panelCreacion.Controls.Add(this.labelUsuario);
            this.panelCreacion.Controls.Add(this.botonAceptar);
            this.panelCreacion.Controls.Add(this.labelSitio);
            this.panelCreacion.Controls.Add(this.labelNotas);
            this.panelCreacion.Controls.Add(this.labelCategoria);
            this.panelCreacion.Controls.Add(this.campoTextoNotas);
            this.panelCreacion.Location = new System.Drawing.Point(60, 3);
            this.panelCreacion.Name = "panelCreacion";
            this.panelCreacion.Size = new System.Drawing.Size(353, 464);
            this.panelCreacion.TabIndex = 16;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelSugerencia);
            this.panelPrincipal.Controls.Add(this.panelCreacion);
            this.panelPrincipal.Location = new System.Drawing.Point(30, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(536, 498);
            this.panelPrincipal.TabIndex = 17;
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
            this.panelSugerencia.Location = new System.Drawing.Point(50, 6);
            this.panelSugerencia.Name = "panelSugerencia";
            this.panelSugerencia.Size = new System.Drawing.Size(408, 250);
            this.panelSugerencia.TabIndex = 18;
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
            // PantallaCrearParUsuarioContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPrincipal);
            this.Location = new System.Drawing.Point(105, 0);
            this.Name = "PantallaCrearParUsuarioContrasena";
            this.Size = new System.Drawing.Size(806, 525);
            this.panelCrearContrasena.ResumeLayout(false);
            this.panelCrearContrasena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorLargoContrasena)).EndInit();
            this.panelCreacion.ResumeLayout(false);
            this.panelCreacion.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelSugerencia.ResumeLayout(false);
            this.panelSugerencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox campoDeTextoAgregarSitio;
        private System.Windows.Forms.TextBox campoDeTextoAgregarUsuario;
        private System.Windows.Forms.Panel panelCrearContrasena;
        private System.Windows.Forms.Label labelLargo;
        private System.Windows.Forms.Button botonGenerarContrasena;
        private System.Windows.Forms.CheckBox cajaSeleccionSimbolos;
        private System.Windows.Forms.CheckBox cajaSeleccionDigitos;
        private System.Windows.Forms.CheckBox cajaSeleccionMinusculas;
        private System.Windows.Forms.CheckBox cajaSeleccionMayucsculas;
        private System.Windows.Forms.NumericUpDown selectorLargoContrasena;
        private System.Windows.Forms.TextBox campoDeTextoIngresarClave;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSitio;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.TextBox campoTextoNotas;
        private System.Windows.Forms.Label labelNotas;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.ComboBox comboCategorias;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label labelLanzarErrores;
        private System.Windows.Forms.Panel panelCreacion;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelSugerencia;
        private System.Windows.Forms.Label labelTituloSugerencia;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelNoHayIguales;
        private System.Windows.Forms.Label labelDataBreach;
        private System.Windows.Forms.Button labelContinuar;
    }
}
