namespace BackOfficeAdministracion
{
    partial class IncidenciasIndividuales
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmboxIncidencia = new System.Windows.Forms.ComboBox();
            this.cmboxJugador = new System.Windows.Forms.ComboBox();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.gboxModoPuntuacion = new System.Windows.Forms.GroupBox();
            this.rbRanking = new System.Windows.Forms.RadioButton();
            this.rbSets = new System.Windows.Forms.RadioButton();
            this.rbPuntos = new System.Windows.Forms.RadioButton();
            this.paneRanking = new System.Windows.Forms.Panel();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempoTranscurrido = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.paneParticular = new System.Windows.Forms.Panel();
            this.txtPuntosGanados = new System.Windows.Forms.TextBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblSetsGanados = new System.Windows.Forms.Label();
            this.txtSetsGanados = new System.Windows.Forms.TextBox();
            this.panePuntos = new System.Windows.Forms.Panel();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.paneIncidencias.SuspendLayout();
            this.gboxModoPuntuacion.SuspendLayout();
            this.paneRanking.SuspendLayout();
            this.paneParticular.SuspendLayout();
            this.panePuntos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneIncidencias
            // 
            this.paneIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIncidencias.Controls.Add(this.panePuntos);
            this.paneIncidencias.Controls.Add(this.paneParticular);
            this.paneIncidencias.Controls.Add(this.paneRanking);
            this.paneIncidencias.Controls.Add(this.gboxModoPuntuacion);
            this.paneIncidencias.Controls.Add(this.btnRefrescar);
            this.paneIncidencias.Controls.Add(this.btnVolver);
            this.paneIncidencias.Controls.Add(this.btnAceptar);
            this.paneIncidencias.Controls.Add(this.cmboxIncidencia);
            this.paneIncidencias.Controls.Add(this.cmboxJugador);
            this.paneIncidencias.Controls.Add(this.lblIncidencia);
            this.paneIncidencias.Controls.Add(this.lblParticipante);
            this.paneIncidencias.Location = new System.Drawing.Point(9, 10);
            this.paneIncidencias.Margin = new System.Windows.Forms.Padding(2);
            this.paneIncidencias.Name = "paneIncidencias";
            this.paneIncidencias.Size = new System.Drawing.Size(530, 327);
            this.paneIncidencias.TabIndex = 1;
            this.paneIncidencias.Paint += new System.Windows.Forms.PaintEventHandler(this.paneIncidencias_Paint);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(326, 274);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(83, 28);
            this.btnRefrescar.TabIndex = 18;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(216, 275);
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
            this.btnAceptar.Location = new System.Drawing.Point(116, 274);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 29);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmboxIncidencia
            // 
            this.cmboxIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxIncidencia.FormattingEnabled = true;
            this.cmboxIncidencia.Location = new System.Drawing.Point(130, 58);
            this.cmboxIncidencia.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxIncidencia.Name = "cmboxIncidencia";
            this.cmboxIncidencia.Size = new System.Drawing.Size(194, 25);
            this.cmboxIncidencia.TabIndex = 7;
            // 
            // cmboxJugador
            // 
            this.cmboxJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxJugador.FormattingEnabled = true;
            this.cmboxJugador.Location = new System.Drawing.Point(129, 24);
            this.cmboxJugador.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxJugador.Name = "cmboxJugador";
            this.cmboxJugador.Size = new System.Drawing.Size(195, 25);
            this.cmboxJugador.TabIndex = 6;
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIncidencia.Location = new System.Drawing.Point(17, 65);
            this.lblIncidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(96, 17);
            this.lblIncidencia.TabIndex = 3;
            this.lblIncidencia.Text = "Tipo incidencia: ";
            // 
            // lblParticipante
            // 
            this.lblParticipante.AutoSize = true;
            this.lblParticipante.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblParticipante.Location = new System.Drawing.Point(17, 27);
            this.lblParticipante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Size = new System.Drawing.Size(78, 17);
            this.lblParticipante.TabIndex = 2;
            this.lblParticipante.Text = "Participante: ";
            // 
            // gboxModoPuntuacion
            // 
            this.gboxModoPuntuacion.Controls.Add(this.rbRanking);
            this.gboxModoPuntuacion.Controls.Add(this.rbSets);
            this.gboxModoPuntuacion.Controls.Add(this.rbPuntos);
            this.gboxModoPuntuacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.gboxModoPuntuacion.Location = new System.Drawing.Point(348, 27);
            this.gboxModoPuntuacion.Name = "gboxModoPuntuacion";
            this.gboxModoPuntuacion.Size = new System.Drawing.Size(158, 103);
            this.gboxModoPuntuacion.TabIndex = 19;
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
            // paneRanking
            // 
            this.paneRanking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneRanking.Controls.Add(this.lblSegundos);
            this.paneRanking.Controls.Add(this.txtSegundos);
            this.paneRanking.Controls.Add(this.label2);
            this.paneRanking.Controls.Add(this.lblHoras);
            this.paneRanking.Controls.Add(this.txtMinutos);
            this.paneRanking.Controls.Add(this.txtPuntuacion);
            this.paneRanking.Controls.Add(this.label1);
            this.paneRanking.Controls.Add(this.txtTiempoTranscurrido);
            this.paneRanking.Controls.Add(this.txtHoras);
            this.paneRanking.Location = new System.Drawing.Point(20, 124);
            this.paneRanking.Name = "paneRanking";
            this.paneRanking.Size = new System.Drawing.Size(448, 108);
            this.paneRanking.TabIndex = 20;
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSegundos.Location = new System.Drawing.Point(413, 31);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(16, 17);
            this.lblSegundos.TabIndex = 15;
            this.lblSegundos.Text = "S";
            // 
            // txtSegundos
            // 
            this.txtSegundos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtSegundos.Location = new System.Drawing.Point(353, 21);
            this.txtSegundos.Margin = new System.Windows.Forms.Padding(2);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(55, 23);
            this.txtSegundos.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(320, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "M";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblHoras.Location = new System.Drawing.Point(240, 31);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(16, 17);
            this.lblHoras.TabIndex = 12;
            this.lblHoras.Text = "H";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMinutos.Location = new System.Drawing.Point(260, 21);
            this.txtMinutos.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(55, 23);
            this.txtMinutos.TabIndex = 11;
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPuntuacion.Location = new System.Drawing.Point(180, 57);
            this.txtPuntuacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(194, 23);
            this.txtPuntuacion.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Puntuacion: ";
            // 
            // txtTiempoTranscurrido
            // 
            this.txtTiempoTranscurrido.AutoSize = true;
            this.txtTiempoTranscurrido.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTiempoTranscurrido.Location = new System.Drawing.Point(17, 24);
            this.txtTiempoTranscurrido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTiempoTranscurrido.Name = "txtTiempoTranscurrido";
            this.txtTiempoTranscurrido.Size = new System.Drawing.Size(119, 17);
            this.txtTiempoTranscurrido.TabIndex = 4;
            this.txtTiempoTranscurrido.Text = "Tiempo transcurrido:";
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtHoras.Location = new System.Drawing.Point(180, 21);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(55, 23);
            this.txtHoras.TabIndex = 8;
            // 
            // paneParticular
            // 
            this.paneParticular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneParticular.Controls.Add(this.txtPuntosGanados);
            this.paneParticular.Controls.Add(this.lblPuntos);
            this.paneParticular.Controls.Add(this.lblSetsGanados);
            this.paneParticular.Controls.Add(this.txtSetsGanados);
            this.paneParticular.Location = new System.Drawing.Point(20, 124);
            this.paneParticular.Name = "paneParticular";
            this.paneParticular.Size = new System.Drawing.Size(341, 126);
            this.paneParticular.TabIndex = 21;
            // 
            // txtPuntosGanados
            // 
            this.txtPuntosGanados.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPuntosGanados.Location = new System.Drawing.Point(121, 57);
            this.txtPuntosGanados.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuntosGanados.Name = "txtPuntosGanados";
            this.txtPuntosGanados.Size = new System.Drawing.Size(194, 23);
            this.txtPuntosGanados.TabIndex = 10;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPuntos.Location = new System.Drawing.Point(25, 60);
            this.lblPuntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(46, 17);
            this.lblPuntos.TabIndex = 9;
            this.lblPuntos.Text = "Puntos";
            // 
            // lblSetsGanados
            // 
            this.lblSetsGanados.AutoSize = true;
            this.lblSetsGanados.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSetsGanados.Location = new System.Drawing.Point(25, 24);
            this.lblSetsGanados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetsGanados.Name = "lblSetsGanados";
            this.lblSetsGanados.Size = new System.Drawing.Size(85, 17);
            this.lblSetsGanados.TabIndex = 4;
            this.lblSetsGanados.Text = "Sets ganados:";
            // 
            // txtSetsGanados
            // 
            this.txtSetsGanados.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtSetsGanados.Location = new System.Drawing.Point(121, 18);
            this.txtSetsGanados.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetsGanados.Name = "txtSetsGanados";
            this.txtSetsGanados.Size = new System.Drawing.Size(194, 23);
            this.txtSetsGanados.TabIndex = 8;
            // 
            // panePuntos
            // 
            this.panePuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panePuntos.Controls.Add(this.lblMinuto);
            this.panePuntos.Controls.Add(this.txtMinuto);
            this.panePuntos.Location = new System.Drawing.Point(20, 124);
            this.panePuntos.Name = "panePuntos";
            this.panePuntos.Size = new System.Drawing.Size(337, 58);
            this.panePuntos.TabIndex = 22;
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
            // IncidenciasIndividuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(548, 347);
            this.Controls.Add(this.paneIncidencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IncidenciasIndividuales";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.IncidenciasIndividuales_Load);
            this.paneIncidencias.ResumeLayout(false);
            this.paneIncidencias.PerformLayout();
            this.gboxModoPuntuacion.ResumeLayout(false);
            this.gboxModoPuntuacion.PerformLayout();
            this.paneRanking.ResumeLayout(false);
            this.paneRanking.PerformLayout();
            this.paneParticular.ResumeLayout(false);
            this.paneParticular.PerformLayout();
            this.panePuntos.ResumeLayout(false);
            this.panePuntos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneIncidencias;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmboxIncidencia;
        private System.Windows.Forms.ComboBox cmboxJugador;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.GroupBox gboxModoPuntuacion;
        private System.Windows.Forms.RadioButton rbRanking;
        private System.Windows.Forms.RadioButton rbSets;
        private System.Windows.Forms.RadioButton rbPuntos;
        private System.Windows.Forms.Panel paneRanking;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTiempoTranscurrido;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Panel paneParticular;
        private System.Windows.Forms.TextBox txtPuntosGanados;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblSetsGanados;
        private System.Windows.Forms.TextBox txtSetsGanados;
        private System.Windows.Forms.Panel panePuntos;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.TextBox txtMinuto;
    }
}