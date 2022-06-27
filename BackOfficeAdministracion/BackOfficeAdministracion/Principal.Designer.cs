namespace BackOfficeAdministracion
{
    partial class Principal
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
            this.paneHerramientas = new System.Windows.Forms.Panel();
            this.paneGestionarDeportes = new System.Windows.Forms.Panel();
            this.paneGestionarUsuarios = new System.Windows.Forms.Panel();
            this.paneGestionarEventos = new System.Windows.Forms.Panel();
            this.paneVerEventos = new System.Windows.Forms.Panel();
            this.paneVerResultados = new System.Windows.Forms.Panel();
            this.paneConfiguracion = new System.Windows.Forms.Panel();
            this.btnGestionarDeportes = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnGestionarEventos = new System.Windows.Forms.Button();
            this.btnVerEventos = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.paneVista = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.paneHerramientas.SuspendLayout();
            this.paneGestionarDeportes.SuspendLayout();
            this.paneGestionarUsuarios.SuspendLayout();
            this.paneGestionarEventos.SuspendLayout();
            this.paneVerEventos.SuspendLayout();
            this.paneVerResultados.SuspendLayout();
            this.paneConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneHerramientas
            // 
            this.paneHerramientas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paneHerramientas.Controls.Add(this.btnSalir);
            this.paneHerramientas.Controls.Add(this.paneConfiguracion);
            this.paneHerramientas.Controls.Add(this.paneVerResultados);
            this.paneHerramientas.Controls.Add(this.paneVerEventos);
            this.paneHerramientas.Controls.Add(this.paneGestionarEventos);
            this.paneHerramientas.Controls.Add(this.paneGestionarUsuarios);
            this.paneHerramientas.Controls.Add(this.paneGestionarDeportes);
            this.paneHerramientas.Location = new System.Drawing.Point(1, 1);
            this.paneHerramientas.Name = "paneHerramientas";
            this.paneHerramientas.Size = new System.Drawing.Size(324, 627);
            this.paneHerramientas.TabIndex = 0;
            // 
            // paneGestionarDeportes
            // 
            this.paneGestionarDeportes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneGestionarDeportes.Controls.Add(this.btnGestionarDeportes);
            this.paneGestionarDeportes.Location = new System.Drawing.Point(11, 32);
            this.paneGestionarDeportes.Name = "paneGestionarDeportes";
            this.paneGestionarDeportes.Size = new System.Drawing.Size(296, 86);
            this.paneGestionarDeportes.TabIndex = 0;
            // 
            // paneGestionarUsuarios
            // 
            this.paneGestionarUsuarios.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneGestionarUsuarios.Controls.Add(this.btnGestionarUsuarios);
            this.paneGestionarUsuarios.Location = new System.Drawing.Point(11, 124);
            this.paneGestionarUsuarios.Name = "paneGestionarUsuarios";
            this.paneGestionarUsuarios.Size = new System.Drawing.Size(296, 86);
            this.paneGestionarUsuarios.TabIndex = 1;
            // 
            // paneGestionarEventos
            // 
            this.paneGestionarEventos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneGestionarEventos.Controls.Add(this.btnGestionarEventos);
            this.paneGestionarEventos.Location = new System.Drawing.Point(11, 216);
            this.paneGestionarEventos.Name = "paneGestionarEventos";
            this.paneGestionarEventos.Size = new System.Drawing.Size(296, 86);
            this.paneGestionarEventos.TabIndex = 2;
            // 
            // paneVerEventos
            // 
            this.paneVerEventos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneVerEventos.Controls.Add(this.btnVerEventos);
            this.paneVerEventos.Location = new System.Drawing.Point(11, 308);
            this.paneVerEventos.Name = "paneVerEventos";
            this.paneVerEventos.Size = new System.Drawing.Size(296, 86);
            this.paneVerEventos.TabIndex = 3;
            // 
            // paneVerResultados
            // 
            this.paneVerResultados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneVerResultados.Controls.Add(this.btnVerResultados);
            this.paneVerResultados.Location = new System.Drawing.Point(11, 400);
            this.paneVerResultados.Name = "paneVerResultados";
            this.paneVerResultados.Size = new System.Drawing.Size(296, 86);
            this.paneVerResultados.TabIndex = 4;
            // 
            // paneConfiguracion
            // 
            this.paneConfiguracion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneConfiguracion.Controls.Add(this.btnConfiguracion);
            this.paneConfiguracion.Location = new System.Drawing.Point(11, 492);
            this.paneConfiguracion.Name = "paneConfiguracion";
            this.paneConfiguracion.Size = new System.Drawing.Size(296, 86);
            this.paneConfiguracion.TabIndex = 5;
            // 
            // btnGestionarDeportes
            // 
            this.btnGestionarDeportes.Location = new System.Drawing.Point(67, 21);
            this.btnGestionarDeportes.Name = "btnGestionarDeportes";
            this.btnGestionarDeportes.Size = new System.Drawing.Size(157, 46);
            this.btnGestionarDeportes.TabIndex = 0;
            this.btnGestionarDeportes.Text = "Gestionar Deportes";
            this.btnGestionarDeportes.UseVisualStyleBackColor = true;
            this.btnGestionarDeportes.Click += new System.EventHandler(this.btnGestionarDeportes_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(67, 19);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(157, 46);
            this.btnGestionarUsuarios.TabIndex = 1;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnGestionarEventos
            // 
            this.btnGestionarEventos.Location = new System.Drawing.Point(67, 17);
            this.btnGestionarEventos.Name = "btnGestionarEventos";
            this.btnGestionarEventos.Size = new System.Drawing.Size(157, 46);
            this.btnGestionarEventos.TabIndex = 2;
            this.btnGestionarEventos.Text = "Gestionar Eventos";
            this.btnGestionarEventos.UseVisualStyleBackColor = true;
            this.btnGestionarEventos.Click += new System.EventHandler(this.btnGestionarEventos_Click);
            // 
            // btnVerEventos
            // 
            this.btnVerEventos.Location = new System.Drawing.Point(67, 21);
            this.btnVerEventos.Name = "btnVerEventos";
            this.btnVerEventos.Size = new System.Drawing.Size(157, 46);
            this.btnVerEventos.TabIndex = 3;
            this.btnVerEventos.Text = "Ver eventos";
            this.btnVerEventos.UseVisualStyleBackColor = true;
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(67, 20);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(157, 46);
            this.btnVerResultados.TabIndex = 4;
            this.btnVerResultados.Text = "Ver resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(67, 15);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(157, 46);
            this.btnConfiguracion.TabIndex = 5;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // paneVista
            // 
            this.paneVista.BackColor = System.Drawing.Color.DarkBlue;
            this.paneVista.Location = new System.Drawing.Point(325, 1);
            this.paneVista.Name = "paneVista";
            this.paneVista.Size = new System.Drawing.Size(756, 627);
            this.paneVista.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(100, 584);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 620);
            this.Controls.Add(this.paneVista);
            this.Controls.Add(this.paneHerramientas);
            this.Name = "Principal";
            this.Text = "SIGDE";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.paneHerramientas.ResumeLayout(false);
            this.paneGestionarDeportes.ResumeLayout(false);
            this.paneGestionarUsuarios.ResumeLayout(false);
            this.paneGestionarEventos.ResumeLayout(false);
            this.paneVerEventos.ResumeLayout(false);
            this.paneVerResultados.ResumeLayout(false);
            this.paneConfiguracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneHerramientas;
        private System.Windows.Forms.Panel paneConfiguracion;
        private System.Windows.Forms.Panel paneVerResultados;
        private System.Windows.Forms.Panel paneVerEventos;
        private System.Windows.Forms.Panel paneGestionarEventos;
        private System.Windows.Forms.Panel paneGestionarUsuarios;
        private System.Windows.Forms.Panel paneGestionarDeportes;
        private System.Windows.Forms.Button btnGestionarDeportes;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.Button btnVerEventos;
        private System.Windows.Forms.Button btnGestionarEventos;
        public System.Windows.Forms.Panel paneVista;
        private System.Windows.Forms.Button btnSalir;
    }
}