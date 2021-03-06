namespace BackOfficeAdministracion
{
    partial class Configuracion
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
            this.paneConfiguracion = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.paneApariencia = new System.Windows.Forms.Panel();
            this.cmboxTema = new System.Windows.Forms.ComboBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblApariencia = new System.Windows.Forms.Label();
            this.paneIdioma = new System.Windows.Forms.Panel();
            this.cmboxIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdiomaE = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.paneConfiguracion.SuspendLayout();
            this.paneApariencia.SuspendLayout();
            this.paneIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneConfiguracion
            // 
            this.paneConfiguracion.Controls.Add(this.btnCerrar);
            this.paneConfiguracion.Controls.Add(this.btnCancelar);
            this.paneConfiguracion.Controls.Add(this.btnAplicar);
            this.paneConfiguracion.Controls.Add(this.paneApariencia);
            this.paneConfiguracion.Controls.Add(this.paneIdioma);
            this.paneConfiguracion.Location = new System.Drawing.Point(0, 3);
            this.paneConfiguracion.Name = "paneConfiguracion";
            this.paneConfiguracion.Size = new System.Drawing.Size(740, 577);
            this.paneConfiguracion.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(383, 486);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 33);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 486);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 33);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(40, 486);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(132, 33);
            this.btnAplicar.TabIndex = 2;
            this.btnAplicar.Text = "Aplicar cambios";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // paneApariencia
            // 
            this.paneApariencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneApariencia.Controls.Add(this.cmboxTema);
            this.paneApariencia.Controls.Add(this.lblTema);
            this.paneApariencia.Controls.Add(this.lblApariencia);
            this.paneApariencia.Location = new System.Drawing.Point(16, 133);
            this.paneApariencia.Name = "paneApariencia";
            this.paneApariencia.Size = new System.Drawing.Size(710, 124);
            this.paneApariencia.TabIndex = 1;
            // 
            // cmboxTema
            // 
            this.cmboxTema.FormattingEnabled = true;
            this.cmboxTema.Items.AddRange(new object[] {
            "Predeterminado",
            "Oscuro",
            "Claro"});
            this.cmboxTema.Location = new System.Drawing.Point(376, 49);
            this.cmboxTema.Name = "cmboxTema";
            this.cmboxTema.Size = new System.Drawing.Size(226, 24);
            this.cmboxTema.TabIndex = 2;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(46, 52);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(110, 17);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Tema a aplicar: ";
            // 
            // lblApariencia
            // 
            this.lblApariencia.AutoSize = true;
            this.lblApariencia.Location = new System.Drawing.Point(6, 0);
            this.lblApariencia.Name = "lblApariencia";
            this.lblApariencia.Size = new System.Drawing.Size(75, 17);
            this.lblApariencia.TabIndex = 0;
            this.lblApariencia.Text = "Apariencia";
            // 
            // paneIdioma
            // 
            this.paneIdioma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIdioma.Controls.Add(this.cmboxIdioma);
            this.paneIdioma.Controls.Add(this.lblIdiomaE);
            this.paneIdioma.Controls.Add(this.lblIdioma);
            this.paneIdioma.Location = new System.Drawing.Point(16, 21);
            this.paneIdioma.Name = "paneIdioma";
            this.paneIdioma.Size = new System.Drawing.Size(710, 92);
            this.paneIdioma.TabIndex = 0;
            // 
            // cmboxIdioma
            // 
            this.cmboxIdioma.FormattingEnabled = true;
            this.cmboxIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmboxIdioma.Location = new System.Drawing.Point(376, 43);
            this.cmboxIdioma.Name = "cmboxIdioma";
            this.cmboxIdioma.Size = new System.Drawing.Size(226, 24);
            this.cmboxIdioma.TabIndex = 2;
            // 
            // lblIdiomaE
            // 
            this.lblIdiomaE.AutoSize = true;
            this.lblIdiomaE.Location = new System.Drawing.Point(46, 43);
            this.lblIdiomaE.Name = "lblIdiomaE";
            this.lblIdiomaE.Size = new System.Drawing.Size(142, 17);
            this.lblIdiomaE.TabIndex = 1;
            this.lblIdiomaE.Text = "Seleccione un idioma";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(3, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(49, 17);
            this.lblIdioma.TabIndex = 0;
            this.lblIdioma.Text = "Idioma";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 580);
            this.Controls.Add(this.paneConfiguracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.paneConfiguracion.ResumeLayout(false);
            this.paneApariencia.ResumeLayout(false);
            this.paneApariencia.PerformLayout();
            this.paneIdioma.ResumeLayout(false);
            this.paneIdioma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneConfiguracion;
        private System.Windows.Forms.Panel paneIdioma;
        private System.Windows.Forms.Label lblIdiomaE;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmboxIdioma;
        private System.Windows.Forms.Panel paneApariencia;
        private System.Windows.Forms.Label lblApariencia;
        private System.Windows.Forms.ComboBox cmboxTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCerrar;
    }
}