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
    public partial class RentIn : Form
    {
        public RentIn()
        {
            InitializeComponent();
        }

        private void RentIn_Load(object sender, EventArgs e)
        {
            LoadTable();
            AutoGenerate();
            cb_room();
            cb_customer();
        }
        private void LoadTable()
        {
            try
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string sql = "select id_transaction, id_room, id_customer,datein, dateout,status from tb_transaction;";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                sqlda.Fill(dTable);
                dg_transaction.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AutoGenerate()
        {
            Koneksi konn = new Koneksi();
            SqlConnection sqlconn = konn.getConnection();
            using (sqlconn)
            {
                string kode = "1";
                string no = "1";
                string kodeten = "1";
                string noten = "1";
                int numtenint = 1;
                sqlconn.Open();
                string sqlcode = "select  top 1   SUBSTRING(id_transaction,1,3)  from tb_transaction order by id_transaction desc";
                string sqlnum = " select  top 1   SUBSTRING(id_transaction,4,1)  from tb_transaction order by id_transaction desc";
                string sqlcodeten = "select  top 1   SUBSTRING(id_transaction,1,2)  from tb_transaction order by id_transaction desc";
                string sqlnumten = " select  top 1   SUBSTRING(id_transaction,3,2)  from tb_transaction order by id_transaction desc";
                SqlCommand sqlcomcode = new SqlCommand(sqlcode, sqlconn);
                SqlCommand sqlcomnum = new SqlCommand(sqlnum, sqlconn);
                SqlCommand sqlcomcodeten = new SqlCommand(sqlcodeten, sqlconn);
                SqlCommand sqlcomnumten = new SqlCommand(sqlnumten, sqlconn);

                using (sqlcomcode)
                {
                    SqlDataReader drcode = sqlcomcode.ExecuteReader();
                    if (drcode.Read())
                    {
                        kode = drcode.GetString(0);
                    }
                }
                sqlconn.Close();
                sqlconn.Open();
                using (sqlcomcodeten)
                {
                    SqlDataReader drcodeten = sqlcomcodeten.ExecuteReader();
                    if (drcodeten.Read())
                    {
                        kodeten = drcodeten.GetString(0);
                    }
                }
                sqlconn.Close();

                sqlconn.Open();
                using (sqlcomnumten)
                {
                    SqlDataReader drnumten = sqlcomnumten.ExecuteReader();
                    if (drnumten.Read())
                    {
                        noten = drnumten.GetString(0);
                        numtenint = Convert.ToInt16(noten);

                    }
                }
                sqlconn.Close();

                sqlconn.Open();
                using (sqlcomnum)
                {
                    SqlDataReader drnum = sqlcomnum.ExecuteReader();
                    if (drnum.Read())
                    {
                        string num = drnum.GetString(0);
                        int numint = Convert.ToInt16(num);
                        if (numint == 9)
                        {
                            numint = numtenint;
                            kode = kodeten;
                        }
                        int nomor = numint + 1;
                        no = Convert.ToString(nomor);
                    }
                }
                tb_idtrans.Text = kode + no;

                sqlconn.Close();


                tb_idtrans.Text = kode + no;
            }
        }
        private void cb_room()
        {
            try
            {
                Koneksi kon = new Koneksi();
                string sql = "select * from tb_room where status='available';";
                SqlConnection sqlcon = kon.getConnection();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                cb_idroom.DataSource = dTable;
                cb_idroom.ValueMember = "id_room";
                cb_idroom.DisplayMember = "id_room";
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cb_customer()
        {
            try
            {
                Koneksi kon = new Koneksi();
                string sql = "select * from tb_customer;";
                SqlConnection sqlcon = kon.getConnection();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                cb_idcust.DataSource = dTable;
                cb_idcust.ValueMember = "id_customer";
                cb_idcust.DisplayMember = "id_customer";
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            cb_idroom.SelectedIndex = -1;
            cb_idcust.SelectedIndex = -1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            string msg = string.Empty;
            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "insert into tb_transaction (id_room, id_customer) values( @idroom, @idcust)";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@idroom", cb_idroom.Text);
                    sqlcom.Parameters.AddWithValue("@idcust", cb_idcust.Text);
                    int res = sqlcom.ExecuteNonQuery();
                    msg = (res != 0 ? "Data has been saved." : "Oops, something went wrong.");
                }
                sqlcon.Close();
            }
            MessageBox.Show(msg);
            LoadTable();
            ClearForm();
            cb_room();
            AutoGenerate();
        }

    }
}
