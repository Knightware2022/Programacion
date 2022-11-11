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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarFavoritos = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cmboxDeportesFavoritos = new System.Windows.Forms.ComboBox();
            this.lblDeportesFavoritos = new System.Windows.Forms.Label();
            this.paneDepoFav = new System.Windows.Forms.Panel();
            this.btnAgregarDeporteFavorito = new System.Windows.Forms.Button();
            this.cmboxDeportes = new System.Windows.Forms.ComboBox();
            this.lblDeportesDisponibles = new System.Windows.Forms.Label();
            this.paneEquiFav = new System.Windows.Forms.Panel();
            this.cmboxEquiFAv = new System.Windows.Forms.ComboBox();
            this.lblEquiposFav = new System.Windows.Forms.Label();
            this.btnEquiposNoFAv = new System.Windows.Forms.Button();
            this.btnRefrescarEqui = new System.Windows.Forms.Button();
            this.cmboxEquiSistem = new System.Windows.Forms.ComboBox();
            this.lblEquipos = new System.Windows.Forms.Label();
            this.paneDepoFav.SuspendLayout();
            this.paneEquiFav.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(274, 145);
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
            this.btnEliminarFavoritos.Location = new System.Drawing.Point(489, 157);
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
            this.btnRefrescar.Location = new System.Drawing.Point(75, 145);
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
            this.cmboxDeportesFavoritos.Location = new System.Drawing.Point(202, 72);
            this.cmboxDeportesFavoritos.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxDeportesFavoritos.Name = "cmboxDeportesFavoritos";
            this.cmboxDeportesFavoritos.Size = new System.Drawing.Size(485, 24);
            this.cmboxDeportesFavoritos.TabIndex = 1;
            // 
            // lblDeportesFavoritos
            // 
            this.lblDeportesFavoritos.AutoSize = true;
            this.lblDeportesFavoritos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeportesFavoritos.Location = new System.Drawing.Point(21, 76);
            this.lblDeportesFavoritos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeportesFavoritos.Name = "lblDeportesFavoritos";
            this.lblDeportesFavoritos.Size = new System.Drawing.Size(120, 15);
            this.lblDeportesFavoritos.TabIndex = 0;
            this.lblDeportesFavoritos.Text = "Deportes Favoritos: ";
            // 
            // paneDepoFav
            // 
            this.paneDepoFav.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneDepoFav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneDepoFav.Controls.Add(this.btnRefrescar);
            this.paneDepoFav.Controls.Add(this.btnVolver);
            this.paneDepoFav.Controls.Add(this.btnAgregarDeporteFavorito);
            this.paneDepoFav.Controls.Add(this.btnEliminarFavoritos);
            this.paneDepoFav.Controls.Add(this.cmboxDeportes);
            this.paneDepoFav.Controls.Add(this.cmboxDeportesFavoritos);
            this.paneDepoFav.Controls.Add(this.lblDeportesDisponibles);
            this.paneDepoFav.Controls.Add(this.lblDeportesFavoritos);
            this.paneDepoFav.Location = new System.Drawing.Point(1, 11);
            this.paneDepoFav.Margin = new System.Windows.Forms.Padding(2);
            this.paneDepoFav.Name = "paneDepoFav";
            this.paneDepoFav.Size = new System.Drawing.Size(721, 191);
            this.paneDepoFav.TabIndex = 1;
            // 
            // btnAgregarDeporteFavorito
            // 
            this.btnAgregarDeporteFavorito.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDeporteFavorito.Location = new System.Drawing.Point(489, 111);
            this.btnAgregarDeporteFavorito.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarDeporteFavorito.Name = "btnAgregarDeporteFavorito";
            this.btnAgregarDeporteFavorito.Size = new System.Drawing.Size(198, 30);
            this.btnAgregarDeporteFavorito.TabIndex = 3;
            this.btnAgregarDeporteFavorito.Text = "Agregar a favoritos";
            this.btnAgregarDeporteFavorito.UseVisualStyleBackColor = true;
            this.btnAgregarDeporteFavorito.Click += new System.EventHandler(this.btnAgregarDeporteFavorito_Click);
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
            this.lblDeportesDisponibles.Location = new System.Drawing.Point(21, 26);
            this.lblDeportesDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeportesDisponibles.Name = "lblDeportesDisponibles";
            this.lblDeportesDisponibles.Size = new System.Drawing.Size(127, 15);
            this.lblDeportesDisponibles.TabIndex = 0;
            this.lblDeportesDisponibles.Text = "Deportes disponibles";
            // 
            // paneEquiFav
            // 
            this.paneEquiFav.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneEquiFav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneEquiFav.Controls.Add(this.cmboxEquiFAv);
            this.paneEquiFav.Controls.Add(this.lblEquiposFav);
            this.paneEquiFav.Controls.Add(this.btnEquiposNoFAv);
            this.paneEquiFav.Controls.Add(this.btnRefrescarEqui);
            this.paneEquiFav.Controls.Add(this.cmboxEquiSistem);
            this.paneEquiFav.Controls.Add(this.lblEquipos);
            this.paneEquiFav.Location = new System.Drawing.Point(1, 206);
            this.paneEquiFav.Margin = new System.Windows.Forms.Padding(2);
            this.paneEquiFav.Name = "paneEquiFav";
            this.paneEquiFav.Size = new System.Drawing.Size(721, 223);
            this.paneEquiFav.TabIndex = 5;
            // 
            // cmboxEquiFAv
            // 
            this.cmboxEquiFAv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxEquiFAv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEquiFAv.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxEquiFAv.FormattingEnabled = true;
            this.cmboxEquiFAv.Location = new System.Drawing.Point(202, 80);
            this.cmboxEquiFAv.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquiFAv.Name = "cmboxEquiFAv";
            this.cmboxEquiFAv.Size = new System.Drawing.Size(485, 24);
            this.cmboxEquiFAv.TabIndex = 6;
            // 
            // lblEquiposFav
            // 
            this.lblEquiposFav.AutoSize = true;
            this.lblEquiposFav.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquiposFav.Location = new System.Drawing.Point(25, 84);
            this.lblEquiposFav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquiposFav.Name = "lblEquiposFav";
            this.lblEquiposFav.Size = new System.Drawing.Size(105, 15);
            this.lblEquiposFav.TabIndex = 5;
            this.lblEquiposFav.Text = "Equipos favoritos";
            // 
            // btnEquiposNoFAv
            // 
            this.btnEquiposNoFAv.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEquiposNoFAv.Location = new System.Drawing.Point(305, 168);
            this.btnEquiposNoFAv.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquiposNoFAv.Name = "btnEquiposNoFAv";
            this.btnEquiposNoFAv.Size = new System.Drawing.Size(198, 30);
            this.btnEquiposNoFAv.TabIndex = 3;
            this.btnEquiposNoFAv.Text = "Eliminar de favoritos";
            this.btnEquiposNoFAv.UseVisualStyleBackColor = true;
            this.btnEquiposNoFAv.Click += new System.EventHandler(this.btnEquiposNoFAv_Click);
            // 
            // btnRefrescarEqui
            // 
            this.btnRefrescarEqui.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescarEqui.Location = new System.Drawing.Point(79, 168);
            this.btnRefrescarEqui.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescarEqui.Name = "btnRefrescarEqui";
            this.btnRefrescarEqui.Size = new System.Drawing.Size(145, 30);
            this.btnRefrescarEqui.TabIndex = 2;
            this.btnRefrescarEqui.Text = "Refrescar lista";
            this.btnRefrescarEqui.UseVisualStyleBackColor = true;
            this.btnRefrescarEqui.Click += new System.EventHandler(this.btnRefrescarEqui_Click);
            // 
            // cmboxEquiSistem
            // 
            this.cmboxEquiSistem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxEquiSistem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEquiSistem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxEquiSistem.FormattingEnabled = true;
            this.cmboxEquiSistem.Location = new System.Drawing.Point(202, 26);
            this.cmboxEquiSistem.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquiSistem.Name = "cmboxEquiSistem";
            this.cmboxEquiSistem.Size = new System.Drawing.Size(485, 24);
            this.cmboxEquiSistem.TabIndex = 1;
            // 
            // lblEquipos
            // 
            this.lblEquipos.AutoSize = true;
            this.lblEquipos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquipos.Location = new System.Drawing.Point(25, 30);
            this.lblEquipos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipos.Name = "lblEquipos";
            this.lblEquipos.Size = new System.Drawing.Size(137, 15);
            this.lblEquipos.TabIndex = 0;
            this.lblEquipos.Text = "Equipos en el sistema: ";
            // 
            // Deportes_Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 440);
            this.Controls.Add(this.paneEquiFav);
            this.Controls.Add(this.paneDepoFav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deportes_Favoritos";
            this.Text = "Deportes_Favoritos";
            this.Load += new System.EventHandler(this.Deportes_Favoritos_Load);
            this.paneDepoFav.ResumeLayout(false);
            this.paneDepoFav.PerformLayout();
            this.paneEquiFav.ResumeLayout(false);
            this.paneEquiFav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblDeportesFavoritos;
        public System.Windows.Forms.Button btnEliminarFavoritos;
        public System.Windows.Forms.Button btnRefrescar;
        public System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel paneDepoFav;
        public System.Windows.Forms.Button btnAgregarDeporteFavorito;
        public System.Windows.Forms.Label lblDeportesDisponibles;
        private System.Windows.Forms.Panel paneEquiFav;
        public System.Windows.Forms.Button btnEquiposNoFAv;
        public System.Windows.Forms.Button btnRefrescarEqui;
        public System.Windows.Forms.Label lblEquipos;
        public System.Windows.Forms.Label lblEquiposFav;
        public System.Windows.Forms.ComboBox cmboxDeportesFavoritos;
        public System.Windows.Forms.ComboBox cmboxDeportes;
        public System.Windows.Forms.ComboBox cmboxEquiSistem;
        public System.Windows.Forms.ComboBox cmboxEquiFAv;
    }
}