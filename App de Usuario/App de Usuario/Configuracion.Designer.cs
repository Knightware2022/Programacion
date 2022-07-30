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
            this.btnCambiarUsuario = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.panePerfil.Controls.Add(this.btnCambiarUsuario);
            this.panePerfil.Controls.Add(this.txtContrasenia);
            this.panePerfil.Controls.Add(this.txtCorreo);
            this.panePerfil.Controls.Add(this.txtNombreUsuario);
            this.panePerfil.Controls.Add(this.lblCorreoElectronico);
            this.panePerfil.Controls.Add(this.lblContrasenia);
            this.panePerfil.Controls.Add(this.lblNombreUsuario);
            this.panePerfil.Controls.Add(this.lblPerfil);
            this.panePerfil.Location = new System.Drawing.Point(12, 12);
            this.panePerfil.Name = "panePerfil";
            this.panePerfil.Size = new System.Drawing.Size(918, 289);
            this.panePerfil.TabIndex = 0;
            // 
            // btnCambiarAvatar
            // 
            this.btnCambiarAvatar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCambiarAvatar.Location = new System.Drawing.Point(654, 229);
            this.btnCambiarAvatar.Name = "btnCambiarAvatar";
            this.btnCambiarAvatar.Size = new System.Drawing.Size(177, 36);
            this.btnCambiarAvatar.TabIndex = 13;
            this.btnCambiarAvatar.Text = "Cambiar ávatar";
            this.btnCambiarAvatar.UseVisualStyleBackColor = true;
            this.btnCambiarAvatar.Click += new System.EventHandler(this.btnCambiarAvatar_Click);
            // 
            // cmboxAvatares
            // 
            this.cmboxAvatares.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxAvatares.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxAvatares.FormattingEnabled = true;
            this.cmboxAvatares.Items.AddRange(new object[] {
            "Estándar",
            "Femenino",
            "Masculino"});
            this.cmboxAvatares.Location = new System.Drawing.Point(366, 205);
            this.cmboxAvatares.Name = "cmboxAvatares";
            this.cmboxAvatares.Size = new System.Drawing.Size(272, 27);
            this.cmboxAvatares.TabIndex = 12;
            // 
            // pboxAvatar
            // 
            this.pboxAvatar.Image = global::App_de_Usuario.Properties.Resources.avatar;
            this.pboxAvatar.Location = new System.Drawing.Point(197, 165);
            this.pboxAvatar.Name = "pboxAvatar";
            this.pboxAvatar.Size = new System.Drawing.Size(121, 100);
            this.pboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAvatar.TabIndex = 11;
            this.pboxAvatar.TabStop = false;
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvatar.Location = new System.Drawing.Point(94, 207);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(60, 18);
            this.lblAvatar.TabIndex = 10;
            this.lblAvatar.Text = "Avatar: ";
            // 
            // btnCambiarCorreo
            // 
            this.btnCambiarCorreo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarCorreo.Location = new System.Drawing.Point(735, 116);
            this.btnCambiarCorreo.Name = "btnCambiarCorreo";
            this.btnCambiarCorreo.Size = new System.Drawing.Size(96, 29);
            this.btnCambiarCorreo.TabIndex = 9;
            this.btnCambiarCorreo.Text = "cambiar";
            this.btnCambiarCorreo.UseVisualStyleBackColor = true;
            // 
            // btnCambiarContrasenia
            // 
            this.btnCambiarContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContrasenia.Location = new System.Drawing.Point(735, 77);
            this.btnCambiarContrasenia.Name = "btnCambiarContrasenia";
            this.btnCambiarContrasenia.Size = new System.Drawing.Size(96, 28);
            this.btnCambiarContrasenia.TabIndex = 8;
            this.btnCambiarContrasenia.Text = "cambiar";
            this.btnCambiarContrasenia.UseVisualStyleBackColor = true;
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUsuario.Location = new System.Drawing.Point(735, 31);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(96, 28);
            this.btnCambiarUsuario.TabIndex = 7;
            this.btnCambiarUsuario.Text = "cambiar";
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContrasenia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtContrasenia.Location = new System.Drawing.Point(222, 77);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(472, 28);
            this.txtContrasenia.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.Location = new System.Drawing.Point(222, 119);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(472, 28);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNombreUsuario.Location = new System.Drawing.Point(222, 31);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(472, 28);
            this.txtNombreUsuario.TabIndex = 4;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreoElectronico.Location = new System.Drawing.Point(19, 122);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(150, 18);
            this.lblCorreoElectronico.TabIndex = 3;
            this.lblCorreoElectronico.Text = "Correo electronico: ";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasenia.Location = new System.Drawing.Point(19, 77);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(98, 18);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña: ";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.Location = new System.Drawing.Point(19, 34);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(153, 18);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre de Usuario: ";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(3, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(46, 18);
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
            this.paneApariencia.Location = new System.Drawing.Point(12, 307);
            this.paneApariencia.Name = "paneApariencia";
            this.paneApariencia.Size = new System.Drawing.Size(918, 117);
            this.paneApariencia.TabIndex = 1;
            // 
            // cmboxTema
            // 
            this.cmboxTema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxTema.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxTema.FormattingEnabled = true;
            this.cmboxTema.Items.AddRange(new object[] {
            "Claro",
            "Oscuro",
            "Predeterminado"});
            this.cmboxTema.Location = new System.Drawing.Point(331, 40);
            this.cmboxTema.Name = "cmboxTema";
            this.cmboxTema.Size = new System.Drawing.Size(474, 29);
            this.cmboxTema.TabIndex = 2;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTema.Location = new System.Drawing.Point(55, 47);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(54, 18);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Tema: ";
            // 
            // lblApariencia
            // 
            this.lblApariencia.AutoSize = true;
            this.lblApariencia.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApariencia.Location = new System.Drawing.Point(-1, 0);
            this.lblApariencia.Name = "lblApariencia";
            this.lblApariencia.Size = new System.Drawing.Size(82, 18);
            this.lblApariencia.TabIndex = 0;
            this.lblApariencia.Text = "Apariencia";
            // 
            // paneIdioma
            // 
            this.paneIdioma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneIdioma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIdioma.Controls.Add(this.cmboxIdiomas);
            this.paneIdioma.Controls.Add(this.label1);
            this.paneIdioma.Controls.Add(this.lblIdioma);
            this.paneIdioma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paneIdioma.Location = new System.Drawing.Point(12, 430);
            this.paneIdioma.Name = "paneIdioma";
            this.paneIdioma.Size = new System.Drawing.Size(918, 100);
            this.paneIdioma.TabIndex = 2;
            // 
            // cmboxIdiomas
            // 
            this.cmboxIdiomas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxIdiomas.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxIdiomas.FormattingEnabled = true;
            this.cmboxIdiomas.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmboxIdiomas.Location = new System.Drawing.Point(332, 40);
            this.cmboxIdiomas.Name = "cmboxIdiomas";
            this.cmboxIdiomas.Size = new System.Drawing.Size(474, 29);
            this.cmboxIdiomas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Idioma";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(54, 18);
            this.lblIdioma.TabIndex = 0;
            this.lblIdioma.Text = "Idioma";
            // 
            // btnAplicarCambios
            // 
            this.btnAplicarCambios.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarCambios.Location = new System.Drawing.Point(197, 536);
            this.btnAplicarCambios.Name = "btnAplicarCambios";
            this.btnAplicarCambios.Size = new System.Drawing.Size(183, 39);
            this.btnAplicarCambios.TabIndex = 3;
            this.btnAplicarCambios.Text = "Aplicar cambios";
            this.btnAplicarCambios.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(408, 536);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 39);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 600);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicarCambios);
            this.Controls.Add(this.paneIdioma);
            this.Controls.Add(this.paneApariencia);
            this.Controls.Add(this.panePerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Button btnCambiarCorreo;
        private System.Windows.Forms.Button btnCambiarContrasenia;
        private System.Windows.Forms.Button btnCambiarUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.PictureBox pboxAvatar;
        private System.Windows.Forms.Panel paneApariencia;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblApariencia;
        private System.Windows.Forms.ComboBox cmboxTema;
        private System.Windows.Forms.Panel paneIdioma;
        private System.Windows.Forms.Button btnAplicarCambios;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmboxIdiomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxAvatares;
        private System.Windows.Forms.Button btnCambiarAvatar;
    }
}