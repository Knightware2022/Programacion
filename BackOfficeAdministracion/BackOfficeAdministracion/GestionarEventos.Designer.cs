namespace BackOfficeAdministracion
{
    partial class GestionarEventos
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
            this.tbcGestionarEventos = new System.Windows.Forms.TabControl();
            this.tbpgAniadir = new System.Windows.Forms.TabPage();
            this.tbpgModificar = new System.Windows.Forms.TabPage();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblCompetidorLocal = new System.Windows.Forms.Label();
            this.lblCompetidorVisitante = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.cmboxModalidad = new System.Windows.Forms.ComboBox();
            this.lblFechaComienzo = new System.Windows.Forms.Label();
            this.lblHoraComienzo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmboxDeportes = new System.Windows.Forms.ComboBox();
            this.cmboxCompetidorLocal = new System.Windows.Forms.ComboBox();
            this.cmboxEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.dtimeFecha = new System.Windows.Forms.DateTimePicker();
            this.cmboxHoraComienzo = new System.Windows.Forms.ComboBox();
            this.cmboxMinutos = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.tbpgEliminar = new System.Windows.Forms.TabPage();
            this.paneEliminar = new System.Windows.Forms.Panel();
            this.lblIDevento = new System.Windows.Forms.Label();
            this.txtIDevento = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCerrarI = new System.Windows.Forms.Button();
            this.btnCerrarII = new System.Windows.Forms.Button();
            this.tbcGestionarEventos.SuspendLayout();
            this.tbpgAniadir.SuspendLayout();
            this.tbpgModificar.SuspendLayout();
            this.tbpgEliminar.SuspendLayout();
            this.paneEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestionarEventos
            // 
            this.tbcGestionarEventos.Controls.Add(this.tbpgAniadir);
            this.tbcGestionarEventos.Controls.Add(this.tbpgModificar);
            this.tbcGestionarEventos.Controls.Add(this.tbpgEliminar);
            this.tbcGestionarEventos.Location = new System.Drawing.Point(0, 4);
            this.tbcGestionarEventos.Name = "tbcGestionarEventos";
            this.tbcGestionarEventos.SelectedIndex = 0;
            this.tbcGestionarEventos.Size = new System.Drawing.Size(737, 586);
            this.tbcGestionarEventos.TabIndex = 0;
            // 
            // tbpgAniadir
            // 
            this.tbpgAniadir.Controls.Add(this.btnCerrarI);
            this.tbpgAniadir.Controls.Add(this.lblMinutos);
            this.tbpgAniadir.Controls.Add(this.lblHora);
            this.tbpgAniadir.Controls.Add(this.cmboxMinutos);
            this.tbpgAniadir.Controls.Add(this.cmboxHoraComienzo);
            this.tbpgAniadir.Controls.Add(this.dtimeFecha);
            this.tbpgAniadir.Controls.Add(this.cmboxEquipoVisitante);
            this.tbpgAniadir.Controls.Add(this.cmboxCompetidorLocal);
            this.tbpgAniadir.Controls.Add(this.cmboxDeportes);
            this.tbpgAniadir.Controls.Add(this.btnCancelar);
            this.tbpgAniadir.Controls.Add(this.btnAgregar);
            this.tbpgAniadir.Controls.Add(this.lblHoraComienzo);
            this.tbpgAniadir.Controls.Add(this.lblFechaComienzo);
            this.tbpgAniadir.Controls.Add(this.cmboxModalidad);
            this.tbpgAniadir.Controls.Add(this.lblModalidad);
            this.tbpgAniadir.Controls.Add(this.lblCompetidorVisitante);
            this.tbpgAniadir.Controls.Add(this.lblCompetidorLocal);
            this.tbpgAniadir.Controls.Add(this.lblDeporte);
            this.tbpgAniadir.Location = new System.Drawing.Point(4, 25);
            this.tbpgAniadir.Name = "tbpgAniadir";
            this.tbpgAniadir.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAniadir.Size = new System.Drawing.Size(729, 557);
            this.tbpgAniadir.TabIndex = 0;
            this.tbpgAniadir.Text = "Añadir evento";
            this.tbpgAniadir.UseVisualStyleBackColor = true;
            // 
            // tbpgModificar
            // 
            this.tbpgModificar.Controls.Add(this.btnCerrarII);
            this.tbpgModificar.Location = new System.Drawing.Point(4, 25);
            this.tbpgModificar.Name = "tbpgModificar";
            this.tbpgModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgModificar.Size = new System.Drawing.Size(728, 557);
            this.tbpgModificar.TabIndex = 1;
            this.tbpgModificar.Text = "Modificar Evento";
            this.tbpgModificar.UseVisualStyleBackColor = true;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(53, 59);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(67, 17);
            this.lblDeporte.TabIndex = 0;
            this.lblDeporte.Text = "Deporte: ";
            // 
            // lblCompetidorLocal
            // 
            this.lblCompetidorLocal.AutoSize = true;
            this.lblCompetidorLocal.Location = new System.Drawing.Point(53, 122);
            this.lblCompetidorLocal.Name = "lblCompetidorLocal";
            this.lblCompetidorLocal.Size = new System.Drawing.Size(159, 17);
            this.lblCompetidorLocal.TabIndex = 1;
            this.lblCompetidorLocal.Text = "Equipo/competidor local";
            // 
            // lblCompetidorVisitante
            // 
            this.lblCompetidorVisitante.AutoSize = true;
            this.lblCompetidorVisitante.Location = new System.Drawing.Point(53, 185);
            this.lblCompetidorVisitante.Name = "lblCompetidorVisitante";
            this.lblCompetidorVisitante.Size = new System.Drawing.Size(184, 17);
            this.lblCompetidorVisitante.TabIndex = 2;
            this.lblCompetidorVisitante.Text = "Equipo/Competidor visitante";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(53, 251);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(73, 17);
            this.lblModalidad.TabIndex = 3;
            this.lblModalidad.Text = "Modalidad";
            // 
            // cmboxModalidad
            // 
            this.cmboxModalidad.FormattingEnabled = true;
            this.cmboxModalidad.Items.AddRange(new object[] {
            "Amistoso",
            "Por puntos"});
            this.cmboxModalidad.Location = new System.Drawing.Point(336, 244);
            this.cmboxModalidad.Name = "cmboxModalidad";
            this.cmboxModalidad.Size = new System.Drawing.Size(260, 24);
            this.cmboxModalidad.TabIndex = 4;
            // 
            // lblFechaComienzo
            // 
            this.lblFechaComienzo.AutoSize = true;
            this.lblFechaComienzo.Location = new System.Drawing.Point(53, 316);
            this.lblFechaComienzo.Name = "lblFechaComienzo";
            this.lblFechaComienzo.Size = new System.Drawing.Size(133, 17);
            this.lblFechaComienzo.TabIndex = 5;
            this.lblFechaComienzo.Text = "Fecha de Comienzo";
            // 
            // lblHoraComienzo
            // 
            this.lblHoraComienzo.AutoSize = true;
            this.lblHoraComienzo.Location = new System.Drawing.Point(53, 378);
            this.lblHoraComienzo.Name = "lblHoraComienzo";
            this.lblHoraComienzo.Size = new System.Drawing.Size(125, 17);
            this.lblHoraComienzo.TabIndex = 6;
            this.lblHoraComienzo.Text = "Hora de Comienzo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(160, 447);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 40);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(388, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmboxDeportes
            // 
            this.cmboxDeportes.FormattingEnabled = true;
            this.cmboxDeportes.Location = new System.Drawing.Point(336, 59);
            this.cmboxDeportes.Name = "cmboxDeportes";
            this.cmboxDeportes.Size = new System.Drawing.Size(260, 24);
            this.cmboxDeportes.TabIndex = 9;
            // 
            // cmboxCompetidorLocal
            // 
            this.cmboxCompetidorLocal.FormattingEnabled = true;
            this.cmboxCompetidorLocal.Location = new System.Drawing.Point(336, 119);
            this.cmboxCompetidorLocal.Name = "cmboxCompetidorLocal";
            this.cmboxCompetidorLocal.Size = new System.Drawing.Size(260, 24);
            this.cmboxCompetidorLocal.TabIndex = 10;
            // 
            // cmboxEquipoVisitante
            // 
            this.cmboxEquipoVisitante.FormattingEnabled = true;
            this.cmboxEquipoVisitante.Location = new System.Drawing.Point(336, 185);
            this.cmboxEquipoVisitante.Name = "cmboxEquipoVisitante";
            this.cmboxEquipoVisitante.Size = new System.Drawing.Size(260, 24);
            this.cmboxEquipoVisitante.TabIndex = 11;
            // 
            // dtimeFecha
            // 
            this.dtimeFecha.Location = new System.Drawing.Point(334, 322);
            this.dtimeFecha.Name = "dtimeFecha";
            this.dtimeFecha.Size = new System.Drawing.Size(262, 22);
            this.dtimeFecha.TabIndex = 12;
            // 
            // cmboxHoraComienzo
            // 
            this.cmboxHoraComienzo.FormattingEnabled = true;
            this.cmboxHoraComienzo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.cmboxHoraComienzo.Location = new System.Drawing.Point(336, 375);
            this.cmboxHoraComienzo.Name = "cmboxHoraComienzo";
            this.cmboxHoraComienzo.Size = new System.Drawing.Size(87, 24);
            this.cmboxHoraComienzo.TabIndex = 13;
            // 
            // cmboxMinutos
            // 
            this.cmboxMinutos.FormattingEnabled = true;
            this.cmboxMinutos.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "00"});
            this.cmboxMinutos.Location = new System.Drawing.Point(483, 375);
            this.cmboxMinutos.Name = "cmboxMinutos";
            this.cmboxMinutos.Size = new System.Drawing.Size(87, 24);
            this.cmboxMinutos.TabIndex = 14;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(429, 382);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(25, 17);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "Hs";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(576, 382);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(57, 17);
            this.lblMinutos.TabIndex = 16;
            this.lblMinutos.Text = "minutos";
            // 
            // tbpgEliminar
            // 
            this.tbpgEliminar.Controls.Add(this.btnCerrar);
            this.tbpgEliminar.Controls.Add(this.paneEliminar);
            this.tbpgEliminar.Location = new System.Drawing.Point(4, 25);
            this.tbpgEliminar.Name = "tbpgEliminar";
            this.tbpgEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgEliminar.Size = new System.Drawing.Size(728, 557);
            this.tbpgEliminar.TabIndex = 2;
            this.tbpgEliminar.Text = "Eliminar Evento";
            this.tbpgEliminar.UseVisualStyleBackColor = true;
            // 
            // paneEliminar
            // 
            this.paneEliminar.Controls.Add(this.btnEliminar);
            this.paneEliminar.Controls.Add(this.txtIDevento);
            this.paneEliminar.Controls.Add(this.lblIDevento);
            this.paneEliminar.Location = new System.Drawing.Point(19, 152);
            this.paneEliminar.Name = "paneEliminar";
            this.paneEliminar.Size = new System.Drawing.Size(685, 210);
            this.paneEliminar.TabIndex = 0;
            // 
            // lblIDevento
            // 
            this.lblIDevento.AutoSize = true;
            this.lblIDevento.Location = new System.Drawing.Point(47, 61);
            this.lblIDevento.Name = "lblIDevento";
            this.lblIDevento.Size = new System.Drawing.Size(161, 17);
            this.lblIDevento.TabIndex = 0;
            this.lblIDevento.Text = "ID de evento a eliminar: ";
            // 
            // txtIDevento
            // 
            this.txtIDevento.Location = new System.Drawing.Point(294, 65);
            this.txtIDevento.Name = "txtIDevento";
            this.txtIDevento.Size = new System.Drawing.Size(256, 22);
            this.txtIDevento.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(197, 132);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Evento";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(671, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 26);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCerrarI
            // 
            this.btnCerrarI.Location = new System.Drawing.Point(675, 0);
            this.btnCerrarI.Name = "btnCerrarI";
            this.btnCerrarI.Size = new System.Drawing.Size(56, 26);
            this.btnCerrarI.TabIndex = 17;
            this.btnCerrarI.Text = "cerrar";
            this.btnCerrarI.UseVisualStyleBackColor = true;
            this.btnCerrarI.Click += new System.EventHandler(this.btnCerrarI_Click);
            // 
            // btnCerrarII
            // 
            this.btnCerrarII.Location = new System.Drawing.Point(668, 0);
            this.btnCerrarII.Name = "btnCerrarII";
            this.btnCerrarII.Size = new System.Drawing.Size(56, 26);
            this.btnCerrarII.TabIndex = 2;
            this.btnCerrarII.Text = "cerrar";
            this.btnCerrarII.UseVisualStyleBackColor = true;
            this.btnCerrarII.Click += new System.EventHandler(this.btnCerrarII_Click);
            // 
            // GestionarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 590);
            this.Controls.Add(this.tbcGestionarEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarEventos";
            this.Text = "GestionarEventos";
            this.Load += new System.EventHandler(this.GestionarEventos_Load);
            this.tbcGestionarEventos.ResumeLayout(false);
            this.tbpgAniadir.ResumeLayout(false);
            this.tbpgAniadir.PerformLayout();
            this.tbpgModificar.ResumeLayout(false);
            this.tbpgEliminar.ResumeLayout(false);
            this.paneEliminar.ResumeLayout(false);
            this.paneEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestionarEventos;
        private System.Windows.Forms.TabPage tbpgAniadir;
        private System.Windows.Forms.TabPage tbpgModificar;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmboxMinutos;
        private System.Windows.Forms.ComboBox cmboxHoraComienzo;
        private System.Windows.Forms.DateTimePicker dtimeFecha;
        private System.Windows.Forms.ComboBox cmboxEquipoVisitante;
        private System.Windows.Forms.ComboBox cmboxCompetidorLocal;
        private System.Windows.Forms.ComboBox cmboxDeportes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblHoraComienzo;
        private System.Windows.Forms.Label lblFechaComienzo;
        private System.Windows.Forms.ComboBox cmboxModalidad;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblCompetidorVisitante;
        private System.Windows.Forms.Label lblCompetidorLocal;
        private System.Windows.Forms.TabPage tbpgEliminar;
        private System.Windows.Forms.Panel paneEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIDevento;
        private System.Windows.Forms.Label lblIDevento;
        private System.Windows.Forms.Button btnCerrarI;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCerrarII;
    }
}