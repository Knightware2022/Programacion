using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeAdministracion
{
    public partial class GestionarUsuarios : Form
    {
        public GestionarUsuarios()
        {
            InitializeComponent();
        }
        private void cerrar() {
            this.Hide();
            Program.frmPrincipal.paneVista.Show();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            paneBuscar.Enabled = false;
            txtUsuario.Enabled = false;
            Usuario u = new Usuario();
            u.nombre = cmboxIDusuarios.Text;
            switch (Logica.BuscandoDatosUsuario(u)) {
                case 0:
                    paneDatos.Enabled = true;
                    txtCorreo.Text = u.correo;
                    txtRol.Text = u.rol.ToString();
                    txtUsuario.Text = u.nombre;
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de conexión");
                    paneBuscar.Enabled = true;

                    break;
                case 2:
                case 3:
                    MessageBox.Show("Ocurrió un error inesperado");
                    paneBuscar.Enabled = true;

                    break;
            }
            
        }
        private void refrescarUsuarios()
        {
            List<string> lista = new List<string>();
            switch (Logica.listarTodosUsuarios(lista))
            {
                case 0:
                    cmboxIDusuarios.Items.Clear();
                    cmboxIDusuarios.Text = lista[0];
                    foreach (string tel in lista)
                    {
                        cmboxIDusuarios.Items.Add(tel);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de conexión");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            refrescarUsuarios();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            try
            {
                u.nombre = txtUsuario.Text;
                u.correo = txtCorreo.Text;
                u.rol = Convert.ToInt32(txtRol.Text);
            
            
            switch (Logica.actualizarUsuario(u))
            {
                case 0:
                    paneDatos.Enabled = false;
                    paneBuscar.Enabled = true;
                    MessageBox.Show("Usuario actualizado exitosamente");
                    txtCorreo.Text = null;
                    txtRol.Text = null;
                    txtTiempoSuscripto.Text = null;
                    txtUsuario.Text = null;
                    paneBuscar.Enabled = true;
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de conexión");
                    break;
                case 2:
                case 3:
                    MessageBox.Show("Ocurrió un error inesperado");
                    break;
            }
            }
            catch
            {
                MessageBox.Show("Datos no válidos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            paneDatos.Enabled = false;
            txtCorreo.Text = null;
            txtRol.Text = null;
            txtTiempoSuscripto.Text = null;
            txtUsuario.Text = null;
            paneBuscar.Enabled = true;
            btnAceptar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void GestionarUsuarios_Load(object sender, EventArgs e)
        {
            paneDatos.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (Logica.eliminarUsuario(txtUsuario.Text)) {
                case 0:
                    refrescarUsuarios();
                    paneDatos.Enabled = false;
                    paneBuscar.Enabled = true;
                    txtCorreo.Text = null;
                    txtRol.Text = null;
                    txtTiempoSuscripto.Text = null;
                    txtUsuario.Text = null;
                    cmboxDeportesFavoritos.Items.Clear();
                    paneBuscar.Enabled = true;
                    MessageBox.Show("usuario eliminado con éxito");
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un problema de conexión");
                    break;
                case 2:
                    MessageBox.Show("Error eliminando usuario");
                    break;
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.nombre = txtUsuario.Text;
            u.correo = txtCorreo.Text;
            try
            {
                u.rol = Convert.ToInt32(txtRol.Text);
                switch (Logica.crearUsuario(u)) {
                    case 0:
                        MessageBox.Show("Usuario creado con éxito");
                        refrescarUsuarios();
                        paneDatos.Enabled = false;
                        txtUsuario.Enabled = false;
                        paneBuscar.Enabled = true;
                        btnAceptar.Enabled = true;
                        btnEliminar.Enabled = true;
                        txtCorreo.Text = null;
                        txtRol.Text = null;
                        txtTiempoSuscripto.Text = null;
                        txtUsuario.Text = null;
                        cmboxDeportesFavoritos.Items.Clear();
                        break;
                    case 1:
                        MessageBox.Show("Error de conexión");
                        break;
                    case 2:
                        MessageBox.Show("Ocurrió un error");
                        break;
                }
            }
            catch {
                MessageBox.Show("Datos no validos");
            }
            
        }

        private void crearU_Click(object sender, EventArgs e)
        {
            paneDatos.Enabled = true;
            txtUsuario.Enabled = true;
            paneBuscar.Enabled = false;
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
