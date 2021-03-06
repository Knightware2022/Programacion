namespace BackOfficeAdministracion
{
    partial class GestionarUsuarios
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
            this.tbcGestionUsuarios = new System.Windows.Forms.TabControl();
            this.tbpgMostrarUsuarios = new System.Windows.Forms.TabPage();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTiempoSuscripto = new System.Windows.Forms.TextBox();
            this.cmboxDeportesFavoritos = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblDeportesFavoritos = new System.Windows.Forms.Label();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmboxIDusuarios = new System.Windows.Forms.ComboBox();
            this.lblIDusuario = new System.Windows.Forms.Label();
            this.rbpgEliminar = new System.Windows.Forms.TabPage();
            this.btnCerrarII = new System.Windows.Forms.Button();
            this.paneEliminarU = new System.Windows.Forms.Panel();
            this.txtIDaEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.tbpgGestionarPublicidad = new System.Windows.Forms.TabPage();
            this.paneAniadirPublicidad = new System.Windows.Forms.Panel();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnAgregarPublicidad = new System.Windows.Forms.Button();
            this.txtURLpublicidad = new System.Windows.Forms.TextBox();
            this.paneEliminarPublicidad = new System.Windows.Forms.Panel();
            this.lblUrlEliminar = new System.Windows.Forms.Label();
            this.cmboxUrl = new System.Windows.Forms.ComboBox();
            this.btnEliminarPublicidad = new System.Windows.Forms.Button();
            this.tbcGestionUsuarios.SuspendLayout();
            this.tbpgMostrarUsuarios.SuspendLayout();
            this.rbpgEliminar.SuspendLayout();
            this.paneEliminarU.SuspendLayout();
            this.tbpgGestionarPublicidad.SuspendLayout();
            this.paneAniadirPublicidad.SuspendLayout();
            this.paneEliminarPublicidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestionUsuarios
            // 
            this.tbcGestionUsuarios.Controls.Add(this.tbpgMostrarUsuarios);
            this.tbcGestionUsuarios.Controls.Add(this.rbpgEliminar);
            this.tbcGestionUsuarios.Controls.Add(this.tbpgGestionarPublicidad);
            this.tbcGestionUsuarios.Location = new System.Drawing.Point(0, 1);
            this.tbcGestionUsuarios.Name = "tbcGestionUsuarios";
            this.tbcGestionUsuarios.SelectedIndex = 0;
            this.tbcGestionUsuarios.Size = new System.Drawing.Size(739, 579);
            this.tbcGestionUsuarios.TabIndex = 0;
            // 
            // tbpgMostrarUsuarios
            // 
            this.tbpgMostrarUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpgMostrarUsuarios.Controls.Add(this.btnCerrar);
            this.tbpgMostrarUsuarios.Controls.Add(this.txtUsuario);
            this.tbpgMostrarUsuarios.Controls.Add(this.txtCorreo);
            this.tbpgMostrarUsuarios.Controls.Add(this.txtTiempoSuscripto);
            this.tbpgMostrarUsuarios.Controls.Add(this.cmboxDeportesFavoritos);
            this.tbpgMostrarUsuarios.Controls.Add(this.btnMostrar);
            this.tbpgMostrarUsuarios.Controls.Add(this.lblDeportesFavoritos);
            this.tbpgMostrarUsuarios.Controls.Add(this.lblAntiguedad);
            this.tbpgMostrarUsuarios.Controls.Add(this.lblCorreo);
            this.tbpgMostrarUsuarios.Controls.Add(this.lblNombre);
            this.tbpgMostrarUsuarios.Controls.Add(this.cmboxIDusuarios);
            this.tbpgMostrarUsuarios.Controls.Add(this.lblIDusuario);
            this.tbpgMostrarUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tbpgMostrarUsuarios.Name = "tbpgMostrarUsuarios";
            this.tbpgMostrarUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgMostrarUsuarios.Size = new System.Drawing.Size(731, 550);
            this.tbpgMostrarUsuarios.TabIndex = 0;
            this.tbpgMostrarUsuarios.Text = "Mostrar usuarios";
            this.tbpgMostrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(674, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(57, 26);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(375, 230);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 22);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(375, 300);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(212, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtTiempoSuscripto
            // 
            this.txtTiempoSuscripto.Location = new System.Drawing.Point(375, 369);
            this.txtTiempoSuscripto.Name = "txtTiempoSuscripto";
            this.txtTiempoSuscripto.Size = new System.Drawing.Size(212, 22);
            this.txtTiempoSuscripto.TabIndex = 8;
            // 
            // cmboxDeportesFavoritos
            // 
            this.cmboxDeportesFavoritos.FormattingEnabled = true;
            this.cmboxDeportesFavoritos.Location = new System.Drawing.Point(375, 449);
            this.cmboxDeportesFavoritos.Name = "cmboxDeportesFavoritos";
            this.cmboxDeportesFavoritos.Size = new System.Drawing.Size(212, 24);
            this.cmboxDeportesFavoritos.TabIndex = 7;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(245, 134);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(107, 34);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // lblDeportesFavoritos
            // 
            this.lblDeportesFavoritos.AutoSize = true;
            this.lblDeportesFavoritos.Location = new System.Drawing.Point(112, 449);
            this.lblDeportesFavoritos.Name = "lblDeportesFavoritos";
            this.lblDeportesFavoritos.Size = new System.Drawing.Size(124, 17);
            this.lblDeportesFavoritos.TabIndex = 5;
            this.lblDeportesFavoritos.Text = "Deportes favoritos";
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(112, 374);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(116, 17);
            this.lblAntiguedad.TabIndex = 4;
            this.lblAntiguedad.Text = "Tiempo suscripto";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(111, 305);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(128, 17);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(112, 230);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de usuario: ";
            // 
            // cmboxIDusuarios
            // 
            this.cmboxIDusuarios.FormattingEnabled = true;
            this.cmboxIDusuarios.Location = new System.Drawing.Point(299, 52);
            this.cmboxIDusuarios.Name = "cmboxIDusuarios";
            this.cmboxIDusuarios.Size = new System.Drawing.Size(212, 24);
            this.cmboxIDusuarios.TabIndex = 1;
            // 
            // lblIDusuario
            // 
            this.lblIDusuario.AutoSize = true;
            this.lblIDusuario.Location = new System.Drawing.Point(108, 55);
            this.lblIDusuario.Name = "lblIDusuario";
            this.lblIDusuario.Size = new System.Drawing.Size(80, 17);
            this.lblIDusuario.TabIndex = 0;
            this.lblIDusuario.Text = "ID usuario: ";
            // 
            // rbpgEliminar
            // 
            this.rbpgEliminar.Controls.Add(this.btnCerrarII);
            this.rbpgEliminar.Controls.Add(this.paneEliminarU);
            this.rbpgEliminar.Location = new System.Drawing.Point(4, 25);
            this.rbpgEliminar.Name = "rbpgEliminar";
            this.rbpgEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.rbpgEliminar.Size = new System.Drawing.Size(731, 550);
            this.rbpgEliminar.TabIndex = 1;
            this.rbpgEliminar.Text = "Eliminar Usuario";
            this.rbpgEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrarII
            // 
            this.btnCerrarII.Location = new System.Drawing.Point(679, 0);
            this.btnCerrarII.Name = "btnCerrarII";
            this.btnCerrarII.Size = new System.Drawing.Size(52, 25);
            this.btnCerrarII.TabIndex = 1;
            this.btnCerrarII.Text = "cerrar";
            this.btnCerrarII.UseVisualStyleBackColor = true;
            this.btnCerrarII.Click += new System.EventHandler(this.btnCerrarII_Click);
            // 
            // paneEliminarU
            // 
            this.paneEliminarU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneEliminarU.Controls.Add(this.txtIDaEliminar);
            this.paneEliminarU.Controls.Add(this.btnEliminar);
            this.paneEliminarU.Controls.Add(this.lblID);
            this.paneEliminarU.Location = new System.Drawing.Point(53, 156);
            this.paneEliminarU.Name = "paneEliminarU";
            this.paneEliminarU.Size = new System.Drawing.Size(620, 203);
            this.paneEliminarU.TabIndex = 0;
            // 
            // txtIDaEliminar
            // 
            this.txtIDaEliminar.Location = new System.Drawing.Point(291, 66);
            this.txtIDaEliminar.Name = "txtIDaEliminar";
            this.txtIDaEliminar.Size = new System.Drawing.Size(260, 22);
            this.txtIDaEliminar.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(193, 135);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 34);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(57, 69);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(165, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID de usuario a eliminar: ";
            // 
            // tbpgGestionarPublicidad
            // 
            this.tbpgGestionarPublicidad.Controls.Add(this.paneEliminarPublicidad);
            this.tbpgGestionarPublicidad.Controls.Add(this.paneAniadirPublicidad);
            this.tbpgGestionarPublicidad.Location = new System.Drawing.Point(4, 25);
            this.tbpgGestionarPublicidad.Name = "tbpgGestionarPublicidad";
            this.tbpgGestionarPublicidad.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgGestionarPublicidad.Size = new System.Drawing.Size(731, 550);
            this.tbpgGestionarPublicidad.TabIndex = 2;
            this.tbpgGestionarPublicidad.Text = "Administrar publicidad";
            this.tbpgGestionarPublicidad.UseVisualStyleBackColor = true;
            // 
            // paneAniadirPublicidad
            // 
            this.paneAniadirPublicidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneAniadirPublicidad.Controls.Add(this.txtURLpublicidad);
            this.paneAniadirPublicidad.Controls.Add(this.btnAgregarPublicidad);
            this.paneAniadirPublicidad.Controls.Add(this.lblUrl);
            this.paneAniadirPublicidad.Location = new System.Drawing.Point(8, 6);
            this.paneAniadirPublicidad.Name = "paneAniadirPublicidad";
            this.paneAniadirPublicidad.Size = new System.Drawing.Size(714, 161);
            this.paneAniadirPublicidad.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(23, 43);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(112, 17);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL publicidad: ";
            // 
            // btnAgregarPublicidad
            // 
            this.btnAgregarPublicidad.Location = new System.Drawing.Point(226, 94);
            this.btnAgregarPublicidad.Name = "btnAgregarPublicidad";
            this.btnAgregarPublicidad.Size = new System.Drawing.Size(122, 47);
            this.btnAgregarPublicidad.TabIndex = 1;
            this.btnAgregarPublicidad.Text = "Agregar Publicidad";
            this.btnAgregarPublicidad.UseVisualStyleBackColor = true;
            // 
            // txtURLpublicidad
            // 
            this.txtURLpublicidad.Location = new System.Drawing.Point(227, 40);
            this.txtURLpublicidad.Name = "txtURLpublicidad";
            this.txtURLpublicidad.Size = new System.Drawing.Size(456, 22);
            this.txtURLpublicidad.TabIndex = 2;
            // 
            // paneEliminarPublicidad
            // 
            this.paneEliminarPublicidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneEliminarPublicidad.Controls.Add(this.btnEliminarPublicidad);
            this.paneEliminarPublicidad.Controls.Add(this.cmboxUrl);
            this.paneEliminarPublicidad.Controls.Add(this.lblUrlEliminar);
            this.paneEliminarPublicidad.Location = new System.Drawing.Point(8, 218);
            this.paneEliminarPublicidad.Name = "paneEliminarPublicidad";
            this.paneEliminarPublicidad.Size = new System.Drawing.Size(714, 206);
            this.paneEliminarPublicidad.TabIndex = 1;
            // 
            // lblUrlEliminar
            // 
            this.lblUrlEliminar.AutoSize = true;
            this.lblUrlEliminar.Location = new System.Drawing.Point(38, 61);
            this.lblUrlEliminar.Name = "lblUrlEliminar";
            this.lblUrlEliminar.Size = new System.Drawing.Size(124, 17);
            this.lblUrlEliminar.TabIndex = 0;
            this.lblUrlEliminar.Text = "URL de publicidad";
            // 
            // cmboxUrl
            // 
            this.cmboxUrl.FormattingEnabled = true;
            this.cmboxUrl.Location = new System.Drawing.Point(263, 58);
            this.cmboxUrl.Name = "cmboxUrl";
            this.cmboxUrl.Size = new System.Drawing.Size(323, 24);
            this.cmboxUrl.TabIndex = 1;
            // 
            // btnEliminarPublicidad
            // 
            this.btnEliminarPublicidad.Location = new System.Drawing.Point(202, 144);
            this.btnEliminarPublicidad.Name = "btnEliminarPublicidad";
            this.btnEliminarPublicidad.Size = new System.Drawing.Size(182, 40);
            this.btnEliminarPublicidad.TabIndex = 2;
            this.btnEliminarPublicidad.Text = "Eliminar Publicidad";
            this.btnEliminarPublicidad.UseVisualStyleBackColor = true;
            // 
            // GestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 580);
            this.Controls.Add(this.tbcGestionUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarios";
            this.Text = "GestionarUsuarios";
            this.tbcGestionUsuarios.ResumeLayout(false);
            this.tbpgMostrarUsuarios.ResumeLayout(false);
            this.tbpgMostrarUsuarios.PerformLayout();
            this.rbpgEliminar.ResumeLayout(false);
            this.paneEliminarU.ResumeLayout(false);
            this.paneEliminarU.PerformLayout();
            this.tbpgGestionarPublicidad.ResumeLayout(false);
            this.paneAniadirPublicidad.ResumeLayout(false);
            this.paneAniadirPublicidad.PerformLayout();
            this.paneEliminarPublicidad.ResumeLayout(false);
            this.paneEliminarPublicidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestionUsuarios;
        private System.Windows.Forms.TabPage tbpgMostrarUsuarios;
        private System.Windows.Forms.ComboBox cmboxDeportesFavoritos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblDeportesFavoritos;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmboxIDusuarios;
        private System.Windows.Forms.Label lblIDusuario;
        private System.Windows.Forms.TabPage rbpgEliminar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTiempoSuscripto;
        private System.Windows.Forms.Panel paneEliminarU;
        private System.Windows.Forms.TextBox txtIDaEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCerrarII;
        private System.Windows.Forms.TabPage tbpgGestionarPublicidad;
        private System.Windows.Forms.Panel paneAniadirPublicidad;
        private System.Windows.Forms.Button btnAgregarPublicidad;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtURLpublicidad;
        private System.Windows.Forms.Panel paneEliminarPublicidad;
        private System.Windows.Forms.Button btnEliminarPublicidad;
        private System.Windows.Forms.ComboBox cmboxUrl;
        private System.Windows.Forms.Label lblUrlEliminar;
    }
}