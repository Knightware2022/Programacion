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
            this.lblDeportesFavoritos = new System.Windows.Forms.Label();
            this.cmboxDeportesFavoritos = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEliminarFavoritos = new System.Windows.Forms.Button();
            this.paneDeportesFavoritos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneDeportesFavoritos
            // 
            this.paneDeportesFavoritos.Controls.Add(this.btnEliminarFavoritos);
            this.paneDeportesFavoritos.Controls.Add(this.btnRefrescar);
            this.paneDeportesFavoritos.Controls.Add(this.cmboxDeportesFavoritos);
            this.paneDeportesFavoritos.Controls.Add(this.lblDeportesFavoritos);
            this.paneDeportesFavoritos.Location = new System.Drawing.Point(20, 132);
            this.paneDeportesFavoritos.Name = "paneDeportesFavoritos";
            this.paneDeportesFavoritos.Size = new System.Drawing.Size(1100, 287);
            this.paneDeportesFavoritos.TabIndex = 0;
            // 
            // lblDeportesFavoritos
            // 
            this.lblDeportesFavoritos.AutoSize = true;
            this.lblDeportesFavoritos.Location = new System.Drawing.Point(38, 72);
            this.lblDeportesFavoritos.Name = "lblDeportesFavoritos";
            this.lblDeportesFavoritos.Size = new System.Drawing.Size(136, 17);
            this.lblDeportesFavoritos.TabIndex = 0;
            this.lblDeportesFavoritos.Text = "Deportes Favoritos: ";
            // 
            // cmboxDeportesFavoritos
            // 
            this.cmboxDeportesFavoritos.FormattingEnabled = true;
            this.cmboxDeportesFavoritos.Location = new System.Drawing.Point(276, 72);
            this.cmboxDeportesFavoritos.Name = "cmboxDeportesFavoritos";
            this.cmboxDeportesFavoritos.Size = new System.Drawing.Size(645, 24);
            this.cmboxDeportesFavoritos.TabIndex = 1;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(205, 155);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(193, 51);
            this.btnRefrescar.TabIndex = 2;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFavoritos
            // 
            this.btnEliminarFavoritos.Location = new System.Drawing.Point(584, 155);
            this.btnEliminarFavoritos.Name = "btnEliminarFavoritos";
            this.btnEliminarFavoritos.Size = new System.Drawing.Size(193, 51);
            this.btnEliminarFavoritos.TabIndex = 3;
            this.btnEliminarFavoritos.Text = "Eliminar de favoritos";
            this.btnEliminarFavoritos.UseVisualStyleBackColor = true;
            // 
            // Deportes_Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 608);
            this.Controls.Add(this.paneDeportesFavoritos);
            this.Name = "Deportes_Favoritos";
            this.Text = "Deportes_Favoritos";
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
    }
}