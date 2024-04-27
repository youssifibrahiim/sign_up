namespace sign_up
{
    partial class Form3
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
            this.From_cmbox = new System.Windows.Forms.ComboBox();
            this.to_cmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm_trip = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.num_trip = new System.Windows.Forms.Label();
            this.username_labl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // From_cmbox
            // 
            this.From_cmbox.DropDownHeight = 150;
            this.From_cmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_cmbox.FormattingEnabled = true;
            this.From_cmbox.IntegralHeight = false;
            this.From_cmbox.Items.AddRange(new object[] {
            "Adly Mansour",
            "Haikstep",
            "Omar Ibn Al-Khattab",
            "Qaba",
            "Hisham Barakat",
            "El-Nozha",
            "El Shams SC",
            "Alf Maskan",
            "Heliopolis",
            "Haroun",
            "El Ahram",
            "Kolleyet El Banat",
            "Stadium",
            "Fair Zon",
            "El Abassiya",
            "Abdou Pasha",
            "El Geish",
            "Bab El-Shaariya",
            "Attaba",
            "Nasser",
            "Maspero",
            "Safaa Hegazy",
            "Kit-Kat"});
            this.From_cmbox.Location = new System.Drawing.Point(154, 235);
            this.From_cmbox.Name = "From_cmbox";
            this.From_cmbox.Size = new System.Drawing.Size(267, 30);
            this.From_cmbox.TabIndex = 0;
            this.From_cmbox.SelectedIndexChanged += new System.EventHandler(this.From_cmbox_SelectedIndexChanged);
            // 
            // to_cmbox
            // 
            this.to_cmbox.DropDownHeight = 150;
            this.to_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.to_cmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_cmbox.FormattingEnabled = true;
            this.to_cmbox.IntegralHeight = false;
            this.to_cmbox.Items.AddRange(new object[] {
            "Adly Mansour",
            "Haikstep",
            "Omar Ibn Al-Khattab",
            "Qaba",
            "Hisham Barakat",
            "El-Nozha",
            "El Shams SC",
            "Alf Maskan",
            "Heliopolis",
            "Haroun",
            "El Ahram",
            "Kolleyet El Banat",
            "Stadium",
            "Fair Zon",
            "El Abassiya",
            "Abdou Pasha",
            "El Geish",
            "Bab El-Shaariya",
            "Attaba",
            "Nasser",
            "Maspero",
            "Safaa Hegazy",
            "Kit-Kat"});
            this.to_cmbox.Location = new System.Drawing.Point(527, 235);
            this.to_cmbox.Name = "to_cmbox";
            this.to_cmbox.Size = new System.Drawing.Size(329, 30);
            this.to_cmbox.TabIndex = 1;
            this.to_cmbox.SelectedIndexChanged += new System.EventHandler(this.to_cmbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "From : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "To : ";
            // 
            // confirm_trip
            // 
            this.confirm_trip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirm_trip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_trip.ForeColor = System.Drawing.Color.White;
            this.confirm_trip.Location = new System.Drawing.Point(315, 454);
            this.confirm_trip.Name = "confirm_trip";
            this.confirm_trip.Size = new System.Drawing.Size(146, 77);
            this.confirm_trip.TabIndex = 4;
            this.confirm_trip.Text = "Confirm";
            this.confirm_trip.UseVisualStyleBackColor = false;
            this.confirm_trip.Click += new System.EventHandler(this.confirm_trip_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btn.Location = new System.Drawing.Point(487, 454);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(142, 77);
            this.Cancel_btn.TabIndex = 5;
            this.Cancel_btn.Text = "Logout";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::sign_up.Properties.Resources.car2;
            this.pictureBox2.Location = new System.Drawing.Point(-157, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Navy;
            this.welcome.Location = new System.Drawing.Point(256, 39);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(205, 48);
            this.welcome.TabIndex = 13;
            this.welcome.Text = "Welcome\r\n";
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(782, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Points";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // num_trip
            // 
            this.num_trip.AutoSize = true;
            this.num_trip.BackColor = System.Drawing.Color.Transparent;
            this.num_trip.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_trip.ForeColor = System.Drawing.Color.Navy;
            this.num_trip.Location = new System.Drawing.Point(290, 169);
            this.num_trip.Name = "num_trip";
            this.num_trip.Size = new System.Drawing.Size(269, 33);
            this.num_trip.TabIndex = 15;
            this.num_trip.Text = "Number of Trips :  ";
            // 
            // username_labl
            // 
            this.username_labl.AutoSize = true;
            this.username_labl.BackColor = System.Drawing.Color.Transparent;
            this.username_labl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_labl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.username_labl.Location = new System.Drawing.Point(467, 51);
            this.username_labl.Name = "username_labl";
            this.username_labl.Size = new System.Drawing.Size(167, 36);
            this.username_labl.TabIndex = 16;
            this.username_labl.Text = "Username";
            this.username_labl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.username_labl.Click += new System.EventHandler(this.username_labl_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sign_up.Properties.Resources.backgroundback1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 580);
            this.Controls.Add(this.username_labl);
            this.Controls.Add(this.num_trip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.confirm_trip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to_cmbox);
            this.Controls.Add(this.From_cmbox);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox From_cmbox;
        private System.Windows.Forms.ComboBox to_cmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirm_trip;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label num_trip;
        private System.Windows.Forms.Label username_labl;
    }
}