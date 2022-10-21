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
            this.lblEquipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.cmboxEquipo = new System.Windows.Forms.ComboBox();
            this.cmboxJugador = new System.Windows.Forms.ComboBox();
            this.cmboxIncidencia = new System.Windows.Forms.ComboBox();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.paneIncidencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneIncidencias
            // 
            this.paneIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIncidencias.Controls.Add(this.btnVolver);
            this.paneIncidencias.Controls.Add(this.btnAceptar);
            this.paneIncidencias.Controls.Add(this.txtMinuto);
            this.paneIncidencias.Controls.Add(this.cmboxIncidencia);
            this.paneIncidencias.Controls.Add(this.cmboxJugador);
            this.paneIncidencias.Controls.Add(this.cmboxEquipo);
            this.paneIncidencias.Controls.Add(this.lblMinuto);
            this.paneIncidencias.Controls.Add(this.lblIncidencia);
            this.paneIncidencias.Controls.Add(this.label1);
            this.paneIncidencias.Controls.Add(this.lblEquipo);
            this.paneIncidencias.Location = new System.Drawing.Point(12, 12);
            this.paneIncidencias.Name = "paneIncidencias";
            this.paneIncidencias.Size = new System.Drawing.Size(498, 301);
            this.paneIncidencias.TabIndex = 0;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquipo.Location = new System.Drawing.Point(36, 38);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(68, 22);
            this.lblEquipo.TabIndex = 0;
            this.lblEquipo.Text = "Equipo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jugador: ";
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIncidencia.Location = new System.Drawing.Point(36, 129);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(125, 22);
            this.lblIncidencia.TabIndex = 3;
            this.lblIncidencia.Text = "Tipo incidencia: ";
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMinuto.Location = new System.Drawing.Point(38, 175);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(68, 22);
            this.lblMinuto.TabIndex = 4;
            this.lblMinuto.Text = "Minuto: ";
            // 
            // cmboxEquipo
            // 
            this.cmboxEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxEquipo.FormattingEnabled = true;
            this.cmboxEquipo.Location = new System.Drawing.Point(185, 38);
            this.cmboxEquipo.Name = "cmboxEquipo";
            this.cmboxEquipo.Size = new System.Drawing.Size(259, 30);
            this.cmboxEquipo.TabIndex = 5;
            // 
            // cmboxJugador
            // 
            this.cmboxJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxJugador.FormattingEnabled = true;
            this.cmboxJugador.Location = new System.Drawing.Point(185, 79);
            this.cmboxJugador.Name = "cmboxJugador";
            this.cmboxJugador.Size = new System.Drawing.Size(259, 30);
            this.cmboxJugador.TabIndex = 6;
            // 
            // cmboxIncidencia
            // 
            this.cmboxIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxIncidencia.FormattingEnabled = true;
            this.cmboxIncidencia.Location = new System.Drawing.Point(186, 121);
            this.cmboxIncidencia.Name = "cmboxIncidencia";
            this.cmboxIncidencia.Size = new System.Drawing.Size(258, 30);
            this.cmboxIncidencia.TabIndex = 7;
            // 
            // txtMinuto
            // 
            this.txtMinuto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMinuto.Location = new System.Drawing.Point(186, 178);
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(258, 27);
            this.txtMinuto.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(75, 224);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 36);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(283, 225);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 34);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 325);
            this.Controls.Add(this.paneIncidencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Incidencias";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.Incidencias_Load);
            this.paneIncidencias.ResumeLayout(false);
            this.paneIncidencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneIncidencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.TextBox txtMinuto;
        private System.Windows.Forms.ComboBox cmboxIncidencia;
        private System.Windows.Forms.ComboBox cmboxJugador;
        private System.Windows.Forms.ComboBox cmboxEquipo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
    }
}