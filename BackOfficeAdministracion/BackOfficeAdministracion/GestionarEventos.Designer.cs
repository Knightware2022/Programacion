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
            this.btnCrearEventoColectivo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.paneDatosEvento = new System.Windows.Forms.Panel();
            this.btnQuitarEncuentroCole = new System.Windows.Forms.Button();
            this.btnAgregarAlEncuentroCole = new System.Windows.Forms.Button();
            this.lblMinutoFinCole = new System.Windows.Forms.Label();
            this.lblHoraFinalizaColec = new System.Windows.Forms.Label();
            this.cmboxMinutoFinCole = new System.Windows.Forms.ComboBox();
            this.cmboxHoraFinCole = new System.Windows.Forms.ComboBox();
            this.lblFinalizaColectivo = new System.Windows.Forms.Label();
            this.btnAlineacion = new System.Windows.Forms.Button();
            this.txtIDencuentroCole = new System.Windows.Forms.TextBox();
            this.txtDescripcionCole = new System.Windows.Forms.TextBox();
            this.lblIDEncuentroCole = new System.Windows.Forms.Label();
            this.dtimeFechaFinaliza = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinalizaCole = new System.Windows.Forms.Label();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.lblMinutosComienza = new System.Windows.Forms.Label();
            this.lblHoraComienza = new System.Windows.Forms.Label();
            this.cmboxMinutos = new System.Windows.Forms.ComboBox();
            this.cmboxHoraComienzo = new System.Windows.Forms.ComboBox();
            this.cmboxEquiposenEncuentro = new System.Windows.Forms.ComboBox();
            this.cmboxEquiposenSistema = new System.Windows.Forms.ComboBox();
            this.cmboxDeportes = new System.Windows.Forms.ComboBox();
            this.lblHoraComienzo = new System.Windows.Forms.Label();
            this.lblDescripcionColect = new System.Windows.Forms.Label();
            this.lblEquiposenEncuentro = new System.Windows.Forms.Label();
            this.lblEquiposenSistema = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.dtimeFechaComienza = new System.Windows.Forms.DateTimePicker();
            this.lblFechaComienzo = new System.Windows.Forms.Label();
            this.paneModificarEvento = new System.Windows.Forms.Panel();
            this.btnRefrescarEncuentroColectivo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmboxIDEvento = new System.Windows.Forms.ComboBox();
            this.lblIDmodificar = new System.Windows.Forms.Label();
            this.tbcGestionarEventos = new System.Windows.Forms.TabControl();
            this.paneEquipos = new System.Windows.Forms.Panel();
            this.tbpgModificar.SuspendLayout();
            this.paneBotones.SuspendLayout();
            this.paneDatosEvento.SuspendLayout();
            this.paneModificarEvento.SuspendLayout();
            this.tbcGestionarEventos.SuspendLayout();
            this.paneEquipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpgModificar
            // 
            this.tbpgModificar.Controls.Add(this.paneBotones);
            this.tbpgModificar.Controls.Add(this.paneDatosEvento);
            this.tbpgModificar.Controls.Add(this.paneModificarEvento);
            this.tbpgModificar.Location = new System.Drawing.Point(4, 26);
            this.tbpgModificar.Margin = new System.Windows.Forms.Padding(2);
            this.tbpgModificar.Name = "tbpgModificar";
            this.tbpgModificar.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgModificar.Size = new System.Drawing.Size(572, 589);
            this.tbpgModificar.TabIndex = 1;
            this.tbpgModificar.Text = "A/B/M eventos";
            this.tbpgModificar.UseVisualStyleBackColor = true;
            // 
            // paneBotones
            // 
            this.paneBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBotones.Controls.Add(this.btnCrearEventoColectivo);
            this.paneBotones.Controls.Add(this.btnEliminar);
            this.paneBotones.Controls.Add(this.btnCerrar);
            this.paneBotones.Controls.Add(this.btnAceptar);
            this.paneBotones.Controls.Add(this.btnCancelar);
            this.paneBotones.Location = new System.Drawing.Point(18, 464);
            this.paneBotones.Margin = new System.Windows.Forms.Padding(2);
            this.paneBotones.Name = "paneBotones";
            this.paneBotones.Size = new System.Drawing.Size(539, 112);
            this.paneBotones.TabIndex = 5;
            // 
            // btnCrearEventoColectivo
            // 
            this.btnCrearEventoColectivo.Enabled = false;
            this.btnCrearEventoColectivo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCrearEventoColectivo.Location = new System.Drawing.Point(178, 63);
            this.btnCrearEventoColectivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearEventoColectivo.Name = "btnCrearEventoColectivo";
            this.btnCrearEventoColectivo.Size = new System.Drawing.Size(160, 35);
            this.btnCrearEventoColectivo.TabIndex = 21;
            this.btnCrearEventoColectivo.Text = "Crear Evento";
            this.btnCrearEventoColectivo.UseVisualStyleBackColor = true;
            this.btnCrearEventoColectivo.Click += new System.EventHandler(this.btnCrearEventoColectivo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(283, 15);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(413, 15);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(26, 15);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 35);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(146, 15);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 35);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // paneDatosEvento
            // 
            this.paneDatosEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneDatosEvento.Controls.Add(this.paneEquipos);
            this.paneDatosEvento.Controls.Add(this.lblMinutoFinCole);
            this.paneDatosEvento.Controls.Add(this.lblHoraFinalizaColec);
            this.paneDatosEvento.Controls.Add(this.cmboxMinutoFinCole);
            this.paneDatosEvento.Controls.Add(this.cmboxHoraFinCole);
            this.paneDatosEvento.Controls.Add(this.lblFinalizaColectivo);
            this.paneDatosEvento.Controls.Add(this.btnAlineacion);
            this.paneDatosEvento.Controls.Add(this.txtIDencuentroCole);
            this.paneDatosEvento.Controls.Add(this.txtDescripcionCole);
            this.paneDatosEvento.Controls.Add(this.lblIDEncuentroCole);
            this.paneDatosEvento.Controls.Add(this.dtimeFechaFinaliza);
            this.paneDatosEvento.Controls.Add(this.lblFechaFinalizaCole);
            this.paneDatosEvento.Controls.Add(this.btnIncidencias);
            this.paneDatosEvento.Controls.Add(this.lblMinutosComienza);
            this.paneDatosEvento.Controls.Add(this.lblHoraComienza);
            this.paneDatosEvento.Controls.Add(this.cmboxMinutos);
            this.paneDatosEvento.Controls.Add(this.cmboxHoraComienzo);
            this.paneDatosEvento.Controls.Add(this.cmboxDeportes);
            this.paneDatosEvento.Controls.Add(this.lblHoraComienzo);
            this.paneDatosEvento.Controls.Add(this.lblDescripcionColect);
            this.paneDatosEvento.Controls.Add(this.lblDeporte);
            this.paneDatosEvento.Controls.Add(this.dtimeFechaComienza);
            this.paneDatosEvento.Controls.Add(this.lblFechaComienzo);
            this.paneDatosEvento.Enabled = false;
            this.paneDatosEvento.Location = new System.Drawing.Point(18, 90);
            this.paneDatosEvento.Margin = new System.Windows.Forms.Padding(2);
            this.paneDatosEvento.Name = "paneDatosEvento";
            this.paneDatosEvento.Size = new System.Drawing.Size(539, 370);
            this.paneDatosEvento.TabIndex = 4;
            // 
            // btnQuitarEncuentroCole
            // 
            this.btnQuitarEncuentroCole.Location = new System.Drawing.Point(476, 52);
            this.btnQuitarEncuentroCole.Name = "btnQuitarEncuentroCole";
            this.btnQuitarEncuentroCole.Size = new System.Drawing.Size(38, 23);
            this.btnQuitarEncuentroCole.TabIndex = 55;
            this.btnQuitarEncuentroCole.Text = "-";
            this.btnQuitarEncuentroCole.UseVisualStyleBackColor = true;
            this.btnQuitarEncuentroCole.Click += new System.EventHandler(this.btnQuitarEncuentroCole_Click);
            // 
            // btnAgregarAlEncuentroCole
            // 
            this.btnAgregarAlEncuentroCole.Location = new System.Drawing.Point(476, 11);
            this.btnAgregarAlEncuentroCole.Name = "btnAgregarAlEncuentroCole";
            this.btnAgregarAlEncuentroCole.Size = new System.Drawing.Size(38, 23);
            this.btnAgregarAlEncuentroCole.TabIndex = 54;
            this.btnAgregarAlEncuentroCole.Text = "+";
            this.btnAgregarAlEncuentroCole.UseVisualStyleBackColor = true;
            this.btnAgregarAlEncuentroCole.Click += new System.EventHandler(this.btnAgregarAlEncuentroCole_Click);
            // 
            // lblMinutoFinCole
            // 
            this.lblMinutoFinCole.AutoSize = true;
            this.lblMinutoFinCole.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMinutoFinCole.Location = new System.Drawing.Point(444, 271);
            this.lblMinutoFinCole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutoFinCole.Name = "lblMinutoFinCole";
            this.lblMinutoFinCole.Size = new System.Drawing.Size(51, 17);
            this.lblMinutoFinCole.TabIndex = 53;
            this.lblMinutoFinCole.Text = "minutos";
            // 
            // lblHoraFinalizaColec
            // 
            this.lblHoraFinalizaColec.AutoSize = true;
            this.lblHoraFinalizaColec.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblHoraFinalizaColec.Location = new System.Drawing.Point(317, 271);
            this.lblHoraFinalizaColec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraFinalizaColec.Name = "lblHoraFinalizaColec";
            this.lblHoraFinalizaColec.Size = new System.Drawing.Size(22, 17);
            this.lblHoraFinalizaColec.TabIndex = 52;
            this.lblHoraFinalizaColec.Text = "Hs";
            // 
            // cmboxMinutoFinCole
            // 
            this.cmboxMinutoFinCole.FormattingEnabled = true;
            this.cmboxMinutoFinCole.Items.AddRange(new object[] {
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
            this.cmboxMinutoFinCole.Location = new System.Drawing.Point(374, 268);
            this.cmboxMinutoFinCole.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxMinutoFinCole.Name = "cmboxMinutoFinCole";
            this.cmboxMinutoFinCole.Size = new System.Drawing.Size(66, 25);
            this.cmboxMinutoFinCole.TabIndex = 51;
            this.cmboxMinutoFinCole.Text = "00";
            // 
            // cmboxHoraFinCole
            // 
            this.cmboxHoraFinCole.FormattingEnabled = true;
            this.cmboxHoraFinCole.Items.AddRange(new object[] {
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
            this.cmboxHoraFinCole.Location = new System.Drawing.Point(247, 271);
            this.cmboxHoraFinCole.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxHoraFinCole.Name = "cmboxHoraFinCole";
            this.cmboxHoraFinCole.Size = new System.Drawing.Size(66, 25);
            this.cmboxHoraFinCole.TabIndex = 50;
            this.cmboxHoraFinCole.Text = "00";
            // 
            // lblFinalizaColectivo
            // 
            this.lblFinalizaColectivo.AutoSize = true;
            this.lblFinalizaColectivo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFinalizaColectivo.Location = new System.Drawing.Point(32, 271);
            this.lblFinalizaColectivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinalizaColectivo.Name = "lblFinalizaColectivo";
            this.lblFinalizaColectivo.Size = new System.Drawing.Size(116, 17);
            this.lblFinalizaColectivo.TabIndex = 49;
            this.lblFinalizaColectivo.Text = "Hora de Finalizacion";
            // 
            // btnAlineacion
            // 
            this.btnAlineacion.Enabled = false;
            this.btnAlineacion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAlineacion.Location = new System.Drawing.Point(282, 334);
            this.btnAlineacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlineacion.Name = "btnAlineacion";
            this.btnAlineacion.Size = new System.Drawing.Size(122, 35);
            this.btnAlineacion.TabIndex = 48;
            this.btnAlineacion.Text = "Alineación";
            this.btnAlineacion.UseVisualStyleBackColor = true;
            this.btnAlineacion.Click += new System.EventHandler(this.btnAlineacion_Click);
            // 
            // txtIDencuentroCole
            // 
            this.txtIDencuentroCole.Enabled = false;
            this.txtIDencuentroCole.Location = new System.Drawing.Point(249, 16);
            this.txtIDencuentroCole.Name = "txtIDencuentroCole";
            this.txtIDencuentroCole.Size = new System.Drawing.Size(242, 23);
            this.txtIDencuentroCole.TabIndex = 47;
            // 
            // txtDescripcionCole
            // 
            this.txtDescripcionCole.Location = new System.Drawing.Point(247, 305);
            this.txtDescripcionCole.Name = "txtDescripcionCole";
            this.txtDescripcionCole.Size = new System.Drawing.Size(242, 23);
            this.txtDescripcionCole.TabIndex = 46;
            // 
            // lblIDEncuentroCole
            // 
            this.lblIDEncuentroCole.AutoSize = true;
            this.lblIDEncuentroCole.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIDEncuentroCole.Location = new System.Drawing.Point(32, 19);
            this.lblIDEncuentroCole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDEncuentroCole.Name = "lblIDEncuentroCole";
            this.lblIDEncuentroCole.Size = new System.Drawing.Size(83, 17);
            this.lblIDEncuentroCole.TabIndex = 45;
            this.lblIDEncuentroCole.Text = "ID encuentro: ";
            // 
            // dtimeFechaFinaliza
            // 
            this.dtimeFechaFinaliza.Location = new System.Drawing.Point(249, 241);
            this.dtimeFechaFinaliza.Margin = new System.Windows.Forms.Padding(2);
            this.dtimeFechaFinaliza.Name = "dtimeFechaFinaliza";
            this.dtimeFechaFinaliza.Size = new System.Drawing.Size(242, 23);
            this.dtimeFechaFinaliza.TabIndex = 44;
            // 
            // lblFechaFinalizaCole
            // 
            this.lblFechaFinalizaCole.AutoSize = true;
            this.lblFechaFinalizaCole.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFechaFinalizaCole.Location = new System.Drawing.Point(34, 241);
            this.lblFechaFinalizaCole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFinalizaCole.Name = "lblFechaFinalizaCole";
            this.lblFechaFinalizaCole.Size = new System.Drawing.Size(97, 17);
            this.lblFechaFinalizaCole.TabIndex = 43;
            this.lblFechaFinalizaCole.Text = "Fecha de finaliza";
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.Enabled = false;
            this.btnIncidencias.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnIncidencias.Location = new System.Drawing.Point(123, 334);
            this.btnIncidencias.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(122, 35);
            this.btnIncidencias.TabIndex = 40;
            this.btnIncidencias.Text = "Incidencias";
            this.btnIncidencias.UseVisualStyleBackColor = true;
            this.btnIncidencias.Click += new System.EventHandler(this.btnIncidencias_Click);
            // 
            // lblMinutosComienza
            // 
            this.lblMinutosComienza.AutoSize = true;
            this.lblMinutosComienza.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMinutosComienza.Location = new System.Drawing.Point(444, 206);
            this.lblMinutosComienza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutosComienza.Name = "lblMinutosComienza";
            this.lblMinutosComienza.Size = new System.Drawing.Size(51, 17);
            this.lblMinutosComienza.TabIndex = 39;
            this.lblMinutosComienza.Text = "minutos";
            // 
            // lblHoraComienza
            // 
            this.lblHoraComienza.AutoSize = true;
            this.lblHoraComienza.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblHoraComienza.Location = new System.Drawing.Point(317, 206);
            this.lblHoraComienza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraComienza.Name = "lblHoraComienza";
            this.lblHoraComienza.Size = new System.Drawing.Size(22, 17);
            this.lblHoraComienza.TabIndex = 38;
            this.lblHoraComienza.Text = "Hs";
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
            this.cmboxMinutos.Location = new System.Drawing.Point(374, 203);
            this.cmboxMinutos.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxMinutos.Name = "cmboxMinutos";
            this.cmboxMinutos.Size = new System.Drawing.Size(66, 25);
            this.cmboxMinutos.TabIndex = 37;
            this.cmboxMinutos.Text = "00";
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
            this.cmboxHoraComienzo.Location = new System.Drawing.Point(247, 203);
            this.cmboxHoraComienzo.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxHoraComienzo.Name = "cmboxHoraComienzo";
            this.cmboxHoraComienzo.Size = new System.Drawing.Size(66, 25);
            this.cmboxHoraComienzo.TabIndex = 36;
            this.cmboxHoraComienzo.Text = "00";
            // 
            // cmboxEquiposenEncuentro
            // 
            this.cmboxEquiposenEncuentro.FormattingEnabled = true;
            this.cmboxEquiposenEncuentro.Location = new System.Drawing.Point(229, 50);
            this.cmboxEquiposenEncuentro.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquiposenEncuentro.Name = "cmboxEquiposenEncuentro";
            this.cmboxEquiposenEncuentro.Size = new System.Drawing.Size(242, 25);
            this.cmboxEquiposenEncuentro.TabIndex = 35;
            // 
            // cmboxEquiposenSistema
            // 
            this.cmboxEquiposenSistema.FormattingEnabled = true;
            this.cmboxEquiposenSistema.Location = new System.Drawing.Point(229, 8);
            this.cmboxEquiposenSistema.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquiposenSistema.Name = "cmboxEquiposenSistema";
            this.cmboxEquiposenSistema.Size = new System.Drawing.Size(242, 25);
            this.cmboxEquiposenSistema.TabIndex = 34;
            // 
            // cmboxDeportes
            // 
            this.cmboxDeportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxDeportes.FormattingEnabled = true;
            this.cmboxDeportes.Location = new System.Drawing.Point(249, 46);
            this.cmboxDeportes.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxDeportes.Name = "cmboxDeportes";
            this.cmboxDeportes.Size = new System.Drawing.Size(242, 25);
            this.cmboxDeportes.TabIndex = 33;
            // 
            // lblHoraComienzo
            // 
            this.lblHoraComienzo.AutoSize = true;
            this.lblHoraComienzo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblHoraComienzo.Location = new System.Drawing.Point(32, 206);
            this.lblHoraComienzo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraComienzo.Name = "lblHoraComienzo";
            this.lblHoraComienzo.Size = new System.Drawing.Size(106, 17);
            this.lblHoraComienzo.TabIndex = 32;
            this.lblHoraComienzo.Text = "Hora de Comienzo";
            // 
            // lblDescripcionColect
            // 
            this.lblDescripcionColect.AutoSize = true;
            this.lblDescripcionColect.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionColect.Location = new System.Drawing.Point(32, 305);
            this.lblDescripcionColect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionColect.Name = "lblDescripcionColect";
            this.lblDescripcionColect.Size = new System.Drawing.Size(161, 17);
            this.lblDescripcionColect.TabIndex = 30;
            this.lblDescripcionColect.Text = "Descripcion-nombre evento: ";
            // 
            // lblEquiposenEncuentro
            // 
            this.lblEquiposenEncuentro.AutoSize = true;
            this.lblEquiposenEncuentro.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquiposenEncuentro.Location = new System.Drawing.Point(12, 52);
            this.lblEquiposenEncuentro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquiposenEncuentro.Name = "lblEquiposenEncuentro";
            this.lblEquiposenEncuentro.Size = new System.Drawing.Size(144, 17);
            this.lblEquiposenEncuentro.TabIndex = 29;
            this.lblEquiposenEncuentro.Text = "Equipos en el encuentro: ";
            // 
            // lblEquiposenSistema
            // 
            this.lblEquiposenSistema.AutoSize = true;
            this.lblEquiposenSistema.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquiposenSistema.Location = new System.Drawing.Point(12, 11);
            this.lblEquiposenSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquiposenSistema.Name = "lblEquiposenSistema";
            this.lblEquiposenSistema.Size = new System.Drawing.Size(130, 17);
            this.lblEquiposenSistema.TabIndex = 28;
            this.lblEquiposenSistema.Text = "Equipos en el sistema: ";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDeporte.Location = new System.Drawing.Point(32, 48);
            this.lblDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(57, 17);
            this.lblDeporte.TabIndex = 27;
            this.lblDeporte.Text = "Deporte: ";
            // 
            // dtimeFechaComienza
            // 
            this.dtimeFechaComienza.Location = new System.Drawing.Point(249, 161);
            this.dtimeFechaComienza.Margin = new System.Windows.Forms.Padding(2);
            this.dtimeFechaComienza.Name = "dtimeFechaComienza";
            this.dtimeFechaComienza.Size = new System.Drawing.Size(242, 23);
            this.dtimeFechaComienza.TabIndex = 26;
            // 
            // lblFechaComienzo
            // 
            this.lblFechaComienzo.AutoSize = true;
            this.lblFechaComienzo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFechaComienzo.Location = new System.Drawing.Point(32, 166);
            this.lblFechaComienzo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaComienzo.Name = "lblFechaComienzo";
            this.lblFechaComienzo.Size = new System.Drawing.Size(113, 17);
            this.lblFechaComienzo.TabIndex = 25;
            this.lblFechaComienzo.Text = "Fecha de Comienzo";
            // 
            // paneModificarEvento
            // 
            this.paneModificarEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneModificarEvento.Controls.Add(this.btnRefrescarEncuentroColectivo);
            this.paneModificarEvento.Controls.Add(this.btnBuscar);
            this.paneModificarEvento.Controls.Add(this.cmboxIDEvento);
            this.paneModificarEvento.Controls.Add(this.lblIDmodificar);
            this.paneModificarEvento.Location = new System.Drawing.Point(18, 14);
            this.paneModificarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.paneModificarEvento.Name = "paneModificarEvento";
            this.paneModificarEvento.Size = new System.Drawing.Size(539, 72);
            this.paneModificarEvento.TabIndex = 3;
            // 
            // btnRefrescarEncuentroColectivo
            // 
            this.btnRefrescarEncuentroColectivo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescarEncuentroColectivo.Location = new System.Drawing.Point(294, 43);
            this.btnRefrescarEncuentroColectivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescarEncuentroColectivo.Name = "btnRefrescarEncuentroColectivo";
            this.btnRefrescarEncuentroColectivo.Size = new System.Drawing.Size(110, 25);
            this.btnRefrescarEncuentroColectivo.TabIndex = 3;
            this.btnRefrescarEncuentroColectivo.Text = "Refrescar";
            this.btnRefrescarEncuentroColectivo.UseVisualStyleBackColor = true;
            this.btnRefrescarEncuentroColectivo.Click += new System.EventHandler(this.btnRefrescarEncuentroColectivo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(126, 43);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmboxIDEvento
            // 
            this.cmboxIDEvento.FormattingEnabled = true;
            this.cmboxIDEvento.Location = new System.Drawing.Point(216, 10);
            this.cmboxIDEvento.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxIDEvento.Name = "cmboxIDEvento";
            this.cmboxIDEvento.Size = new System.Drawing.Size(252, 25);
            this.cmboxIDEvento.TabIndex = 1;
            // 
            // lblIDmodificar
            // 
            this.lblIDmodificar.AutoSize = true;
            this.lblIDmodificar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIDmodificar.Location = new System.Drawing.Point(27, 12);
            this.lblIDmodificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDmodificar.Name = "lblIDmodificar";
            this.lblIDmodificar.Size = new System.Drawing.Size(113, 17);
            this.lblIDmodificar.TabIndex = 0;
            this.lblIDmodificar.Text = "Evento a modificar: ";
            // 
            // tbcGestionarEventos
            // 
            this.tbcGestionarEventos.Controls.Add(this.tbpgModificar);
            this.tbcGestionarEventos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbcGestionarEventos.Location = new System.Drawing.Point(0, 3);
            this.tbcGestionarEventos.Margin = new System.Windows.Forms.Padding(2);
            this.tbcGestionarEventos.Name = "tbcGestionarEventos";
            this.tbcGestionarEventos.SelectedIndex = 0;
            this.tbcGestionarEventos.Size = new System.Drawing.Size(580, 619);
            this.tbcGestionarEventos.TabIndex = 0;
            // 
            // paneEquipos
            // 
            this.paneEquipos.Controls.Add(this.lblEquiposenSistema);
            this.paneEquipos.Controls.Add(this.btnQuitarEncuentroCole);
            this.paneEquipos.Controls.Add(this.lblEquiposenEncuentro);
            this.paneEquipos.Controls.Add(this.btnAgregarAlEncuentroCole);
            this.paneEquipos.Controls.Add(this.cmboxEquiposenSistema);
            this.paneEquipos.Controls.Add(this.cmboxEquiposenEncuentro);
            this.paneEquipos.Location = new System.Drawing.Point(10, 75);
            this.paneEquipos.Name = "paneEquipos";
            this.paneEquipos.Size = new System.Drawing.Size(528, 81);
            this.paneEquipos.TabIndex = 56;
            // 
            // GestionarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 625);
            this.Controls.Add(this.tbcGestionarEventos);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionarEventos";
            this.Text = "GestionarEventos";
            this.Load += new System.EventHandler(this.GestionarEventos_Load);
            this.tbpgModificar.ResumeLayout(false);
            this.paneBotones.ResumeLayout(false);
            this.paneDatosEvento.ResumeLayout(false);
            this.paneDatosEvento.PerformLayout();
            this.paneModificarEvento.ResumeLayout(false);
            this.paneModificarEvento.PerformLayout();
            this.tbcGestionarEventos.ResumeLayout(false);
            this.paneEquipos.ResumeLayout(false);
            this.paneEquipos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpgModificar;
        private System.Windows.Forms.Panel paneBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel paneDatosEvento;
        private System.Windows.Forms.Label lblMinutosComienza;
        private System.Windows.Forms.Label lblHoraComienza;
        private System.Windows.Forms.ComboBox cmboxMinutos;
        private System.Windows.Forms.ComboBox cmboxHoraComienzo;
        private System.Windows.Forms.ComboBox cmboxEquiposenEncuentro;
        private System.Windows.Forms.ComboBox cmboxEquiposenSistema;
        private System.Windows.Forms.ComboBox cmboxDeportes;
        private System.Windows.Forms.Label lblHoraComienzo;
        private System.Windows.Forms.Label lblDescripcionColect;
        private System.Windows.Forms.Label lblEquiposenEncuentro;
        private System.Windows.Forms.Label lblEquiposenSistema;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.DateTimePicker dtimeFechaComienza;
        private System.Windows.Forms.Label lblFechaComienzo;
        private System.Windows.Forms.Panel paneModificarEvento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmboxIDEvento;
        private System.Windows.Forms.Label lblIDmodificar;
        private System.Windows.Forms.TabControl tbcGestionarEventos;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.DateTimePicker dtimeFechaFinaliza;
        private System.Windows.Forms.Label lblFechaFinalizaCole;
        private System.Windows.Forms.TextBox txtIDencuentroCole;
        private System.Windows.Forms.TextBox txtDescripcionCole;
        private System.Windows.Forms.Label lblIDEncuentroCole;
        private System.Windows.Forms.Button btnAlineacion;
        private System.Windows.Forms.Button btnCrearEventoColectivo;
        private System.Windows.Forms.Button btnRefrescarEncuentroColectivo;
        private System.Windows.Forms.Label lblMinutoFinCole;
        private System.Windows.Forms.Label lblHoraFinalizaColec;
        private System.Windows.Forms.ComboBox cmboxMinutoFinCole;
        private System.Windows.Forms.ComboBox cmboxHoraFinCole;
        private System.Windows.Forms.Label lblFinalizaColectivo;
        private System.Windows.Forms.Button btnQuitarEncuentroCole;
        private System.Windows.Forms.Button btnAgregarAlEncuentroCole;
        private System.Windows.Forms.Panel paneEquipos;
    }
}