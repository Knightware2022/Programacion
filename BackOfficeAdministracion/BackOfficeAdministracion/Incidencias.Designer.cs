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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.cmboxIncidencia = new System.Windows.Forms.ComboBox();
            this.cmboxJugador = new System.Windows.Forms.ComboBox();
            this.cmboxEquipo = new System.Windows.Forms.ComboBox();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.paneIncidencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneIncidencias
            // 
            this.paneIncidencias.BackColor = System.Drawing.Color.LightGray;
            this.paneIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIncidencias.Controls.Add(this.btnRefrescar);
            this.paneIncidencias.Controls.Add(this.btnVolver);
            this.paneIncidencias.Controls.Add(this.btnAceptar);
            this.paneIncidencias.Controls.Add(this.txtMinuto);
            this.paneIncidencias.Controls.Add(this.cmboxIncidencia);
            this.paneIncidencias.Controls.Add(this.cmboxJugador);
            this.paneIncidencias.Controls.Add(this.cmboxEquipo);
            this.paneIncidencias.Controls.Add(this.lblMinuto);
            this.paneIncidencias.Controls.Add(this.lblIncidencia);
            this.paneIncidencias.Controls.Add(this.lblJugador);
            this.paneIncidencias.Controls.Add(this.lblEquipo);
            this.paneIncidencias.Location = new System.Drawing.Point(15, 10);
            this.paneIncidencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneIncidencias.Name = "paneIncidencias";
            this.paneIncidencias.Size = new System.Drawing.Size(498, 301);
            this.paneIncidencias.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(316, 225);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(129, 34);
            this.btnRefrescar.TabIndex = 12;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(185, 225);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnAceptar.Location = new System.Drawing.Point(53, 224);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 36);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtMinuto
            // 
            this.txtMinuto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMinuto.Location = new System.Drawing.Point(187, 178);
            this.txtMinuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(257, 27);
            this.txtMinuto.TabIndex = 8;
            // 
            // cmboxIncidencia
            // 
            this.cmboxIncidencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxIncidencia.FormattingEnabled = true;
            this.cmboxIncidencia.Location = new System.Drawing.Point(187, 121);
            this.cmboxIncidencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxIncidencia.Name = "cmboxIncidencia";
            this.cmboxIncidencia.Size = new System.Drawing.Size(257, 30);
            this.cmboxIncidencia.TabIndex = 7;
            this.cmboxIncidencia.SelectedIndexChanged += new System.EventHandler(this.cmboxIncidencia_SelectedIndexChanged);
            // 
            // cmboxJugador
            // 
            this.cmboxJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxJugador.FormattingEnabled = true;
            this.cmboxJugador.Location = new System.Drawing.Point(185, 79);
            this.cmboxJugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxJugador.Name = "cmboxJugador";
            this.cmboxJugador.Size = new System.Drawing.Size(259, 30);
            this.cmboxJugador.TabIndex = 6;
            // 
            // cmboxEquipo
            // 
            this.cmboxEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxEquipo.FormattingEnabled = true;
            this.cmboxEquipo.Location = new System.Drawing.Point(185, 38);
            this.cmboxEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxEquipo.Name = "cmboxEquipo";
            this.cmboxEquipo.Size = new System.Drawing.Size(259, 30);
            this.cmboxEquipo.TabIndex = 5;
            this.cmboxEquipo.SelectedIndexChanged += new System.EventHandler(this.cmboxEquipo_SelectedIndexChanged);
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMinuto.Location = new System.Drawing.Point(37, 175);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(68, 22);
            this.lblMinuto.TabIndex = 4;
            this.lblMinuto.Text = "Minuto: ";
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
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblJugador.Location = new System.Drawing.Point(36, 82);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(77, 22);
            this.lblJugador.TabIndex = 2;
            this.lblJugador.Text = "Jugador: ";
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
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(520, 325);
            this.Controls.Add(this.paneIncidencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Incidencias";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.Incidencias_Load);
            this.paneIncidencias.ResumeLayout(false);
            this.paneIncidencias.PerformLayout();
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
    }
}