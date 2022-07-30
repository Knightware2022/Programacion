namespace App_de_Usuario
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.paneBotones = new System.Windows.Forms.Panel();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.paneAvatar = new System.Windows.Forms.Panel();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.btnFavoritos = new System.Windows.Forms.Button();
            this.btnDeportes = new System.Windows.Forms.Button();
            this.btnEncuentros = new System.Windows.Forms.Button();
            this.btnTorneos = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.paneBanner = new System.Windows.Forms.Panel();
            this.pboxPublicidad = new System.Windows.Forms.PictureBox();
            this.paneVentanas = new System.Windows.Forms.Panel();
            this.paneBotones.SuspendLayout();
            this.paneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.paneAvatar.SuspendLayout();
            this.paneBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPublicidad)).BeginInit();
            this.SuspendLayout();
            // 
            // paneBotones
            // 
            this.paneBotones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paneBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBotones.Controls.Add(this.paneLogo);
            this.paneBotones.Controls.Add(this.paneAvatar);
            this.paneBotones.Controls.Add(this.btnFavoritos);
            this.paneBotones.Controls.Add(this.btnDeportes);
            this.paneBotones.Controls.Add(this.btnEncuentros);
            this.paneBotones.Controls.Add(this.btnTorneos);
            this.paneBotones.Controls.Add(this.btnResultados);
            this.paneBotones.Location = new System.Drawing.Point(1, 0);
            this.paneBotones.Margin = new System.Windows.Forms.Padding(4);
            this.paneBotones.Name = "paneBotones";
            this.paneBotones.Size = new System.Drawing.Size(966, 164);
            this.paneBotones.TabIndex = 0;
            // 
            // paneLogo
            // 
            this.paneLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneLogo.Controls.Add(this.pboxLogo);
            this.paneLogo.Location = new System.Drawing.Point(4, 4);
            this.paneLogo.Margin = new System.Windows.Forms.Padding(4);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(165, 155);
            this.paneLogo.TabIndex = 6;
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::App_de_Usuario.Properties.Resources.Knightware_Letra;
            this.pboxLogo.Location = new System.Drawing.Point(-1, -1);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(165, 155);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 1;
            this.pboxLogo.TabStop = false;
            // 
            // paneAvatar
            // 
            this.paneAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneAvatar.Controls.Add(this.btnAvatar);
            this.paneAvatar.Location = new System.Drawing.Point(795, 4);
            this.paneAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.paneAvatar.Name = "paneAvatar";
            this.paneAvatar.Size = new System.Drawing.Size(165, 155);
            this.paneAvatar.TabIndex = 5;
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackgroundImage = global::App_de_Usuario.Properties.Resources.avatar;
            this.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAvatar.Location = new System.Drawing.Point(-1, 3);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(161, 147);
            this.btnAvatar.TabIndex = 0;
            this.btnAvatar.UseVisualStyleBackColor = true;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnFavoritos.Location = new System.Drawing.Point(571, 33);
            this.btnFavoritos.Margin = new System.Windows.Forms.Padding(4);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(160, 44);
            this.btnFavoritos.TabIndex = 4;
            this.btnFavoritos.Text = "Equipos Favoritos";
            this.btnFavoritos.UseVisualStyleBackColor = true;
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // btnDeportes
            // 
            this.btnDeportes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeportes.Location = new System.Drawing.Point(486, 85);
            this.btnDeportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeportes.Name = "btnDeportes";
            this.btnDeportes.Size = new System.Drawing.Size(130, 44);
            this.btnDeportes.TabIndex = 3;
            this.btnDeportes.Text = "Deportes";
            this.btnDeportes.UseVisualStyleBackColor = true;
            // 
            // btnEncuentros
            // 
            this.btnEncuentros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnEncuentros.Location = new System.Drawing.Point(393, 31);
            this.btnEncuentros.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncuentros.Name = "btnEncuentros";
            this.btnEncuentros.Size = new System.Drawing.Size(128, 44);
            this.btnEncuentros.TabIndex = 2;
            this.btnEncuentros.Text = "Encuentros";
            this.btnEncuentros.UseVisualStyleBackColor = true;
            this.btnEncuentros.Click += new System.EventHandler(this.btnEncuentros_Click);
            // 
            // btnTorneos
            // 
            this.btnTorneos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnTorneos.Location = new System.Drawing.Point(290, 85);
            this.btnTorneos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTorneos.Name = "btnTorneos";
            this.btnTorneos.Size = new System.Drawing.Size(128, 44);
            this.btnTorneos.TabIndex = 1;
            this.btnTorneos.Text = "Torneos";
            this.btnTorneos.UseVisualStyleBackColor = true;
            // 
            // btnResultados
            // 
            this.btnResultados.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(177, 31);
            this.btnResultados.Margin = new System.Windows.Forms.Padding(4);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(138, 44);
            this.btnResultados.TabIndex = 0;
            this.btnResultados.Text = "Ver Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // paneBanner
            // 
            this.paneBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBanner.Controls.Add(this.pboxPublicidad);
            this.paneBanner.Location = new System.Drawing.Point(1, 672);
            this.paneBanner.Margin = new System.Windows.Forms.Padding(4);
            this.paneBanner.Name = "paneBanner";
            this.paneBanner.Size = new System.Drawing.Size(966, 140);
            this.paneBanner.TabIndex = 1;
            // 
            // pboxPublicidad
            // 
            this.pboxPublicidad.Image = global::App_de_Usuario.Properties.Resources.banner_publicidad_01;
            this.pboxPublicidad.Location = new System.Drawing.Point(3, 3);
            this.pboxPublicidad.Name = "pboxPublicidad";
            this.pboxPublicidad.Size = new System.Drawing.Size(957, 132);
            this.pboxPublicidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPublicidad.TabIndex = 0;
            this.pboxPublicidad.TabStop = false;
            this.pboxPublicidad.Click += new System.EventHandler(this.pboxPublicidad_Click);
            // 
            // paneVentanas
            // 
            this.paneVentanas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paneVentanas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneVentanas.Location = new System.Drawing.Point(1, 172);
            this.paneVentanas.Margin = new System.Windows.Forms.Padding(4);
            this.paneVentanas.Name = "paneVentanas";
            this.paneVentanas.Size = new System.Drawing.Size(966, 492);
            this.paneVentanas.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 814);
            this.Controls.Add(this.paneVentanas);
            this.Controls.Add(this.paneBanner);
            this.Controls.Add(this.paneBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "SIGDE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cerrarForm);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.paneBotones.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.paneAvatar.ResumeLayout(false);
            this.paneBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPublicidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneBotones;
        private System.Windows.Forms.Button btnEncuentros;
        private System.Windows.Forms.Button btnTorneos;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnDeportes;
        private System.Windows.Forms.Button btnFavoritos;
        private System.Windows.Forms.Panel paneAvatar;
        private System.Windows.Forms.Panel paneBanner;
        private System.Windows.Forms.Panel paneLogo;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.PictureBox pboxPublicidad;
        private System.Windows.Forms.Button btnAvatar;
        public System.Windows.Forms.Panel paneVentanas;
    }
}