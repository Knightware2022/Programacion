namespace BackOfficeAdministracion
{
    partial class Alineacion
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
            this.paneAlineacion = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmboxEquipo = new System.Windows.Forms.ComboBox();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.cmboxJugador = new System.Windows.Forms.ComboBox();
            this.cmboxAlineacion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstboxAlineacion = new System.Windows.Forms.ListBox();
            this.paneAlineacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneAlineacion
            // 
            this.paneAlineacion.BackColor = System.Drawing.Color.LightGray;
            this.paneAlineacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneAlineacion.Controls.Add(this.lstboxAlineacion);
            this.paneAlineacion.Controls.Add(this.button1);
            this.paneAlineacion.Controls.Add(this.cmboxAlineacion);
            this.paneAlineacion.Controls.Add(this.btnVolver);
            this.paneAlineacion.Controls.Add(this.btnAceptar);
            this.paneAlineacion.Controls.Add(this.cmboxJugador);
            this.paneAlineacion.Controls.Add(this.cmboxEquipo);
            this.paneAlineacion.Controls.Add(this.lblIncidencia);
            this.paneAlineacion.Controls.Add(this.lblJugador);
            this.paneAlineacion.Controls.Add(this.lblEquipo);
            this.paneAlineacion.Location = new System.Drawing.Point(0, 0);
            this.paneAlineacion.Name = "paneAlineacion";
            this.paneAlineacion.Size = new System.Drawing.Size(528, 371);
            this.paneAlineacion.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(19, 257);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 28);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(19, 167);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 28);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cmboxEquipo
            // 
            this.cmboxEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxEquipo.FormattingEnabled = true;
            this.cmboxEquipo.Location = new System.Drawing.Point(169, 10);
            this.cmboxEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquipo.Name = "cmboxEquipo";
            this.cmboxEquipo.Size = new System.Drawing.Size(195, 25);
            this.cmboxEquipo.TabIndex = 16;
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIncidencia.Location = new System.Drawing.Point(16, 90);
            this.lblIncidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(115, 17);
            this.lblIncidencia.TabIndex = 14;
            this.lblIncidencia.Text = "Alineación-Posición";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblJugador.Location = new System.Drawing.Point(16, 51);
            this.lblJugador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(59, 17);
            this.lblJugador.TabIndex = 13;
            this.lblJugador.Text = "Jugador: ";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquipo.Location = new System.Drawing.Point(16, 13);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(53, 17);
            this.lblEquipo.TabIndex = 12;
            this.lblEquipo.Text = "Equipo: ";
            // 
            // cmboxJugador
            // 
            this.cmboxJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxJugador.FormattingEnabled = true;
            this.cmboxJugador.Location = new System.Drawing.Point(170, 48);
            this.cmboxJugador.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxJugador.Name = "cmboxJugador";
            this.cmboxJugador.Size = new System.Drawing.Size(195, 25);
            this.cmboxJugador.TabIndex = 17;
            // 
            // cmboxAlineacion
            // 
            this.cmboxAlineacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxAlineacion.FormattingEnabled = true;
            this.cmboxAlineacion.Location = new System.Drawing.Point(169, 87);
            this.cmboxAlineacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxAlineacion.Name = "cmboxAlineacion";
            this.cmboxAlineacion.Size = new System.Drawing.Size(195, 25);
            this.cmboxAlineacion.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(19, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ver alineación";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstboxAlineacion
            // 
            this.lstboxAlineacion.FormattingEnabled = true;
            this.lstboxAlineacion.Location = new System.Drawing.Point(170, 125);
            this.lstboxAlineacion.Name = "lstboxAlineacion";
            this.lstboxAlineacion.Size = new System.Drawing.Size(353, 238);
            this.lstboxAlineacion.TabIndex = 24;
            // 
            // Alineacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 373);
            this.Controls.Add(this.paneAlineacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alineacion";
            this.Text = "Alineacion";
            this.Load += new System.EventHandler(this.Alineacion_Load);
            this.paneAlineacion.ResumeLayout(false);
            this.paneAlineacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneAlineacion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmboxEquipo;
        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox cmboxAlineacion;
        private System.Windows.Forms.ComboBox cmboxJugador;
        private System.Windows.Forms.ListBox lstboxAlineacion;
        private System.Windows.Forms.Button button1;
    }
}