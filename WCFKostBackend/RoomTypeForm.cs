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
    public partial class RoomTypeForm : Form
    {
        public RoomTypeForm()
        {
            InitializeComponent();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

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
                    string sql = "insert into tb_room_type (name,price,information) values( @name, @price, @info)";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    using (sqlcom)
                    {
                        sqlcom.Parameters.AddWithValue("@name", tb_name.Text);
                        sqlcom.Parameters.AddWithValue("@price", tb_price.Text);
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
            else
            {
                MessageBox.Show("Please Fix The Error");
            }

        }

        private void RoomTypeForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            AutoGenerate();
            btn_delete.Visible=false;
            btn_update.Visible = false;
            btn_reset.Visible = false;
            
        }
        private void LoadTable()
        {
            
            
            try
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string sql = "select id_room_type,name,price,information from tb_room_type;";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                sqlda.Fill(dTable);
                dg_roomtype.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                sqlcon.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void dg_roomtype_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_roomtype.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                string price = row.Cells[2].Value.ToString();
                string info = row.Cells[3].Value.ToString();

                tb_idroomtype.Text = id;
                tb_name.Text = name;
                tb_price.Text = price;
                tb_info.Text = info;

                btn_update.Visible= true;
                btn_add.Visible = false;
                btn_delete.Visible = true;
                tb_idroomtype.Enabled = false;
                btn_reset.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            btn_update.Visible = false;
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_reset.Visible = false;
            tb_idroomtype.Text = null;
            tb_name.Text = null;
            tb_price.Text = null;
            tb_info.Text = null;
            AutoGenerate();
        }
        private void ClearForm()
        {
            tb_name.Text = null;
            tb_price.Text = null;
            tb_info.Text = null;
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
                string sqlcode = "select  top 1   SUBSTRING(id_room_type,1,3)  from tb_room_type order by id_room_type desc";
                string sqlnum = " select  top 1   SUBSTRING(id_room_type,4,1)  from tb_room_type order by id_room_type desc";
                string sqlcodeten = "select  top 1   SUBSTRING(id_room_type,1,2)  from tb_room_type order by id_room_type desc";
                string sqlnumten = " select  top 1   SUBSTRING(id_room_type,3,2)  from tb_room_type order by id_room_type desc";
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
                tb_idroomtype.Text = kode + no;

                sqlconn.Close();


                tb_idroomtype.Text = kode + no;
            }
        }
        private int ValidateData()
        {
            int flag = 0;
            if (tb_idroomtype.Text == "")
            {
                tb_name.Focus();
                errorProvider1.SetError(tb_idroomtype, "Please Fill in The ID Room Type");
                flag = 1;
            }
            if (tb_name.Text == "")
            {
                tb_name.Focus();
                errorProvider1.SetError(tb_name, "Please Fill in The Name");
                flag = 1;
            }
            if (tb_price.Text == "")
            {
                tb_price.Focus();
                errorProvider1.SetError(tb_price, "Please Fill The Price");
                flag = 1;
            }
            if (tb_info.Text == "")
            {
                tb_info.Focus();
                errorProvider1.SetError(tb_info, "Please Fill The Info");
                flag = 1;
            }
            return flag;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            string msg = string.Empty;
            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "delete from tb_room_type where id_room_type = @id";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcon)
                {
                    sqlcom.Parameters.AddWithValue("@id", tb_idroomtype.Text);
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
                    string sql = "update tb_room_type set name = @name, price = @price, information = @info where id_room_type = @id";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    using (sqlcom)
                    {
                        sqlcom.Parameters.AddWithValue("@id", tb_idroomtype.Text);
                        sqlcom.Parameters.AddWithValue("@name", tb_name.Text);
                        sqlcom.Parameters.AddWithValue("@price", tb_price.Text);
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
            else
            {
                MessageBox.Show("Please Fix The Error");
            }
        }

        private void RoomTypeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
