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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtNuevaContraConfirma = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNuevaContra = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.paneBotones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.paneApariencia = new System.Windows.Forms.Panel();
            this.cmboxTema = new System.Windows.Forms.ComboBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblApariencia = new System.Windows.Forms.Label();
            this.paneIdioma = new System.Windows.Forms.Panel();
            this.cmboxIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdiomaE = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.paneConfiguracion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paneBotones.SuspendLayout();
            this.paneApariencia.SuspendLayout();
            this.paneIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneConfiguracion
            // 
            this.paneConfiguracion.Controls.Add(this.panel1);
            this.paneConfiguracion.Controls.Add(this.paneBotones);
            this.paneConfiguracion.Controls.Add(this.paneApariencia);
            this.paneConfiguracion.Controls.Add(this.paneIdioma);
            this.paneConfiguracion.Location = new System.Drawing.Point(0, 2);
            this.paneConfiguracion.Margin = new System.Windows.Forms.Padding(2);
            this.paneConfiguracion.Name = "paneConfiguracion";
            this.paneConfiguracion.Size = new System.Drawing.Size(580, 619);
            this.paneConfiguracion.TabIndex = 0;
            this.paneConfiguracion.Paint += new System.Windows.Forms.PaintEventHandler(this.paneConfiguracion_Paint);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCambiarContraseña);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.txtNuevaContraConfirma);
            this.panel1.Controls.Add(this.txtNuevaContraseña);
            this.panel1.Controls.Add(this.txtContraActual);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNuevaContra);
            this.panel1.Controls.Add(this.lblContra);
            this.panel1.Location = new System.Drawing.Point(12, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 195);
            this.panel1.TabIndex = 6;
            // 
            // btnVer
            // 
            this.btnVer.BackgroundImage = global::BackOfficeAdministracion.Properties.Resources.ojo;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Location = new System.Drawing.Point(488, 93);
            this.btnVer.Margin = new System.Windows.Forms.Padding(2);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(26, 28);
            this.btnVer.TabIndex = 7;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.MouseEnter += new System.EventHandler(this.btnVer_MouseEnter);
            this.btnVer.MouseLeave += new System.EventHandler(this.btnVer_MouseLeave);
            // 
            // txtNuevaContraConfirma
            // 
            this.txtNuevaContraConfirma.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtNuevaContraConfirma.Location = new System.Drawing.Point(214, 117);
            this.txtNuevaContraConfirma.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaContraConfirma.Name = "txtNuevaContraConfirma";
            this.txtNuevaContraConfirma.Size = new System.Drawing.Size(251, 23);
            this.txtNuevaContraConfirma.TabIndex = 6;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtNuevaContraseña.Location = new System.Drawing.Point(214, 79);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(251, 23);
            this.txtNuevaContraseña.TabIndex = 5;
            // 
            // txtContraActual
            // 
            this.txtContraActual.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtContraActual.Location = new System.Drawing.Point(214, 41);
            this.txtContraActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.Size = new System.Drawing.Size(251, 23);
            this.txtContraActual.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña Actual: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Repita contraseña: ";
            // 
            // lblNuevaContra
            // 
            this.lblNuevaContra.AutoSize = true;
            this.lblNuevaContra.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNuevaContra.Location = new System.Drawing.Point(34, 78);
            this.lblNuevaContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaContra.Name = "lblNuevaContra";
            this.lblNuevaContra.Size = new System.Drawing.Size(113, 17);
            this.lblNuevaContra.TabIndex = 1;
            this.lblNuevaContra.Text = "Nueva Contraseña: ";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblContra.Location = new System.Drawing.Point(4, 0);
            this.lblContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(70, 17);
            this.lblContra.TabIndex = 0;
            this.lblContra.Text = "Contraseña";
            // 
            // paneBotones
            // 
            this.paneBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBotones.Controls.Add(this.btnCerrar);
            this.paneBotones.Controls.Add(this.btnAplicar);
            this.paneBotones.Location = new System.Drawing.Point(7, 503);
            this.paneBotones.Margin = new System.Windows.Forms.Padding(2);
            this.paneBotones.Name = "paneBotones";
            this.paneBotones.Size = new System.Drawing.Size(567, 84);
            this.paneBotones.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(364, 28);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 27);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.Location = new System.Drawing.Point(74, 28);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(141, 27);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Aplicar cambios";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // paneApariencia
            // 
            this.paneApariencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneApariencia.Controls.Add(this.cmboxTema);
            this.paneApariencia.Controls.Add(this.lblTema);
            this.paneApariencia.Controls.Add(this.lblApariencia);
            this.paneApariencia.Location = new System.Drawing.Point(12, 108);
            this.paneApariencia.Margin = new System.Windows.Forms.Padding(2);
            this.paneApariencia.Name = "paneApariencia";
            this.paneApariencia.Size = new System.Drawing.Size(562, 81);
            this.paneApariencia.TabIndex = 1;
            // 
            // cmboxTema
            // 
            this.cmboxTema.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxTema.FormattingEnabled = true;
            this.cmboxTema.Items.AddRange(new object[] {
            "Predeterminado",
            "Oscuro",
            "Claro"});
            this.cmboxTema.Location = new System.Drawing.Point(214, 39);
            this.cmboxTema.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxTema.Name = "cmboxTema";
            this.cmboxTema.Size = new System.Drawing.Size(251, 25);
            this.cmboxTema.TabIndex = 2;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTema.Location = new System.Drawing.Point(34, 42);
            this.lblTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(90, 17);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Tema a aplicar: ";
            // 
            // lblApariencia
            // 
            this.lblApariencia.AutoSize = true;
            this.lblApariencia.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblApariencia.Location = new System.Drawing.Point(4, 0);
            this.lblApariencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApariencia.Name = "lblApariencia";
            this.lblApariencia.Size = new System.Drawing.Size(65, 17);
            this.lblApariencia.TabIndex = 0;
            this.lblApariencia.Text = "Apariencia";
            // 
            // paneIdioma
            // 
            this.paneIdioma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneIdioma.Controls.Add(this.cmboxIdioma);
            this.paneIdioma.Controls.Add(this.lblIdiomaE);
            this.paneIdioma.Controls.Add(this.lblIdioma);
            this.paneIdioma.Location = new System.Drawing.Point(12, 17);
            this.paneIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.paneIdioma.Name = "paneIdioma";
            this.paneIdioma.Size = new System.Drawing.Size(562, 74);
            this.paneIdioma.TabIndex = 0;
            // 
            // cmboxIdioma
            // 
            this.cmboxIdioma.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxIdioma.FormattingEnabled = true;
            this.cmboxIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cmboxIdioma.Location = new System.Drawing.Point(214, 35);
            this.cmboxIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmboxIdioma.Name = "cmboxIdioma";
            this.cmboxIdioma.Size = new System.Drawing.Size(251, 25);
            this.cmboxIdioma.TabIndex = 2;
            // 
            // lblIdiomaE
            // 
            this.lblIdiomaE.AutoSize = true;
            this.lblIdiomaE.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIdiomaE.Location = new System.Drawing.Point(34, 35);
            this.lblIdiomaE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdiomaE.Name = "lblIdiomaE";
            this.lblIdiomaE.Size = new System.Drawing.Size(121, 17);
            this.lblIdiomaE.TabIndex = 1;
            this.lblIdiomaE.Text = "Seleccione un idioma";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIdioma.Location = new System.Drawing.Point(2, 0);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(43, 17);
            this.lblIdioma.TabIndex = 0;
            this.lblIdioma.Text = "Idioma";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCambiarContraseña.Location = new System.Drawing.Point(280, 164);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(185, 27);
            this.btnCambiarContraseña.TabIndex = 8;
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 625);
            this.Controls.Add(this.paneConfiguracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Configuracion";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.paneConfiguracion.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneBotones.ResumeLayout(false);
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
        private System.Windows.Forms.Panel paneBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNuevaContraConfirma;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNuevaContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnCambiarContraseña;
    }
}