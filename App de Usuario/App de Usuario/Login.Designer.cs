﻿namespace App_de_Usuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.paneIngreso = new System.Windows.Forms.Panel();
            this.lblCambiarIdiomaII = new System.Windows.Forms.Label();
            this.cmboxCambiarIdiomaII = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.paneRegistrarse = new System.Windows.Forms.Panel();
            this.lblCambiarIdioma = new System.Windows.Forms.Label();
            this.cmboxIdioma = new System.Windows.Forms.ComboBox();
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
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(15, 50);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(339, 48);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 28);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasenia.Location = new System.Drawing.Point(15, 105);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(98, 18);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña: ";
            // 
            // paneIngreso
            // 
            this.paneIngreso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paneIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIngreso.Controls.Add(this.lblCambiarIdiomaII);
            this.paneIngreso.Controls.Add(this.cmboxCambiarIdiomaII);
            this.paneIngreso.Controls.Add(this.button1);
            this.paneIngreso.Controls.Add(this.btnGuest);
            this.paneIngreso.Controls.Add(this.btnRegistrarse);
            this.paneIngreso.Controls.Add(this.btnIngresar);
            this.paneIngreso.Controls.Add(this.txtContrasenia);
            this.paneIngreso.Controls.Add(this.lblContrasenia);
            this.paneIngreso.Controls.Add(this.txtUsuario);
            this.paneIngreso.Controls.Add(this.lblUsuario);
            this.paneIngreso.Location = new System.Drawing.Point(12, 206);
            this.paneIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneIngreso.Name = "paneIngreso";
            this.paneIngreso.Size = new System.Drawing.Size(725, 200);
            this.paneIngreso.TabIndex = 3;
            // 
            // lblCambiarIdiomaII
            // 
            this.lblCambiarIdiomaII.AutoSize = true;
            this.lblCambiarIdiomaII.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCambiarIdiomaII.Location = new System.Drawing.Point(15, 15);
            this.lblCambiarIdiomaII.Name = "lblCambiarIdiomaII";
            this.lblCambiarIdiomaII.Size = new System.Drawing.Size(74, 18);
            this.lblCambiarIdiomaII.TabIndex = 17;
            this.lblCambiarIdiomaII.Text = "Lenguaje";
            // 
            // cmboxCambiarIdiomaII
            // 
            this.cmboxCambiarIdiomaII.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxCambiarIdiomaII.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxCambiarIdiomaII.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.cmboxCambiarIdiomaII.FormattingEnabled = true;
            this.cmboxCambiarIdiomaII.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmboxCambiarIdiomaII.Location = new System.Drawing.Point(339, 2);
            this.cmboxCambiarIdiomaII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxCambiarIdiomaII.Name = "cmboxCambiarIdiomaII";
            this.cmboxCambiarIdiomaII.Size = new System.Drawing.Size(321, 30);
            this.cmboxCambiarIdiomaII.TabIndex = 16;
            this.cmboxCambiarIdiomaII.SelectedIndexChanged += new System.EventHandler(this.cmboxCambiarIdiomaII_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(547, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseEnter += new System.EventHandler(this.btnVerContrasenia_Enter);
            this.button1.MouseLeave += new System.EventHandler(this.btnVerContrasenia_Leave);
            // 
            // btnGuest
            // 
            this.btnGuest.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.Location = new System.Drawing.Point(424, 142);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(139, 36);
            this.btnGuest.TabIndex = 6;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(271, 142);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(139, 36);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(116, 142);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(139, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContrasenia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(339, 102);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(201, 28);
            this.txtContrasenia.TabIndex = 3;
            // 
            // paneRegistrarse
            // 
            this.paneRegistrarse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paneRegistrarse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneRegistrarse.Controls.Add(this.lblCambiarIdioma);
            this.paneRegistrarse.Controls.Add(this.cmboxIdioma);
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
            this.paneRegistrarse.Size = new System.Drawing.Size(725, 317);
            this.paneRegistrarse.TabIndex = 4;
            // 
            // lblCambiarIdioma
            // 
            this.lblCambiarIdioma.AutoSize = true;
            this.lblCambiarIdioma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCambiarIdioma.Location = new System.Drawing.Point(37, 15);
            this.lblCambiarIdioma.Name = "lblCambiarIdioma";
            this.lblCambiarIdioma.Size = new System.Drawing.Size(74, 18);
            this.lblCambiarIdioma.TabIndex = 15;
            this.lblCambiarIdioma.Text = "Lenguaje";
            // 
            // cmboxIdioma
            // 
            this.cmboxIdioma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxIdioma.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.cmboxIdioma.FormattingEnabled = true;
            this.cmboxIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmboxIdioma.Location = new System.Drawing.Point(363, 9);
            this.cmboxIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxIdioma.Name = "cmboxIdioma";
            this.cmboxIdioma.Size = new System.Drawing.Size(321, 30);
            this.cmboxIdioma.TabIndex = 14;
            this.cmboxIdioma.SelectedIndexChanged += new System.EventHandler(this.cmboxIdioma_SelectedIndexChanged);
            // 
            // btnVerContrasenia
            // 
            this.btnVerContrasenia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerContrasenia.BackgroundImage")));
            this.btnVerContrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerContrasenia.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVerContrasenia.Location = new System.Drawing.Point(691, 128);
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
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(419, 250);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 48);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(96, 250);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(132, 48);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(363, 214);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(321, 28);
            this.txtCorreo.TabIndex = 11;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.Location = new System.Drawing.Point(37, 214);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(150, 18);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo electronico: ";
            // 
            // txtConfirmarContrasenia
            // 
            this.txtConfirmarContrasenia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtConfirmarContrasenia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasenia.Location = new System.Drawing.Point(363, 159);
            this.txtConfirmarContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            this.txtConfirmarContrasenia.Size = new System.Drawing.Size(321, 28);
            this.txtConfirmarContrasenia.TabIndex = 9;
            // 
            // lblConfirmarContrasenia
            // 
            this.lblConfirmarContrasenia.AutoSize = true;
            this.lblConfirmarContrasenia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmarContrasenia.Location = new System.Drawing.Point(37, 164);
            this.lblConfirmarContrasenia.Name = "lblConfirmarContrasenia";
            this.lblConfirmarContrasenia.Size = new System.Drawing.Size(161, 18);
            this.lblConfirmarContrasenia.TabIndex = 8;
            this.lblConfirmarContrasenia.Text = "Confirmar contraseña";
            // 
            // txtRegistrarContrasenia
            // 
            this.txtRegistrarContrasenia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRegistrarContrasenia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarContrasenia.Location = new System.Drawing.Point(363, 108);
            this.txtRegistrarContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistrarContrasenia.Name = "txtRegistrarContrasenia";
            this.txtRegistrarContrasenia.Size = new System.Drawing.Size(321, 28);
            this.txtRegistrarContrasenia.TabIndex = 7;
            // 
            // lblRegistroUsuario
            // 
            this.lblRegistroUsuario.AutoSize = true;
            this.lblRegistroUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblRegistroUsuario.Location = new System.Drawing.Point(37, 113);
            this.lblRegistroUsuario.Name = "lblRegistroUsuario";
            this.lblRegistroUsuario.Size = new System.Drawing.Size(98, 18);
            this.lblRegistroUsuario.TabIndex = 6;
            this.lblRegistroUsuario.Text = "Contraseña: ";
            // 
            // txtRegistrarUsuario
            // 
            this.txtRegistrarUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRegistrarUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarUsuario.Location = new System.Drawing.Point(363, 62);
            this.txtRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistrarUsuario.Name = "txtRegistrarUsuario";
            this.txtRegistrarUsuario.Size = new System.Drawing.Size(321, 28);
            this.txtRegistrarUsuario.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.Location = new System.Drawing.Point(37, 64);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(71, 18);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Usuario: ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel paneIngreso;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Panel paneRegistrarse;
        private System.Windows.Forms.TextBox txtRegistrarContrasenia;
        private System.Windows.Forms.TextBox txtRegistrarUsuario;
        private System.Windows.Forms.TextBox txtConfirmarContrasenia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnVerContrasenia;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblContrasenia;
        public System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.Button btnGuest;
        public System.Windows.Forms.Button btnRegistrarse;
        public System.Windows.Forms.Label lblRegistroUsuario;
        public System.Windows.Forms.Label lblNombreUsuario;
        public System.Windows.Forms.Label lblConfirmarContrasenia;
        public System.Windows.Forms.Button btnRegistro;
        public System.Windows.Forms.Label lblCorreo;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lblCambiarIdioma;
        public System.Windows.Forms.Label lblCambiarIdiomaII;
        public System.Windows.Forms.ComboBox cmboxIdioma;
        public System.Windows.Forms.ComboBox cmboxCambiarIdiomaII;
    }
}

