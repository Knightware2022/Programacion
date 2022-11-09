namespace App_de_Usuario
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
            this.pcboxLogo = new System.Windows.Forms.PictureBox();
            this.lstviewAlineacion = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Posicion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Equipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmboxEquipoAlineacion = new System.Windows.Forms.ComboBox();
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
            this.paneAlineacion.Controls.Add(this.lstviewAlineacion);
            this.paneAlineacion.Controls.Add(this.btnRefrescar);
            this.paneAlineacion.Controls.Add(this.button1);
            this.paneAlineacion.Controls.Add(this.btnVolver);
            this.paneAlineacion.Controls.Add(this.cmboxEquipoAlineacion);
            this.paneAlineacion.Controls.Add(this.lblEquipo);
            this.paneAlineacion.Location = new System.Drawing.Point(0, 0);
            this.paneAlineacion.Name = "paneAlineacion";
            this.paneAlineacion.Size = new System.Drawing.Size(528, 371);
            this.paneAlineacion.TabIndex = 1;
            // 
            // pcboxLogo
            // 
            this.pcboxLogo.Location = new System.Drawing.Point(153, 40);
            this.pcboxLogo.Name = "pcboxLogo";
            this.pcboxLogo.Size = new System.Drawing.Size(112, 91);
            this.pcboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxLogo.TabIndex = 27;
            this.pcboxLogo.TabStop = false;
            // 
            // lstviewAlineacion
            // 
            this.lstviewAlineacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstviewAlineacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellido,
            this.Posicion,
            this.Equipo});
            this.lstviewAlineacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lstviewAlineacion.GridLines = true;
            this.lstviewAlineacion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstviewAlineacion.HideSelection = false;
            this.lstviewAlineacion.Location = new System.Drawing.Point(10, 137);
            this.lstviewAlineacion.Name = "lstviewAlineacion";
            this.lstviewAlineacion.Size = new System.Drawing.Size(506, 222);
            this.lstviewAlineacion.TabIndex = 26;
            this.lstviewAlineacion.UseCompatibleStateImageBehavior = false;
            this.lstviewAlineacion.View = System.Windows.Forms.View.Details;
            this.lstviewAlineacion.SelectedIndexChanged += new System.EventHandler(this.lstviewAlineacion_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 83;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 83;
            // 
            // Posicion
            // 
            this.Posicion.Text = "Posicion";
            this.Posicion.Width = 83;
            // 
            // Equipo
            // 
            this.Equipo.Text = "Equipo";
            this.Equipo.Width = 83;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(388, 43);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(129, 28);
            this.btnRefrescar.TabIndex = 25;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(388, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ver alineación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(388, 75);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 28);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmboxEquipoAlineacion
            // 
            this.cmboxEquipoAlineacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxEquipoAlineacion.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxEquipoAlineacion.FormattingEnabled = true;
            this.cmboxEquipoAlineacion.Location = new System.Drawing.Point(75, 10);
            this.cmboxEquipoAlineacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxEquipoAlineacion.Name = "cmboxEquipoAlineacion";
            this.cmboxEquipoAlineacion.Size = new System.Drawing.Size(282, 25);
            this.cmboxEquipoAlineacion.TabIndex = 16;
            this.cmboxEquipoAlineacion.SelectedIndexChanged += new System.EventHandler(this.cmboxEquipoAlineacion_SelectedIndexChanged);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEquipo.Location = new System.Drawing.Point(18, 10);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(53, 17);
            this.lblEquipo.TabIndex = 12;
            this.lblEquipo.Text = "Equipo: ";
            // 
            // Alineacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 372);
            this.Controls.Add(this.paneAlineacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alineacion";
            this.Text = "Alineacion";
            this.paneAlineacion.ResumeLayout(false);
            this.paneAlineacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneAlineacion;
        private System.Windows.Forms.ListView lstviewAlineacion;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Posicion;
        private System.Windows.Forms.ColumnHeader Equipo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmboxEquipoAlineacion;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.PictureBox pcboxLogo;
    }
}