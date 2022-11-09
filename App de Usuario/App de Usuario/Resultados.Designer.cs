namespace App_de_Usuario
{
    partial class Resultados
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
            this.paneBuscar = new System.Windows.Forms.Panel();
            this.paneBuscarEvento = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmboxEquipos = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.grboxFiltros = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.rbTodoslosFiltros = new System.Windows.Forms.RadioButton();
            this.rbEquipo = new System.Windows.Forms.RadioButton();
            this.rbDeporte = new System.Windows.Forms.RadioButton();
            this.cmboxDeporte = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.paneResultados = new System.Windows.Forms.Panel();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.btnAlineacion = new System.Windows.Forms.Button();
            this.cmboxEquiposParticipan = new System.Windows.Forms.ComboBox();
            this.lblEquiposParticipando = new System.Windows.Forms.Label();
            this.txtDeporteEvento = new System.Windows.Forms.TextBox();
            this.lblDeporteEvento = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.txtFechaComienzo = new System.Windows.Forms.TextBox();
            this.cmboxNombreEvento = new System.Windows.Forms.ComboBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblfechaComienzo = new System.Windows.Forms.Label();
            this.lblEvento1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.paneBuscar.SuspendLayout();
            this.paneBuscarEvento.SuspendLayout();
            this.grboxFiltros.SuspendLayout();
            this.paneResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneBuscar
            // 
            this.paneBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.paneBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBuscar.Controls.Add(this.paneBuscarEvento);
            this.paneBuscar.Location = new System.Drawing.Point(9, 10);
            this.paneBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.paneBuscar.Name = "paneBuscar";
            this.paneBuscar.Size = new System.Drawing.Size(686, 112);
            this.paneBuscar.TabIndex = 0;
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
            this.paneBuscarEvento.Location = new System.Drawing.Point(2, 1);
            this.paneBuscarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.paneBuscarEvento.Name = "paneBuscarEvento";
            this.paneBuscarEvento.Size = new System.Drawing.Size(681, 108);
            this.paneBuscarEvento.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.Location = new System.Drawing.Point(35, 74);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(72, 29);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            // cmboxDeporte
            // 
            this.cmboxDeporte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxDeporte.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxDeporte.FormattingEnabled = true;
            this.cmboxDeporte.Location = new System.Drawing.Point(116, 9);
            this.cmboxDeporte.Margin = new System.Windows.Forms.Padding(2);
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
            // paneResultados
            // 
            this.paneResultados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneResultados.Controls.Add(this.btnIncidencias);
            this.paneResultados.Controls.Add(this.btnAlineacion);
            this.paneResultados.Controls.Add(this.cmboxEquiposParticipan);
            this.paneResultados.Controls.Add(this.lblEquiposParticipando);
            this.paneResultados.Controls.Add(this.txtDeporteEvento);
            this.paneResultados.Controls.Add(this.lblDeporteEvento);
            this.paneResultados.Controls.Add(this.txtFechaFin);
            this.paneResultados.Controls.Add(this.txtFechaComienzo);
            this.paneResultados.Controls.Add(this.cmboxNombreEvento);
            this.paneResultados.Controls.Add(this.lblFechaFin);
            this.paneResultados.Controls.Add(this.lblfechaComienzo);
            this.paneResultados.Controls.Add(this.lblEvento1);
            this.paneResultados.Controls.Add(this.btnVolver);
            this.paneResultados.Location = new System.Drawing.Point(9, 126);
            this.paneResultados.Margin = new System.Windows.Forms.Padding(2);
            this.paneResultados.Name = "paneResultados";
            this.paneResultados.Size = new System.Drawing.Size(686, 313);
            this.paneResultados.TabIndex = 1;
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnIncidencias.Location = new System.Drawing.Point(233, 244);
            this.btnIncidencias.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(117, 33);
            this.btnIncidencias.TabIndex = 44;
            this.btnIncidencias.Text = "Incidencias";
            this.btnIncidencias.UseVisualStyleBackColor = true;
            // 
            // btnAlineacion
            // 
            this.btnAlineacion.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAlineacion.Location = new System.Drawing.Point(59, 244);
            this.btnAlineacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlineacion.Name = "btnAlineacion";
            this.btnAlineacion.Size = new System.Drawing.Size(117, 33);
            this.btnAlineacion.TabIndex = 43;
            this.btnAlineacion.Text = "Alineacion";
            this.btnAlineacion.UseVisualStyleBackColor = true;
            this.btnAlineacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmboxEquiposParticipan
            // 
            this.cmboxEquiposParticipan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxEquiposParticipan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEquiposParticipan.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxEquiposParticipan.FormattingEnabled = true;
            this.cmboxEquiposParticipan.Location = new System.Drawing.Point(232, 181);
            this.cmboxEquiposParticipan.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquiposParticipan.Name = "cmboxEquiposParticipan";
            this.cmboxEquiposParticipan.Size = new System.Drawing.Size(380, 24);
            this.cmboxEquiposParticipan.TabIndex = 42;
            // 
            // lblEquiposParticipando
            // 
            this.lblEquiposParticipando.AutoSize = true;
            this.lblEquiposParticipando.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEquiposParticipando.Location = new System.Drawing.Point(34, 185);
            this.lblEquiposParticipando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquiposParticipando.Name = "lblEquiposParticipando";
            this.lblEquiposParticipando.Size = new System.Drawing.Size(142, 15);
            this.lblEquiposParticipando.TabIndex = 41;
            this.lblEquiposParticipando.Text = "Equipos que participan: ";
            // 
            // txtDeporteEvento
            // 
            this.txtDeporteEvento.Enabled = false;
            this.txtDeporteEvento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDeporteEvento.Location = new System.Drawing.Point(233, 54);
            this.txtDeporteEvento.Name = "txtDeporteEvento";
            this.txtDeporteEvento.Size = new System.Drawing.Size(380, 24);
            this.txtDeporteEvento.TabIndex = 40;
            // 
            // lblDeporteEvento
            // 
            this.lblDeporteEvento.AutoSize = true;
            this.lblDeporteEvento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeporteEvento.Location = new System.Drawing.Point(36, 58);
            this.lblDeporteEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeporteEvento.Name = "lblDeporteEvento";
            this.lblDeporteEvento.Size = new System.Drawing.Size(119, 15);
            this.lblDeporteEvento.TabIndex = 39;
            this.lblDeporteEvento.Text = "Deporte del evento: ";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Enabled = false;
            this.txtFechaFin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtFechaFin.Location = new System.Drawing.Point(233, 137);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(380, 24);
            this.txtFechaFin.TabIndex = 38;
            // 
            // txtFechaComienzo
            // 
            this.txtFechaComienzo.Enabled = false;
            this.txtFechaComienzo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtFechaComienzo.Location = new System.Drawing.Point(233, 91);
            this.txtFechaComienzo.Name = "txtFechaComienzo";
            this.txtFechaComienzo.Size = new System.Drawing.Size(380, 24);
            this.txtFechaComienzo.TabIndex = 37;
            // 
            // cmboxNombreEvento
            // 
            this.cmboxNombreEvento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxNombreEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxNombreEvento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxNombreEvento.FormattingEnabled = true;
            this.cmboxNombreEvento.Location = new System.Drawing.Point(233, 21);
            this.cmboxNombreEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxNombreEvento.Name = "cmboxNombreEvento";
            this.cmboxNombreEvento.Size = new System.Drawing.Size(380, 24);
            this.cmboxNombreEvento.TabIndex = 36;
            this.cmboxNombreEvento.SelectedIndexChanged += new System.EventHandler(this.cmboxNombreEvento_SelectedIndexChanged);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.Location = new System.Drawing.Point(34, 141);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(111, 15);
            this.lblFechaFin.TabIndex = 35;
            this.lblFechaFin.Text = "Fecha finalización:";
            // 
            // lblfechaComienzo
            // 
            this.lblfechaComienzo.AutoSize = true;
            this.lblfechaComienzo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblfechaComienzo.Location = new System.Drawing.Point(35, 95);
            this.lblfechaComienzo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechaComienzo.Name = "lblfechaComienzo";
            this.lblfechaComienzo.Size = new System.Drawing.Size(105, 15);
            this.lblfechaComienzo.TabIndex = 34;
            this.lblfechaComienzo.Text = "Fecha comienzo: ";
            // 
            // lblEvento1
            // 
            this.lblEvento1.AutoSize = true;
            this.lblEvento1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEvento1.Location = new System.Drawing.Point(35, 25);
            this.lblEvento1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvento1.Name = "lblEvento1";
            this.lblEvento1.Size = new System.Drawing.Size(119, 15);
            this.lblEvento1.TabIndex = 33;
            this.lblEvento1.Text = "Nombre del evento: ";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(409, 244);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 33);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 441);
            this.Controls.Add(this.paneResultados);
            this.Controls.Add(this.paneBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.paneBuscar.ResumeLayout(false);
            this.paneBuscarEvento.ResumeLayout(false);
            this.paneBuscarEvento.PerformLayout();
            this.grboxFiltros.ResumeLayout(false);
            this.grboxFiltros.PerformLayout();
            this.paneResultados.ResumeLayout(false);
            this.paneResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneBuscar;
        private System.Windows.Forms.Panel paneResultados;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel paneBuscarEvento;
        public System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmboxEquipos;
        public System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.GroupBox grboxFiltros;
        public System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.RadioButton rbTodoslosFiltros;
        private System.Windows.Forms.RadioButton rbEquipo;
        private System.Windows.Forms.RadioButton rbDeporte;
        private System.Windows.Forms.ComboBox cmboxDeporte;
        public System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.TextBox txtDeporteEvento;
        private System.Windows.Forms.Label lblDeporteEvento;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.TextBox txtFechaComienzo;
        private System.Windows.Forms.ComboBox cmboxNombreEvento;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblfechaComienzo;
        private System.Windows.Forms.Label lblEvento1;
        private System.Windows.Forms.ComboBox cmboxEquiposParticipan;
        private System.Windows.Forms.Label lblEquiposParticipando;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.Button btnAlineacion;
    }
}