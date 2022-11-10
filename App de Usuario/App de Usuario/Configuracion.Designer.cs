namespace App_de_Usuario
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panePerfil = new System.Windows.Forms.Panel();
            this.btnCambiarAvatar = new System.Windows.Forms.Button();
            this.cmboxAvatares = new System.Windows.Forms.ComboBox();
            this.pboxAvatar = new System.Windows.Forms.PictureBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.btnCambiarCorreo = new System.Windows.Forms.Button();
            this.btnCambiarContrasenia = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.paneApariencia = new System.Windows.Forms.Panel();
            this.cmboxTema = new System.Windows.Forms.ComboBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblApariencia = new System.Windows.Forms.Label();
            this.paneIdioma = new System.Windows.Forms.Panel();
            this.cmboxIdiomas = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneIdioma = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnAplicarCambios = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panePerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).BeginInit();
            this.paneApariencia.SuspendLayout();
            this.paneIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // panePerfil
            // 
            this.panePerfil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panePerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panePerfil.Controls.Add(this.btnCambiarAvatar);
            this.panePerfil.Controls.Add(this.cmboxAvatares);
            this.panePerfil.Controls.Add(this.pboxAvatar);
            this.panePerfil.Controls.Add(this.lblAvatar);
            this.panePerfil.Controls.Add(this.btnCambiarCorreo);
            this.panePerfil.Controls.Add(this.btnCambiarContrasenia);
            this.panePerfil.Controls.Add(this.txtContrasenia);
            this.panePerfil.Controls.Add(this.txtCorreo);
            this.panePerfil.Controls.Add(this.txtNombreUsuario);
            this.panePerfil.Controls.Add(this.lblCorreoElectronico);
            this.panePerfil.Controls.Add(this.lblContrasenia);
            this.panePerfil.Controls.Add(this.lblNombreUsuario);
            this.panePerfil.Controls.Add(this.lblPerfil);
            this.panePerfil.Location = new System.Drawing.Point(9, 10);
            this.panePerfil.Margin = new System.Windows.Forms.Padding(2);
            this.panePerfil.Name = "panePerfil";
            this.panePerfil.Size = new System.Drawing.Size(689, 235);
            this.panePerfil.TabIndex = 0;
            // 
            // btnCambiarAvatar
            // 
            this.btnCambiarAvatar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCambiarAvatar.Location = new System.Drawing.Point(490, 186);
            this.btnCambiarAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarAvatar.Name = "btnCambiarAvatar";
            this.btnCambiarAvatar.Size = new System.Drawing.Size(133, 29);
            this.btnCambiarAvatar.TabIndex = 13;
            this.btnCambiarAvatar.Text = "Vista previa";
            this.btnCambiarAvatar.UseVisualStyleBackColor = true;
            this.btnCambiarAvatar.Click += new System.EventHandler(this.btnCambiarAvatar_Click);
            // 
            // cmboxAvatares
            // 
            this.cmboxAvatares.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxAvatares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxAvatares.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxAvatares.FormattingEnabled = true;
            this.cmboxAvatares.Items.AddRange(new object[] {
            "Estándar",
            "Femenino",
            "Masculino"});
            this.cmboxAvatares.Location = new System.Drawing.Point(274, 167);
            this.cmboxAvatares.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxAvatares.Name = "cmboxAvatares";
            this.cmboxAvatares.Size = new System.Drawing.Size(205, 24);
            this.cmboxAvatares.TabIndex = 12;
            // 
            // pboxAvatar
            // 
            this.pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatar;
            this.pboxAvatar.Location = new System.Drawing.Point(148, 134);
            this.pboxAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pboxAvatar.Name = "pboxAvatar";
            this.pboxAvatar.Size = new System.Drawing.Size(91, 81);
            this.pboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAvatar.TabIndex = 11;
            this.pboxAvatar.TabStop = false;
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvatar.Location = new System.Drawing.Point(70, 168);
            this.lblAvatar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(50, 15);
            this.lblAvatar.TabIndex = 10;
            this.lblAvatar.Text = "Avatar: ";
            // 
            // btnCambiarCorreo
            // 
            this.btnCambiarCorreo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarCorreo.Location = new System.Drawing.Point(551, 94);
            this.btnCambiarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarCorreo.Name = "btnCambiarCorreo";
            this.btnCambiarCorreo.Size = new System.Drawing.Size(88, 24);
            this.btnCambiarCorreo.TabIndex = 9;
            this.btnCambiarCorreo.Text = "cambiar";
            this.btnCambiarCorreo.UseVisualStyleBackColor = true;
            this.btnCambiarCorreo.Click += new System.EventHandler(this.btnCambiarCorreo_Click);
            // 
            // btnCambiarContrasenia
            // 
            this.btnCambiarContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContrasenia.Location = new System.Drawing.Point(551, 59);
            this.btnCambiarContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarContrasenia.Name = "btnCambiarContrasenia";
            this.btnCambiarContrasenia.Size = new System.Drawing.Size(88, 23);
            this.btnCambiarContrasenia.TabIndex = 8;
            this.btnCambiarContrasenia.Text = "cambiar";
            this.btnCambiarContrasenia.UseVisualStyleBackColor = true;
            this.btnCambiarContrasenia.Click += new System.EventHandler(this.btnCambiarContrasenia_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContrasenia.Enabled = false;
            this.txtContrasenia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtContrasenia.Location = new System.Drawing.Point(166, 63);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(355, 24);
            this.txtContrasenia.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.Location = new System.Drawing.Point(166, 97);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(355, 24);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNombreUsuario.Location = new System.Drawing.Point(166, 25);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(355, 24);
            this.txtNombreUsuario.TabIndex = 4;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreoElectronico.Location = new System.Drawing.Point(14, 99);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(119, 15);
            this.lblCorreoElectronico.TabIndex = 3;
            this.lblCorreoElectronico.Text = "Correo electronico: ";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasenia.Location = new System.Drawing.Point(14, 63);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(79, 15);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña: ";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.Location = new System.Drawing.Point(14, 28);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(122, 15);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre de Usuario: ";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(2, 0);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(37, 15);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "Perfil";
            // 
            // paneApariencia
            // 
            this.paneApariencia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneApariencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneApariencia.Controls.Add(this.cmboxTema);
            this.paneApariencia.Controls.Add(this.lblTema);
            this.paneApariencia.Controls.Add(this.lblApariencia);
            this.paneApariencia.Location = new System.Drawing.Point(9, 249);
            this.paneApariencia.Margin = new System.Windows.Forms.Padding(2);
            this.paneApariencia.Name = "paneApariencia";
            this.paneApariencia.Size = new System.Drawing.Size(689, 95);
            this.paneApariencia.TabIndex = 1;
            // 
            // cmboxTema
            // 
            this.cmboxTema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTema.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxTema.FormattingEnabled = true;
            this.cmboxTema.Items.AddRange(new object[] {
            "Claro",
            "Oscuro",
            "Predeterminado"});
            this.cmboxTema.Location = new System.Drawing.Point(248, 32);
            this.cmboxTema.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxTema.Name = "cmboxTema";
            this.cmboxTema.Size = new System.Drawing.Size(356, 24);
            this.cmboxTema.TabIndex = 2;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTema.Location = new System.Drawing.Point(41, 38);
            this.lblTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(44, 15);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Tema: ";
            // 
            // lblApariencia
            // 
            this.lblApariencia.AutoSize = true;
            this.lblApariencia.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApariencia.Location = new System.Drawing.Point(-1, 0);
            this.lblApariencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApariencia.Name = "lblApariencia";
            this.lblApariencia.Size = new System.Drawing.Size(68, 15);
            this.lblApariencia.TabIndex = 0;
            this.lblApariencia.Text = "Apariencia";
            // 
            // paneIdioma
            // 
            this.paneIdioma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneIdioma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIdioma.Controls.Add(this.cmboxIdiomas);
            this.paneIdioma.Controls.Add(this.lblSeleccioneIdioma);
            this.paneIdioma.Controls.Add(this.lblIdioma);
            this.paneIdioma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paneIdioma.Location = new System.Drawing.Point(9, 349);
            this.paneIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.paneIdioma.Name = "paneIdioma";
            this.paneIdioma.Size = new System.Drawing.Size(689, 82);
            this.paneIdioma.TabIndex = 2;
            // 
            // cmboxIdiomas
            // 
            this.cmboxIdiomas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxIdiomas.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxIdiomas.FormattingEnabled = true;
            this.cmboxIdiomas.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.cmboxIdiomas.Location = new System.Drawing.Point(249, 32);
            this.cmboxIdiomas.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxIdiomas.Name = "cmboxIdiomas";
            this.cmboxIdiomas.Size = new System.Drawing.Size(356, 24);
            this.cmboxIdiomas.TabIndex = 3;
            // 
            // lblSeleccioneIdioma
            // 
            this.lblSeleccioneIdioma.AutoSize = true;
            this.lblSeleccioneIdioma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblSeleccioneIdioma.Location = new System.Drawing.Point(44, 35);
            this.lblSeleccioneIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccioneIdioma.Name = "lblSeleccioneIdioma";
            this.lblSeleccioneIdioma.Size = new System.Drawing.Size(116, 15);
            this.lblSeleccioneIdioma.TabIndex = 1;
            this.lblSeleccioneIdioma.Text = "Seleccionar Idioma";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(3, 0);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(45, 15);
            this.lblIdioma.TabIndex = 0;
            this.lblIdioma.Text = "Idioma";
            // 
            // btnAplicarCambios
            // 
            this.btnAplicarCambios.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarCambios.Location = new System.Drawing.Point(148, 436);
            this.btnAplicarCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnAplicarCambios.Name = "btnAplicarCambios";
            this.btnAplicarCambios.Size = new System.Drawing.Size(137, 32);
            this.btnAplicarCambios.TabIndex = 3;
            this.btnAplicarCambios.Text = "Aplicar cambios";
            this.btnAplicarCambios.UseVisualStyleBackColor = true;
            this.btnAplicarCambios.Click += new System.EventHandler(this.btnAplicarCambios_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(306, 436);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 488);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicarCambios);
            this.Controls.Add(this.paneIdioma);
            this.Controls.Add(this.paneApariencia);
            this.Controls.Add(this.panePerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.panePerfil.ResumeLayout(false);
            this.panePerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).EndInit();
            this.paneApariencia.ResumeLayout(false);
            this.paneApariencia.PerformLayout();
            this.paneIdioma.ResumeLayout(false);
            this.paneIdioma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panePerfil;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.PictureBox pboxAvatar;
        private System.Windows.Forms.Panel paneApariencia;
        private System.Windows.Forms.Panel paneIdioma;
        public System.Windows.Forms.ComboBox cmboxIdiomas;
        public System.Windows.Forms.Label lblPerfil;
        public System.Windows.Forms.Label lblContrasenia;
        public System.Windows.Forms.Label lblNombreUsuario;
        public System.Windows.Forms.Label lblCorreoElectronico;
        public System.Windows.Forms.Button btnCambiarCorreo;
        public System.Windows.Forms.Button btnCambiarContrasenia;
        public System.Windows.Forms.Label lblAvatar;
        public System.Windows.Forms.Label lblTema;
        public System.Windows.Forms.Label lblApariencia;
        public System.Windows.Forms.Button btnAplicarCambios;
        public System.Windows.Forms.Label lblIdioma;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lblSeleccioneIdioma;
        public System.Windows.Forms.Button btnCambiarAvatar;
        public System.Windows.Forms.ComboBox cmboxTema;
        public System.Windows.Forms.ComboBox cmboxAvatares;
    }
}