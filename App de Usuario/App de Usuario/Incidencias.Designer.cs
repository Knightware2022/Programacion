namespace App_de_Usuario
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
            this.paneAlineacion = new System.Windows.Forms.Panel();
            this.pcboxLogo = new System.Windows.Forms.PictureBox();
            this.lstviewIncidencias = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Minuto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ocurrencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Puntos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmboxEquipo = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.paneAlineacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // paneAlineacion
            // 
            this.paneAlineacion.BackColor = System.Drawing.Color.LightGray;
            this.paneAlineacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneAlineacion.Controls.Add(this.pcboxLogo);
            this.paneAlineacion.Controls.Add(this.lstviewIncidencias);
            this.paneAlineacion.Controls.Add(this.btnRefrescar);
            this.paneAlineacion.Controls.Add(this.btnIncidencias);
            this.paneAlineacion.Controls.Add(this.btnVolver);
            this.paneAlineacion.Controls.Add(this.cmboxEquipo);
            this.paneAlineacion.Controls.Add(this.lblEquipo);
            this.paneAlineacion.Location = new System.Drawing.Point(0, 0);
            this.paneAlineacion.Name = "paneAlineacion";
            this.paneAlineacion.Size = new System.Drawing.Size(528, 371);
            this.paneAlineacion.TabIndex = 1;
            // 
            // pcboxLogo
            // 
            this.pcboxLogo.Location = new System.Drawing.Point(146, 43);
            this.pcboxLogo.Name = "pcboxLogo";
            this.pcboxLogo.Size = new System.Drawing.Size(112, 81);
            this.pcboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxLogo.TabIndex = 27;
            this.pcboxLogo.TabStop = false;
            // 
            // lstviewIncidencias
            // 
            this.lstviewIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstviewIncidencias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellido,
            this.Minuto,
            this.Ocurrencia,
            this.Puntos});
            this.lstviewIncidencias.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lstviewIncidencias.GridLines = true;
            this.lstviewIncidencias.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstviewIncidencias.HideSelection = false;
            this.lstviewIncidencias.Location = new System.Drawing.Point(3, 129);
            this.lstviewIncidencias.Name = "lstviewIncidencias";
            this.lstviewIncidencias.Size = new System.Drawing.Size(524, 237);
            this.lstviewIncidencias.TabIndex = 26;
            this.lstviewIncidencias.UseCompatibleStateImageBehavior = false;
            this.lstviewIncidencias.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 80;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 81;
            // 
            // Minuto
            // 
            this.Minuto.DisplayIndex = 3;
            this.Minuto.Text = "Minuto";
            this.Minuto.Width = 50;
            // 
            // Ocurrencia
            // 
            this.Ocurrencia.DisplayIndex = 2;
            this.Ocurrencia.Text = "Ocurrencia";
            this.Ocurrencia.Width = 80;
            // 
            // Puntos
            // 
            this.Puntos.Text = "Puntos sumados";
            this.Puntos.Width = 240;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(387, 42);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(129, 28);
            this.btnRefrescar.TabIndex = 25;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnIncidencias.Location = new System.Drawing.Point(387, 10);
            this.btnIncidencias.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(129, 28);
            this.btnIncidencias.TabIndex = 23;
            this.btnIncidencias.Text = "Ver Incidencias";
            this.btnIncidencias.UseVisualStyleBackColor = true;
            this.btnIncidencias.Click += new System.EventHandler(this.btnIncidencias_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(387, 74);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 28);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmboxEquipo
            // 
            this.cmboxEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxEquipo.FormattingEnabled = true;
            this.cmboxEquipo.Location = new System.Drawing.Point(73, 13);
            this.cmboxEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquipo.Name = "cmboxEquipo";
            this.cmboxEquipo.Size = new System.Drawing.Size(310, 25);
            this.cmboxEquipo.TabIndex = 16;
            this.cmboxEquipo.SelectedIndexChanged += new System.EventHandler(this.cmboxEquipo_SelectedIndexChanged);
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
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 369);
            this.Controls.Add(this.paneAlineacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Incidencias";
            this.Text = "Incidencias";
            this.Load += new System.EventHandler(this.Incidencias_Load);
            this.paneAlineacion.ResumeLayout(false);
            this.paneAlineacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneAlineacion;
        private System.Windows.Forms.ListView lstviewIncidencias;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Ocurrencia;
        private System.Windows.Forms.ColumnHeader Minuto;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmboxEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ColumnHeader Puntos;
        private System.Windows.Forms.PictureBox pcboxLogo;
    }
}