using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoSeguridad
{
    public partial class Servicios_Medicos : Form
    {
        public Servicios_Medicos()
        {
            InitializeComponent();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login2 us = new Login2();

            us.MdiParent = this;
            us.Show();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transaccionalDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista_trans_cliente newMDIChild = new Vista_trans_cliente();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void alergiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista_alergias newMDIChild = new Vista_alergias();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void enfermedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista_enfermedades newMDIChild = new Vista_enfermedades();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista_paciente newMDIChild = new Vista_paciente();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void transaccionalDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tran_Proveedores newMDIChild = new Tran_Proveedores();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores newMDIChild = new Proveedores();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\kimbe\\Desktop\\Servicios Medicos - Copy\\Servicios-Medico-Oficial\\Ayuda\\ManualUsuarioMantenimientos.chm");
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaDoctores newMDIChild = new VistaDoctores();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void inventarioDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaInvEquipo newMDIChild = new VistaInvEquipo();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection formulariosApp = Application.OpenForms;
            foreach (Form f in formulariosApp)
            {
                if (f.Name != "frmLogin")
                {
                    f.Hide();
                }
            }
            Login login = new Login();
            login.Show();
        }
    }
}
