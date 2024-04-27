using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sign_up
{
  
    public partial class Form6 : Form
    {
        public string UserName { get; set; }
        public static int numoftrips { get; set; }
        public Form6()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numoftrips++;
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numoftrips++;
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
    }
}









