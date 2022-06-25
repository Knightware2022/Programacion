namespace BackOffice
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
            this.tbpgGestionarUsuarios = new System.Windows.Forms.TabControl();
            this.tbpgMostrar = new System.Windows.Forms.TabPage();
            this.cmboxDeportesFavoritos = new System.Windows.Forms.ComboBox();
            this.lblDeportesFavoritos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmboxIDs = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtTiempoSuscripto = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbpgEliminar = new System.Windows.Forms.TabPage();
            this.paneEliminar = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDusuario = new System.Windows.Forms.Label();
            this.tbpgGestionarUsuarios.SuspendLayout();
            this.tbpgMostrar.SuspendLayout();
            this.tbpgEliminar.SuspendLayout();
            this.paneEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpgGestionarUsuarios
            // 
            this.tbpgGestionarUsuarios.Controls.Add(this.tbpgMostrar);
            this.tbpgGestionarUsuarios.Controls.Add(this.tbpgEliminar);
            this.tbpgGestionarUsuarios.Location = new System.Drawing.Point(1, 0);
            this.tbpgGestionarUsuarios.Name = "tbpgGestionarUsuarios";
            this.tbpgGestionarUsuarios.SelectedIndex = 0;
            this.tbpgGestionarUsuarios.Size = new System.Drawing.Size(748, 558);
            this.tbpgGestionarUsuarios.TabIndex = 0;
            // 
            // tbpgMostrar
            // 
            this.tbpgMostrar.Controls.Add(this.cmboxDeportesFavoritos);
            this.tbpgMostrar.Controls.Add(this.lblDeportesFavoritos);
            this.tbpgMostrar.Controls.Add(this.btnBuscar);
            this.tbpgMostrar.Controls.Add(this.cmboxIDs);
            this.tbpgMostrar.Controls.Add(this.lblId);
            this.tbpgMostrar.Controls.Add(this.txtTiempoSuscripto);
            this.tbpgMostrar.Controls.Add(this.lblTiempo);
            this.tbpgMostrar.Controls.Add(this.txtCorreo);
            this.tbpgMostrar.Controls.Add(this.lblCorreo);
            this.tbpgMostrar.Controls.Add(this.txtNombre);
            this.tbpgMostrar.Controls.Add(this.lblNombre);
            this.tbpgMostrar.Location = new System.Drawing.Point(4, 29);
            this.tbpgMostrar.Name = "tbpgMostrar";
            this.tbpgMostrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgMostrar.Size = new System.Drawing.Size(740, 525);
            this.tbpgMostrar.TabIndex = 0;
            this.tbpgMostrar.Text = "Mostrar Usuarios";
            this.tbpgMostrar.UseVisualStyleBackColor = true;
            // 
            // cmboxDeportesFavoritos
            // 
            this.cmboxDeportesFavoritos.FormattingEnabled = true;
            this.cmboxDeportesFavoritos.Location = new System.Drawing.Point(356, 416);
            this.cmboxDeportesFavoritos.Name = "cmboxDeportesFavoritos";
            this.cmboxDeportesFavoritos.Size = new System.Drawing.Size(240, 28);
            this.cmboxDeportesFavoritos.TabIndex = 10;
            // 
            // lblDeportesFavoritos
            // 
            this.lblDeportesFavoritos.AutoSize = true;
            this.lblDeportesFavoritos.Location = new System.Drawing.Point(79, 419);
            this.lblDeportesFavoritos.Name = "lblDeportesFavoritos";
            this.lblDeportesFavoritos.Size = new System.Drawing.Size(133, 20);
            this.lblDeportesFavoritos.TabIndex = 9;
            this.lblDeportesFavoritos.Text = "Deportes Favoritos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(233, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmboxIDs
            // 
            this.cmboxIDs.FormattingEnabled = true;
            this.cmboxIDs.Location = new System.Drawing.Point(356, 54);
            this.cmboxIDs.Name = "cmboxIDs";
            this.cmboxIDs.Size = new System.Drawing.Size(240, 28);
            this.cmboxIDs.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(79, 57);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 20);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID usuario: ";
            // 
            // txtTiempoSuscripto
            // 
            this.txtTiempoSuscripto.Location = new System.Drawing.Point(356, 345);
            this.txtTiempoSuscripto.Name = "txtTiempoSuscripto";
            this.txtTiempoSuscripto.Size = new System.Drawing.Size(240, 27);
            this.txtTiempoSuscripto.TabIndex = 5;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(79, 348);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(139, 20);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempo subscripto: ";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(356, 270);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(240, 27);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(79, 277);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(139, 20);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo electronico: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(356, 204);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(79, 204);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(140, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de usuario:";
            // 
            // tbpgEliminar
            // 
            this.tbpgEliminar.Controls.Add(this.paneEliminar);
            this.tbpgEliminar.Location = new System.Drawing.Point(4, 29);
            this.tbpgEliminar.Name = "tbpgEliminar";
            this.tbpgEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgEliminar.Size = new System.Drawing.Size(740, 525);
            this.tbpgEliminar.TabIndex = 1;
            this.tbpgEliminar.Text = "Eliminar Usuario";
            this.tbpgEliminar.UseVisualStyleBackColor = true;
            // 
            // paneEliminar
            // 
            this.paneEliminar.Controls.Add(this.btnEliminar);
            this.paneEliminar.Controls.Add(this.txtID);
            this.paneEliminar.Controls.Add(this.lblIDusuario);
            this.paneEliminar.Location = new System.Drawing.Point(6, 147);
            this.paneEliminar.Name = "paneEliminar";
            this.paneEliminar.Size = new System.Drawing.Size(728, 189);
            this.paneEliminar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(221, 118);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 29);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(322, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(314, 27);
            this.txtID.TabIndex = 1;
            // 
            // lblIDusuario
            // 
            this.lblIDusuario.AutoSize = true;
            this.lblIDusuario.Location = new System.Drawing.Point(63, 47);
            this.lblIDusuario.Name = "lblIDusuario";
            this.lblIDusuario.Size = new System.Drawing.Size(174, 20);
            this.lblIDusuario.TabIndex = 0;
            this.lblIDusuario.Text = "ID de usuario a eliminar: ";
            // 
            // GestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 554);
            this.Controls.Add(this.tbpgGestionarUsuarios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionarUsuarios";
            this.ShowInTaskbar = false;
            this.Text = "GestionarUsuarios";
            this.tbpgGestionarUsuarios.ResumeLayout(false);
            this.tbpgMostrar.ResumeLayout(false);
            this.tbpgMostrar.PerformLayout();
            this.tbpgEliminar.ResumeLayout(false);
            this.paneEliminar.ResumeLayout(false);
            this.paneEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbpgGestionarUsuarios;
        private TabPage tbpgMostrar;
        private TabPage tbpgEliminar;
        private Label lblCorreo;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtTiempoSuscripto;
        private Label lblTiempo;
        private TextBox txtCorreo;
        private ComboBox cmboxIDs;
        private Label lblId;
        private Button btnBuscar;
        private ComboBox cmboxDeportesFavoritos;
        private Label lblDeportesFavoritos;
        private Label lblIDusuario;
        private Panel paneEliminar;
        private Button btnEliminar;
        private TextBox txtID;
    }
}