namespace App_de_Usuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.paneIngreso = new System.Windows.Forms.Panel();
            this.btnVerContraseniaII = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.paneRegistrarse = new System.Windows.Forms.Panel();
            this.btnVerContrasenia = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtConfirmarContrasenia = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasenia = new System.Windows.Forms.Label();
            this.txtRegistrarContrasenia = new System.Windows.Forms.TextBox();
            this.lblRegistroUsuario = new System.Windows.Forms.Label();
            this.txtRegistrarUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.paneIngreso.SuspendLayout();
            this.paneRegistrarse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(13, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(337, 33);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(13, 90);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(89, 17);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña: ";
            // 
            // paneIngreso
            // 
            this.paneIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIngreso.Controls.Add(this.btnVerContraseniaII);
            this.paneIngreso.Controls.Add(this.btnGuest);
            this.paneIngreso.Controls.Add(this.btnRegistrarse);
            this.paneIngreso.Controls.Add(this.btnIngresar);
            this.paneIngreso.Controls.Add(this.txtContrasenia);
            this.paneIngreso.Controls.Add(this.lblContrasenia);
            this.paneIngreso.Controls.Add(this.txtUsuario);
            this.paneIngreso.Controls.Add(this.lblUsuario);
            this.paneIngreso.Location = new System.Drawing.Point(15, 239);
            this.paneIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneIngreso.Name = "paneIngreso";
            this.paneIngreso.Size = new System.Drawing.Size(725, 200);
            this.paneIngreso.TabIndex = 3;
            // 
            // btnVerContraseniaII
            // 
            this.btnVerContraseniaII.Location = new System.Drawing.Point(553, 59);
            this.btnVerContraseniaII.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerContraseniaII.Name = "btnVerContraseniaII";
            this.btnVerContraseniaII.Size = new System.Drawing.Size(25, 24);
            this.btnVerContraseniaII.TabIndex = 7;
            this.btnVerContraseniaII.UseVisualStyleBackColor = true;
            this.btnVerContraseniaII.MouseEnter += new System.EventHandler(this.btnVerContrasenia_Enter);
            this.btnVerContraseniaII.MouseLeave += new System.EventHandler(this.btnVerContrasenia_Leave);
            // 
            // btnGuest
            // 
            this.btnGuest.Location = new System.Drawing.Point(415, 142);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(101, 36);
            this.btnGuest.TabIndex = 6;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(271, 142);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(101, 36);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(127, 142);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(337, 87);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(201, 22);
            this.txtContrasenia.TabIndex = 3;
            // 
            // paneRegistrarse
            // 
            this.paneRegistrarse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneRegistrarse.Controls.Add(this.btnVerContrasenia);
            this.paneRegistrarse.Controls.Add(this.btnCancelar);
            this.paneRegistrarse.Controls.Add(this.btnRegistro);
            this.paneRegistrarse.Controls.Add(this.txtCorreo);
            this.paneRegistrarse.Controls.Add(this.lblCorreo);
            this.paneRegistrarse.Controls.Add(this.txtConfirmarContrasenia);
            this.paneRegistrarse.Controls.Add(this.lblConfirmarContrasenia);
            this.paneRegistrarse.Controls.Add(this.txtRegistrarContrasenia);
            this.paneRegistrarse.Controls.Add(this.lblRegistroUsuario);
            this.paneRegistrarse.Controls.Add(this.txtRegistrarUsuario);
            this.paneRegistrarse.Controls.Add(this.lblNombreUsuario);
            this.paneRegistrarse.Location = new System.Drawing.Point(19, 14);
            this.paneRegistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneRegistrarse.Name = "paneRegistrarse";
            this.paneRegistrarse.Size = new System.Drawing.Size(725, 268);
            this.paneRegistrarse.TabIndex = 4;
            // 
            // btnVerContrasenia
            // 
            this.btnVerContrasenia.Location = new System.Drawing.Point(690, 85);
            this.btnVerContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerContrasenia.Name = "btnVerContrasenia";
            this.btnVerContrasenia.Size = new System.Drawing.Size(29, 28);
            this.btnVerContrasenia.TabIndex = 13;
            this.btnVerContrasenia.UseVisualStyleBackColor = true;
            this.btnVerContrasenia.MouseEnter += new System.EventHandler(this.btnVerContrasenia_Enter);
            this.btnVerContrasenia.MouseLeave += new System.EventHandler(this.btnVerContrasenia_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(411, 206);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(55, 206);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(101, 36);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(363, 171);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(321, 22);
            this.txtCorreo.TabIndex = 11;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(37, 171);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(132, 17);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo electronico: ";
            // 
            // txtConfirmarContrasenia
            // 
            this.txtConfirmarContrasenia.Location = new System.Drawing.Point(363, 116);
            this.txtConfirmarContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            this.txtConfirmarContrasenia.Size = new System.Drawing.Size(321, 22);
            this.txtConfirmarContrasenia.TabIndex = 9;
            // 
            // lblConfirmarContrasenia
            // 
            this.lblConfirmarContrasenia.AutoSize = true;
            this.lblConfirmarContrasenia.Location = new System.Drawing.Point(37, 121);
            this.lblConfirmarContrasenia.Name = "lblConfirmarContrasenia";
            this.lblConfirmarContrasenia.Size = new System.Drawing.Size(144, 17);
            this.lblConfirmarContrasenia.TabIndex = 8;
            this.lblConfirmarContrasenia.Text = "Confirmar contraseña";
            // 
            // txtRegistrarContrasenia
            // 
            this.txtRegistrarContrasenia.Location = new System.Drawing.Point(363, 65);
            this.txtRegistrarContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistrarContrasenia.Name = "txtRegistrarContrasenia";
            this.txtRegistrarContrasenia.Size = new System.Drawing.Size(321, 22);
            this.txtRegistrarContrasenia.TabIndex = 7;
            // 
            // lblRegistroUsuario
            // 
            this.lblRegistroUsuario.AutoSize = true;
            this.lblRegistroUsuario.Location = new System.Drawing.Point(37, 70);
            this.lblRegistroUsuario.Name = "lblRegistroUsuario";
            this.lblRegistroUsuario.Size = new System.Drawing.Size(89, 17);
            this.lblRegistroUsuario.TabIndex = 6;
            this.lblRegistroUsuario.Text = "Contraseña: ";
            // 
            // txtRegistrarUsuario
            // 
            this.txtRegistrarUsuario.Location = new System.Drawing.Point(363, 18);
            this.txtRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistrarUsuario.Name = "txtRegistrarUsuario";
            this.txtRegistrarUsuario.Size = new System.Drawing.Size(321, 22);
            this.txtRegistrarUsuario.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(37, 21);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(65, 17);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Usuario: ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 405);
            this.Controls.Add(this.paneRegistrarse);
            this.Controls.Add(this.paneIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Autentificacion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.paneIngreso.ResumeLayout(false);
            this.paneIngreso.PerformLayout();
            this.paneRegistrarse.ResumeLayout(false);
            this.paneRegistrarse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Panel paneIngreso;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Panel paneRegistrarse;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txtRegistrarContrasenia;
        private System.Windows.Forms.Label lblRegistroUsuario;
        private System.Windows.Forms.TextBox txtRegistrarUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblConfirmarContrasenia;
        private System.Windows.Forms.TextBox txtConfirmarContrasenia;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerContrasenia;
        private System.Windows.Forms.Button btnVerContraseniaII;
    }
}

