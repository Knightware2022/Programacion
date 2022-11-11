namespace BackOfficeAdministracion
{
    partial class Incidencias
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
            this.paneIncidencias = new System.Windows.Forms.Panel();
            this.gboxModoPuntuacion = new System.Windows.Forms.GroupBox();
            this.rbRanking = new System.Windows.Forms.RadioButton();
            this.rbSets = new System.Windows.Forms.RadioButton();
            this.rbPuntos = new System.Windows.Forms.RadioButton();
            this.panePuntos = new System.Windows.Forms.Panel();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmboxIncidencia = new System.Windows.Forms.ComboBox();
            this.cmboxJugador = new System.Windows.Forms.ComboBox();
            this.cmboxEquipo = new System.Windows.Forms.ComboBox();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.panePuntuacion = new System.Windows.Forms.Panel();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.paneIncidencias.SuspendLayout();
            this.gboxModoPuntuacion.SuspendLayout();
            this.panePuntos.SuspendLayout();
            this.panePuntuacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneIncidencias
            // 
            this.paneIncidencias.BackColor = System.Drawing.Color.LightGray;
            this.paneIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIncidencias.Controls.Add(this.panePuntuacion);
            this.paneIncidencias.Controls.Add(this.gboxModoPuntuacion);
            this.paneIncidencias.Controls.Add(this.panePuntos);
            this.paneIncidencias.Controls.Add(this.btnRefrescar);
            this.paneIncidencias.Controls.Add(this.btnVolver);
            this.paneIncidencias.Controls.Add(this.btnAceptar);
            this.paneIncidencias.Controls.Add(this.cmboxIncidencia);
            this.paneIncidencias.Controls.Add(this.cmboxJugador);
            this.paneIncidencias.Controls.Add(this.cmboxEquipo);
            this.paneIncidencias.Controls.Add(this.lblIncidencia);
            this.paneIncidencias.Controls.Add(this.lblJugador);
            this.paneIncidencias.Controls.Add(this.lblEquipo);
            this.paneIncidencias.Location = new System.Drawing.Point(1, 0);
            this.paneIncidencias.Margin = new System.Windows.Forms.Padding(2);
            this.paneIncidencias.Name = "paneIncidencias";
            this.paneIncidencias.Size = new System.Drawing.Size(552, 369);
            this.paneIncidencias.TabIndex = 0;
            // 
            // gboxModoPuntuacion
            // 
            this.gboxModoPuntuacion.Controls.Add(this.rbRanking);
            this.gboxModoPuntuacion.Controls.Add(this.rbSets);
            this.gboxModoPuntuacion.Controls.Add(this.rbPuntos);
            this.gboxModoPuntuacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.gboxModoPuntuacion.Location = new System.Drawing.Point(381, 31);
            this.gboxModoPuntuacion.Name = "gboxModoPuntuacion";
            this.gboxModoPuntuacion.Size = new System.Drawing.Size(158, 103);
            this.gboxModoPuntuacion.TabIndex = 16;
            this.gboxModoPuntuacion.TabStop = false;
            this.gboxModoPuntuacion.Text = "Sistema de puntuacion: ";
            // 
            // rbRanking
            // 
            this.rbRanking.AutoSize = true;
            this.rbRanking.Location = new System.Drawing.Point(21, 71);
            this.rbRanking.Name = "rbRanking";
            this.rbRanking.Size = new System.Drawing.Size(70, 21);
            this.rbRanking.TabIndex = 2;
            this.rbRanking.TabStop = true;
            this.rbRanking.Text = "Ranking";
            this.rbRanking.UseVisualStyleBackColor = true;
            this.rbRanking.CheckedChanged += new System.EventHandler(this.rbRanking_CheckedChanged);
            // 
            // rbSets
            // 
            this.rbSets.AutoSize = true;
            this.rbSets.Location = new System.Drawing.Point(21, 48);
            this.rbSets.Name = "rbSets";
            this.rbSets.Size = new System.Drawing.Size(50, 21);
            this.rbSets.TabIndex = 1;
            this.rbSets.TabStop = true;
            this.rbSets.Text = "Sets";
            this.rbSets.UseVisualStyleBackColor = true;
            this.rbSets.CheckedChanged += new System.EventHandler(this.rbSets_CheckedChanged);
            // 
            // rbPuntos
            // 
            this.rbPuntos.AutoSize = true;
            this.rbPuntos.Location = new System.Drawing.Point(21, 24);
            this.rbPuntos.Name = "rbPuntos";
            this.rbPuntos.Size = new System.Drawing.Size(64, 21);
            this.rbPuntos.TabIndex = 0;
            this.rbPuntos.TabStop = true;
            this.rbPuntos.Text = "Puntos";
            this.rbPuntos.UseVisualStyleBackColor = true;
            this.rbPuntos.CheckedChanged += new System.EventHandler(this.rbPuntos_CheckedChanged);
            // 
            // panePuntos
            // 
            this.panePuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panePuntos.Controls.Add(this.lblMinuto);
            this.panePuntos.Controls.Add(this.txtMinuto);
            this.panePuntos.Location = new System.Drawing.Point(30, 140);
            this.panePuntos.Name = "panePuntos";
            this.panePuntos.Size = new System.Drawing.Size(337, 58);
            this.panePuntos.TabIndex = 14;
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMinuto.Location = new System.Drawing.Point(21, 21);
            this.lblMinuto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(53, 17);
            this.lblMinuto.TabIndex = 4;
            this.lblMinuto.Text = "Minuto: ";
            // 
            // txtMinuto
            // 
            this.txtMinuto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMinuto.Location = new System.Drawing.Point(121, 18);
            this.txtMinuto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(194, 23);
            this.txtMinuto.TabIndex = 8;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(329, 309);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(97, 28);
            this.btnRefrescar.TabIndex = 12;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(231, 309);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 28);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(132, 308);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 29);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmboxIncidencia
            // 
            this.cmboxIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxIncidencia.FormattingEnabled = true;
            this.cmboxIncidencia.Location = new System.Drawing.Point(140, 98);
            this.cmboxIncidencia.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxIncidencia.Name = "cmboxIncidencia";
            this.cmboxIncidencia.Size = new System.Drawing.Size(227, 25);
            this.cmboxIncidencia.TabIndex = 7;
            this.cmboxIncidencia.SelectedIndexChanged += new System.EventHandler(this.cmboxIncidencia_SelectedIndexChanged);
            // 
            // cmboxJugador
            // 
            this.cmboxJugador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxJugador.FormattingEnabled = true;
            this.cmboxJugador.Location = new System.Drawing.Point(139, 64);
            this.cmboxJugador.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxJugador.Name = "cmboxJugador";
            this.cmboxJugador.Size = new System.Drawing.Size(228, 25);
            this.cmboxJugador.TabIndex = 6;
            // 
            // cmboxEquipo
            // 
            this.cmboxEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxEquipo.FormattingEnabled = true;
            this.cmboxEquipo.Location = new System.Drawing.Point(139, 31);
            this.cmboxEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquipo.Name = "cmboxEquipo";
            this.cmboxEquipo.Size = new System.Drawing.Size(228, 25);
            this.cmboxEquipo.TabIndex = 5;
            this.cmboxEquipo.SelectedIndexChanged += new System.EventHandler(this.cmboxEquipo_SelectedIndexChanged);
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIncidencia.Location = new System.Drawing.Point(27, 105);
            this.lblIncidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(96, 17);
            this.lblIncidencia.TabIndex = 3;
            this.lblIncidencia.Text = "Tipo incidencia: ";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblJugador.Location = new System.Drawing.Point(27, 67);
            this.lblJugador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(59, 17);
            this.lblJugador.TabIndex = 2;
            this.lblJugador.Text = "Jugador: ";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquipo.Location = new System.Drawing.Point(27, 31);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(53, 17);
            this.lblEquipo.TabIndex = 0;
            this.lblEquipo.Text = "Equipo: ";
            // 
            // panePuntuacion
            // 
            this.panePuntuacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panePuntuacion.Controls.Add(this.lblPuntos);
            this.panePuntuacion.Controls.Add(this.txtPuntos);
            this.panePuntuacion.Location = new System.Drawing.Point(30, 225);
            this.panePuntuacion.Name = "panePuntuacion";
            this.panePuntuacion.Size = new System.Drawing.Size(337, 58);
            this.panePuntuacion.TabIndex = 17;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPuntos.Location = new System.Drawing.Point(21, 21);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(46, 17);
            this.lblPuntos.TabIndex = 4;
            this.lblPuntos.Text = "Puntos";
            // 
            // txtPuntos
            // 
            this.txtPuntos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPuntos.Location = new System.Drawing.Point(121, 18);
            this.txtPuntos.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(194, 23);
            this.txtPuntos.TabIndex = 8;
            this.txtPuntos.Text = "0";
            // 
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(553, 380);
            this.Controls.Add(this.paneIncidencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Incidencias";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.Incidencias_Load);
            this.paneIncidencias.ResumeLayout(false);
            this.paneIncidencias.PerformLayout();
            this.gboxModoPuntuacion.ResumeLayout(false);
            this.gboxModoPuntuacion.PerformLayout();
            this.panePuntos.ResumeLayout(false);
            this.panePuntos.PerformLayout();
            this.panePuntuacion.ResumeLayout(false);
            this.panePuntuacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel paneIncidencias;
        public System.Windows.Forms.Label lblJugador;
        public System.Windows.Forms.Label lblEquipo;
        public System.Windows.Forms.Label lblMinuto;
        public System.Windows.Forms.Label lblIncidencia;
        public System.Windows.Forms.TextBox txtMinuto;
        public System.Windows.Forms.ComboBox cmboxIncidencia;
        public System.Windows.Forms.ComboBox cmboxJugador;
        public System.Windows.Forms.ComboBox cmboxEquipo;
        public System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnRefrescar;
        public System.Windows.Forms.Panel panePuntos;
        public System.Windows.Forms.GroupBox gboxModoPuntuacion;
        public System.Windows.Forms.RadioButton rbSets;
        public System.Windows.Forms.RadioButton rbPuntos;
        public System.Windows.Forms.RadioButton rbRanking;
        public System.Windows.Forms.Panel panePuntuacion;
        public System.Windows.Forms.Label lblPuntos;
        public System.Windows.Forms.TextBox txtPuntos;
    }
}