namespace App_de_Usuario
{
    partial class Deportes_Favoritos
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
            this.paneDeportesFavoritos = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarFavoritos = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.cmboxDeportesFavoritos = new System.Windows.Forms.ComboBox();
            this.lblDeportesFavoritos = new System.Windows.Forms.Label();
            this.paneDeportesFavoritos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneDeportesFavoritos
            // 
            this.paneDeportesFavoritos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paneDeportesFavoritos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneDeportesFavoritos.Controls.Add(this.btnVolver);
            this.paneDeportesFavoritos.Controls.Add(this.btnEliminarFavoritos);
            this.paneDeportesFavoritos.Controls.Add(this.btnRefrescar);
            this.paneDeportesFavoritos.Controls.Add(this.cmboxDeportesFavoritos);
            this.paneDeportesFavoritos.Controls.Add(this.lblDeportesFavoritos);
            this.paneDeportesFavoritos.Location = new System.Drawing.Point(20, 139);
            this.paneDeportesFavoritos.Name = "paneDeportesFavoritos";
            this.paneDeportesFavoritos.Size = new System.Drawing.Size(961, 230);
            this.paneDeportesFavoritos.TabIndex = 0;
            this.paneDeportesFavoritos.Paint += new System.Windows.Forms.PaintEventHandler(this.paneDeportesFavoritos_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(689, 144);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(193, 51);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Cerrar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarFavoritos
            // 
            this.btnEliminarFavoritos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarFavoritos.Location = new System.Drawing.Point(399, 144);
            this.btnEliminarFavoritos.Name = "btnEliminarFavoritos";
            this.btnEliminarFavoritos.Size = new System.Drawing.Size(193, 51);
            this.btnEliminarFavoritos.TabIndex = 3;
            this.btnEliminarFavoritos.Text = "Eliminar de favoritos";
            this.btnEliminarFavoritos.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.Location = new System.Drawing.Point(112, 144);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(193, 51);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // cmboxDeportesFavoritos
            // 
            this.cmboxDeportesFavoritos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboxDeportesFavoritos.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.cmboxDeportesFavoritos.FormattingEnabled = true;
            this.cmboxDeportesFavoritos.Location = new System.Drawing.Point(276, 72);
            this.cmboxDeportesFavoritos.Name = "cmboxDeportesFavoritos";
            this.cmboxDeportesFavoritos.Size = new System.Drawing.Size(645, 29);
            this.cmboxDeportesFavoritos.TabIndex = 1;
            // 
            // lblDeportesFavoritos
            // 
            this.lblDeportesFavoritos.AutoSize = true;
            this.lblDeportesFavoritos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeportesFavoritos.Location = new System.Drawing.Point(38, 72);
            this.lblDeportesFavoritos.Name = "lblDeportesFavoritos";
            this.lblDeportesFavoritos.Size = new System.Drawing.Size(153, 18);
            this.lblDeportesFavoritos.TabIndex = 0;
            this.lblDeportesFavoritos.Text = "Deportes Favoritos: ";
            // 
            // Deportes_Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 608);
            this.Controls.Add(this.paneDeportesFavoritos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Deportes_Favoritos";
            this.Text = "Deportes_Favoritos";
            this.Load += new System.EventHandler(this.Deportes_Favoritos_Load);
            this.paneDeportesFavoritos.ResumeLayout(false);
            this.paneDeportesFavoritos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneDeportesFavoritos;
        private System.Windows.Forms.ComboBox cmboxDeportesFavoritos;
        private System.Windows.Forms.Label lblDeportesFavoritos;
        private System.Windows.Forms.Button btnEliminarFavoritos;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnVolver;
    }
}