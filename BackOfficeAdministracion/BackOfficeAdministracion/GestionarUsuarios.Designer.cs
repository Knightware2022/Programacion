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
            this.paneBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.paneDatos = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.txtTiempoSuscripto = new System.Windows.Forms.TextBox();
            this.lblDeportesFavoritos = new System.Windows.Forms.Label();
            this.cmboxDeportesFavoritos = new System.Windows.Forms.ComboBox();
            this.paneBuscar = new System.Windows.Forms.Panel();
            this.lblIDusuario = new System.Windows.Forms.Label();
            this.cmboxIDusuarios = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.tbpgGestionarPublicidad = new System.Windows.Forms.TabPage();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.paneEliminarPublicidad = new System.Windows.Forms.Panel();
            this.btnEliminarPublicidad = new System.Windows.Forms.Button();
            this.cmboxUrl = new System.Windows.Forms.ComboBox();
            this.lblUrlEliminar = new System.Windows.Forms.Label();
            this.paneAniadirPublicidad = new System.Windows.Forms.Panel();
            this.txtURLpublicidad = new System.Windows.Forms.TextBox();
            this.btnAgregarPublicidad = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tbcGestionUsuarios.SuspendLayout();
            this.tbpgMostrarUsuarios.SuspendLayout();
            this.paneBotones.SuspendLayout();
            this.paneDatos.SuspendLayout();
            this.paneBuscar.SuspendLayout();
            this.tbpgGestionarPublicidad.SuspendLayout();
            this.paneEliminarPublicidad.SuspendLayout();
            this.paneAniadirPublicidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestionUsuarios
            // 
            this.tbcGestionUsuarios.Controls.Add(this.tbpgMostrarUsuarios);
            this.tbcGestionUsuarios.Controls.Add(this.tbpgGestionarPublicidad);
            this.tbcGestionUsuarios.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbcGestionUsuarios.Location = new System.Drawing.Point(0, 1);
            this.tbcGestionUsuarios.Name = "tbcGestionUsuarios";
            this.tbcGestionUsuarios.SelectedIndex = 0;
            this.tbcGestionUsuarios.Size = new System.Drawing.Size(774, 762);
            this.tbcGestionUsuarios.TabIndex = 0;
            // 
            // tbpgMostrarUsuarios
            // 
            this.tbpgMostrarUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpgMostrarUsuarios.Controls.Add(this.paneBotones);
            this.tbpgMostrarUsuarios.Controls.Add(this.paneDatos);
            this.tbpgMostrarUsuarios.Controls.Add(this.paneBuscar);
            this.tbpgMostrarUsuarios.Location = new System.Drawing.Point(4, 31);
            this.tbpgMostrarUsuarios.Name = "tbpgMostrarUsuarios";
            this.tbpgMostrarUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgMostrarUsuarios.Size = new System.Drawing.Size(766, 727);
            this.tbpgMostrarUsuarios.TabIndex = 0;
            this.tbpgMostrarUsuarios.Text = "Mostrar usuarios";
            this.tbpgMostrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // paneBotones
            // 
            this.paneBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBotones.Controls.Add(this.btnEliminar);
            this.paneBotones.Controls.Add(this.btnCerrar);
            this.paneBotones.Controls.Add(this.btnAceptar);
            this.paneBotones.Controls.Add(this.btnCancelar);
            this.paneBotones.Location = new System.Drawing.Point(18, 577);
            this.paneBotones.Name = "paneBotones";
            this.paneBotones.Size = new System.Drawing.Size(723, 84);
            this.paneBotones.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(377, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 43);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(551, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(119, 43);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(37, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 43);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(195, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 43);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // paneDatos
            // 
            this.paneDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneDatos.Controls.Add(this.txtUsuario);
            this.paneDatos.Controls.Add(this.lblNombre);
            this.paneDatos.Controls.Add(this.lblCorreo);
            this.paneDatos.Controls.Add(this.txtCorreo);
            this.paneDatos.Controls.Add(this.lblAntiguedad);
            this.paneDatos.Controls.Add(this.txtTiempoSuscripto);
            this.paneDatos.Controls.Add(this.lblDeportesFavoritos);
            this.paneDatos.Controls.Add(this.cmboxDeportesFavoritos);
            this.paneDatos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.paneDatos.Location = new System.Drawing.Point(19, 129);
            this.paneDatos.Name = "paneDatos";
            this.paneDatos.Size = new System.Drawing.Size(705, 442);
            this.paneDatos.TabIndex = 13;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(338, 63);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(268, 27);
            this.txtUsuario.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(54, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(151, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de usuario: ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(54, 136);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(145, 22);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(338, 133);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(268, 27);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(54, 205);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(131, 22);
            this.lblAntiguedad.TabIndex = 4;
            this.lblAntiguedad.Text = "Tiempo suscripto";
            // 
            // txtTiempoSuscripto
            // 
            this.txtTiempoSuscripto.Location = new System.Drawing.Point(338, 202);
            this.txtTiempoSuscripto.Name = "txtTiempoSuscripto";
            this.txtTiempoSuscripto.Size = new System.Drawing.Size(268, 27);
            this.txtTiempoSuscripto.TabIndex = 8;
            // 
            // lblDeportesFavoritos
            // 
            this.lblDeportesFavoritos.AutoSize = true;
            this.lblDeportesFavoritos.Location = new System.Drawing.Point(54, 285);
            this.lblDeportesFavoritos.Name = "lblDeportesFavoritos";
            this.lblDeportesFavoritos.Size = new System.Drawing.Size(139, 22);
            this.lblDeportesFavoritos.TabIndex = 5;
            this.lblDeportesFavoritos.Text = "Deportes favoritos";
            // 
            // cmboxDeportesFavoritos
            // 
            this.cmboxDeportesFavoritos.FormattingEnabled = true;
            this.cmboxDeportesFavoritos.Location = new System.Drawing.Point(338, 282);
            this.cmboxDeportesFavoritos.Name = "cmboxDeportesFavoritos";
            this.cmboxDeportesFavoritos.Size = new System.Drawing.Size(268, 30);
            this.cmboxDeportesFavoritos.TabIndex = 7;
            // 
            // paneBuscar
            // 
            this.paneBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneBuscar.Controls.Add(this.lblIDusuario);
            this.paneBuscar.Controls.Add(this.cmboxIDusuarios);
            this.paneBuscar.Controls.Add(this.btnMostrar);
            this.paneBuscar.Location = new System.Drawing.Point(19, 23);
            this.paneBuscar.Name = "paneBuscar";
            this.paneBuscar.Size = new System.Drawing.Size(705, 100);
            this.paneBuscar.TabIndex = 12;
            // 
            // lblIDusuario
            // 
            this.lblIDusuario.AutoSize = true;
            this.lblIDusuario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblIDusuario.Location = new System.Drawing.Point(14, 26);
            this.lblIDusuario.Name = "lblIDusuario";
            this.lblIDusuario.Size = new System.Drawing.Size(90, 22);
            this.lblIDusuario.TabIndex = 0;
            this.lblIDusuario.Text = "ID usuario: ";
            // 
            // cmboxIDusuarios
            // 
            this.cmboxIDusuarios.FormattingEnabled = true;
            this.cmboxIDusuarios.Location = new System.Drawing.Point(272, 23);
            this.cmboxIDusuarios.Name = "cmboxIDusuarios";
            this.cmboxIDusuarios.Size = new System.Drawing.Size(331, 30);
            this.cmboxIDusuarios.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMostrar.Location = new System.Drawing.Point(124, 53);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(107, 32);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Buscar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // tbpgGestionarPublicidad
            // 
            this.tbpgGestionarPublicidad.Controls.Add(this.btnCerrar2);
            this.tbpgGestionarPublicidad.Controls.Add(this.paneEliminarPublicidad);
            this.tbpgGestionarPublicidad.Controls.Add(this.paneAniadirPublicidad);
            this.tbpgGestionarPublicidad.Location = new System.Drawing.Point(4, 31);
            this.tbpgGestionarPublicidad.Name = "tbpgGestionarPublicidad";
            this.tbpgGestionarPublicidad.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgGestionarPublicidad.Size = new System.Drawing.Size(766, 727);
            this.tbpgGestionarPublicidad.TabIndex = 2;
            this.tbpgGestionarPublicidad.Text = "Administrar publicidad";
            this.tbpgGestionarPublicidad.UseVisualStyleBackColor = true;
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrar2.Location = new System.Drawing.Point(300, 622);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(119, 43);
            this.btnCerrar2.TabIndex = 3;
            this.btnCerrar2.Text = "cerrar";
            this.btnCerrar2.UseVisualStyleBackColor = true;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // paneEliminarPublicidad
            // 
            this.paneEliminarPublicidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneEliminarPublicidad.Controls.Add(this.btnEliminarPublicidad);
            this.paneEliminarPublicidad.Controls.Add(this.cmboxUrl);
            this.paneEliminarPublicidad.Controls.Add(this.lblUrlEliminar);
            this.paneEliminarPublicidad.Location = new System.Drawing.Point(8, 332);
            this.paneEliminarPublicidad.Name = "paneEliminarPublicidad";
            this.paneEliminarPublicidad.Size = new System.Drawing.Size(727, 201);
            this.paneEliminarPublicidad.TabIndex = 1;
            // 
            // btnEliminarPublicidad
            // 
            this.btnEliminarPublicidad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPublicidad.Location = new System.Drawing.Point(202, 144);
            this.btnEliminarPublicidad.Name = "btnEliminarPublicidad";
            this.btnEliminarPublicidad.Size = new System.Drawing.Size(194, 40);
            this.btnEliminarPublicidad.TabIndex = 2;
            this.btnEliminarPublicidad.Text = "Eliminar Publicidad";
            this.btnEliminarPublicidad.UseVisualStyleBackColor = true;
            // 
            // cmboxUrl
            // 
            this.cmboxUrl.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmboxUrl.FormattingEnabled = true;
            this.cmboxUrl.Location = new System.Drawing.Point(263, 58);
            this.cmboxUrl.Name = "cmboxUrl";
            this.cmboxUrl.Size = new System.Drawing.Size(323, 30);
            this.cmboxUrl.TabIndex = 1;
            // 
            // lblUrlEliminar
            // 
            this.lblUrlEliminar.AutoSize = true;
            this.lblUrlEliminar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblUrlEliminar.Location = new System.Drawing.Point(38, 61);
            this.lblUrlEliminar.Name = "lblUrlEliminar";
            this.lblUrlEliminar.Size = new System.Drawing.Size(137, 22);
            this.lblUrlEliminar.TabIndex = 0;
            this.lblUrlEliminar.Text = "URL de publicidad";
            // 
            // paneAniadirPublicidad
            // 
            this.paneAniadirPublicidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneAniadirPublicidad.Controls.Add(this.txtURLpublicidad);
            this.paneAniadirPublicidad.Controls.Add(this.btnAgregarPublicidad);
            this.paneAniadirPublicidad.Controls.Add(this.lblUrl);
            this.paneAniadirPublicidad.Location = new System.Drawing.Point(8, 130);
            this.paneAniadirPublicidad.Name = "paneAniadirPublicidad";
            this.paneAniadirPublicidad.Size = new System.Drawing.Size(714, 161);
            this.paneAniadirPublicidad.TabIndex = 0;
            // 
            // txtURLpublicidad
            // 
            this.txtURLpublicidad.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtURLpublicidad.Location = new System.Drawing.Point(227, 40);
            this.txtURLpublicidad.Name = "txtURLpublicidad";
            this.txtURLpublicidad.Size = new System.Drawing.Size(456, 27);
            this.txtURLpublicidad.TabIndex = 2;
            // 
            // btnAgregarPublicidad
            // 
            this.btnAgregarPublicidad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPublicidad.Location = new System.Drawing.Point(226, 94);
            this.btnAgregarPublicidad.Name = "btnAgregarPublicidad";
            this.btnAgregarPublicidad.Size = new System.Drawing.Size(134, 47);
            this.btnAgregarPublicidad.TabIndex = 1;
            this.btnAgregarPublicidad.Text = "Agregar Publicidad";
            this.btnAgregarPublicidad.UseVisualStyleBackColor = true;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblUrl.Location = new System.Drawing.Point(23, 43);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(125, 22);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL publicidad: ";
            // 
            // GestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 769);
            this.Controls.Add(this.tbcGestionUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarUsuarios";
            this.Text = "GestionarUsuarios";
            this.tbcGestionUsuarios.ResumeLayout(false);
            this.tbpgMostrarUsuarios.ResumeLayout(false);
            this.paneBotones.ResumeLayout(false);
            this.paneDatos.ResumeLayout(false);
            this.paneDatos.PerformLayout();
            this.paneBuscar.ResumeLayout(false);
            this.paneBuscar.PerformLayout();
            this.tbpgGestionarPublicidad.ResumeLayout(false);
            this.paneEliminarPublicidad.ResumeLayout(false);
            this.paneEliminarPublicidad.PerformLayout();
            this.paneAniadirPublicidad.ResumeLayout(false);
            this.paneAniadirPublicidad.PerformLayout();
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
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTiempoSuscripto;
        private System.Windows.Forms.TabPage tbpgGestionarPublicidad;
        private System.Windows.Forms.Panel paneAniadirPublicidad;
        private System.Windows.Forms.Button btnAgregarPublicidad;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtURLpublicidad;
        private System.Windows.Forms.Panel paneEliminarPublicidad;
        private System.Windows.Forms.Button btnEliminarPublicidad;
        private System.Windows.Forms.ComboBox cmboxUrl;
        private System.Windows.Forms.Label lblUrlEliminar;
        private System.Windows.Forms.Panel paneBuscar;
        private System.Windows.Forms.Panel paneDatos;
        private System.Windows.Forms.Panel paneBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar2;
    }
}