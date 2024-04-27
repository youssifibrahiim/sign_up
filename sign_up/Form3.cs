using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up
{
    public partial class Form3 : Form
    {
        public string UserName { get; set; }
        public static int dist { get; set; }
        Form4 form4 = new Form4();
        string to = "";
        string current = "";
        string[] from =
        {
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
                "Kit-Kat"
        };
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            username_labl.Text = UserName.ToString();
            num_trip.Text += Form6.numoftrips.ToString();
        }

        private void confirm_trip_Click(object sender, EventArgs e)
        {
            int startIndex = Array.IndexOf(from, current);
            int endIndex = Array.IndexOf(from, to);
            if (startIndex != -1 && endIndex != -1)
            {
                int distance = Math.Abs(endIndex - startIndex);
                dist = distance;
                form4.dist = distance;
                this.Hide();
                form4.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("please Choose Your Distination");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // User clicked Yes, perform logout actions
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void From_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            current = From_cmbox.Text;
        }

        private void to_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            to = to_cmbox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
            this.Close();
        }

        private void username_labl_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }
    }
}
