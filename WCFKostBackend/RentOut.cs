using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WCFKostBackend
{
    public partial class RentOut : Form
    {
        public RentOut()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RentOut_Load(object sender, EventArgs e)
        {
            LoadTable();

        }
        private void LoadTable()
        {
            try
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string sql = "select A.id_transaction, A.id_room, A.id_customer, B.name ,A.datein,A.status from tb_transaction A, tb_customer B where A.id_customer = B.id_customer AND A.status='Rent In';";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                sqlda.Fill(dTable);
                dg_rentout.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_rentout_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_rentout.SelectedRows)
            {
                string idtrans = row.Cells[0].Value.ToString();
                string idroom = row.Cells[1].Value.ToString();
                string idcust = row.Cells[2].Value.ToString();
                string custname = row.Cells[3].Value.ToString();

                tb_idtrans.Text = idtrans;
                tb_idroom.Text = idroom;
                tb_idcust.Text = idcust;
                tb_custname.Text = custname;

                tb_idtrans.Enabled = false;
                btn_rentout.Enabled = true;
            }
        }

        private void btn_rentout_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            string msg = string.Empty;
            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "update tb_transaction set dateout = @out, status=@status where id_transaction = @id";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@id", tb_idtrans.Text);
                    sqlcom.Parameters.AddWithValue("@out", DateTime.Now);
                    sqlcom.Parameters.AddWithValue("@status", "Rent Out");
                    int res = sqlcom.ExecuteNonQuery();
                    msg = (res != 0 ? "Data has been updated." : "Oops, something went wrong.");
                }
                sqlcon.Close();
            }
            MessageBox.Show(msg);
            Reset();
            LoadTable();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            btn_rentout.Enabled = false;
            tb_idtrans.Text = null;
            tb_idroom.Text = null;
            tb_idcust.Text = null;
            tb_custname.Text = null;
        }

        private void RentOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
        }

    }
}
