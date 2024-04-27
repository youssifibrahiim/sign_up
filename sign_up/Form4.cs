using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up
{
    public partial class Form4 : Form
    {
        public string[] drivername {  get; set; }
        public int dist { get; set; }
        public double off { get; set; }
        public Form4()
        {
            InitializeComponent();
        }
        private void UpdateLabel4()
        {
            if (driver_lst.SelectedItem != null)
            {
                
                label4.Text = $"Your Captain is: {drivername[driver_lst.SelectedIndex]}";
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            double price = 5;
            price = price * dist;
            double off = price * Form7.offer;
            price -= off;
            price_labl.Text = $"Price: {price.ToString()} EGP";
            price_labl.AutoSize = true;

            double time = 2.5;
            time *= (double)dist;
            label2.Text = $"Time: {time.ToString()} min";
            label2.AutoSize = true;

            drivername = new string[7];
            driver_lst.SelectedIndexChanged += (s, ev) => UpdateLabel4();
            Driver[] driversArray = Driver.AssignDrivers();
            int i = 0;
            foreach (Driver driver in driversArray)
            {
                driver_lst.Items.Add($"{driver.name} >> Away {driver.distance}Km >> Car {driver.cartype}");
                drivername[i] = driver.name;
                i++;
            }
        }
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        class Driver
        {
            public int distance { get; private set; }
        public string name { get; private set; }
            public string cartype { get; private set; }

            private static string[] carTypes =
            {
                "Toyota Corolla",
                "Kia Cerato",
                "Hyundai verna",
                "Nissan Sunny",
                "Chevrolet Aveo",
                "Lancer Boma"
            };

            private static string[] names =
            {
                "Batoo",
                "Banbon",
                "Salo7",
                "Y7yo7",
                "3amdon",
                "Khaled",
                "Ali",
                "Murad",
                "Fares",
                "Nasser",
                "Youssef",
                "Moaz",
                "Ziad",
                "Firas"
            };

            public Driver(string driverName, int driverDistance, string driverCartype)
            {
                name = driverName;
                distance = driverDistance;
                cartype = driverCartype;
            }

            public static Driver[] AssignDrivers()
            {
                Random random = new Random();
                int numberOfDrivers = random.Next(1, 6);
                Driver[] drivers = new Driver[numberOfDrivers];

                for (int i = 0; i < numberOfDrivers; i++)
                {
                    // Generate random index for name and car type
                    int nameIndex = random.Next(names.Length);
                    int carTypeIndex = random.Next(carTypes.Length);

                    // Create a new Driver with random name, distance, and car type
                    drivers[i] = new Driver(names[nameIndex], random.Next(1, 7), carTypes[carTypeIndex]);
                }

                return drivers;
            }
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (driver_lst.SelectedIndex == -1)
            {
                Form3 form3 = new Form3();
                MessageBox.Show("please Choose Your Request");

            }
            else
            {
                this.Hide();
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Close();
            }
        }

        private void driver_lst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
