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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            AutoGenerate();
            btn_delete.Visible = false;
            btn_update.Visible = false;
            btn_reset.Visible = false;
            cb_room();
            cb_customer();
        }
        private void LoadTable()
        {
            try
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string sql = "select id_reservation, id_room, id_customer,date_time,status,info from tb_reservation;";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                sqlda.Fill(dTable);
                dg_reservation.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
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
                string sqlcode = "select  top 1   SUBSTRING(id_reservation,1,3)  from tb_reservation order by id_reservation desc";
                string sqlnum = " select  top 1   SUBSTRING(id_reservation,4,1)  from tb_reservation order by id_reservation desc";
                string sqlcodeten = "select  top 1   SUBSTRING(id_reservation,1,2)  from tb_reservation order by id_reservation desc";
                string sqlnumten = " select  top 1   SUBSTRING(id_reservation,3,2)  from tb_reservation order by id_reservation desc";
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
                tb_idreserv.Text = kode + no;

                sqlconn.Close();


                tb_idreserv.Text = kode + no;
            }
        }

        private void ReservationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            btn_update.Visible = false;
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_reset.Visible = false;
            ClearForm();
            AutoGenerate();
        }
        private void ClearForm()
        {
            cb_idroom.SelectedIndex = 0;
            cb_idcust.SelectedIndex = 0;
            tb_info.Text = null;
        }

        private void dg_reservation_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_reservation.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                string idroom = row.Cells[1].Value.ToString();
                string idcust = row.Cells[2].Value.ToString();
                string info = row.Cells[5].Value.ToString();

                tb_idreserv.Text = id;
                cb_idroom.Text = idroom;
                cb_idcust.Text = idcust;
                tb_info.Text = info;

                btn_update.Visible = true;
                btn_add.Visible = false;
                btn_delete.Visible = true;
                tb_idreserv.Enabled = false;
                btn_reset.Visible = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            string msg = string.Empty;
            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "insert into tb_reservation (id_room, id_customer, info) values( @idroom, @idcust, @info)";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@idroom", cb_idroom.Text);
                    sqlcom.Parameters.AddWithValue("@idcust", cb_idcust.Text);
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            string msg = string.Empty;
            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "update tb_reservation set id_room = @idroom, id_customer = @idcust, date_time=@date, info=@info where id_reservation = @id";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@id", tb_idreserv.Text);
                    sqlcom.Parameters.AddWithValue("@idroom", cb_idroom.Text);
                    sqlcom.Parameters.AddWithValue("@idcust", cb_idcust.Text);
                    sqlcom.Parameters.AddWithValue("@date", DateTime.Now);
                    sqlcom.Parameters.AddWithValue("@info", tb_info.Text);
                    int res = sqlcom.ExecuteNonQuery();
                    msg = (res != 0 ? "Data has been updated." : "Oops, something went wrong.");
                }
                sqlcon.Close();
            }
            MessageBox.Show(msg);
            Reset();
            AutoGenerate();
            LoadTable();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            string msg = string.Empty;
            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "delete from tb_reservation where id_reservation = @id";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcon)
                {
                    sqlcom.Parameters.AddWithValue("@id", tb_idreserv.Text);
                    int res = sqlcom.ExecuteNonQuery();
                    msg = (res != 0 ? "Data has been deleted " : "Oops, something went wrong");

                }
                sqlcon.Close();
            }
            MessageBox.Show(msg);
            Reset();
            AutoGenerate();
            LoadTable();
        }
    }
}
