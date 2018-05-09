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
    public partial class VistaDoctores : Form
    {
        public VistaDoctores()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentanaDoctores mov = new VentanaDoctores();
            mov.MdiParent = this.MdiParent;

            int cod1;
            string MyConnection3 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

            string Query2 = "Select id_doc from doctores order by id_doc DESC LIMIT 1;";
            OdbcConnection MyConn3 = new OdbcConnection(MyConnection3);
            OdbcCommand MyCommand3 = new OdbcCommand(Query2, MyConn3);
            MyConn3.Open();
            OdbcDataReader myreader3;
            myreader3 = MyCommand3.ExecuteReader();
            if (myreader3.Read())
            {
                cod1 = (int)myreader3["id_doc"];
                int cod2 = cod1 + 1;

                mov.primarykey.Text = cod2.ToString();
                
            }
            mov.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dgv_trans_prov.CurrentCell = Dgv_trans_prov.Rows[0].Cells[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dgv_trans_prov.FirstDisplayedScrollingRowIndex = Dgv_trans_prov.RowCount - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_trans_prov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_trans_prov_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VentanaDoctores mov = new VentanaDoctores();
            mov.primarykey.Text = Dgv_trans_prov.CurrentRow.Cells[0].Value.ToString();
            mov.textBox2.Text = Dgv_trans_prov.CurrentRow.Cells[1].Value.ToString();
            mov.textBox3.Text = Dgv_trans_prov.CurrentRow.Cells[2].Value.ToString();
            mov.textBox4.Text = Dgv_trans_prov.CurrentRow.Cells[3].Value.ToString();
            mov.textBox5.Text = Dgv_trans_prov.CurrentRow.Cells[4].Value.ToString();
            mov.textBox6.Text = Dgv_trans_prov.CurrentRow.Cells[5].Value.ToString();
            mov.textBox7.Text = Dgv_trans_prov.CurrentRow.Cells[6].Value.ToString();
        
            mov.Show();
        }

        private void VistaDoctores_Load(object sender, EventArgs e)
        {

            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=servidor_seguridad; UID=root; PWD=;";
                string Query = "select * from doctores ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_trans_prov.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_trans_prov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VentanaDoctores mov = new VentanaDoctores();
            mov.primarykey.Text = Dgv_trans_prov.CurrentRow.Cells[0].Value.ToString();
            mov.textBox2.Text = Dgv_trans_prov.CurrentRow.Cells[1].Value.ToString();
            mov.textBox3.Text = Dgv_trans_prov.CurrentRow.Cells[2].Value.ToString();
            mov.textBox4.Text = Dgv_trans_prov.CurrentRow.Cells[3].Value.ToString();
            mov.textBox5.Text = Dgv_trans_prov.CurrentRow.Cells[4].Value.ToString();
            mov.textBox6.Text = Dgv_trans_prov.CurrentRow.Cells[5].Value.ToString();
            mov.textBox7.Text = Dgv_trans_prov.CurrentRow.Cells[6].Value.ToString();
       
            mov.Show();
        }

        private void VistaDoctores_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=servidor_seguridad; UID=root; PWD=;";
                string Query = "select * from doctores ;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);

                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                Dgv_trans_prov.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
