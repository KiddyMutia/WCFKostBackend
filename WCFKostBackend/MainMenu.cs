﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCFKostBackend
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.Show();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm rf = new RoomForm();
            rf.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin af = new Admin();
            af.Show();
        }

        private void btn_roomtype_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomTypeForm rtf = new RoomTypeForm();
            rtf.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservationForm rf = new ReservationForm();
            rf.Show();
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentIn ri = new RentIn();
            ri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentOut ro = new RentOut();
            ro.Show();
        }

        private void btn_monthlypaid_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyPaid mp = new MonthlyPaid();
            mp.Show();
        }
    }
}
