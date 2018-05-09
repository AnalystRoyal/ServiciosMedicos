//Raul Portillo Mayo 2018 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
namespace PrototipoSeguridad
{
    public partial class Tran_Proveedores : Form
    {
        public Tran_Proveedores()
        {
            InitializeComponent();
        }
        //Codigo para cargar datos de la tabla transacciones de proveedores
        //al momento de abrir la ventana
        private void Tran_Proveedores_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=servidor_seguridad; UID=root; PWD=;";
                string Query = "select * from transacciones_proveedores ;";
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
        //Boton ingresar en le navegador para ingresar un registro nuevo 
        //automaticamente coloca el siguiente id que se ingresara
        private void button1_Click(object sender, EventArgs e)
        {
            int cod1;
            string Query2 = "Select id_tranproveedor from transacciones_proveedores order by id_tranproveedor DESC LIMIT 1;";
            string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=servidor_seguridad; UID=root; PWD=;";
            OdbcConnection MyConn3 = new OdbcConnection(MyConnection2);
            OdbcCommand MyCommand3 = new OdbcCommand(Query2, MyConn3);
            MyConn3.Open();
            OdbcDataReader myreader3;
            myreader3 = MyCommand3.ExecuteReader();
            if (myreader3.Read())
            {
                cod1 = (int)myreader3["id_tranproveedor"];
                int cod2 = cod1 + 1;
                Mantenimiento_proveedor mov = new Mantenimiento_proveedor();
                mov.Show();
                mov.primarykey.Text = cod2.ToString();
                mov.primarykey.Enabled = false;
            }
         
        }

        private void Dgv_trans_prov_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //Evento doble clic del grid para pasar los datos de la fila al form de 
        //mantenimiento de transacciones para poder editar el registro
        private void Dgv_trans_prov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mantenimiento_proveedor mov = new Mantenimiento_proveedor();
            mov.primarykey.Text = Dgv_trans_prov.CurrentRow.Cells[0].Value.ToString();
            mov.primarykey.Enabled = false;
            mov.textBox1.Text = Dgv_trans_prov.CurrentRow.Cells[1].Value.ToString();
            mov.textBox2.Text = Dgv_trans_prov.CurrentRow.Cells[2].Value.ToString();
            mov.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mantenimiento_proveedor mov = new Mantenimiento_proveedor();
            mov.MdiParent = this.MdiParent;

            int cod1;
            string MyConnection3 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

            string Query2 = "Select id_tranproveedor from transacciones_proveedores order by id_tranproveedor DESC LIMIT 1;";
            OdbcConnection MyConn3 = new OdbcConnection(MyConnection3);
            OdbcCommand MyCommand3 = new OdbcCommand(Query2, MyConn3);
            MyConn3.Open();
            OdbcDataReader myreader3;
            myreader3 = MyCommand3.ExecuteReader();
            if (myreader3.Read())
            {
                cod1 = (int)myreader3["id_tranproveedor"];
                int cod2 = cod1 + 1;

                mov.primarykey.Text = cod2.ToString();
                mov.primarykey.Enabled = false;
            }
            mov.Show();
        }
        //Para moverse al primer registro del grid
        private void button2_Click(object sender, EventArgs e)
        {
            Dgv_trans_prov.CurrentCell = Dgv_trans_prov.Rows[0].Cells[1];
        }
        //Para moverse al ultimo registro del grid
        private void button3_Click(object sender, EventArgs e)
        {
            Dgv_trans_prov.FirstDisplayedScrollingRowIndex = Dgv_trans_prov.RowCount - 1;
        }
        //cerrar la ventana
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
