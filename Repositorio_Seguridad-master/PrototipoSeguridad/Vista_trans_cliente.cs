using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoSeguridad
{
    public partial class Vista_trans_cliente : Form
    {
        public Vista_trans_cliente()
        {
            InitializeComponent();
            llenarTablaM();
        }

        string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

        // llena una tabla al iniciar con los datos de una vista realizada en la base de datos
        public void llenarTablaM()
        {
            try
            {
                string Query = "select * from Vtransaccional_cliente;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Vista_trans_cliente_Load(object sender, EventArgs e)
        {
            llenarTablaM();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna = dataGridView1.CurrentCell.RowIndex.ToString();//selecciona numero de columna
            int columna_id = Convert.ToInt32(columna);

            //MessageBox.Show(dataGridView1.Rows[columna_id].Cells[0].Value.ToString());  

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Trans_cliente trans_m = new Trans_cliente();
            trans_m.MdiParent = this.MdiParent;
            int cod1;
            string columna = dataGridView1.CurrentCell.RowIndex.ToString();//selecciona numero de columna
            int columna_id = Convert.ToInt32(columna);
            string dato1 = dataGridView1.Rows[columna_id].Cells[0].Value.ToString();
            int datoint = Convert.ToInt32(dato1);
            //MessageBox.Show(datoint.ToString()); 
            string MyConnection3 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

            string Query = "select descripcion,accion,cod_transaccion from transaccional_cliente where cod_transaccion =" + datoint + ";";
            OdbcConnection MyConn2 = new OdbcConnection(MyConnection3);
            OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
            MyConn2.Open();
            OdbcDataReader reader = MyCommand2.ExecuteReader();
            // coloca en los textBox, y comboBox correspondientes la informacion que se obtiene de la base de datos
            if (reader.Read())
            {
                trans_m.descripcion.Text = (string)reader["descripcion"];
                trans_m.accion.Text = (string)reader["accion"];
                cod1 = (int)reader["cod_transaccion"];
                trans_m.primarykey.Text = cod1.ToString();

            }

            reader.Close();
      
            MyConn2.Close();
            

            trans_m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Trans_cliente trans_m = new Trans_cliente();
            trans_m.MdiParent = this.MdiParent;

            int cod1;
            string MyConnection3 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

            string Query2 = "Select cod_transaccion from transaccional_cliente order by cod_transaccion DESC LIMIT 1;";
            OdbcConnection MyConn3 = new OdbcConnection(MyConnection3);
            OdbcCommand MyCommand3 = new OdbcCommand(Query2, MyConn3);
            MyConn3.Open();
            OdbcDataReader myreader3;
            myreader3 = MyCommand3.ExecuteReader();
            if (myreader3.Read())
            {
                cod1 = (int)myreader3["cod_transaccion"];
                int cod2 = cod1 + 1;

                trans_m.primarykey.Text = cod2.ToString();
                trans_m.primarykey.Visible = true;
            }
            trans_m.Show();
        }

        private void Vista_trans_cliente_Click(object sender, EventArgs e)
        {
            llenarTablaM();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
