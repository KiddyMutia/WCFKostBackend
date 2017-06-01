namespace WCFKostBackend
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_roomtype = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_transaction = new System.Windows.Forms.Button();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.btn_monthlypaid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Kost";
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_room.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_room.Location = new System.Drawing.Point(466, 146);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(112, 64);
            this.btn_room.TabIndex = 1;
            this.btn_room.Text = "Room";
            this.btn_room.UseVisualStyleBackColor = false;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_roomtype
            // 
            this.btn_roomtype.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_roomtype.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_roomtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_roomtype.Location = new System.Drawing.Point(322, 146);
            this.btn_roomtype.Name = "btn_roomtype";
            this.btn_roomtype.Size = new System.Drawing.Size(112, 64);
            this.btn_roomtype.TabIndex = 2;
            this.btn_roomtype.Text = "Room Type";
            this.btn_roomtype.UseVisualStyleBackColor = false;
            this.btn_roomtype.Click += new System.EventHandler(this.btn_roomtype_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_customer.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_customer.Location = new System.Drawing.Point(178, 146);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(110, 64);
            this.btn_customer.TabIndex = 3;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_admin.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_admin.Location = new System.Drawing.Point(36, 146);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(110, 64);
            this.btn_admin.TabIndex = 4;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_transaction
            // 
            this.btn_transaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_transaction.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_transaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_transaction.Location = new System.Drawing.Point(178, 247);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(110, 64);
            this.btn_transaction.TabIndex = 5;
            this.btn_transaction.Text = "Rent In";
            this.btn_transaction.UseVisualStyleBackColor = false;
            this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
            // 
            // btn_reservation
            // 
            this.btn_reservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reservation.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_reservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reservation.Location = new System.Drawing.Point(36, 247);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(110, 64);
            this.btn_reservation.TabIndex = 6;
            this.btn_reservation.Text = "Reservation";
            this.btn_reservation.UseVisualStyleBackColor = false;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // btn_monthlypaid
            // 
            this.btn_monthlypaid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_monthlypaid.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_monthlypaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_monthlypaid.Location = new System.Drawing.Point(468, 247);
            this.btn_monthlypaid.Name = "btn_monthlypaid";
            this.btn_monthlypaid.Size = new System.Drawing.Size(110, 64);
            this.btn_monthlypaid.TabIndex = 7;
            this.btn_monthlypaid.Text = "Monthly Paid";
            this.btn_monthlypaid.UseVisualStyleBackColor = false;
            this.btn_monthlypaid.Click += new System.EventHandler(this.btn_monthlypaid_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(322, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Rent Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WCFKostBackend.Properties.Resources.intro5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_monthlypaid);
            this.Controls.Add(this.btn_reservation);
            this.Controls.Add(this.btn_transaction);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.btn_roomtype);
            this.Controls.Add(this.btn_room);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_room;
        private System.Windows.Forms.Button btn_roomtype;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Button btn_monthlypaid;
        private System.Windows.Forms.Button button1;
    }
}