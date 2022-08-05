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
            this.paneIngresar = new System.Windows.Forms.Panel();
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
            this.chkboxOlvide.Location = new System.Drawing.Point(36, 279);
            this.chkboxOlvide.Name = "chkboxOlvide";
            this.chkboxOlvide.Size = new System.Drawing.Size(172, 21);
            this.chkboxOlvide.TabIndex = 6;
            this.chkboxOlvide.Text = "Olvidó su contraseña?";
            this.chkboxOlvide.UseVisualStyleBackColor = true;
            this.chkboxOlvide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkboxOlvide_MouseClick);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(21, 20);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(192, 17);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Ingrese su correo electronico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(237, 15);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(198, 22);
            this.txtCorreo.TabIndex = 8;
            // 
            // paneOlvide
            // 
            this.paneOlvide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneOlvide.Controls.Add(this.lblCorreo);
            this.paneOlvide.Controls.Add(this.txtCorreo);
            this.paneOlvide.Location = new System.Drawing.Point(29, 318);
            this.paneOlvide.Name = "paneOlvide";
            this.paneOlvide.Size = new System.Drawing.Size(450, 60);
            this.paneOlvide.TabIndex = 9;
            // 
            // paneIngresar
            // 
            this.paneIngresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIngresar.Controls.Add(this.btnCancelar);
            this.paneIngresar.Controls.Add(this.btnAceptar);
            this.paneIngresar.Controls.Add(this.txtContrasenia);
            this.paneIngresar.Controls.Add(this.txtUsuario);
            this.paneIngresar.Controls.Add(this.lblContrasenia);
            this.paneIngresar.Controls.Add(this.lblUsuario);
            this.paneIngresar.Location = new System.Drawing.Point(29, 32);
            this.paneIngresar.Name = "paneIngresar";
            this.paneIngresar.Size = new System.Drawing.Size(467, 241);
            this.paneIngresar.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 163);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(98, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 40);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Entrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(224, 101);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(192, 22);
            this.txtContrasenia.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(224, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(192, 22);
            this.txtUsuario.TabIndex = 8;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(49, 106);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(81, 17);
            this.lblContrasenia.TabIndex = 7;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(49, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario/Correo: ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 405);
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
    }
}

