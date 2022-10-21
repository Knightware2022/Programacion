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
            this.tbpgModificar = new System.Windows.Forms.TabPage();
            this.paneBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.paneModificar = new System.Windows.Forms.Panel();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.cmboxMinutos = new System.Windows.Forms.ComboBox();
            this.cmboxHoraComienzo = new System.Windows.Forms.ComboBox();
            this.cmboxEquiposenEncuentro = new System.Windows.Forms.ComboBox();
            this.cmboxEquiposenSistema = new System.Windows.Forms.ComboBox();
            this.cmboxDeportes = new System.Windows.Forms.ComboBox();
            this.lblHoraComienzo = new System.Windows.Forms.Label();
            this.cmboxModalidad = new System.Windows.Forms.ComboBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblEquiposenEncuentro = new System.Windows.Forms.Label();
            this.lblEquiposenSistema = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.dtimeFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaComienzo = new System.Windows.Forms.Label();
            this.paneModificarEvento = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmboxIDEvento = new System.Windows.Forms.ComboBox();
            this.lblIDmodificar = new System.Windows.Forms.Label();
            this.tbcGestionarEventos = new System.Windows.Forms.TabControl();
            this.btnSuspendeEvento = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAlienacion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblJugadorAlineacion = new System.Windows.Forms.Label();
            this.tbpgModificar.SuspendLayout();
            this.paneBotones.SuspendLayout();
            this.paneModificar.SuspendLayout();
            this.paneModificarEvento.SuspendLayout();
            this.tbcGestionarEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpgModificar
            // 
            this.tbpgModificar.Controls.Add(this.paneBotones);
            this.tbpgModificar.Controls.Add(this.paneModificar);
            this.tbpgModificar.Controls.Add(this.paneModificarEvento);
            this.tbpgModificar.Location = new System.Drawing.Point(4, 31);
            this.tbpgModificar.Name = "tbpgModificar";
            this.tbpgModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgModificar.Size = new System.Drawing.Size(766, 727);
            this.tbpgModificar.TabIndex = 1;
            this.tbpgModificar.Text = "Alta, baja y modificación de eventos";
            this.tbpgModificar.UseVisualStyleBackColor = true;
            // 
            // paneBotones
            // 
            this.paneBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBotones.Controls.Add(this.btnSuspendeEvento);
            this.paneBotones.Controls.Add(this.btnEliminar);
            this.paneBotones.Controls.Add(this.btnCerrar);
            this.paneBotones.Controls.Add(this.btnAceptar);
            this.paneBotones.Controls.Add(this.btnCancelar);
            this.paneBotones.Location = new System.Drawing.Point(24, 597);
            this.paneBotones.Name = "paneBotones";
            this.paneBotones.Size = new System.Drawing.Size(718, 111);
            this.paneBotones.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(377, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 43);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(551, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(119, 43);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(37, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 43);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(195, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 43);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // paneModificar
            // 
            this.paneModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneModificar.Controls.Add(this.lblAlienacion);
            this.paneModificar.Controls.Add(this.comboBox1);
            this.paneModificar.Controls.Add(this.comboBox2);
            this.paneModificar.Controls.Add(this.lblJugadorAlineacion);
            this.paneModificar.Controls.Add(this.lblMinutos);
            this.paneModificar.Controls.Add(this.lblHora);
            this.paneModificar.Controls.Add(this.cmboxMinutos);
            this.paneModificar.Controls.Add(this.cmboxHoraComienzo);
            this.paneModificar.Controls.Add(this.cmboxEquiposenEncuentro);
            this.paneModificar.Controls.Add(this.cmboxEquiposenSistema);
            this.paneModificar.Controls.Add(this.cmboxDeportes);
            this.paneModificar.Controls.Add(this.lblHoraComienzo);
            this.paneModificar.Controls.Add(this.cmboxModalidad);
            this.paneModificar.Controls.Add(this.lblModalidad);
            this.paneModificar.Controls.Add(this.lblEquiposenEncuentro);
            this.paneModificar.Controls.Add(this.lblEquiposenSistema);
            this.paneModificar.Controls.Add(this.lblDeporte);
            this.paneModificar.Controls.Add(this.dtimeFecha);
            this.paneModificar.Controls.Add(this.lblFechaComienzo);
            this.paneModificar.Location = new System.Drawing.Point(24, 100);
            this.paneModificar.Name = "paneModificar";
            this.paneModificar.Size = new System.Drawing.Size(718, 491);
            this.paneModificar.TabIndex = 4;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMinutos.Location = new System.Drawing.Point(589, 369);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(66, 22);
            this.lblMinutos.TabIndex = 39;
            this.lblMinutos.Text = "minutos";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblHora.Location = new System.Drawing.Point(434, 369);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(28, 22);
            this.lblHora.TabIndex = 38;
            this.lblHora.Text = "Hs";
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
            this.cmboxMinutos.Location = new System.Drawing.Point(496, 362);
            this.cmboxMinutos.Name = "cmboxMinutos";
            this.cmboxMinutos.Size = new System.Drawing.Size(87, 30);
            this.cmboxMinutos.TabIndex = 37;
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
            this.cmboxHoraComienzo.Location = new System.Drawing.Point(325, 362);
            this.cmboxHoraComienzo.Name = "cmboxHoraComienzo";
            this.cmboxHoraComienzo.Size = new System.Drawing.Size(87, 30);
            this.cmboxHoraComienzo.TabIndex = 36;
            // 
            // cmboxEquiposenEncuentro
            // 
            this.cmboxEquiposenEncuentro.FormattingEnabled = true;
            this.cmboxEquiposenEncuentro.Location = new System.Drawing.Point(326, 108);
            this.cmboxEquiposenEncuentro.Name = "cmboxEquiposenEncuentro";
            this.cmboxEquiposenEncuentro.Size = new System.Drawing.Size(321, 30);
            this.cmboxEquiposenEncuentro.TabIndex = 35;
            // 
            // cmboxEquiposenSistema
            // 
            this.cmboxEquiposenSistema.FormattingEnabled = true;
            this.cmboxEquiposenSistema.Location = new System.Drawing.Point(326, 57);
            this.cmboxEquiposenSistema.Name = "cmboxEquiposenSistema";
            this.cmboxEquiposenSistema.Size = new System.Drawing.Size(321, 30);
            this.cmboxEquiposenSistema.TabIndex = 34;
            // 
            // cmboxDeportes
            // 
            this.cmboxDeportes.FormattingEnabled = true;
            this.cmboxDeportes.Location = new System.Drawing.Point(326, 12);
            this.cmboxDeportes.Name = "cmboxDeportes";
            this.cmboxDeportes.Size = new System.Drawing.Size(321, 30);
            this.cmboxDeportes.TabIndex = 33;
            // 
            // lblHoraComienzo
            // 
            this.lblHoraComienzo.AutoSize = true;
            this.lblHoraComienzo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblHoraComienzo.Location = new System.Drawing.Point(36, 370);
            this.lblHoraComienzo.Name = "lblHoraComienzo";
            this.lblHoraComienzo.Size = new System.Drawing.Size(136, 22);
            this.lblHoraComienzo.TabIndex = 32;
            this.lblHoraComienzo.Text = "Hora de Comienzo";
            // 
            // cmboxModalidad
            // 
            this.cmboxModalidad.FormattingEnabled = true;
            this.cmboxModalidad.Items.AddRange(new object[] {
            "Amistoso",
            "Por puntos"});
            this.cmboxModalidad.Location = new System.Drawing.Point(326, 428);
            this.cmboxModalidad.Name = "cmboxModalidad";
            this.cmboxModalidad.Size = new System.Drawing.Size(319, 30);
            this.cmboxModalidad.TabIndex = 31;
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblModalidad.Location = new System.Drawing.Point(36, 431);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(153, 22);
            this.lblModalidad.TabIndex = 30;
            this.lblModalidad.Text = "Descripcion evento: ";
            // 
            // lblEquiposenEncuentro
            // 
            this.lblEquiposenEncuentro.AutoSize = true;
            this.lblEquiposenEncuentro.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquiposenEncuentro.Location = new System.Drawing.Point(36, 111);
            this.lblEquiposenEncuentro.Name = "lblEquiposenEncuentro";
            this.lblEquiposenEncuentro.Size = new System.Drawing.Size(188, 22);
            this.lblEquiposenEncuentro.TabIndex = 29;
            this.lblEquiposenEncuentro.Text = "Equipos en el encuentro: ";
            // 
            // lblEquiposenSistema
            // 
            this.lblEquiposenSistema.AutoSize = true;
            this.lblEquiposenSistema.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquiposenSistema.Location = new System.Drawing.Point(36, 60);
            this.lblEquiposenSistema.Name = "lblEquiposenSistema";
            this.lblEquiposenSistema.Size = new System.Drawing.Size(170, 22);
            this.lblEquiposenSistema.TabIndex = 28;
            this.lblEquiposenSistema.Text = "Equipos en el sistema: ";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDeporte.Location = new System.Drawing.Point(36, 15);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(74, 22);
            this.lblDeporte.TabIndex = 27;
            this.lblDeporte.Text = "Deporte: ";
            // 
            // dtimeFecha
            // 
            this.dtimeFecha.Location = new System.Drawing.Point(326, 292);
            this.dtimeFecha.Name = "dtimeFecha";
            this.dtimeFecha.Size = new System.Drawing.Size(321, 27);
            this.dtimeFecha.TabIndex = 26;
            // 
            // lblFechaComienzo
            // 
            this.lblFechaComienzo.AutoSize = true;
            this.lblFechaComienzo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFechaComienzo.Location = new System.Drawing.Point(36, 297);
            this.lblFechaComienzo.Name = "lblFechaComienzo";
            this.lblFechaComienzo.Size = new System.Drawing.Size(145, 22);
            this.lblFechaComienzo.TabIndex = 25;
            this.lblFechaComienzo.Text = "Fecha de Comienzo";
            // 
            // paneModificarEvento
            // 
            this.paneModificarEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneModificarEvento.Controls.Add(this.btnBuscar);
            this.paneModificarEvento.Controls.Add(this.cmboxIDEvento);
            this.paneModificarEvento.Controls.Add(this.lblIDmodificar);
            this.paneModificarEvento.Location = new System.Drawing.Point(24, 17);
            this.paneModificarEvento.Name = "paneModificarEvento";
            this.paneModificarEvento.Size = new System.Drawing.Size(718, 77);
            this.paneModificarEvento.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(195, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmboxIDEvento
            // 
            this.cmboxIDEvento.FormattingEnabled = true;
            this.cmboxIDEvento.Location = new System.Drawing.Point(288, 12);
            this.cmboxIDEvento.Name = "cmboxIDEvento";
            this.cmboxIDEvento.Size = new System.Drawing.Size(335, 30);
            this.cmboxIDEvento.TabIndex = 1;
            // 
            // lblIDmodificar
            // 
            this.lblIDmodificar.AutoSize = true;
            this.lblIDmodificar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIDmodificar.Location = new System.Drawing.Point(36, 15);
            this.lblIDmodificar.Name = "lblIDmodificar";
            this.lblIDmodificar.Size = new System.Drawing.Size(165, 22);
            this.lblIDmodificar.TabIndex = 0;
            this.lblIDmodificar.Text = "ID evento a modificar: ";
            // 
            // tbcGestionarEventos
            // 
            this.tbcGestionarEventos.Controls.Add(this.tbpgModificar);
            this.tbcGestionarEventos.Controls.Add(this.tabPage1);
            this.tbcGestionarEventos.Controls.Add(this.tabPage2);
            this.tbcGestionarEventos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbcGestionarEventos.Location = new System.Drawing.Point(0, 4);
            this.tbcGestionarEventos.Name = "tbcGestionarEventos";
            this.tbcGestionarEventos.SelectedIndex = 0;
            this.tbcGestionarEventos.Size = new System.Drawing.Size(774, 762);
            this.tbcGestionarEventos.TabIndex = 0;
            // 
            // btnSuspendeEvento
            // 
            this.btnSuspendeEvento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSuspendeEvento.Location = new System.Drawing.Point(263, 63);
            this.btnSuspendeEvento.Name = "btnSuspendeEvento";
            this.btnSuspendeEvento.Size = new System.Drawing.Size(186, 43);
            this.btnSuspendeEvento.TabIndex = 20;
            this.btnSuspendeEvento.Text = "Suspender Evento";
            this.btnSuspendeEvento.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 727);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Modificacion Evento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 727);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAlienacion
            // 
            this.lblAlienacion.AutoSize = true;
            this.lblAlienacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblAlienacion.Location = new System.Drawing.Point(36, 230);
            this.lblAlienacion.Name = "lblAlienacion";
            this.lblAlienacion.Size = new System.Drawing.Size(83, 22);
            this.lblAlienacion.TabIndex = 44;
            this.lblAlienacion.Text = "Alineacion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(326, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 30);
            this.comboBox1.TabIndex = 42;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(326, 165);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(322, 30);
            this.comboBox2.TabIndex = 41;
            // 
            // lblJugadorAlineacion
            // 
            this.lblJugadorAlineacion.AutoSize = true;
            this.lblJugadorAlineacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblJugadorAlineacion.Location = new System.Drawing.Point(36, 168);
            this.lblJugadorAlineacion.Name = "lblJugadorAlineacion";
            this.lblJugadorAlineacion.Size = new System.Drawing.Size(77, 22);
            this.lblJugadorAlineacion.TabIndex = 40;
            this.lblJugadorAlineacion.Text = "Jugador: ";
            // 
            // GestionarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 769);
            this.Controls.Add(this.tbcGestionarEventos);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarEventos";
            this.Text = "GestionarEventos";
            this.tbpgModificar.ResumeLayout(false);
            this.paneBotones.ResumeLayout(false);
            this.paneModificar.ResumeLayout(false);
            this.paneModificar.PerformLayout();
            this.paneModificarEvento.ResumeLayout(false);
            this.paneModificarEvento.PerformLayout();
            this.tbcGestionarEventos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpgModificar;
        private System.Windows.Forms.Panel paneBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel paneModificar;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmboxMinutos;
        private System.Windows.Forms.ComboBox cmboxHoraComienzo;
        private System.Windows.Forms.ComboBox cmboxEquiposenEncuentro;
        private System.Windows.Forms.ComboBox cmboxEquiposenSistema;
        private System.Windows.Forms.ComboBox cmboxDeportes;
        private System.Windows.Forms.Label lblHoraComienzo;
        private System.Windows.Forms.ComboBox cmboxModalidad;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblEquiposenEncuentro;
        private System.Windows.Forms.Label lblEquiposenSistema;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.DateTimePicker dtimeFecha;
        private System.Windows.Forms.Label lblFechaComienzo;
        private System.Windows.Forms.Panel paneModificarEvento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmboxIDEvento;
        private System.Windows.Forms.Label lblIDmodificar;
        private System.Windows.Forms.TabControl tbcGestionarEventos;
        private System.Windows.Forms.Button btnSuspendeEvento;
        private System.Windows.Forms.Label lblAlienacion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblJugadorAlineacion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}