using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace PrototipoSeguridad
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=servidor_seguridad; UID=root; PWD=;";
                string Query = "select * from proveedores ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_proveedores.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MantenimientoProveedores mov = new MantenimientoProveedores();
            mov.MdiParent = this.MdiParent;

            int cod1;
            string MyConnection3 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

            string Query2 = "Select idProveedores from proveedores order by idProveedores DESC LIMIT 1;";
            OdbcConnection MyConn3 = new OdbcConnection(MyConnection3);
            OdbcCommand MyCommand3 = new OdbcCommand(Query2, MyConn3);
            MyConn3.Open();
            OdbcDataReader myreader3;
            myreader3 = MyCommand3.ExecuteReader();
            if (myreader3.Read())
            {
                cod1 = (int)myreader3["idProveedores"];
                int cod2 = cod1 + 1;

                mov.label9.Text = cod2.ToString();
                mov.label9.Visible = true;
            }
            mov.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dgv_proveedores.CurrentCell = Dgv_proveedores.Rows[0].Cells[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dgv_proveedores.FirstDisplayedScrollingRowIndex = Dgv_proveedores.RowCount - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MantenimientoProveedores mov = new MantenimientoProveedores();
            mov.label9.Text = Dgv_proveedores.CurrentRow.Cells[0].Value.ToString();
            mov.label9.Visible = true;
            mov.textBox1.Text = Dgv_proveedores.CurrentRow.Cells[1].Value.ToString();
            mov.textBox2.Text = Dgv_proveedores.CurrentRow.Cells[2].Value.ToString();
            mov.textBox3.Text = Dgv_proveedores.CurrentRow.Cells[3].Value.ToString();
            mov.textBox4.Text = Dgv_proveedores.CurrentRow.Cells[4].Value.ToString();
            mov.textBox5.Text = Dgv_proveedores.CurrentRow.Cells[5].Value.ToString();
            mov.textBox6.Text = Dgv_proveedores.CurrentRow.Cells[6].Value.ToString();

            mov.Show();
        }
    }
}
