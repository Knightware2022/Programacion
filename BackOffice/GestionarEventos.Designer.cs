namespace BackOffice
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
            this.tbpgGestionEventos = new System.Windows.Forms.TabControl();
            this.tbpgAniadir = new System.Windows.Forms.TabPage();
            this.btnCanelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmboxEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.cmboxEquipoLocal = new System.Windows.Forms.ComboBox();
            this.cmboxDeporte = new System.Windows.Forms.ComboBox();
            this.cmboxMinutos = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.cmboxHora = new System.Windows.Forms.ComboBox();
            this.lblHoraComienzo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaComienzo = new System.Windows.Forms.Label();
            this.cmboxModalidad = new System.Windows.Forms.ComboBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblEquipo2 = new System.Windows.Forms.Label();
            this.lblEquipo1 = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.tbpgModificar = new System.Windows.Forms.TabPage();
            this.tbpgEliminar = new System.Windows.Forms.TabPage();
            this.tbpgGestionEventos.SuspendLayout();
            this.tbpgAniadir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpgGestionEventos
            // 
            this.tbpgGestionEventos.Controls.Add(this.tbpgAniadir);
            this.tbpgGestionEventos.Controls.Add(this.tbpgModificar);
            this.tbpgGestionEventos.Controls.Add(this.tbpgEliminar);
            this.tbpgGestionEventos.Location = new System.Drawing.Point(0, 3);
            this.tbpgGestionEventos.Name = "tbpgGestionEventos";
            this.tbpgGestionEventos.SelectedIndex = 0;
            this.tbpgGestionEventos.Size = new System.Drawing.Size(751, 553);
            this.tbpgGestionEventos.TabIndex = 0;
            // 
            // tbpgAniadir
            // 
            this.tbpgAniadir.Controls.Add(this.btnCanelar);
            this.tbpgAniadir.Controls.Add(this.btnAgregar);
            this.tbpgAniadir.Controls.Add(this.cmboxEquipoVisitante);
            this.tbpgAniadir.Controls.Add(this.cmboxEquipoLocal);
            this.tbpgAniadir.Controls.Add(this.cmboxDeporte);
            this.tbpgAniadir.Controls.Add(this.cmboxMinutos);
            this.tbpgAniadir.Controls.Add(this.lblHora);
            this.tbpgAniadir.Controls.Add(this.cmboxHora);
            this.tbpgAniadir.Controls.Add(this.lblHoraComienzo);
            this.tbpgAniadir.Controls.Add(this.dateTimePicker1);
            this.tbpgAniadir.Controls.Add(this.lblFechaComienzo);
            this.tbpgAniadir.Controls.Add(this.cmboxModalidad);
            this.tbpgAniadir.Controls.Add(this.lblModalidad);
            this.tbpgAniadir.Controls.Add(this.lblEquipo2);
            this.tbpgAniadir.Controls.Add(this.lblEquipo1);
            this.tbpgAniadir.Controls.Add(this.lblDeporte);
            this.tbpgAniadir.Location = new System.Drawing.Point(4, 29);
            this.tbpgAniadir.Name = "tbpgAniadir";
            this.tbpgAniadir.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAniadir.Size = new System.Drawing.Size(743, 520);
            this.tbpgAniadir.TabIndex = 0;
            this.tbpgAniadir.Text = "Añadir evento";
            this.tbpgAniadir.UseVisualStyleBackColor = true;
            // 
            // btnCanelar
            // 
            this.btnCanelar.Location = new System.Drawing.Point(418, 464);
            this.btnCanelar.Name = "btnCanelar";
            this.btnCanelar.Size = new System.Drawing.Size(94, 29);
            this.btnCanelar.TabIndex = 15;
            this.btnCanelar.Text = "Cancelar";
            this.btnCanelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(193, 464);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cmboxEquipoVisitante
            // 
            this.cmboxEquipoVisitante.FormattingEnabled = true;
            this.cmboxEquipoVisitante.Location = new System.Drawing.Point(342, 179);
            this.cmboxEquipoVisitante.Name = "cmboxEquipoVisitante";
            this.cmboxEquipoVisitante.Size = new System.Drawing.Size(312, 28);
            this.cmboxEquipoVisitante.TabIndex = 13;
            // 
            // cmboxEquipoLocal
            // 
            this.cmboxEquipoLocal.FormattingEnabled = true;
            this.cmboxEquipoLocal.Location = new System.Drawing.Point(342, 110);
            this.cmboxEquipoLocal.Name = "cmboxEquipoLocal";
            this.cmboxEquipoLocal.Size = new System.Drawing.Size(312, 28);
            this.cmboxEquipoLocal.TabIndex = 12;
            // 
            // cmboxDeporte
            // 
            this.cmboxDeporte.FormattingEnabled = true;
            this.cmboxDeporte.Location = new System.Drawing.Point(342, 33);
            this.cmboxDeporte.Name = "cmboxDeporte";
            this.cmboxDeporte.Size = new System.Drawing.Size(312, 28);
            this.cmboxDeporte.TabIndex = 11;
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
            this.cmboxMinutos.Location = new System.Drawing.Point(461, 383);
            this.cmboxMinutos.Name = "cmboxMinutos";
            this.cmboxMinutos.Size = new System.Drawing.Size(84, 28);
            this.cmboxMinutos.TabIndex = 10;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(432, 391);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(23, 20);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "hs";
            // 
            // cmboxHora
            // 
            this.cmboxHora.FormattingEnabled = true;
            this.cmboxHora.Items.AddRange(new object[] {
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
            this.cmboxHora.Location = new System.Drawing.Point(342, 383);
            this.cmboxHora.Name = "cmboxHora";
            this.cmboxHora.Size = new System.Drawing.Size(84, 28);
            this.cmboxHora.TabIndex = 8;
            // 
            // lblHoraComienzo
            // 
            this.lblHoraComienzo.AutoSize = true;
            this.lblHoraComienzo.Location = new System.Drawing.Point(31, 383);
            this.lblHoraComienzo.Name = "lblHoraComienzo";
            this.lblHoraComienzo.Size = new System.Drawing.Size(118, 20);
            this.lblHoraComienzo.TabIndex = 7;
            this.lblHoraComienzo.Text = "Hora comienzo: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblFechaComienzo
            // 
            this.lblFechaComienzo.AutoSize = true;
            this.lblFechaComienzo.Location = new System.Drawing.Point(31, 318);
            this.lblFechaComienzo.Name = "lblFechaComienzo";
            this.lblFechaComienzo.Size = new System.Drawing.Size(144, 20);
            this.lblFechaComienzo.TabIndex = 5;
            this.lblFechaComienzo.Text = "Fecha de comienzo: ";
            // 
            // cmboxModalidad
            // 
            this.cmboxModalidad.FormattingEnabled = true;
            this.cmboxModalidad.Items.AddRange(new object[] {
            "Amistoso",
            "Por puntos"});
            this.cmboxModalidad.Location = new System.Drawing.Point(342, 254);
            this.cmboxModalidad.Name = "cmboxModalidad";
            this.cmboxModalidad.Size = new System.Drawing.Size(170, 28);
            this.cmboxModalidad.TabIndex = 4;
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(31, 257);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(89, 20);
            this.lblModalidad.TabIndex = 3;
            this.lblModalidad.Text = "Modalidad: ";
            // 
            // lblEquipo2
            // 
            this.lblEquipo2.AutoSize = true;
            this.lblEquipo2.Location = new System.Drawing.Point(31, 187);
            this.lblEquipo2.Name = "lblEquipo2";
            this.lblEquipo2.Size = new System.Drawing.Size(208, 20);
            this.lblEquipo2.TabIndex = 2;
            this.lblEquipo2.Text = "Equipo/Competidor visitante: ";
            // 
            // lblEquipo1
            // 
            this.lblEquipo1.AutoSize = true;
            this.lblEquipo1.Location = new System.Drawing.Point(31, 113);
            this.lblEquipo1.Name = "lblEquipo1";
            this.lblEquipo1.Size = new System.Drawing.Size(185, 20);
            this.lblEquipo1.TabIndex = 1;
            this.lblEquipo1.Text = "Equipo/Competidor local: ";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(31, 36);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(71, 20);
            this.lblDeporte.TabIndex = 0;
            this.lblDeporte.Text = "Deporte: ";
            // 
            // tbpgModificar
            // 
            this.tbpgModificar.Location = new System.Drawing.Point(4, 29);
            this.tbpgModificar.Name = "tbpgModificar";
            this.tbpgModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgModificar.Size = new System.Drawing.Size(743, 520);
            this.tbpgModificar.TabIndex = 1;
            this.tbpgModificar.Text = "Modificar Evento";
            this.tbpgModificar.UseVisualStyleBackColor = true;
            // 
            // tbpgEliminar
            // 
            this.tbpgEliminar.Location = new System.Drawing.Point(4, 29);
            this.tbpgEliminar.Name = "tbpgEliminar";
            this.tbpgEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgEliminar.Size = new System.Drawing.Size(743, 520);
            this.tbpgEliminar.TabIndex = 2;
            this.tbpgEliminar.Text = "Eliminar Evento";
            this.tbpgEliminar.UseVisualStyleBackColor = true;
            // 
            // GestionarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 554);
            this.Controls.Add(this.tbpgGestionEventos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionarEventos";
            this.ShowInTaskbar = false;
            this.Text = "GestionarEventos";
            this.tbpgGestionEventos.ResumeLayout(false);
            this.tbpgAniadir.ResumeLayout(false);
            this.tbpgAniadir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbpgGestionEventos;
        private TabPage tbpgAniadir;
        private TabPage tbpgModificar;
        private TabPage tbpgEliminar;
        private Label lblEquipo2;
        private Label lblEquipo1;
        private Label lblDeporte;
        private ComboBox cmboxModalidad;
        private Label lblModalidad;
        private ComboBox cmboxMinutos;
        private Label lblHora;
        private ComboBox cmboxHora;
        private Label lblHoraComienzo;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaComienzo;
        private ComboBox cmboxDeporte;
        private ComboBox cmboxEquipoVisitante;
        private ComboBox cmboxEquipoLocal;
        private Button btnAgregar;
        private Button btnCanelar;
    }
}