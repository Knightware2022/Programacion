namespace App_de_Usuario
{
    partial class EventosProgramados
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
            this.paneBuscarEvento = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmboxDeporte = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.paneEvento = new System.Windows.Forms.Panel();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblfechaComienzo = new System.Windows.Forms.Label();
            this.lblEvento1 = new System.Windows.Forms.Label();
            this.cmboxNombreEvento = new System.Windows.Forms.ComboBox();
            this.grboxFiltros = new System.Windows.Forms.GroupBox();
            this.rbDeporte = new System.Windows.Forms.RadioButton();
            this.rbEquipo = new System.Windows.Forms.RadioButton();
            this.rbTodoslosFiltros = new System.Windows.Forms.RadioButton();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.cmboxEquipos = new System.Windows.Forms.ComboBox();
            this.txtFechaComienzo = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.lblEquiposParticipando = new System.Windows.Forms.Label();
            this.cmboxEquiposParticipan = new System.Windows.Forms.ComboBox();
            this.lblJugadores = new System.Windows.Forms.Label();
            this.cmboxJugadoresEquipos = new System.Windows.Forms.ComboBox();
            this.btnSuscribirse = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDeporteEvento = new System.Windows.Forms.Label();
            this.txtDeporteEvento = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.paneBuscarEvento.SuspendLayout();
            this.paneEvento.SuspendLayout();
            this.grboxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneBuscarEvento
            // 
            this.paneBuscarEvento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paneBuscarEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBuscarEvento.Controls.Add(this.btnFiltrar);
            this.paneBuscarEvento.Controls.Add(this.cmboxEquipos);
            this.paneBuscarEvento.Controls.Add(this.lblEquipo);
            this.paneBuscarEvento.Controls.Add(this.grboxFiltros);
            this.paneBuscarEvento.Controls.Add(this.cmboxDeporte);
            this.paneBuscarEvento.Controls.Add(this.lblDeporte);
            this.paneBuscarEvento.Location = new System.Drawing.Point(16, 2);
            this.paneBuscarEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneBuscarEvento.Name = "paneBuscarEvento";
            this.paneBuscarEvento.Size = new System.Drawing.Size(681, 108);
            this.paneBuscarEvento.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Location = new System.Drawing.Point(35, 74);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(72, 29);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmboxDeporte
            // 
            this.cmboxDeporte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxDeporte.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxDeporte.FormattingEnabled = true;
            this.cmboxDeporte.Location = new System.Drawing.Point(116, 9);
            this.cmboxDeporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmboxDeporte.Name = "cmboxDeporte";
            this.cmboxDeporte.Size = new System.Drawing.Size(322, 24);
            this.cmboxDeporte.TabIndex = 1;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeporte.Location = new System.Drawing.Point(32, 13);
            this.lblDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(58, 15);
            this.lblDeporte.TabIndex = 0;
            this.lblDeporte.Text = "Deporte: ";
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
            this.paneEvento.Location = new System.Drawing.Point(16, 114);
            this.paneEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneEvento.Name = "paneEvento";
            this.paneEvento.Size = new System.Drawing.Size(681, 378);
            this.paneEvento.TabIndex = 1;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.Location = new System.Drawing.Point(32, 156);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(111, 15);
            this.lblFechaFin.TabIndex = 12;
            this.lblFechaFin.Text = "Fecha finalización:";
            // 
            // lblfechaComienzo
            // 
            this.lblfechaComienzo.AutoSize = true;
            this.lblfechaComienzo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblfechaComienzo.Location = new System.Drawing.Point(33, 110);
            this.lblfechaComienzo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechaComienzo.Name = "lblfechaComienzo";
            this.lblfechaComienzo.Size = new System.Drawing.Size(105, 15);
            this.lblfechaComienzo.TabIndex = 6;
            this.lblfechaComienzo.Text = "Fecha comienzo: ";
            // 
            // lblEvento1
            // 
            this.lblEvento1.AutoSize = true;
            this.lblEvento1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvento1.Location = new System.Drawing.Point(33, 40);
            this.lblEvento1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvento1.Name = "lblEvento1";
            this.lblEvento1.Size = new System.Drawing.Size(119, 15);
            this.lblEvento1.TabIndex = 0;
            this.lblEvento1.Text = "Nombre del evento: ";
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
            // grboxFiltros
            // 
            this.grboxFiltros.Controls.Add(this.btnRefrescar);
            this.grboxFiltros.Controls.Add(this.rbTodoslosFiltros);
            this.grboxFiltros.Controls.Add(this.rbEquipo);
            this.grboxFiltros.Controls.Add(this.rbDeporte);
            this.grboxFiltros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.grboxFiltros.Location = new System.Drawing.Point(461, 9);
            this.grboxFiltros.Name = "grboxFiltros";
            this.grboxFiltros.Size = new System.Drawing.Size(200, 94);
            this.grboxFiltros.TabIndex = 3;
            this.grboxFiltros.TabStop = false;
            this.grboxFiltros.Text = "Filtrar por";
            // 
            // rbDeporte
            // 
            this.rbDeporte.AutoSize = true;
            this.rbDeporte.Location = new System.Drawing.Point(19, 20);
            this.rbDeporte.Name = "rbDeporte";
            this.rbDeporte.Size = new System.Drawing.Size(70, 19);
            this.rbDeporte.TabIndex = 0;
            this.rbDeporte.TabStop = true;
            this.rbDeporte.Text = "Deporte";
            this.rbDeporte.UseVisualStyleBackColor = true;
            this.rbDeporte.CheckedChanged += new System.EventHandler(this.rbDeporte_CheckedChanged);
            // 
            // rbEquipo
            // 
            this.rbEquipo.AutoSize = true;
            this.rbEquipo.Location = new System.Drawing.Point(19, 45);
            this.rbEquipo.Name = "rbEquipo";
            this.rbEquipo.Size = new System.Drawing.Size(63, 19);
            this.rbEquipo.TabIndex = 1;
            this.rbEquipo.TabStop = true;
            this.rbEquipo.Text = "Equipo";
            this.rbEquipo.UseVisualStyleBackColor = true;
            this.rbEquipo.CheckedChanged += new System.EventHandler(this.rbEquipo_CheckedChanged);
            // 
            // rbTodoslosFiltros
            // 
            this.rbTodoslosFiltros.AutoSize = true;
            this.rbTodoslosFiltros.Location = new System.Drawing.Point(19, 70);
            this.rbTodoslosFiltros.Name = "rbTodoslosFiltros";
            this.rbTodoslosFiltros.Size = new System.Drawing.Size(115, 19);
            this.rbTodoslosFiltros.TabIndex = 3;
            this.rbTodoslosFiltros.TabStop = true;
            this.rbTodoslosFiltros.Text = "Todos los filtros";
            this.rbTodoslosFiltros.UseVisualStyleBackColor = true;
            this.rbTodoslosFiltros.CheckedChanged += new System.EventHandler(this.rbTodoslosFiltros_CheckedChanged);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquipo.Location = new System.Drawing.Point(32, 45);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(51, 15);
            this.lblEquipo.TabIndex = 4;
            this.lblEquipo.Text = "Equipo: ";
            // 
            // cmboxEquipos
            // 
            this.cmboxEquipos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEquipos.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxEquipos.FormattingEnabled = true;
            this.cmboxEquipos.Location = new System.Drawing.Point(116, 41);
            this.cmboxEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquipos.Name = "cmboxEquipos";
            this.cmboxEquipos.Size = new System.Drawing.Size(322, 24);
            this.cmboxEquipos.TabIndex = 6;
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
            // txtFechaFin
            // 
            this.txtFechaFin.Enabled = false;
            this.txtFechaFin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtFechaFin.Location = new System.Drawing.Point(231, 152);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(380, 24);
            this.txtFechaFin.TabIndex = 25;
            // 
            // lblEquiposParticipando
            // 
            this.lblEquiposParticipando.AutoSize = true;
            this.lblEquiposParticipando.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquiposParticipando.Location = new System.Drawing.Point(33, 205);
            this.lblEquiposParticipando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquiposParticipando.Name = "lblEquiposParticipando";
            this.lblEquiposParticipando.Size = new System.Drawing.Size(142, 15);
            this.lblEquiposParticipando.TabIndex = 26;
            this.lblEquiposParticipando.Text = "Equipos que participan: ";
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
            // btnSuscribirse
            // 
            this.btnSuscribirse.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSuscribirse.Location = new System.Drawing.Point(206, 287);
            this.btnSuscribirse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuscribirse.Name = "btnSuscribirse";
            this.btnSuscribirse.Size = new System.Drawing.Size(199, 33);
            this.btnSuscribirse.TabIndex = 11;
            this.btnSuscribirse.Text = "Suscribirse al evento";
            this.btnSuscribirse.UseVisualStyleBackColor = true;
            this.btnSuscribirse.Click += new System.EventHandler(this.btnSuscribirse_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(530, 287);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 33);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDeporteEvento
            // 
            this.lblDeporteEvento.AutoSize = true;
            this.lblDeporteEvento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeporteEvento.Location = new System.Drawing.Point(34, 73);
            this.lblDeporteEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeporteEvento.Name = "lblDeporteEvento";
            this.lblDeporteEvento.Size = new System.Drawing.Size(119, 15);
            this.lblDeporteEvento.TabIndex = 31;
            this.lblDeporteEvento.Text = "Deporte del evento: ";
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
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(94, 19);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(101, 29);
            this.btnRefrescar.TabIndex = 11;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // EventosProgramados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 495);
            this.Controls.Add(this.paneEvento);
            this.Controls.Add(this.paneBuscarEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventosProgramados";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.EventosProgramados_Load);
            this.paneBuscarEvento.ResumeLayout(false);
            this.paneBuscarEvento.PerformLayout();
            this.paneEvento.ResumeLayout(false);
            this.paneEvento.PerformLayout();
            this.grboxFiltros.ResumeLayout(false);
            this.grboxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneBuscarEvento;
        private System.Windows.Forms.ComboBox cmboxDeporte;
        private System.Windows.Forms.Panel paneEvento;
        private System.Windows.Forms.Label lblEvento1;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblfechaComienzo;
        public System.Windows.Forms.Label lblDeporte;
        public System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmboxNombreEvento;
        private System.Windows.Forms.GroupBox grboxFiltros;
        private System.Windows.Forms.RadioButton rbEquipo;
        private System.Windows.Forms.RadioButton rbDeporte;
        public System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.RadioButton rbTodoslosFiltros;
        private System.Windows.Forms.ComboBox cmboxEquipos;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.TextBox txtFechaComienzo;
        private System.Windows.Forms.Label lblEquiposParticipando;
        private System.Windows.Forms.ComboBox cmboxEquiposParticipan;
        private System.Windows.Forms.ComboBox cmboxJugadoresEquipos;
        private System.Windows.Forms.Label lblJugadores;
        public System.Windows.Forms.Button btnSuscribirse;
        public System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtDeporteEvento;
        private System.Windows.Forms.Label lblDeporteEvento;
        public System.Windows.Forms.Button btnRefrescar;
    }
}