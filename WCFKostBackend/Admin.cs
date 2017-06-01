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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadTable();
            AutoGenerate();
            btn_delete.Visible = false;
            btn_update.Visible = false;
            btn_reset.Visible = false;
        }
        private void LoadTable()
        {
            try
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string sql = "select id_admin,name, username,password,address, phonenumber, admin_type from tb_admin;";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                sqlda.Fill(dTable);
                dg_admin.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
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
                string sqlcode = "select  top 1   SUBSTRING(id_admin,1,3)  from tb_admin order by id_admin desc";
                string sqlnum = " select  top 1   SUBSTRING(id_admin,4,1)  from tb_admin order by id_admin desc";
                string sqlcodeten = "select  top 1   SUBSTRING(id_admin,1,2)  from tb_admin order by id_admin desc";
                string sqlnumten = " select  top 1   SUBSTRING(id_admin,3,2)  from tb_admin order by id_admin desc";
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
                tb_idadmin.Text = kode + no;

                sqlconn.Close();


                tb_idadmin.Text = kode + no;
            }
        }

        private void dg_admin_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_admin.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                string username = row.Cells[2].Value.ToString();
                string password = row.Cells[3].Value.ToString();
                string address = row.Cells[4].Value.ToString();
                string phonenumber = row.Cells[5].Value.ToString();
                string admintype = row.Cells[6].Value.ToString();

                tb_idadmin.Text = id;
                tb_name.Text = name;
                tb_username.Text = username;
                tb_password.Text = password;
                tb_address.Text = address;
                tb_phone.Text = phonenumber;
                cb_admintype.Text = admintype;

                btn_update.Visible = true;
                btn_add.Visible = false;
                btn_delete.Visible = true;
                tb_idadmin.Enabled = false;
                btn_reset.Visible = true;
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
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
            tb_name.Text = null;
            tb_username.Text = null;
            tb_password.Text = null;
            tb_address.Text = null;
            tb_phone.Text = null;
            cb_admintype.Text = "Admin";
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
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
            if (tb_address.Text == "")
            {
                tb_address.Focus();
                errorProvider1.SetError(tb_address, "Please Fill in The Address");
                flag = 1;
            }
            if (tb_phone.Text == "")
            {
                tb_phone.Focus();
                errorProvider1.SetError(tb_phone, "Please Fill in The Phone");
                flag = 1;
            }
            if (tb_username.Text == "")
            {
                tb_username.Focus();
                errorProvider1.SetError(tb_username, "Please Fill in The Username");
                flag = 1;
            }
            if (tb_password.Text == "")
            {
                tb_password.Focus();
                errorProvider1.SetError(tb_password, "Please Fill in The Password");
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
                string sql = "delete from tb_admin where id_admin = @id";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                using (sqlcon)
                {
                    sqlcom.Parameters.AddWithValue("@id", tb_idadmin.Text);
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
                    string sql = "insert into tb_admin (name, username, password, address, phonenumber, admin_type) values( @name, @username, @password, @address, @phone, @admintype)";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    using (sqlcom)
                    {
                        sqlcom.Parameters.AddWithValue("@name", tb_name.Text);
                        sqlcom.Parameters.AddWithValue("@username", tb_username.Text);
                        sqlcom.Parameters.AddWithValue("@password", tb_password.Text);
                        sqlcom.Parameters.AddWithValue("@address", tb_address.Text);
                        sqlcom.Parameters.AddWithValue("@phone", tb_phone.Text);
                        sqlcom.Parameters.AddWithValue("@admintype", cb_admintype.Text);
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
                    string sql = "update tb_admin set name = @name, username = @username,password=@password, address = @address, phonenumber=@phone, admin_type=@admintype where id_admin = @id";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    using (sqlcom)
                    {
                        sqlcom.Parameters.AddWithValue("@id", tb_idadmin.Text);
                        sqlcom.Parameters.AddWithValue("@name", tb_name.Text);
                        sqlcom.Parameters.AddWithValue("@username", tb_username.Text);
                        sqlcom.Parameters.AddWithValue("@password", tb_password.Text);
                        sqlcom.Parameters.AddWithValue("@address", tb_address.Text);
                        sqlcom.Parameters.AddWithValue("@phone", tb_phone.Text);
                        sqlcom.Parameters.AddWithValue("@admintype", cb_admintype.Text);
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
    }
}
