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
            this.paneIncidencias.SuspendLayout();
            this.gboxModoPuntuacion.SuspendLayout();
            this.panePuntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneIncidencias
            // 
            this.paneIncidencias.BackColor = System.Drawing.Color.LightGray;
            this.paneIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.paneIncidencias.Size = new System.Drawing.Size(552, 282);
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
            this.btnRefrescar.Location = new System.Drawing.Point(334, 228);
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
            this.btnVolver.Location = new System.Drawing.Point(236, 228);
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
            this.btnAceptar.Location = new System.Drawing.Point(137, 227);
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
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(553, 279);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneIncidencias;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.TextBox txtMinuto;
        private System.Windows.Forms.ComboBox cmboxIncidencia;
        private System.Windows.Forms.ComboBox cmboxJugador;
        private System.Windows.Forms.ComboBox cmboxEquipo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panePuntos;
        private System.Windows.Forms.GroupBox gboxModoPuntuacion;
        private System.Windows.Forms.RadioButton rbSets;
        private System.Windows.Forms.RadioButton rbPuntos;
        private System.Windows.Forms.RadioButton rbRanking;
    }
}