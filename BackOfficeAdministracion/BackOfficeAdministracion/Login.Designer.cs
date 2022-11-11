namespace BackOfficeAdministracion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.chkboxOlvide = new System.Windows.Forms.CheckBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.paneOlvide = new System.Windows.Forms.Panel();
            this.btnCancelarII = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.paneIngresar = new System.Windows.Forms.Panel();
            this.btnVerContrasenia = new System.Windows.Forms.Button();
            this.cmboxIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.paneOlvide.SuspendLayout();
            this.paneIngresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkboxOlvide
            // 
            this.chkboxOlvide.AutoSize = true;
            this.chkboxOlvide.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxOlvide.Location = new System.Drawing.Point(22, 243);
            this.chkboxOlvide.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxOlvide.Name = "chkboxOlvide";
            this.chkboxOlvide.Size = new System.Drawing.Size(147, 21);
            this.chkboxOlvide.TabIndex = 6;
            this.chkboxOlvide.Text = "Olvidó su contraseña?";
            this.chkboxOlvide.UseVisualStyleBackColor = true;
            this.chkboxOlvide.CheckedChanged += new System.EventHandler(this.chkboxOlvide_CheckedChanged_1);
            this.chkboxOlvide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkboxOlvide_MouseClick);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(16, 32);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(162, 17);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Ingrese su correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.Location = new System.Drawing.Point(200, 32);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(226, 23);
            this.txtCorreo.TabIndex = 8;
            // 
            // paneOlvide
            // 
            this.paneOlvide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneOlvide.Controls.Add(this.btnCancelarII);
            this.paneOlvide.Controls.Add(this.btnEnviar);
            this.paneOlvide.Controls.Add(this.lblCorreo);
            this.paneOlvide.Controls.Add(this.txtCorreo);
            this.paneOlvide.Location = new System.Drawing.Point(22, 94);
            this.paneOlvide.Margin = new System.Windows.Forms.Padding(2);
            this.paneOlvide.Name = "paneOlvide";
            this.paneOlvide.Size = new System.Drawing.Size(446, 126);
            this.paneOlvide.TabIndex = 9;
            // 
            // btnCancelarII
            // 
            this.btnCancelarII.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarII.Location = new System.Drawing.Point(266, 73);
            this.btnCancelarII.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarII.Name = "btnCancelarII";
            this.btnCancelarII.Size = new System.Drawing.Size(82, 32);
            this.btnCancelarII.TabIndex = 12;
            this.btnCancelarII.Text = "Cancelar";
            this.btnCancelarII.UseVisualStyleBackColor = true;
            this.btnCancelarII.Click += new System.EventHandler(this.btnCancelarII_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(82, 73);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(82, 32);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // paneIngresar
            // 
            this.paneIngresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIngresar.Controls.Add(this.btnVerContrasenia);
            this.paneIngresar.Controls.Add(this.cmboxIdioma);
            this.paneIngresar.Controls.Add(this.lblIdioma);
            this.paneIngresar.Controls.Add(this.btnCancelar);
            this.paneIngresar.Controls.Add(this.btnAceptar);
            this.paneIngresar.Controls.Add(this.txtContrasenia);
            this.paneIngresar.Controls.Add(this.txtUsuario);
            this.paneIngresar.Controls.Add(this.lblContrasenia);
            this.paneIngresar.Controls.Add(this.lblUsuario);
            this.paneIngresar.Location = new System.Drawing.Point(22, 42);
            this.paneIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.paneIngresar.Name = "paneIngresar";
            this.paneIngresar.Size = new System.Drawing.Size(454, 196);
            this.paneIngresar.TabIndex = 10;
            // 
            // btnVerContrasenia
            // 
            this.btnVerContrasenia.BackgroundImage = global::BackOfficeAdministracion.Properties.Resources.ojo;
            this.btnVerContrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerContrasenia.Location = new System.Drawing.Point(402, 84);
            this.btnVerContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerContrasenia.Name = "btnVerContrasenia";
            this.btnVerContrasenia.Size = new System.Drawing.Size(22, 21);
            this.btnVerContrasenia.TabIndex = 14;
            this.btnVerContrasenia.UseVisualStyleBackColor = true;
            this.btnVerContrasenia.MouseEnter += new System.EventHandler(this.btnVerContrasenia_MouseEnter);
            this.btnVerContrasenia.MouseLeave += new System.EventHandler(this.btnVerContrasenia_MouseLeave);
            // 
            // cmboxIdioma
            // 
            this.cmboxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxIdioma.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxIdioma.FormattingEnabled = true;
            this.cmboxIdioma.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.cmboxIdioma.Location = new System.Drawing.Point(147, 21);
            this.cmboxIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxIdioma.Name = "cmboxIdioma";
            this.cmboxIdioma.Size = new System.Drawing.Size(242, 25);
            this.cmboxIdioma.TabIndex = 13;
            this.cmboxIdioma.SelectedIndexChanged += new System.EventHandler(this.cmboxIdioma_SelectedIndexChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(16, 20);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(50, 17);
            this.lblIdioma.TabIndex = 12;
            this.lblIdioma.Text = "Idioma: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(244, 146);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 32);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(82, 146);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 32);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Entrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtContrasenia.Location = new System.Drawing.Point(147, 106);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(242, 23);
            this.txtContrasenia.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(147, 60);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(242, 23);
            this.txtUsuario.TabIndex = 8;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(16, 106);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(70, 17);
            this.lblContrasenia.TabIndex = 7;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(16, 59);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 306);
            this.Controls.Add(this.paneIngresar);
            this.Controls.Add(this.paneOlvide);
            this.Controls.Add(this.chkboxOlvide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.paneOlvide.ResumeLayout(false);
            this.paneOlvide.PerformLayout();
            this.paneIngresar.ResumeLayout(false);
            this.paneIngresar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblCorreo;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.Panel paneOlvide;
        public System.Windows.Forms.TextBox txtContrasenia;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Button btnCancelarII;
        public System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.ComboBox cmboxIdioma;
        public System.Windows.Forms.Label lblIdioma;
        public System.Windows.Forms.Button btnVerContrasenia;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Label lblContrasenia;
        public System.Windows.Forms.CheckBox chkboxOlvide;
        public System.Windows.Forms.Panel paneIngresar;
    }
}

