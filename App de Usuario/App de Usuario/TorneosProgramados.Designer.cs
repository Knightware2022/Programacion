namespace App_de_Usuario
{
    partial class TorneosProgramados
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
            this.paneEvento = new System.Windows.Forms.Panel();
            this.txtDeporteEvento = new System.Windows.Forms.TextBox();
            this.lblDeporteEvento = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSuscribirse = new System.Windows.Forms.Button();
            this.cmboxJugadoresEquipos = new System.Windows.Forms.ComboBox();
            this.lblJugadores = new System.Windows.Forms.Label();
            this.cmboxEquiposParticipan = new System.Windows.Forms.ComboBox();
            this.lblEquiposParticipando = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.txtFechaComienzo = new System.Windows.Forms.TextBox();
            this.cmboxNombreEvento = new System.Windows.Forms.ComboBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblfechaComienzo = new System.Windows.Forms.Label();
            this.lblEvento1 = new System.Windows.Forms.Label();
            this.paneBuscarEvento = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmboxTorneos = new System.Windows.Forms.ComboBox();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.paneEvento.SuspendLayout();
            this.paneBuscarEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneEvento
            // 
            this.paneEvento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneEvento.Controls.Add(this.txtDeporteEvento);
            this.paneEvento.Controls.Add(this.lblDeporteEvento);
            this.paneEvento.Controls.Add(this.btnVolver);
            this.paneEvento.Controls.Add(this.btnSuscribirse);
            this.paneEvento.Controls.Add(this.cmboxJugadoresEquipos);
            this.paneEvento.Controls.Add(this.lblJugadores);
            this.paneEvento.Controls.Add(this.cmboxEquiposParticipan);
            this.paneEvento.Controls.Add(this.lblEquiposParticipando);
            this.paneEvento.Controls.Add(this.txtFechaFin);
            this.paneEvento.Controls.Add(this.txtFechaComienzo);
            this.paneEvento.Controls.Add(this.cmboxNombreEvento);
            this.paneEvento.Controls.Add(this.lblFechaFin);
            this.paneEvento.Controls.Add(this.lblfechaComienzo);
            this.paneEvento.Controls.Add(this.lblEvento1);
            this.paneEvento.Location = new System.Drawing.Point(1, 91);
            this.paneEvento.Margin = new System.Windows.Forms.Padding(2);
            this.paneEvento.Name = "paneEvento";
            this.paneEvento.Size = new System.Drawing.Size(705, 401);
            this.paneEvento.TabIndex = 3;
            // 
            // txtDeporteEvento
            // 
            this.txtDeporteEvento.Enabled = false;
            this.txtDeporteEvento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDeporteEvento.Location = new System.Drawing.Point(231, 69);
            this.txtDeporteEvento.Name = "txtDeporteEvento";
            this.txtDeporteEvento.Size = new System.Drawing.Size(380, 24);
            this.txtDeporteEvento.TabIndex = 32;
            // 
            // lblDeporteEvento
            // 
            this.lblDeporteEvento.AutoSize = true;
            this.lblDeporteEvento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeporteEvento.Location = new System.Drawing.Point(32, 73);
            this.lblDeporteEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeporteEvento.Name = "lblDeporteEvento";
            this.lblDeporteEvento.Size = new System.Drawing.Size(112, 15);
            this.lblDeporteEvento.TabIndex = 31;
            this.lblDeporteEvento.Text = "Deporte del torneo";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(531, 301);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 33);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSuscribirse
            // 
            this.btnSuscribirse.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSuscribirse.Location = new System.Drawing.Point(197, 301);
            this.btnSuscribirse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuscribirse.Name = "btnSuscribirse";
            this.btnSuscribirse.Size = new System.Drawing.Size(199, 33);
            this.btnSuscribirse.TabIndex = 11;
            this.btnSuscribirse.Text = "Suscribirse al Torneo";
            this.btnSuscribirse.UseVisualStyleBackColor = true;
            this.btnSuscribirse.Click += new System.EventHandler(this.btnSuscribirse_Click);
            // 
            // cmboxJugadoresEquipos
            // 
            this.cmboxJugadoresEquipos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxJugadoresEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxJugadoresEquipos.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxJugadoresEquipos.FormattingEnabled = true;
            this.cmboxJugadoresEquipos.Location = new System.Drawing.Point(231, 246);
            this.cmboxJugadoresEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxJugadoresEquipos.Name = "cmboxJugadoresEquipos";
            this.cmboxJugadoresEquipos.Size = new System.Drawing.Size(380, 24);
            this.cmboxJugadoresEquipos.TabIndex = 29;
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblJugadores.Location = new System.Drawing.Point(32, 255);
            this.lblJugadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(135, 15);
            this.lblJugadores.TabIndex = 28;
            this.lblJugadores.Text = "Jugadores del equipo: ";
            // 
            // cmboxEquiposParticipan
            // 
            this.cmboxEquiposParticipan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxEquiposParticipan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEquiposParticipan.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxEquiposParticipan.FormattingEnabled = true;
            this.cmboxEquiposParticipan.Location = new System.Drawing.Point(231, 201);
            this.cmboxEquiposParticipan.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquiposParticipan.Name = "cmboxEquiposParticipan";
            this.cmboxEquiposParticipan.Size = new System.Drawing.Size(380, 24);
            this.cmboxEquiposParticipan.TabIndex = 27;
            this.cmboxEquiposParticipan.SelectedIndexChanged += new System.EventHandler(this.cmboxEquiposParticipan_SelectedIndexChanged);
            // 
            // lblEquiposParticipando
            // 
            this.lblEquiposParticipando.AutoSize = true;
            this.lblEquiposParticipando.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquiposParticipando.Location = new System.Drawing.Point(33, 210);
            this.lblEquiposParticipando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquiposParticipando.Name = "lblEquiposParticipando";
            this.lblEquiposParticipando.Size = new System.Drawing.Size(202, 15);
            this.lblEquiposParticipando.TabIndex = 26;
            this.lblEquiposParticipando.Text = "Equipos que participan del torneo: ";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Enabled = false;
            this.txtFechaFin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtFechaFin.Location = new System.Drawing.Point(231, 152);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(380, 24);
            this.txtFechaFin.TabIndex = 25;
            // 
            // txtFechaComienzo
            // 
            this.txtFechaComienzo.Enabled = false;
            this.txtFechaComienzo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtFechaComienzo.Location = new System.Drawing.Point(231, 106);
            this.txtFechaComienzo.Name = "txtFechaComienzo";
            this.txtFechaComienzo.Size = new System.Drawing.Size(380, 24);
            this.txtFechaComienzo.TabIndex = 24;
            // 
            // cmboxNombreEvento
            // 
            this.cmboxNombreEvento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxNombreEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxNombreEvento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxNombreEvento.FormattingEnabled = true;
            this.cmboxNombreEvento.Location = new System.Drawing.Point(231, 36);
            this.cmboxNombreEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxNombreEvento.Name = "cmboxNombreEvento";
            this.cmboxNombreEvento.Size = new System.Drawing.Size(380, 24);
            this.cmboxNombreEvento.TabIndex = 23;
            this.cmboxNombreEvento.SelectedIndexChanged += new System.EventHandler(this.cmboxNombreEvento_SelectedIndexChanged);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.Location = new System.Drawing.Point(32, 156);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(171, 15);
            this.lblFechaFin.TabIndex = 12;
            this.lblFechaFin.Text = "Fecha finalización del torneo:";
            // 
            // lblfechaComienzo
            // 
            this.lblfechaComienzo.AutoSize = true;
            this.lblfechaComienzo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblfechaComienzo.Location = new System.Drawing.Point(33, 110);
            this.lblfechaComienzo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechaComienzo.Name = "lblfechaComienzo";
            this.lblfechaComienzo.Size = new System.Drawing.Size(165, 15);
            this.lblfechaComienzo.TabIndex = 6;
            this.lblfechaComienzo.Text = "Fecha comienzo del torneo: ";
            // 
            // lblEvento1
            // 
            this.lblEvento1.AutoSize = true;
            this.lblEvento1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvento1.Location = new System.Drawing.Point(33, 40);
            this.lblEvento1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvento1.Name = "lblEvento1";
            this.lblEvento1.Size = new System.Drawing.Size(138, 15);
            this.lblEvento1.TabIndex = 0;
            this.lblEvento1.Text = "Encuentros del torneo: ";
            // 
            // paneBuscarEvento
            // 
            this.paneBuscarEvento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paneBuscarEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBuscarEvento.Controls.Add(this.btnRefrescar);
            this.paneBuscarEvento.Controls.Add(this.btnFiltrar);
            this.paneBuscarEvento.Controls.Add(this.cmboxTorneos);
            this.paneBuscarEvento.Controls.Add(this.lblTorneo);
            this.paneBuscarEvento.Location = new System.Drawing.Point(1, 2);
            this.paneBuscarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.paneBuscarEvento.Name = "paneBuscarEvento";
            this.paneBuscarEvento.Size = new System.Drawing.Size(705, 85);
            this.paneBuscarEvento.TabIndex = 2;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(502, 12);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(109, 29);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Location = new System.Drawing.Point(502, 45);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(109, 29);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmboxTorneos
            // 
            this.cmboxTorneos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxTorneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTorneos.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxTorneos.FormattingEnabled = true;
            this.cmboxTorneos.Location = new System.Drawing.Point(133, 17);
            this.cmboxTorneos.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxTorneos.Name = "cmboxTorneos";
            this.cmboxTorneos.Size = new System.Drawing.Size(322, 24);
            this.cmboxTorneos.TabIndex = 1;
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTorneo.Location = new System.Drawing.Point(47, 21);
            this.lblTorneo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(53, 15);
            this.lblTorneo.TabIndex = 0;
            this.lblTorneo.Text = "Torneos";
            // 
            // TorneosProgramados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(708, 492);
            this.Controls.Add(this.paneEvento);
            this.Controls.Add(this.paneBuscarEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TorneosProgramados";
            this.Text = "TorneosProgramados";
            this.Load += new System.EventHandler(this.TorneosProgramados_Load);
            this.paneEvento.ResumeLayout(false);
            this.paneEvento.PerformLayout();
            this.paneBuscarEvento.ResumeLayout(false);
            this.paneBuscarEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneEvento;
        public System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.Button btnSuscribirse;
        private System.Windows.Forms.Panel paneBuscarEvento;
        public System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.Label lblTorneo;
        public System.Windows.Forms.Button btnRefrescar;
        public System.Windows.Forms.TextBox txtDeporteEvento;
        public System.Windows.Forms.Label lblDeporteEvento;
        public System.Windows.Forms.ComboBox cmboxJugadoresEquipos;
        public System.Windows.Forms.Label lblJugadores;
        public System.Windows.Forms.ComboBox cmboxEquiposParticipan;
        public System.Windows.Forms.Label lblEquiposParticipando;
        public System.Windows.Forms.TextBox txtFechaFin;
        public System.Windows.Forms.TextBox txtFechaComienzo;
        public System.Windows.Forms.ComboBox cmboxNombreEvento;
        public System.Windows.Forms.Label lblFechaFin;
        public System.Windows.Forms.Label lblfechaComienzo;
        public System.Windows.Forms.Label lblEvento1;
        public System.Windows.Forms.ComboBox cmboxTorneos;
    }
}