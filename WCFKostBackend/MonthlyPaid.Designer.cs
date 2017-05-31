namespace WCFKostBackend
{
    partial class MonthlyPaid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyPaid));
            this.btn_rentin = new System.Windows.Forms.Button();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_monthly = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_idtrans = new System.Windows.Forms.ComboBox();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_idroom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_monthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rentin
            // 
            this.btn_rentin.Location = new System.Drawing.Point(137, 317);
            this.btn_rentin.Name = "btn_rentin";
            this.btn_rentin.Size = new System.Drawing.Size(50, 23);
            this.btn_rentin.TabIndex = 80;
            this.btn_rentin.Text = "Rent In";
            this.btn_rentin.UseVisualStyleBackColor = true;
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(138, 223);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(184, 20);
            this.tb_total.TabIndex = 78;
            this.tb_total.TextChanged += new System.EventHandler(this.tb_total_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(39, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 77;
            this.label13.Text = "Date";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(37, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Total";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(37, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "ID Transaction";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dg_monthly
            // 
            this.dg_monthly.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_monthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_monthly.Location = new System.Drawing.Point(369, 25);
            this.dg_monthly.Name = "dg_monthly";
            this.dg_monthly.Size = new System.Drawing.Size(327, 325);
            this.dg_monthly.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(64, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 33);
            this.label7.TabIndex = 71;
            this.label7.Text = "Monthly Paid Form";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(369, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 325);
            this.label6.TabIndex = 70;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 273);
            this.label4.TabIndex = 69;
            this.label4.Text = "           \r\n\r\n\r\n\r\n\r\n                                          \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                "\r\n\r\n\r\n\r\n\r\n\r\n                                                                    " +
                "                                      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(20, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 39);
            this.label3.TabIndex = 68;
            this.label3.Text = "           \r\n \r\n                                                                 " +
                "                                         ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(361, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 338);
            this.label2.TabIndex = 67;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 52);
            this.label1.TabIndex = 66;
            this.label1.Text = "           \r\n  \r\n                                                                " +
                "                                               \r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 286);
            this.label5.TabIndex = 65;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WCFKostBackend.Properties.Resources.intro5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // cb_idtrans
            // 
            this.cb_idtrans.FormattingEnabled = true;
            this.cb_idtrans.Location = new System.Drawing.Point(138, 104);
            this.cb_idtrans.Name = "cb_idtrans";
            this.cb_idtrans.Size = new System.Drawing.Size(184, 21);
            this.cb_idtrans.TabIndex = 83;
            this.cb_idtrans.SelectedIndexChanged += new System.EventHandler(this.cb_idtrans_SelectedIndexChanged);
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(137, 152);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(184, 20);
            this.dt_date.TabIndex = 84;
            this.dt_date.ValueChanged += new System.EventHandler(this.dt_date_ValueChanged);
            // 
            // tb_info
            // 
            this.tb_info.Location = new System.Drawing.Point(138, 260);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.Size = new System.Drawing.Size(184, 50);
            this.tb_info.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(38, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(37, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "ID Room";
            // 
            // tb_idroom
            // 
            this.tb_idroom.Location = new System.Drawing.Point(137, 188);
            this.tb_idroom.Name = "tb_idroom";
            this.tb_idroom.Size = new System.Drawing.Size(184, 20);
            this.tb_idroom.TabIndex = 88;
            // 
            // MonthlyPaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 364);
            this.Controls.Add(this.tb_idroom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.cb_idtrans);
            this.Controls.Add(this.btn_rentin);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dg_monthly);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MonthlyPaid";
            this.Text = "MonthlyPaid";
            ((System.ComponentModel.ISupportInitialize)(this.dg_monthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rentin;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_monthly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_idtrans;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_idroom;

    }
}