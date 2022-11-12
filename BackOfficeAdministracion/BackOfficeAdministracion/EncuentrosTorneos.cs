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
    public partial class EncuentrosTorneos : Form
    {
        public EncuentrosTorneos()
        {
            InitializeComponent();
        }
        EncuentrosColectivos encuentros = new EncuentrosColectivos();
        //Primer Panel
	public void tema(Color fondo, Color letra, Color casilla, Color boton)
        {

            this.BackColor = fondo;
            paneFiltro.BackColor = fondo;
            lblFiltro.ForeColor = letra;
            cmboxDeportes.BackColor = casilla;
            btnRefrescar.BackColor = boton;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.FlatAppearance.BorderColor = boton;
            btnRefrescar.ForeColor = letra;
            btnVerCargados.BackColor = boton;
            btnVerCargados.FlatStyle = FlatStyle.Flat;
            btnVerCargados.ForeColor = letra;
            btnFiltrar.BackColor = boton;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.FlatAppearance.BorderColor = boton;
            btnFiltrar.ForeColor = letra;

            //Segundo Panel
            paneEncuentros.BackColor = fondo;
            lblNombreEncuentro.ForeColor = letra;
            cmboxEncuentros.BackColor = casilla;
            cmboxEncuentros.ForeColor = letra;
            lblFechaComienzo.ForeColor = letra;
            lblHoraFinaliza.ForeColor = letra;
            lblEquiposEnEncuentro.ForeColor = letra;
            btnAgregar.BackColor = boton;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderColor = boton;
            btnAgregar.ForeColor = letra;
            btnQuitar.BackColor = boton;
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.FlatAppearance.BorderColor = boton;
            btnQuitar.ForeColor = letra;
            btnVolver.BackColor = boton;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.FlatAppearance.BorderColor = boton;
            btnVolver.ForeColor = letra;
        }


        private void EncuentrosTorneos_Load(object sender, EventArgs e)
        {

        }
        public void filtrar()
        {
            try
            {
                string deporteTorneo = cmboxDeportes.Text;
                List<string> encuentros = new List<string>();
                switch (Logica.datosEncuentrosDisponibles(GestionarTorneos.torneosColectivos.idTorneo, encuentros, deporteTorneo))
                {
                    case 0:
                        cmboxEncuentros.Items.Clear();
                        cmboxEncuentros.Text = null;
                        foreach (string nombre in encuentros)
                        {
                            cmboxEncuentros.Items.Add(nombre);
                        }
                        cmboxEncuentros.Text = encuentros[0];
                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 3:
                        MessageBox.Show(Idiomas.noEventosAvailbale);
                        break;
                }
            }
            catch
            {
                MessageBox.Show(Idiomas.noEventosAvailbaleCONDEPORTE);
            }
        }
        public void refrescarDatosEvento()
        {
            try
            {
                int id = 0;
                if (int.TryParse(cmboxEncuentros.Text.Substring(3, (cmboxEncuentros.Text.IndexOf(" ") - 3)), out id))
                {
                    txtHoraFinaliza.Text = null;
                    txtFechaComienzo.Text = null;
                    cmboxEquiposDeEncuentros.Items.Clear();
                    encuentros.idEncuentro = id;
                    List<string> equiposEncuentro = new List<string>();
                    switch (Logica.DatosEncuentrosColectivos(encuentros, equiposEncuentro))
                    {
                        case 0:
                            btnAgregar.Enabled = true;
                            txtFechaComienzo.Text = encuentros.fechaComienzo.ToString();
                            txtHoraFinaliza.Text = encuentros.fechaFinaliza.ToString();
                            cmboxEquiposDeEncuentros.Text = null;
                            cmboxEquiposDeEncuentros.Items.Clear();
                            foreach (string nombreEquipo in equiposEncuentro)
                            {
                                cmboxEquiposDeEncuentros.Items.Add(nombreEquipo);
                            }
                            cmboxEquiposDeEncuentros.Text = equiposEncuentro[0];
                            break;
                        case 1:
                            MessageBox.Show(Idiomas.errordeConexion);
                            break;
                        case 2:
                            MessageBox.Show(Idiomas.errorInesperado);
                            break;
                        case 5:
                            btnAgregar.Enabled = false;
                            cmboxEquiposDeEncuentros.Text = null;
                            MessageBox.Show(Idiomas.EventosNOTIENEequipos);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                }
            }
            catch
            {
                MessageBox.Show(Idiomas.errorInesperadoCoherente);
            }
        }
        public void eventosEnTorneo()
        {
            try
            {
                List<string> encuentros = new List<string>();
                switch (Logica.datosEncuentrosenTorneo(GestionarTorneos.torneosColectivos.idTorneo, encuentros))
                {
                    case 0:
                        cmboxEncuentros.Items.Clear();
                        cmboxEncuentros.Text = null;
                        foreach (string nombre in encuentros)
                        {
                            cmboxEncuentros.Items.Add(nombre);
                        }
                        cmboxEncuentros.Text = encuentros[0];
                        btnQuitar.Enabled = true;
                        btnAgregar.Enabled = false;
                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperadoCoherente);
                        break;
                    case 3:
                        MessageBox.Show(Idiomas.torneoNotieneEncuentros);
                        break;
                }
            }
            catch
            {
                MessageBox.Show(Idiomas.torneoNotieneEncuentros);
            }
        }


        private void btnRefrescar_Click(object sender, EventArgs e)
        {

            List<string> lista = new List<string>();
            switch (Logica.nombresDeportes(lista))
            {
                case 0:
                    cmboxDeportes.Items.Clear();
                    foreach (string nombre in lista)
                    {
                        cmboxDeportes.Items.Add(nombre);
                    }
                    cmboxDeportes.Text = lista[0];
                    btnQuitar.Enabled = false;

                    break;
                case 1:
                    MessageBox.Show(Idiomas.errorInesperado);
                    break;
                case 2:
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                    break;
                case 3:
                    MessageBox.Show(Idiomas.noDeportesSistema);
                    break;
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.filtrar();
            btnQuitar.Enabled = false;
        }

        private void cmboxEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescarDatosEvento();
        }

        private void btnVerCargados_Click(object sender, EventArgs e)
        {
            eventosEnTorneo();
            refrescarDatosEvento();
            btnAgregar.Enabled = false;
        }

        private void cmboxEquiposDeEncuentros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void paneEncuentros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.frmPrincipal.Enabled = true;
            this.Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
           try {
                int id = 0;
                if (int.TryParse(cmboxEncuentros.Text.Substring(3, (cmboxEncuentros.Text.IndexOf(" ") - 3)), out id))
                {
                    switch (Logica.insertarEventoenTorneo(GestionarTorneos.torneosColectivos.idTorneo, GestionarTorneos.torneosColectivos.idDeporteTorneo, id))
                    {
                        case 0:
                            MessageBox.Show(Idiomas.eventoAnadido);
                            txtFechaComienzo.Text = null;
                            txtHoraFinaliza.Text = null;
                            cmboxEquiposDeEncuentros.Text = null;
                            cmboxEquiposDeEncuentros.Items.Clear();
                            this.filtrar();
                            break;
                        case 1:
                            MessageBox.Show(Idiomas.errordeConexion);
                            break;
                        case 2:
                            MessageBox.Show(Idiomas.errorInesperado);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(Idiomas.errorInesperadoCoherente);
                }
             }
              catch {
                  MessageBox.Show(Idiomas.errorInesperadoCoherente);
             }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try { 
            int id = 0;
            if (int.TryParse(cmboxEncuentros.Text.Substring(3, (cmboxEncuentros.Text.IndexOf(" ") - 3)), out id))
            {
                switch (Logica.EliminarEventoenTorneo(GestionarTorneos.torneosColectivos.idTorneo, GestionarTorneos.torneosColectivos.idDeporteTorneo, id))
                {
                    case 0:
                        MessageBox.Show(Idiomas.encuentroEliminadoTorneo);
                        txtFechaComienzo.Text = null;
                        txtHoraFinaliza.Text = null;
                        cmboxEquiposDeEncuentros.Text = null;
                        cmboxEquiposDeEncuentros.Items.Clear();
                        this.eventosEnTorneo();
                        refrescarDatosEvento();

                        break;
                    case 1:
                        MessageBox.Show(Idiomas.errordeConexion);
                        break;
                    case 2:
                        MessageBox.Show(Idiomas.errorInesperadoCoherente);
                        break;
                }
            }
            else
            {
                MessageBox.Show(Idiomas.errorInesperadoCoherente);
            }
            }catch
            {
                MessageBox.Show(Idiomas.errorInesperadoCoherente);
            }
        }
    }
}
