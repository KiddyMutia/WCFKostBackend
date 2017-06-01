namespace WCFKostBackend
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_idadmin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_admin = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_admintype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = global::WCFKostBackend.Properties.Resources.undo_small;
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reset.Location = new System.Drawing.Point(293, 313);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(30, 23);
            this.btn_reset.TabIndex = 83;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(138, 313);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(51, 23);
            this.btn_update.TabIndex = 82;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(202, 313);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(54, 23);
            this.btn_delete.TabIndex = 81;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(139, 313);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(50, 23);
            this.btn_add.TabIndex = 80;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(139, 110);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(184, 20);
            this.tb_name.TabIndex = 79;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(139, 166);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(184, 20);
            this.tb_password.TabIndex = 77;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(39, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Username";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Info.Location = new System.Drawing.Point(39, 168);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(61, 13);
            this.Info.TabIndex = 75;
            this.Info.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(40, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Name";
            // 
            // tb_idadmin
            // 
            this.tb_idadmin.Enabled = false;
            this.tb_idadmin.Location = new System.Drawing.Point(139, 82);
            this.tb_idadmin.Name = "tb_idadmin";
            this.tb_idadmin.Size = new System.Drawing.Size(184, 20);
            this.tb_idadmin.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(39, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "ID Admin";
            // 
            // dg_admin
            // 
            this.dg_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_admin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_admin.Location = new System.Drawing.Point(370, 22);
            this.dg_admin.Name = "dg_admin";
            this.dg_admin.Size = new System.Drawing.Size(444, 325);
            this.dg_admin.TabIndex = 71;
            this.dg_admin.SelectionChanged += new System.EventHandler(this.dg_admin_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(108, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 33);
            this.label7.TabIndex = 70;
            this.label7.Text = "Admin Form";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(370, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 325);
            this.label6.TabIndex = 69;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(21, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 273);
            this.label4.TabIndex = 68;
            this.label4.Text = "           \r\n\r\n\r\n\r\n\r\n                                          \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                "\r\n\r\n\r\n\r\n\r\n\r\n                                                                    " +
                "                                      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(21, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 39);
            this.label3.TabIndex = 67;
            this.label3.Text = "           \r\n \r\n                                                                 " +
                "                                         ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(362, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 338);
            this.label2.TabIndex = 66;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 52);
            this.label1.TabIndex = 65;
            this.label1.Text = "           \r\n  \r\n                                                                " +
                "                                               \r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(14, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 286);
            this.label5.TabIndex = 64;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(139, 138);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(184, 20);
            this.tb_username.TabIndex = 84;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(139, 194);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(184, 52);
            this.tb_address.TabIndex = 88;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(139, 253);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(184, 20);
            this.tb_phone.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(39, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(39, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(40, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 89;
            this.label13.Text = "Admin Type";
            // 
            // cb_admintype
            // 
            this.cb_admintype.FormattingEnabled = true;
            this.cb_admintype.Items.AddRange(new object[] {
            "Admin",
            "Super Admin"});
            this.cb_admintype.Location = new System.Drawing.Point(139, 280);
            this.cb_admintype.Name = "cb_admintype";
            this.cb_admintype.Size = new System.Drawing.Size(184, 21);
            this.cb_admintype.TabIndex = 90;
            this.cb_admintype.Text = "Admin";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WCFKostBackend.Properties.Resources.intro5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 370);
            this.Controls.Add(this.cb_admintype);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_idadmin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dg_admin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_idadmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_admin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_admintype;
        private System.Windows.Forms.Label label13;
    }
}