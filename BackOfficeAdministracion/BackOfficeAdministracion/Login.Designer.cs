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
            this.chkboxOlvide = new System.Windows.Forms.CheckBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.paneOlvide = new System.Windows.Forms.Panel();
            this.btnCancelarII = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.paneIngresar = new System.Windows.Forms.Panel();
            this.btnVerContrasenia = new System.Windows.Forms.Button();
            this.cmboxIdioma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.chkboxOlvide.Location = new System.Drawing.Point(29, 299);
            this.chkboxOlvide.Name = "chkboxOlvide";
            this.chkboxOlvide.Size = new System.Drawing.Size(189, 26);
            this.chkboxOlvide.TabIndex = 6;
            this.chkboxOlvide.Text = "Olvidó su contraseña?";
            this.chkboxOlvide.UseVisualStyleBackColor = true;
            this.chkboxOlvide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkboxOlvide_MouseClick);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(21, 39);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(215, 22);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Ingrese su correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.Location = new System.Drawing.Point(266, 39);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(300, 27);
            this.txtCorreo.TabIndex = 8;
            // 
            // paneOlvide
            // 
            this.paneOlvide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneOlvide.Controls.Add(this.btnCancelarII);
            this.paneOlvide.Controls.Add(this.btnEnviar);
            this.paneOlvide.Controls.Add(this.lblCorreo);
            this.paneOlvide.Controls.Add(this.txtCorreo);
            this.paneOlvide.Location = new System.Drawing.Point(29, 116);
            this.paneOlvide.Name = "paneOlvide";
            this.paneOlvide.Size = new System.Drawing.Size(594, 155);
            this.paneOlvide.TabIndex = 9;
            // 
            // btnCancelarII
            // 
            this.btnCancelarII.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarII.Location = new System.Drawing.Point(354, 90);
            this.btnCancelarII.Name = "btnCancelarII";
            this.btnCancelarII.Size = new System.Drawing.Size(110, 40);
            this.btnCancelarII.TabIndex = 12;
            this.btnCancelarII.Text = "Cancelar";
            this.btnCancelarII.UseVisualStyleBackColor = true;
            this.btnCancelarII.Click += new System.EventHandler(this.btnCancelarII_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(109, 90);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(110, 40);
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
            this.paneIngresar.Controls.Add(this.label1);
            this.paneIngresar.Controls.Add(this.btnCancelar);
            this.paneIngresar.Controls.Add(this.btnAceptar);
            this.paneIngresar.Controls.Add(this.txtContrasenia);
            this.paneIngresar.Controls.Add(this.txtUsuario);
            this.paneIngresar.Controls.Add(this.lblContrasenia);
            this.paneIngresar.Controls.Add(this.lblUsuario);
            this.paneIngresar.Location = new System.Drawing.Point(29, 53);
            this.paneIngresar.Name = "paneIngresar";
            this.paneIngresar.Size = new System.Drawing.Size(605, 241);
            this.paneIngresar.TabIndex = 10;
            // 
            // btnVerContrasenia
            // 
            this.btnVerContrasenia.BackgroundImage = global::BackOfficeAdministracion.Properties.Resources.ojo;
            this.btnVerContrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerContrasenia.Location = new System.Drawing.Point(536, 103);
            this.btnVerContrasenia.Name = "btnVerContrasenia";
            this.btnVerContrasenia.Size = new System.Drawing.Size(30, 26);
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
            "Ingles"});
            this.cmboxIdioma.Location = new System.Drawing.Point(196, 26);
            this.cmboxIdioma.Name = "cmboxIdioma";
            this.cmboxIdioma.Size = new System.Drawing.Size(321, 30);
            this.cmboxIdioma.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Idioma: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(326, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(109, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 40);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Entrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtContrasenia.Location = new System.Drawing.Point(196, 131);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(321, 27);
            this.txtContrasenia.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(196, 74);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(321, 27);
            this.txtUsuario.TabIndex = 8;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(21, 130);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(90, 22);
            this.lblContrasenia.TabIndex = 7;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(21, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(125, 22);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario/Correo: ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 377);
            this.Controls.Add(this.paneIngresar);
            this.Controls.Add(this.paneOlvide);
            this.Controls.Add(this.chkboxOlvide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificacion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.paneOlvide.ResumeLayout(false);
            this.paneOlvide.PerformLayout();
            this.paneIngresar.ResumeLayout(false);
            this.paneIngresar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkboxOlvide;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel paneOlvide;
        private System.Windows.Forms.Panel paneIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelarII;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cmboxIdioma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerContrasenia;
    }
}

