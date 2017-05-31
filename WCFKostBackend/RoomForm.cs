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

        }
          
        private void AutoGenerate()
        {
            Koneksi konn = new Koneksi();
            SqlConnection sqlconn = konn.getConnection();
            using (sqlconn)
            {
                string kode = "1";
                string no = "1";
                sqlconn.Open();
                string sqlcode = "select  top 1   SUBSTRING(id_room,1,3)  from tb_room order by id_room desc";
                string sqlnum = " select  top 1   SUBSTRING(id_room,4,1)  from tb_room order by id_room desc";
                SqlCommand sqlcomcode = new SqlCommand(sqlcode, sqlconn);
                SqlCommand sqlcomnum = new SqlCommand(sqlnum, sqlconn);

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
                using (sqlcomnum)
                {
                    SqlDataReader drnum = sqlcomnum.ExecuteReader();
                    if (drnum.Read())
                    {
                        string num = drnum.GetString(0);
                        int nomor = Convert.ToInt16(num) + 1;
                        no = Convert.ToString(nomor);
                    }
                }
                tb_idroom.Text = kode + no;

                sqlconn.Close();
            }
        }

        private void dg_room_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_room.SelectedRows)
            {
                string id_room = row.Cells[0].Value.ToString();
                string id_room_type = row.Cells[1].Value.ToString();
                string name = row.Cells[2].Value.ToString();
                string price = row.Cells[3].Value.ToString();
                string status = row.Cells[4].Value.ToString();

                cb_idroomtype.Text = id_room_type;
                tb_name.Text = name;
                tb_price.Text = price;
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
    }
}
