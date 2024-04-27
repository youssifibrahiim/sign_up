using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up
{
    public partial class Form1 : Form
    {
        
        Form3 form3 = new Form3();

        public Form1()
        {
            InitializeComponent();
        }
        string filename, record;
        FileStream sign_up_file;
        StreamReader sr;
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             zbyyyyyy
            mngaaaaaa
            elbolbol
             
             
             
             */
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            filename = "C:\\Users\\workstation\\Downloads\\sign_up_and_log_in--master\\sign_up_and_log_in--master\\signup.txt";
            sign_up_file = new FileStream(filename, FileMode.Open, FileAccess.Read); // Changed FileMode.Append to FileMode.Open
            sr = new StreamReader(sign_up_file); // Removed declaration of StreamReader
             record = sr.ReadLine();
            string[] check;
            while (record != null)
            {
                check = record.Split(',');
                if (email_txt.Text == check[2] && pass_txt.Text == check[3])
                {

                    form3.UserName = check[0];
                    this.Hide();
                    form3.Show();
                    return;
                }
                record = sr.ReadLine(); // Advance to the next line
            }
            MessageBox.Show("not found");
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5(this);
            form5.ShowDialog();
            this.Show();
        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {

           
            

        }

        private void pass_txt_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email_labl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            pass_txt.UseSystemPasswordChar = !pass_txt.UseSystemPasswordChar;
            button1.Text = pass_txt.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private void pass_labl_Click(object sender, EventArgs e)
        {

        }

        private void email_txt_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
 