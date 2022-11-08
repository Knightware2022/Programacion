namespace App_de_Usuario
{
    partial class Deportes_Favoritos
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
            this.paneDeportesFavoritos = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarFavoritos = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cmboxDeportesFavoritos = new System.Windows.Forms.ComboBox();
            this.lblDeportesFavoritos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarDeporteFavorito = new System.Windows.Forms.Button();
            this.btnRefrescarDeportesEnSistema = new System.Windows.Forms.Button();
            this.cmboxDeportes = new System.Windows.Forms.ComboBox();
            this.lblDeportesDisponibles = new System.Windows.Forms.Label();
            this.paneDeportesFavoritos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneDeportesFavoritos
            // 
            this.paneDeportesFavoritos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneDeportesFavoritos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneDeportesFavoritos.Controls.Add(this.btnVolver);
            this.paneDeportesFavoritos.Controls.Add(this.btnEliminarFavoritos);
            this.paneDeportesFavoritos.Controls.Add(this.btnRefrescar);
            this.paneDeportesFavoritos.Controls.Add(this.cmboxDeportesFavoritos);
            this.paneDeportesFavoritos.Controls.Add(this.lblDeportesFavoritos);
            this.paneDeportesFavoritos.Location = new System.Drawing.Point(1, 22);
            this.paneDeportesFavoritos.Margin = new System.Windows.Forms.Padding(2);
            this.paneDeportesFavoritos.Name = "paneDeportesFavoritos";
            this.paneDeportesFavoritos.Size = new System.Drawing.Size(721, 135);
            this.paneDeportesFavoritos.TabIndex = 0;
            this.paneDeportesFavoritos.Paint += new System.Windows.Forms.PaintEventHandler(this.paneDeportesFavoritos_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(507, 75);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 30);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Cerrar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarFavoritos
            // 
            this.btnEliminarFavoritos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarFavoritos.Location = new System.Drawing.Point(264, 75);
            this.btnEliminarFavoritos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarFavoritos.Name = "btnEliminarFavoritos";
            this.btnEliminarFavoritos.Size = new System.Drawing.Size(198, 30);
            this.btnEliminarFavoritos.TabIndex = 3;
            this.btnEliminarFavoritos.Text = "Eliminar de favoritos";
            this.btnEliminarFavoritos.UseVisualStyleBackColor = true;
            this.btnEliminarFavoritos.Click += new System.EventHandler(this.btnEliminarFavoritos_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(74, 75);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(145, 30);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "Refrescar lista";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // cmboxDeportesFavoritos
            // 
            this.cmboxDeportesFavoritos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxDeportesFavoritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxDeportesFavoritos.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxDeportesFavoritos.FormattingEnabled = true;
            this.cmboxDeportesFavoritos.Location = new System.Drawing.Point(202, 26);
            this.cmboxDeportesFavoritos.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxDeportesFavoritos.Name = "cmboxDeportesFavoritos";
            this.cmboxDeportesFavoritos.Size = new System.Drawing.Size(485, 24);
            this.cmboxDeportesFavoritos.TabIndex = 1;
            // 
            // lblDeportesFavoritos
            // 
            this.lblDeportesFavoritos.AutoSize = true;
            this.lblDeportesFavoritos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeportesFavoritos.Location = new System.Drawing.Point(25, 30);
            this.lblDeportesFavoritos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeportesFavoritos.Name = "lblDeportesFavoritos";
            this.lblDeportesFavoritos.Size = new System.Drawing.Size(120, 15);
            this.lblDeportesFavoritos.TabIndex = 0;
            this.lblDeportesFavoritos.Text = "Deportes Favoritos: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAgregarDeporteFavorito);
            this.panel1.Controls.Add(this.btnRefrescarDeportesEnSistema);
            this.panel1.Controls.Add(this.cmboxDeportes);
            this.panel1.Controls.Add(this.lblDeportesDisponibles);
            this.panel1.Location = new System.Drawing.Point(1, 183);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 135);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregarDeporteFavorito
            // 
            this.btnAgregarDeporteFavorito.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDeporteFavorito.Location = new System.Drawing.Point(399, 75);
            this.btnAgregarDeporteFavorito.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDeporteFavorito.Name = "btnAgregarDeporteFavorito";
            this.btnAgregarDeporteFavorito.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarDeporteFavorito.TabIndex = 3;
            this.btnAgregarDeporteFavorito.Text = "Agregar a favoritos";
            this.btnAgregarDeporteFavorito.UseVisualStyleBackColor = true;
            this.btnAgregarDeporteFavorito.Click += new System.EventHandler(this.btnAgregarDeporteFavorito_Click);
            // 
            // btnRefrescarDeportesEnSistema
            // 
            this.btnRefrescarDeportesEnSistema.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescarDeportesEnSistema.Location = new System.Drawing.Point(131, 75);
            this.btnRefrescarDeportesEnSistema.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescarDeportesEnSistema.Name = "btnRefrescarDeportesEnSistema";
            this.btnRefrescarDeportesEnSistema.Size = new System.Drawing.Size(150, 30);
            this.btnRefrescarDeportesEnSistema.TabIndex = 2;
            this.btnRefrescarDeportesEnSistema.Text = "Refrescar lista";
            this.btnRefrescarDeportesEnSistema.UseVisualStyleBackColor = true;
            this.btnRefrescarDeportesEnSistema.Click += new System.EventHandler(this.btnRefrescarDeportesEnSistema_Click);
            // 
            // cmboxDeportes
            // 
            this.cmboxDeportes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxDeportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxDeportes.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxDeportes.FormattingEnabled = true;
            this.cmboxDeportes.Location = new System.Drawing.Point(202, 26);
            this.cmboxDeportes.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxDeportes.Name = "cmboxDeportes";
            this.cmboxDeportes.Size = new System.Drawing.Size(485, 24);
            this.cmboxDeportes.TabIndex = 1;
            // 
            // lblDeportesDisponibles
            // 
            this.lblDeportesDisponibles.AutoSize = true;
            this.lblDeportesDisponibles.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeportesDisponibles.Location = new System.Drawing.Point(25, 30);
            this.lblDeportesDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeportesDisponibles.Name = "lblDeportesDisponibles";
            this.lblDeportesDisponibles.Size = new System.Drawing.Size(127, 15);
            this.lblDeportesDisponibles.TabIndex = 0;
            this.lblDeportesDisponibles.Text = "Deportes disponibles";
            // 
            // Deportes_Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneDeportesFavoritos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deportes_Favoritos";
            this.Text = "Deportes_Favoritos";
            this.Load += new System.EventHandler(this.Deportes_Favoritos_Load);
            this.paneDeportesFavoritos.ResumeLayout(false);
            this.paneDeportesFavoritos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneDeportesFavoritos;
        private System.Windows.Forms.ComboBox cmboxDeportesFavoritos;
        public System.Windows.Forms.Label lblDeportesFavoritos;
        public System.Windows.Forms.Button btnEliminarFavoritos;
        public System.Windows.Forms.Button btnRefrescar;
        public System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnAgregarDeporteFavorito;
        public System.Windows.Forms.Button btnRefrescarDeportesEnSistema;
        private System.Windows.Forms.ComboBox cmboxDeportes;
        public System.Windows.Forms.Label lblDeportesDisponibles;
    }
}