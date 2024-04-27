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
    public partial class Form7 : Form
    {
        public static double offer { get; set; }
        public static int pp = 0; //current points
        public static int n = 0; //used points
        public Form7()
        {
            InitializeComponent();
        }

        public void Form7_Load(object sender, EventArgs e)
        {
            int point = 1;
            pp = pp + (point * Form3.dist) - n;
            Form3.dist = 0;
            n = 0;
            label1.Text += pp.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool flag = false;
            if (radioButton1.Checked && pp > 25)
            {
                offer = 0.25;
                flag = true;
                n = 25;
            }
            else if(radioButton2.Checked && pp > 50)
            {
                offer = 0.5;
                flag = true;
                n = 50;
            }
            else if(radioButton3.Checked && pp > 75)
            {
                offer = 0.75;
                flag = true;
                n = 75;
            }
            else if (radioButton4.Checked && pp > 100)
            {
                offer = 1;
                flag = true;
                n = 100;
            }
            else
            {
                MessageBox.Show("The Points isn't Enough");
            }
            if (flag)
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.ShowDialog();
                this.Close();
            }
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
