namespace BackOfficeAdministracion
{
    partial class EncuentrosTorneos
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
            this.paneFiltro = new System.Windows.Forms.Panel();
            this.btnVerCargados = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cmboxDeportes = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.paneEncuentros = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmboxEquiposDeEncuentros = new System.Windows.Forms.ComboBox();
            this.cmboxEncuentros = new System.Windows.Forms.ComboBox();
            this.txtHoraFinaliza = new System.Windows.Forms.TextBox();
            this.txtFechaComienzo = new System.Windows.Forms.TextBox();
            this.lblEquiposEnEncuentro = new System.Windows.Forms.Label();
            this.lblHoraFinaliza = new System.Windows.Forms.Label();
            this.lblFechaComienzo = new System.Windows.Forms.Label();
            this.lblNombreEncuentro = new System.Windows.Forms.Label();
            this.paneFiltro.SuspendLayout();
            this.paneEncuentros.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneFiltro
            // 
            this.paneFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneFiltro.Controls.Add(this.btnVerCargados);
            this.paneFiltro.Controls.Add(this.btnFiltrar);
            this.paneFiltro.Controls.Add(this.btnRefrescar);
            this.paneFiltro.Controls.Add(this.cmboxDeportes);
            this.paneFiltro.Controls.Add(this.lblFiltro);
            this.paneFiltro.Location = new System.Drawing.Point(12, 12);
            this.paneFiltro.Name = "paneFiltro";
            this.paneFiltro.Size = new System.Drawing.Size(614, 131);
            this.paneFiltro.TabIndex = 0;
            // 
            // btnVerCargados
            // 
            this.btnVerCargados.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerCargados.Location = new System.Drawing.Point(18, 76);
            this.btnVerCargados.Name = "btnVerCargados";
            this.btnVerCargados.Size = new System.Drawing.Size(218, 35);
            this.btnVerCargados.TabIndex = 10;
            this.btnVerCargados.Text = "Encuentros en el torneo";
            this.btnVerCargados.UseVisualStyleBackColor = true;
            this.btnVerCargados.Click += new System.EventHandler(this.btnVerCargados_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Location = new System.Drawing.Point(261, 76);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 35);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(493, 10);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(94, 35);
            this.btnRefrescar.TabIndex = 8;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // cmboxDeportes
            // 
            this.cmboxDeportes.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxDeportes.FormattingEnabled = true;
            this.cmboxDeportes.Location = new System.Drawing.Point(208, 15);
            this.cmboxDeportes.Name = "cmboxDeportes";
            this.cmboxDeportes.Size = new System.Drawing.Size(212, 25);
            this.cmboxDeportes.TabIndex = 1;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFiltro.Location = new System.Drawing.Point(25, 18);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(156, 17);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtrar eventos por deporte: ";
            // 
            // paneEncuentros
            // 
            this.paneEncuentros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneEncuentros.Controls.Add(this.btnVolver);
            this.paneEncuentros.Controls.Add(this.btnQuitar);
            this.paneEncuentros.Controls.Add(this.btnAgregar);
            this.paneEncuentros.Controls.Add(this.cmboxEquiposDeEncuentros);
            this.paneEncuentros.Controls.Add(this.cmboxEncuentros);
            this.paneEncuentros.Controls.Add(this.txtHoraFinaliza);
            this.paneEncuentros.Controls.Add(this.txtFechaComienzo);
            this.paneEncuentros.Controls.Add(this.lblEquiposEnEncuentro);
            this.paneEncuentros.Controls.Add(this.lblHoraFinaliza);
            this.paneEncuentros.Controls.Add(this.lblFechaComienzo);
            this.paneEncuentros.Controls.Add(this.lblNombreEncuentro);
            this.paneEncuentros.Location = new System.Drawing.Point(16, 159);
            this.paneEncuentros.Name = "paneEncuentros";
            this.paneEncuentros.Size = new System.Drawing.Size(614, 252);
            this.paneEncuentros.TabIndex = 1;
            this.paneEncuentros.Paint += new System.Windows.Forms.PaintEventHandler(this.paneEncuentros_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(415, 190);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(106, 39);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnQuitar.Location = new System.Drawing.Point(225, 190);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(172, 39);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Quitar del torneo";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(59, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 41);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar al torneo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmboxEquiposDeEncuentros
            // 
            this.cmboxEquiposDeEncuentros.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxEquiposDeEncuentros.FormattingEnabled = true;
            this.cmboxEquiposDeEncuentros.Location = new System.Drawing.Point(208, 149);
            this.cmboxEquiposDeEncuentros.Name = "cmboxEquiposDeEncuentros";
            this.cmboxEquiposDeEncuentros.Size = new System.Drawing.Size(301, 25);
            this.cmboxEquiposDeEncuentros.TabIndex = 8;
            this.cmboxEquiposDeEncuentros.SelectedIndexChanged += new System.EventHandler(this.cmboxEquiposDeEncuentros_SelectedIndexChanged);
            // 
            // cmboxEncuentros
            // 
            this.cmboxEncuentros.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxEncuentros.FormattingEnabled = true;
            this.cmboxEncuentros.Location = new System.Drawing.Point(208, 27);
            this.cmboxEncuentros.Name = "cmboxEncuentros";
            this.cmboxEncuentros.Size = new System.Drawing.Size(301, 25);
            this.cmboxEncuentros.TabIndex = 7;
            this.cmboxEncuentros.SelectedIndexChanged += new System.EventHandler(this.cmboxEncuentros_SelectedIndexChanged);
            // 
            // txtHoraFinaliza
            // 
            this.txtHoraFinaliza.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtHoraFinaliza.Location = new System.Drawing.Point(208, 104);
            this.txtHoraFinaliza.Name = "txtHoraFinaliza";
            this.txtHoraFinaliza.Size = new System.Drawing.Size(301, 23);
            this.txtHoraFinaliza.TabIndex = 6;
            // 
            // txtFechaComienzo
            // 
            this.txtFechaComienzo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFechaComienzo.Location = new System.Drawing.Point(208, 64);
            this.txtFechaComienzo.Name = "txtFechaComienzo";
            this.txtFechaComienzo.Size = new System.Drawing.Size(301, 23);
            this.txtFechaComienzo.TabIndex = 5;
            // 
            // lblEquiposEnEncuentro
            // 
            this.lblEquiposEnEncuentro.AutoSize = true;
            this.lblEquiposEnEncuentro.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquiposEnEncuentro.Location = new System.Drawing.Point(25, 152);
            this.lblEquiposEnEncuentro.Name = "lblEquiposEnEncuentro";
            this.lblEquiposEnEncuentro.Size = new System.Drawing.Size(138, 17);
            this.lblEquiposEnEncuentro.TabIndex = 3;
            this.lblEquiposEnEncuentro.Text = "Equipos que participan: ";
            // 
            // lblHoraFinaliza
            // 
            this.lblHoraFinaliza.AutoSize = true;
            this.lblHoraFinaliza.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblHoraFinaliza.Location = new System.Drawing.Point(25, 107);
            this.lblHoraFinaliza.Name = "lblHoraFinaliza";
            this.lblHoraFinaliza.Size = new System.Drawing.Size(111, 17);
            this.lblHoraFinaliza.TabIndex = 2;
            this.lblHoraFinaliza.Text = "Fecha finalizacion: ";
            // 
            // lblFechaComienzo
            // 
            this.lblFechaComienzo.AutoSize = true;
            this.lblFechaComienzo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFechaComienzo.Location = new System.Drawing.Point(25, 71);
            this.lblFechaComienzo.Name = "lblFechaComienzo";
            this.lblFechaComienzo.Size = new System.Drawing.Size(98, 17);
            this.lblFechaComienzo.TabIndex = 1;
            this.lblFechaComienzo.Text = "Fecha comienzo:";
            // 
            // lblNombreEncuentro
            // 
            this.lblNombreEncuentro.AutoSize = true;
            this.lblNombreEncuentro.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNombreEncuentro.Location = new System.Drawing.Point(25, 27);
            this.lblNombreEncuentro.Name = "lblNombreEncuentro";
            this.lblNombreEncuentro.Size = new System.Drawing.Size(113, 17);
            this.lblNombreEncuentro.TabIndex = 0;
            this.lblNombreEncuentro.Text = "Nombre encuentro: ";
            // 
            // EncuentrosTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 446);
            this.Controls.Add(this.paneEncuentros);
            this.Controls.Add(this.paneFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EncuentrosTorneos";
            this.Text = "EncuentrosTorneos";
            this.Load += new System.EventHandler(this.EncuentrosTorneos_Load);
            this.paneFiltro.ResumeLayout(false);
            this.paneFiltro.PerformLayout();
            this.paneEncuentros.ResumeLayout(false);
            this.paneEncuentros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneFiltro;
        private System.Windows.Forms.ComboBox cmboxDeportes;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel paneEncuentros;
        private System.Windows.Forms.Label lblHoraFinaliza;
        private System.Windows.Forms.Label lblFechaComienzo;
        private System.Windows.Forms.Label lblNombreEncuentro;
        private System.Windows.Forms.TextBox txtHoraFinaliza;
        private System.Windows.Forms.TextBox txtFechaComienzo;
        private System.Windows.Forms.Label lblEquiposEnEncuentro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ComboBox cmboxEquiposDeEncuentros;
        private System.Windows.Forms.ComboBox cmboxEncuentros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerCargados;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnVolver;
    }
}