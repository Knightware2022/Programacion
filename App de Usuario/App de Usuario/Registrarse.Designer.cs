namespace App_de_Usuario
{
    partial class Registrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrarse));
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.paneRegistrarse.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneRegistrarse
            // 
            this.paneRegistrarse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.paneRegistrarse.Location = new System.Drawing.Point(96, 152);
            this.paneRegistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneRegistrarse.Name = "paneRegistrarse";
            this.paneRegistrarse.Size = new System.Drawing.Size(743, 271);
            this.paneRegistrarse.TabIndex = 5;
            // 
            // btnVerContrasenia
            // 
            this.btnVerContrasenia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerContrasenia.BackgroundImage")));
            this.btnVerContrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerContrasenia.ForeColor = System.Drawing.Color.Firebrick;
            this.btnVerContrasenia.Location = new System.Drawing.Point(690, 85);
            this.btnVerContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerContrasenia.Name = "btnVerContrasenia";
            this.btnVerContrasenia.Size = new System.Drawing.Size(29, 28);
            this.btnVerContrasenia.TabIndex = 13;
            this.btnVerContrasenia.MouseEnter += new System.EventHandler(this.btnVerContrasenia_MouseEnter);
            this.btnVerContrasenia.MouseLeave += new System.EventHandler(this.btnVerContrasenia_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(390, 206);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(55, 206);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(132, 36);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(363, 171);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(321, 28);
            this.txtCorreo.TabIndex = 11;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.Location = new System.Drawing.Point(37, 171);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(150, 18);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo electronico: ";
            // 
            // txtConfirmarContrasenia
            // 
            this.txtConfirmarContrasenia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtConfirmarContrasenia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasenia.Location = new System.Drawing.Point(363, 116);
            this.txtConfirmarContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            this.txtConfirmarContrasenia.Size = new System.Drawing.Size(321, 28);
            this.txtConfirmarContrasenia.TabIndex = 9;
            // 
            // lblConfirmarContrasenia
            // 
            this.lblConfirmarContrasenia.AutoSize = true;
            this.lblConfirmarContrasenia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmarContrasenia.Location = new System.Drawing.Point(37, 121);
            this.lblConfirmarContrasenia.Name = "lblConfirmarContrasenia";
            this.lblConfirmarContrasenia.Size = new System.Drawing.Size(161, 18);
            this.lblConfirmarContrasenia.TabIndex = 8;
            this.lblConfirmarContrasenia.Text = "Confirmar contraseña";
            // 
            // txtRegistrarContrasenia
            // 
            this.txtRegistrarContrasenia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRegistrarContrasenia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarContrasenia.Location = new System.Drawing.Point(363, 65);
            this.txtRegistrarContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistrarContrasenia.Name = "txtRegistrarContrasenia";
            this.txtRegistrarContrasenia.Size = new System.Drawing.Size(321, 28);
            this.txtRegistrarContrasenia.TabIndex = 7;
            // 
            // lblRegistroUsuario
            // 
            this.lblRegistroUsuario.AutoSize = true;
            this.lblRegistroUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblRegistroUsuario.Location = new System.Drawing.Point(37, 70);
            this.lblRegistroUsuario.Name = "lblRegistroUsuario";
            this.lblRegistroUsuario.Size = new System.Drawing.Size(98, 18);
            this.lblRegistroUsuario.TabIndex = 6;
            this.lblRegistroUsuario.Text = "Contraseña: ";
            // 
            // txtRegistrarUsuario
            // 
            this.txtRegistrarUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRegistrarUsuario.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarUsuario.Location = new System.Drawing.Point(363, 18);
            this.txtRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistrarUsuario.Name = "txtRegistrarUsuario";
            this.txtRegistrarUsuario.Size = new System.Drawing.Size(321, 28);
            this.txtRegistrarUsuario.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.Location = new System.Drawing.Point(37, 21);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(71, 18);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Usuario: ";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "Conviértase en usuario premium para poder eliminar todas las publicidades, ",
            "seguir equipos, avisos de eventos, personalizar su ávatar y muchas otras fun-",
            "ciones muy interesantes que no encontrará en otro lugar",
            "Regístrese ahora a tan solo 15 USD"});
            this.listBox1.Location = new System.Drawing.Point(96, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(743, 88);
            this.listBox1.TabIndex = 6;
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 492);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.paneRegistrarse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            this.paneRegistrarse.ResumeLayout(false);
            this.paneRegistrarse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneRegistrarse;
        private System.Windows.Forms.Button btnVerContrasenia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtConfirmarContrasenia;
        private System.Windows.Forms.Label lblConfirmarContrasenia;
        private System.Windows.Forms.TextBox txtRegistrarContrasenia;
        private System.Windows.Forms.Label lblRegistroUsuario;
        private System.Windows.Forms.TextBox txtRegistrarUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ListBox listBox1;
    }
}