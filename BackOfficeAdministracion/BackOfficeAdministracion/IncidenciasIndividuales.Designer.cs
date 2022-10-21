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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.cmboxIncidencia = new System.Windows.Forms.ComboBox();
            this.cmboxJugador = new System.Windows.Forms.ComboBox();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            this.txtSet = new System.Windows.Forms.TextBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.paneIncidencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneIncidencias
            // 
            this.paneIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIncidencias.Controls.Add(this.txtPosicion);
            this.paneIncidencias.Controls.Add(this.txtPuntos);
            this.paneIncidencias.Controls.Add(this.lblPosicion);
            this.paneIncidencias.Controls.Add(this.lblPuntos);
            this.paneIncidencias.Controls.Add(this.txtSet);
            this.paneIncidencias.Controls.Add(this.lblSet);
            this.paneIncidencias.Controls.Add(this.btnVolver);
            this.paneIncidencias.Controls.Add(this.btnAceptar);
            this.paneIncidencias.Controls.Add(this.txtMinuto);
            this.paneIncidencias.Controls.Add(this.cmboxIncidencia);
            this.paneIncidencias.Controls.Add(this.cmboxJugador);
            this.paneIncidencias.Controls.Add(this.lblMinuto);
            this.paneIncidencias.Controls.Add(this.lblIncidencia);
            this.paneIncidencias.Controls.Add(this.lblParticipante);
            this.paneIncidencias.Location = new System.Drawing.Point(12, 12);
            this.paneIncidencias.Name = "paneIncidencias";
            this.paneIncidencias.Size = new System.Drawing.Size(479, 404);
            this.paneIncidencias.TabIndex = 1;
            this.paneIncidencias.Paint += new System.Windows.Forms.PaintEventHandler(this.paneIncidencias_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(270, 334);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 34);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(66, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 36);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtMinuto
            // 
            this.txtMinuto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMinuto.Location = new System.Drawing.Point(173, 129);
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(258, 27);
            this.txtMinuto.TabIndex = 8;
            // 
            // cmboxIncidencia
            // 
            this.cmboxIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxIncidencia.FormattingEnabled = true;
            this.cmboxIncidencia.Location = new System.Drawing.Point(173, 72);
            this.cmboxIncidencia.Name = "cmboxIncidencia";
            this.cmboxIncidencia.Size = new System.Drawing.Size(258, 30);
            this.cmboxIncidencia.TabIndex = 7;
            // 
            // cmboxJugador
            // 
            this.cmboxJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxJugador.FormattingEnabled = true;
            this.cmboxJugador.Location = new System.Drawing.Point(172, 30);
            this.cmboxJugador.Name = "cmboxJugador";
            this.cmboxJugador.Size = new System.Drawing.Size(259, 30);
            this.cmboxJugador.TabIndex = 6;
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMinuto.Location = new System.Drawing.Point(25, 126);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(68, 22);
            this.lblMinuto.TabIndex = 4;
            this.lblMinuto.Text = "Minuto: ";
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIncidencia.Location = new System.Drawing.Point(23, 80);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(125, 22);
            this.lblIncidencia.TabIndex = 3;
            this.lblIncidencia.Text = "Tipo incidencia: ";
            // 
            // lblParticipante
            // 
            this.lblParticipante.AutoSize = true;
            this.lblParticipante.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblParticipante.Location = new System.Drawing.Point(23, 33);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Size = new System.Drawing.Size(102, 22);
            this.lblParticipante.TabIndex = 2;
            this.lblParticipante.Text = "Participante: ";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSet.Location = new System.Drawing.Point(23, 172);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(37, 22);
            this.lblSet.TabIndex = 12;
            this.lblSet.Text = "Set:";
            // 
            // txtSet
            // 
            this.txtSet.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtSet.Location = new System.Drawing.Point(172, 172);
            this.txtSet.Name = "txtSet";
            this.txtSet.Size = new System.Drawing.Size(258, 27);
            this.txtSet.TabIndex = 13;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPuntos.Location = new System.Drawing.Point(23, 221);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(68, 22);
            this.lblPuntos.TabIndex = 14;
            this.lblPuntos.Text = "Puntos: ";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPosicion.Location = new System.Drawing.Point(25, 271);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(79, 22);
            this.lblPosicion.TabIndex = 15;
            this.lblPosicion.Text = "Posicion: ";
            // 
            // txtPuntos
            // 
            this.txtPuntos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPuntos.Location = new System.Drawing.Point(173, 221);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(258, 27);
            this.txtPuntos.TabIndex = 16;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPosicion.Location = new System.Drawing.Point(172, 271);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(258, 27);
            this.txtPosicion.TabIndex = 17;
            // 
            // IncidenciasIndividuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 426);
            this.Controls.Add(this.paneIncidencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncidenciasIndividuales";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.IncidenciasIndividuales_Load);
            this.paneIncidencias.ResumeLayout(false);
            this.paneIncidencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneIncidencias;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.TextBox txtSet;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtMinuto;
        private System.Windows.Forms.ComboBox cmboxIncidencia;
        private System.Windows.Forms.ComboBox cmboxJugador;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.Label lblParticipante;
    }
}