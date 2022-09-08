﻿using System;
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
            txtID.Enabled = false;

            Usuario u = new Usuario();
            u.nombre = cmboxIDusuarios.Text;
            switch (Logica.BuscandoDatosUsuario(u)) {
                case 0:
                    paneDatos.Enabled = true;
                    txtCorreo.Text = u.correo;
                    txtRol.Text = u.rol.ToString();
                    txtUsuario.Text = u.nombre;
                    txtTiempoSuscripto.Text = u.mesesSuscritos.ToString();
                    txtID.Text = u.id.ToString();
                    deportesFavoritos(u.id);
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
        private void deportesFavoritos(int id) {
            List<string> lista = new List<string>();
            switch (Logica.averiguarDeportesFavoritos(id, lista))
            {
                case 0:
                    cmboxDeportesFavoritos.Items.Clear();
                    cmboxDeportesFavoritos.Text = lista[0];
                    foreach (string deporte in lista)
                    {
                        cmboxDeportesFavoritos.Items.Add(deporte);
                    }
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de conexión");
                    break;
                case 2:
                    MessageBox.Show("Ocurrió un error inesperado cargando deportes");
                    break;
            }
        }
        private void refrescarPublicidad()
        {
            List<string> lista = new List<string>();
            switch (Logica.listarTodaPublicidad(lista))
            {
                case 0:
                    cmboxUrl.Items.Clear();
                    cmboxUrl.Text = lista[0];
                    foreach (string url in lista)
                    {
                        cmboxUrl.Items.Add(url);
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
           try {
               
                u.nombre = txtUsuario.Text;
                u.correo = txtCorreo.Text;
                u.rol = Convert.ToInt32(txtRol.Text);
                u.id = Convert.ToInt32(txtID.Text);
                u.mesesSuscritos = Convert.ToInt32(txtTiempoSuscripto.Text);
            
            switch (Logica.actualizarUsuario(u))
            {
                case 0:
                    paneDatos.Enabled = false;
                    paneBuscar.Enabled = true;
                    MessageBox.Show("Usuario actualizado exitosamente");
                    txtCorreo.Text = null;
                    txtRol.Text = null;
                        txtID.Text = null;
                    txtTiempoSuscripto.Text = null;
                    txtUsuario.Text = null;
                    paneBuscar.Enabled = true;
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un error de conexión");
                    break;
                case 2:
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
            txtID.Text = null;
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
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                switch (Logica.eliminarUsuario(txtUsuario.Text, id))
                {
                    case 0:
                        refrescarUsuarios();
                        paneDatos.Enabled = false;
                        paneBuscar.Enabled = true;
                        txtCorreo.Text = null;
                        txtID.Text = null;
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
            catch {
                MessageBox.Show("ocurrió un error, intente nuevamente");
            }
           
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.nombre = txtUsuario.Text;
            u.correo = txtCorreo.Text;
            
            try
            {
                u.id = Convert.ToInt32(txtID.Text);
                u.mesesSuscritos = Convert.ToInt32(txtTiempoSuscripto.Text);
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
                        txtID.Text = null;
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
            txtID.Enabled = true;
            paneBuscar.Enabled = false;
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAgregarPublicidad_Click(object sender, EventArgs e)
        {
            string publicidad = txtURLpublicidad.Text;
            switch (Logica.AñadirPublicidad(publicidad)) {
                case 0:
                    MessageBox.Show("Publicidad añadida con éxito");
                    txtURLpublicidad.Text = null;
                    break;
                case 1:
                    MessageBox.Show("Error de conexión");
                    break;
                case 2:
                    MessageBox.Show("Error inesperado");
                    break;
            }
        }

        private void btnRefrescarPublicidad_Click(object sender, EventArgs e)
        {
            refrescarPublicidad();
        }

        private void btnEliminarPublicidad_Click(object sender, EventArgs e)
        {
            switch (Logica.eliminarPublicidad(cmboxUrl.Text))
            {
                case 0:
                    refrescarPublicidad();
                    paneBuscar.Enabled = true;
                    MessageBox.Show("publicidad eliminada con éxito");
                    break;
                case 1:
                    MessageBox.Show("Ocurrió un problema de conexión");
                    break;
                case 2:
                    MessageBox.Show("Error eliminando usuario");
                    break;
            }
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {

            string correo = txtCorreo.Text;
            if (correo != null)
            {
                if (correo.Contains(".com") && correo.Contains("@"))
                {
                    string titulo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el titulo del correo: ", "Titulo del correo");
                    string cuerpo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el cuerpo del correo: ", "Cuerpo del correo", "Gracias por usar nuestros servicios, le daremos el próximo mes 100% gratis");
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("Titulo: " + titulo + "\n" + "Contenido: " + cuerpo, "Previsualizacion del cooreo", MessageBoxButtons.OKCancel);
                    if (respuesta == DialogResult.OK)
                    {
                        Mensajeria.sendCorreo2(correo, titulo, cuerpo);
                    }
                    else
                    {
                    }


                }//del primer if
                else
                {
                    MessageBox.Show("Correo no válido");
                }
            }
            else {
                MessageBox.Show("No seleccionó ningún correo o el usuario no lo tiene");

            }
        }
    }
}
