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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            cb_roomtype();
            LoadTable();
            btn_delete.Visible = false;
            btn_update.Visible = false;
            AutoGenerate();
            btn_reset.Visible = false;
        }
        private void LoadTable()
        {
            try
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string sql = "select id_room, id_room_type,name,status from tb_room;";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                sqlda.Fill(dTable);
                dg_room.DataSource = dTable; 
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
            cb_idroomtype.SelectedIndex = 0;
            tb_name.Text = null;
            cb_stat.SelectedIndex = 0;
            AutoGenerate();
        }
        private int ValidateData()
        {
            int flag = 0;            
            if (tb_name.Text == "")
            {
                tb_name.Focus();
                errorProvider1.SetError(tb_name, "Please Fill in The Name");
                flag = 1;
            }
            return flag;
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
                string sqlcode = "select  top 1   SUBSTRING(id_room,1,3)  from tb_room order by id_room desc";
                string sqlnum = " select  top 1   SUBSTRING(id_room,4,1)  from tb_room order by id_room desc";
                string sqlcodeten = "select  top 1   SUBSTRING(id_room,1,2)  from tb_room order by id_room desc";
                string sqlnumten = " select  top 1   SUBSTRING(id_room,3,2)  from tb_room order by id_room desc";
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
                tb_idroom.Text = kode + no;

                sqlconn.Close();


                tb_idroom.Text = kode + no;
            }
        }

        private void dg_room_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_room.SelectedRows)
            {
                string id_room = row.Cells[0].Value.ToString();
                string id_room_type = row.Cells[1].Value.ToString();
                string name = row.Cells[2].Value.ToString();
                string status = row.Cells[3].Value.ToString();

                tb_idroom.Text = id_room;
                cb_idroomtype.Text = id_room_type;
                tb_name.Text = name;
                cb_stat.Text = status;

                btn_update.Visible = true;
                btn_add.Visible = false;
                btn_delete.Visible = true;
                tb_idroom.Enabled = false;
                btn_reset.Visible = true;
            }
        }
        private void cb_roomtype()
        {
            try
            {
                Koneksi kon = new Koneksi();
                string sql = "select * from tb_room_type;";
                SqlConnection sqlcon = kon.getConnection();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);  
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                cb_idroomtype.DataSource = dTable;
                cb_idroomtype.ValueMember = "id_room_type";
                cb_idroomtype.DisplayMember = "id_room_type";
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (ValidateData() == 0)
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string msg = string.Empty;
                using (sqlcon)
                {
                    sqlcon.Open();
                    string sql = "insert into tb_room (id_room_type, name, status) values( @idrt, @name, @status)";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    using (sqlcom)
                    {
                        sqlcom.Parameters.AddWithValue("@idrt", cb_idroomtype.Text);
                        sqlcom.Parameters.AddWithValue("@name", tb_name.Text);
                        sqlcom.Parameters.AddWithValue("@status", cb_stat.Text);
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
            else
            {
                MessageBox.Show("Please Fix The Error");
            }
        }
        private void ClearForm()
        {
            tb_name.Text = null;
            cb_idroomtype.SelectedIndex = 0;
            cb_stat.SelectedIndex = 0;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string msg = string.Empty;
                using (sqlcon)
                {
                    sqlcon.Open();
                    string sql = "update tb_room set name = @name, status = @status, id_room_type = @idrt where id_room = @id";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    using (sqlcom)
                    {
                        sqlcom.Parameters.AddWithValue("@id", tb_idroom.Text);
                        sqlcom.Parameters.AddWithValue("@idrt", cb_idroomtype.Text);
                        sqlcom.Parameters.AddWithValue("@name", tb_name.Text);
                        sqlcom.Parameters.AddWithValue("@status", cb_stat.Text);
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
            else
            {
                MessageBox.Show("Please Fix The Error");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            string msg = string.Empty;
            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "delete from tb_room where id_room = @id";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcon)
                {
                    sqlcom.Parameters.AddWithValue("@id", tb_idroom.Text);
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

        private void RoomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
