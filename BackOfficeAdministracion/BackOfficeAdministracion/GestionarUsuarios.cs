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

        public void tema(Color fondo, Color letra, Color casilla, Color boton)
        {

            this.BackColor = fondo;

            //Mostrar usuarios
            tbpgMostrarUsuarios.BackColor = fondo;
            paneBuscar.BackColor = fondo;
            paneDatos.BackColor = fondo;
            paneBotones.BackColor = fondo;

            lblIdUsu.ForeColor = letra;
            lblIdUsu.ForeColor = letra;
            lblNombre.ForeColor = letra;
            lblCorreo.ForeColor = letra;
            lblAntiguedad.ForeColor = letra;
            lblDeportesFavoritos.ForeColor = letra;
            lblRol.ForeColor = letra;

            btnMostrar.BackColor = boton;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.FlatAppearance.BorderColor = boton;
            btnMostrar.ForeColor = letra;
            btnRefrescar.BackColor = boton;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.FlatAppearance.BorderColor = boton;
            btnRefrescar.ForeColor = letra;
            btnAceptar.BackColor = boton;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.FlatAppearance.BorderColor = boton;
            btnAceptar.ForeColor = letra;
            btnCancelar.BackColor = boton;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderColor = boton;
            btnCancelar.ForeColor = letra;
            btnEliminar.BackColor = boton;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderColor = boton;
            btnEliminar.ForeColor = letra;
            btnCerrar.BackColor = boton;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderColor = boton;
            btnCerrar.ForeColor = letra;
            btnCrearUsuario.BackColor = boton;
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.FlatAppearance.BorderColor = boton;
            btnCrearUsuario.ForeColor = letra;
            btnEnviarCorreo.BackColor = boton;
            btnEnviarCorreo.FlatStyle = FlatStyle.Flat;
            btnEnviarCorreo.FlatAppearance.BorderColor = boton;
            btnEnviarCorreo.ForeColor = letra;

            //Administrar publicidad

            tbpgGestionarPublicidad.BackColor = fondo;
            paneAniadirPublicidad.BackColor = fondo;
            paneEliminarPublicidad.BackColor = fondo;
            paneVerPublicidad.BackColor = fondo;

            lblUrl.ForeColor = letra;
            lblUrlEliminar.ForeColor = letra;
            lblAsignarURL.ForeColor = letra;
            lblAsignarUsuario.ForeColor = letra;

            btnAgregarPublicidad.BackColor = boton;
            btnAgregarPublicidad.FlatStyle = FlatStyle.Flat;
            btnAgregarPublicidad.FlatAppearance.BorderColor = boton;
            btnAgregarPublicidad.ForeColor = letra;
            btnEliminarPublicidad.BackColor = boton;
            btnEliminarPublicidad.FlatStyle = FlatStyle.Flat;
            btnEliminarPublicidad.FlatAppearance.BorderColor = boton;
            btnEliminarPublicidad.ForeColor = letra;
            btnRefrescarPublicidad.BackColor = boton;
            btnRefrescarPublicidad.FlatStyle = FlatStyle.Flat;
            btnRefrescarPublicidad.FlatAppearance.BorderColor = boton;
            btnRefrescarPublicidad.ForeColor = letra;
            btnAsignar.BackColor = boton;
            btnAsignar.FlatStyle = FlatStyle.Flat;
            btnAsignar.FlatAppearance.BorderColor = boton;
            btnAsignar.ForeColor = letra;
            btnCerrar2.BackColor = boton;
            btnCerrar2.FlatStyle = FlatStyle.Flat;
            btnCerrar2.FlatAppearance.BorderColor = boton;
            btnCerrar2.ForeColor = letra;
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
            bool bandera = true;
            int random = 0;
            Random r = new Random();
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
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCrearUsuario.Enabled = false;
                    btnEnviarCorreo.Enabled = true;
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    paneBuscar.Enabled = true;

                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    paneBuscar.Enabled = true;
                    break;
                case 3:
                    switch (Logica.BuscandoUsuarioGuest(u.nombre)) {
                        case 0:// el usuario es guest 
                            DialogResult eliminarGuest = MessageBox.Show(Idiomas.usuarioERAGUEST, Idiomas.titulosBorrarUsuario, MessageBoxButtons.YesNo);
                            if (eliminarGuest == DialogResult.Yes)
                            {
                                switch (Logica.eliminarUsuarioGuest(u.nombre)) {
                                    case 0:
                                        MessageBox.Show(Idiomas.usuarioEliminado);
                                        this.refrescarUsuarios();
                                        break;
                                    case 1:
                                        MessageBox.Show(Idiomas.errordeConexion);
                                        break;
                                    case 2:
                                        MessageBox.Show(Idiomas.errorInesperado);
                                        break;
                                    case 3:
                                        MessageBox.Show(Idiomas.usuarioEliminado);
                                        break;
                                }                  
                            }
                            else
                            {
                                
                            }


                            break;
                        case 1:
                            MessageBox.Show(Idiomas.errordeConexion);
                            break;
                        case 2:
                            MessageBox.Show(Idiomas.errorInesperado);
                            break;
                        case 3:
                            DialogResult crearUsuario = MessageBox.Show(Idiomas.crearUsuario, Idiomas.titulosCrearUsuario , MessageBoxButtons.YesNo);
                            if (crearUsuario == DialogResult.Yes)
                            {
                                paneDatos.Enabled = true;
                                txtUsuario.Enabled = false;
                                while (bandera == true)
                                {
                                    random = r.Next();
                                    switch (Logica.BuscarID(random))
                                    {
                                        case 0:
                                            break;
                                        case 1:
                                        case 2:
                                            MessageBox.Show(Idiomas.errorInesperado);
                                            break;
                                        case 3:
                                            bandera = false;
                                            break;
                                    }
                                }//comentario
                                btnCrearUsuario.Enabled = true;
                                txtUsuario.Text = cmboxIDusuarios.Text;
                                txtID.Text = random.ToString();
                                txtID.Enabled = false;
                                paneBuscar.Enabled = false;
                                btnAceptar.Enabled = false;
                                btnEliminar.Enabled = false;
                            }
                            else
                            {

                            }
                            break;
                    }
                    
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
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
            }
        }
        private void deportesFavoritos(int id) {
            List<string> lista = new List<string>();
            switch (Logica.averiguarDeportesFavoritos(id, lista))
            {
                case 0:
                    cmboxDeportesFavoritos.Items.Clear();
                    foreach (string deporte in lista)
                    {
                        cmboxDeportesFavoritos.Items.Add(deporte);
                    }
                    cmboxDeportesFavoritos.Text = lista[0];
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
            }
        }
        private void refrescarPublicidad()
        {
          //  try
          //  {
                List<string> lista = new List<string>();
                switch (Logica.listarTodaPublicidad(lista))
                {
                    case 0:
                        cmboxUrl.Items.Clear();
                        foreach (string url in lista)
                        {
                            cmboxUrl.Items.Add(url);
                        }
                        cmboxUrl.Text = lista[0];

                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperado);
                        break;
                }
            //}
            //catch {
            //    MessageBox.Show("No hay publicidad");
         //  }
        }
        private void refrescarPublicidad2()
        {
            List<string> lista = new List<string>();
            switch (Logica.listarTodaPublicidad(lista))
            {
                case 0:
                    cmboxURLasignar.Items.Clear();
                    foreach (string url in lista)
                    {
                        cmboxURLasignar.Items.Add(url);
                    }
                    cmboxURLasignar.Text = lista[0];

                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
            }
        }
        private void refrescarUsuariosGUEST()
        {
            try
            {
                List<string> lista = new List<string>();
                switch (Logica.listarTodosUsuariosGUEST(lista))
                {
                    case 0:
                        cmboxGuestaAsignar.Items.Clear();
                        foreach (string url in lista)
                        {
                            cmboxGuestaAsignar.Items.Add(url);
                        }
                        cmboxGuestaAsignar.Text = lista[0];

                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperado);
                        break;
                }
            }
            catch {
                MessageBox.Show("No se encontraron usuarios Guest");
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
                    MessageBox.Show(Idiomas.usuarioActualizado);
                    txtCorreo.Text = null;
                    txtRol.Text = null;
                        txtID.Text = null;
                    txtTiempoSuscripto.Text = null;
                    txtUsuario.Text = null;
                    paneBuscar.Enabled = true;
                        btnCrearUsuario.Enabled = false;
                        btnAceptar.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnEnviarCorreo.Enabled = false;
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
            }
            }
            catch
            {
                MessageBox.Show(Idiomas.datosNovalidos);
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
            cmboxDeportesFavoritos.Items.Clear();
            paneBuscar.Enabled = true;
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEnviarCorreo.Enabled = false;
            btnCrearUsuario.Enabled = false;
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
                        btnEnviarCorreo.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnAceptar.Enabled = false;
                        btnCrearUsuario.Enabled = false;
                        MessageBox.Show(Idiomas.usuarioEliminado);
                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperado);
                        break;
                }
            }
            catch {
                MessageBox.Show(Idiomas.errorInesperado);
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
                        MessageBox.Show(Idiomas.usuarioCreado);
                        refrescarUsuarios();
                        paneDatos.Enabled = false;
                        txtUsuario.Enabled = false;
                        paneBuscar.Enabled = true;
                        btnEnviarCorreo.Enabled = false;
                        btnCrearUsuario.Enabled = false;
                        btnAceptar.Enabled = false;
                        btnEliminar.Enabled = false;
                        txtCorreo.Text = null;
                        txtID.Text = null;
                        txtRol.Text = null;
                        txtTiempoSuscripto.Text = null;
                        txtUsuario.Text = null;
                        cmboxDeportesFavoritos.Items.Clear();
                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperado);
                        break;
                    case 3:
                        MessageBox.Show(Idiomas.correoEnUSo);
                        break;
                }
            }
            catch {
                MessageBox.Show(Idiomas.datosNovalidos);
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

        /**
         * 
         *  paneDatos.Enabled = true;
            txtUsuario.Enabled = true;
            txtID.Enabled = true;
            paneBuscar.Enabled = false;
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = false;
         * 
         * 
         * 
         * 
         * 
         * */




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
            refrescarUsuariosGUEST();
            this.refrescarPublicidad2();
        }

        private void btnEliminarPublicidad_Click(object sender, EventArgs e)
        {
            switch (Logica.eliminarPublicidad(cmboxUrl.Text))
            {
                case 0:
                    refrescarPublicidad();
                    paneBuscar.Enabled = true;
                    MessageBox.Show(Idiomas.publicidadAnanida);
                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreAutogen = cmboxGuestaAsignar.Text;
            string url = cmboxURLasignar.Text;
            switch (Logica.asignarPublicidad(nombreAutogen, url)) {
                case 0:
                    MessageBox.Show(Idiomas.publicidadAnanida);

                    break;
                case 1:
                    MessageBox.Show(Idiomas.errordeConexion);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
            }
        }
    }
}
