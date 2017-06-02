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
    public partial class MonthlyPaid : Form
    {
        public MonthlyPaid()
        {
            InitializeComponent();
        }

       
        private void MonthlyPaid_Load(object sender, EventArgs e)
        {
            LoadTable();
            AutoGenerate();
            cb_trans();
            cb_idtrans.SelectedIndex = -1;
           // tbfill();
        }
        private void LoadTable()
        {
            try
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string sql = "select id_monthpaid, id_transaction, date_time, total, info from tb_monthpaid;";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                sqlda.Fill(dTable);
                dg_monthly.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
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
                string sqlcode = "select  top 1   SUBSTRING(id_monthpaid,1,3)  from tb_monthpaid order by id_monthpaid desc";
                string sqlnum = " select  top 1   SUBSTRING(id_monthpaid,4,1)  from tb_monthpaid order by id_monthpaid desc";
                string sqlcodeten = "select  top 1   SUBSTRING(id_monthpaid,1,2)  from tb_monthpaid order by id_monthpaid desc";
                string sqlnumten = " select  top 1   SUBSTRING(id_monthpaid,3,2)  from tb_monthpaid order by id_monthpaid desc";
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
                tb_idmonthly.Text = kode + no;

                sqlconn.Close();


                tb_idmonthly.Text = kode + no;
            }

        }
        private void cb_trans()
        {
            try
            {
                Koneksi kon = new Koneksi();
                string sql = "select * from tb_transaction where status='Rent In';";
                SqlConnection sqlcon = kon.getConnection();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                cb_idtrans.DataSource = dTable;
                cb_idtrans.ValueMember = "id_transaction";
                cb_idtrans.DisplayMember = "id_transaction";
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_rentin_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            string msg = string.Empty;
            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "insert into tb_monthpaid (id_transaction, date_time, info) values( @idtrans, @date, @info)";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@idtrans", cb_idtrans.Text);
                    sqlcom.Parameters.AddWithValue("@date", DateTime.Now);
                    sqlcom.Parameters.AddWithValue("@info", tb_info.Text);
                    int res = sqlcom.ExecuteNonQuery();
                    msg = (res != 0 ? "Data has been saved." : "Oops, something went wrong.");
                }
                sqlcon.Close();
            }
            MessageBox.Show(msg);
            LoadTable();
            ClearForm();
            AutoGenerate();
        }
        private void ClearForm()
        {
            cb_idtrans.SelectedIndex = 0;
            tb_idroom.Text = null;
            tb_total.Text = null;
            tb_info.Text = null;
        }

        private void MonthlyPaid_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
        //private void tbfill()
        //{
        //    try
        //    {

        //        string kode = null;
        //        Koneksi kon = new Koneksi();
        //        string sql = "select id_room from tb_transaction where id_transaction = @idtrans;";
        //        SqlConnection sqlcon = kon.getConnection();
        //        sqlcon.Open();
        //        SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
        //        using (sqlcom)
        //        {
        //            sqlcom.Parameters.AddWithValue("@idtrans", cb_idtrans.Text);
        //            SqlDataReader drcode = sqlcom.ExecuteReader();
        //            if (drcode.Read())
        //            {
        //                kode = drcode.GetString(0);
        //            }
        //        }
        //        sqlcon.Close();
        //        tb_idroom.Text = kode;
        //        // MyConn2.Close();  
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
