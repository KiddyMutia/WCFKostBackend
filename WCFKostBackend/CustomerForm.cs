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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            AutoGenerate();
        }
        private void LoadTable()
        {
            try
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string sql = "select id_customer,name, birthdate,address,phonenumber,card_type,card_number from tb_customer;";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = sqlcom;
                DataTable dTable = new DataTable();
                sqlda.Fill(dTable);
                dg_customer.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
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
            DateTime now = DateTime.Today;
            if (now.Year - dt_birthdate.Value.Year < 17)
            {
                dt_birthdate.Focus();
                errorProvider1.SetError(dt_birthdate, "Age Must Above 17");
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
            if (tb_cardnumber.Text == "")
            {
                tb_cardnumber.Focus();
                errorProvider1.SetError(tb_cardnumber, "Please Fill in The Card Number");
                flag = 1;
            }
            return flag;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (ValidateData() == 0)
            {
                Koneksi kon = new Koneksi();
                SqlConnection sqlcon = kon.getConnection();
                string msg = string.Empty;
                string birthday = dt_birthdate.Value.ToString("yyyy-MM-dd");
                using (sqlcon)
                {
                    sqlcon.Open();
                    string sql = "insert into tb_customer (name, birthdate, address, phonenumber, card_type, card_number) values( @name, @birth, @address, @phone, @ctype,@cnum)";
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    using (sqlcom)
                    {
                        sqlcom.Parameters.AddWithValue("@name", tb_name.Text);
                        sqlcom.Parameters.AddWithValue("@birth", birthday);
                        sqlcom.Parameters.AddWithValue("@address", tb_address.Text);
                        sqlcom.Parameters.AddWithValue("@phone", tb_phone.Text);
                        sqlcom.Parameters.AddWithValue("@ctype", cb_cardtype.Text);
                        sqlcom.Parameters.AddWithValue("@cnum", tb_cardnumber.Text);
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
            dt_birthdate.Value = DateTime.Parse("2/5/2000");
            tb_address.Text = null;
            tb_phone.Text = null;
            cb_cardtype.SelectedIndex = 0;
            tb_cardnumber.Text = null;
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
                string sqlcode = "select  top 1   SUBSTRING(id_customer,1,3)  from tb_customer order by id_customer desc";
                string sqlnum = " select  top 1   SUBSTRING(id_customer,4,1)  from tb_customer order by id_customer desc";
                string sqlcodeten = "select  top 1   SUBSTRING(id_customer,1,2)  from tb_customer order by id_customer desc";
                string sqlnumten = " select  top 1   SUBSTRING(id_customer,3,2)  from tb_customer order by id_customer desc";
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
                tb_idcust.Text = kode + no;

                sqlconn.Close();

                
                tb_idcust.Text = kode + no;
            }
        }
        
    }
}
