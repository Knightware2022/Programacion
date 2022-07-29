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
            this.paneBotones = new System.Windows.Forms.Panel();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnTorneos = new System.Windows.Forms.Button();
            this.btnEncuentros = new System.Windows.Forms.Button();
            this.btnDeportes = new System.Windows.Forms.Button();
            this.btnFavoritos = new System.Windows.Forms.Button();
            this.paneAvatar = new System.Windows.Forms.Panel();
            this.pboxAvatar = new System.Windows.Forms.PictureBox();
            this.paneBanner = new System.Windows.Forms.Panel();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.paneVentanas = new System.Windows.Forms.Panel();
            this.paneBotones.SuspendLayout();
            this.paneAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // paneBotones
            // 
            this.paneBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBotones.Controls.Add(this.paneLogo);
            this.paneBotones.Controls.Add(this.paneAvatar);
            this.paneBotones.Controls.Add(this.btnFavoritos);
            this.paneBotones.Controls.Add(this.btnDeportes);
            this.paneBotones.Controls.Add(this.btnEncuentros);
            this.paneBotones.Controls.Add(this.btnTorneos);
            this.paneBotones.Controls.Add(this.btnResultados);
            this.paneBotones.Location = new System.Drawing.Point(1, 0);
            this.paneBotones.Name = "paneBotones";
            this.paneBotones.Size = new System.Drawing.Size(725, 134);
            this.paneBotones.TabIndex = 0;
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(133, 25);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(91, 36);
            this.btnResultados.TabIndex = 0;
            this.btnResultados.Text = "Ver Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            // 
            // btnTorneos
            // 
            this.btnTorneos.Location = new System.Drawing.Point(223, 69);
            this.btnTorneos.Name = "btnTorneos";
            this.btnTorneos.Size = new System.Drawing.Size(91, 36);
            this.btnTorneos.TabIndex = 1;
            this.btnTorneos.Text = "Torneos";
            this.btnTorneos.UseVisualStyleBackColor = true;
            // 
            // btnEncuentros
            // 
            this.btnEncuentros.Location = new System.Drawing.Point(300, 25);
            this.btnEncuentros.Name = "btnEncuentros";
            this.btnEncuentros.Size = new System.Drawing.Size(91, 36);
            this.btnEncuentros.TabIndex = 2;
            this.btnEncuentros.Text = "Encuentros";
            this.btnEncuentros.UseVisualStyleBackColor = true;
            // 
            // btnDeportes
            // 
            this.btnDeportes.Location = new System.Drawing.Point(371, 69);
            this.btnDeportes.Name = "btnDeportes";
            this.btnDeportes.Size = new System.Drawing.Size(91, 36);
            this.btnDeportes.TabIndex = 3;
            this.btnDeportes.Text = "Deportes";
            this.btnDeportes.UseVisualStyleBackColor = true;
            this.btnDeportes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.Location = new System.Drawing.Point(438, 27);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(105, 36);
            this.btnFavoritos.TabIndex = 4;
            this.btnFavoritos.Text = "Equipos Favoritos";
            this.btnFavoritos.UseVisualStyleBackColor = true;
            // 
            // paneAvatar
            // 
            this.paneAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneAvatar.Controls.Add(this.pboxAvatar);
            this.paneAvatar.Location = new System.Drawing.Point(596, 3);
            this.paneAvatar.Name = "paneAvatar";
            this.paneAvatar.Size = new System.Drawing.Size(124, 126);
            this.paneAvatar.TabIndex = 5;
            // 
            // pboxAvatar
            // 
            this.pboxAvatar.Location = new System.Drawing.Point(3, 7);
            this.pboxAvatar.Name = "pboxAvatar";
            this.pboxAvatar.Size = new System.Drawing.Size(116, 111);
            this.pboxAvatar.TabIndex = 0;
            this.pboxAvatar.TabStop = false;
            // 
            // paneBanner
            // 
            this.paneBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBanner.Location = new System.Drawing.Point(1, 546);
            this.paneBanner.Name = "paneBanner";
            this.paneBanner.Size = new System.Drawing.Size(725, 114);
            this.paneBanner.TabIndex = 1;
            // 
            // paneLogo
            // 
            this.paneLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneLogo.Location = new System.Drawing.Point(3, 3);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(124, 126);
            this.paneLogo.TabIndex = 6;
            // 
            // paneVentanas
            // 
            this.paneVentanas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneVentanas.Location = new System.Drawing.Point(1, 140);
            this.paneVentanas.Name = "paneVentanas";
            this.paneVentanas.Size = new System.Drawing.Size(725, 400);
            this.paneVentanas.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 661);
            this.Controls.Add(this.paneVentanas);
            this.Controls.Add(this.paneBanner);
            this.Controls.Add(this.paneBotones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Principal";
            this.Text = "SIGDE";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.paneBotones.ResumeLayout(false);
            this.paneAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).EndInit();
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
        private System.Windows.Forms.PictureBox pboxAvatar;
        private System.Windows.Forms.Panel paneBanner;
        private System.Windows.Forms.Panel paneLogo;
        private System.Windows.Forms.Panel paneVentanas;
    }
}