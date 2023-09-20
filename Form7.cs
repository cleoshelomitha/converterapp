using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertercleoshelomitha
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;

            if (value1 == "KM2")
            {
                if (value2 == "KM2")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "HM2")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "DAM2")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "M2")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "DM2")
                {
                    hasil = angka * 100000000;
                }
                else if (value2 == "CM2")
                {
                    hasil = angka * 10000000000;
                }
                else if (value2 == "MM2")
                {
                    hasil = angka * 1000000000000;
                }
                else if (value2 == "HA")
                {
                    hasil = angka * 100;
                }
            }

            if (value1 == "HM2")
            {
                if (value2 == "HM2")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM2")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "DAM2")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "M2")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "DM2")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "CM2")
                {
                    hasil = angka * 100000000;
                }
                else if (value2 == "MM2")
                {
                    hasil = angka * 10000000000;
                }
                else if (value2 == "HA")
                {
                    hasil = angka * 1;
                }
            }

            if (value1 == "DAM2")
            {
                if (value2 == "DAM2")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM2")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "HM2")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "M2")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "DM2")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "CM2")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "MM2")
                {
                    hasil = angka * 100000000;
                }
                else if (value2 == "HA")
                {
                    hasil = angka / 100;
                }
            }

            if (value1 == "M2")
            {
                if (value2 == "M2")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM2")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "HM2")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "DAM2")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "DM2")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "CM2")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "MM2")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "HA")
                {
                    hasil = angka / 10000;
                }
            }

            if (value1 == "DM2")
            {
                if (value2 == "DM2")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM2")
                {
                    hasil = angka / 100000000;
                }
                else if (value2 == "HM2")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "DAM2")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "M2")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "CM2")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "MM2")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "HA")
                {
                    hasil = angka / 1000000;
                }
            }

            if (value1 == "CM2")
            {
                if (value2 == "CM2")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM2")
                {
                    hasil = angka / 10000000000;
                }
                else if (value2 == "HM2")
                {
                    hasil = angka / 100000000;
                }
                else if (value2 == "DAM2")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "M2")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "DM2")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "MM2")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "HA")
                {
                    hasil = angka / 100000000;
                }
            }

            if (value1 == "MM2")
            {
                if (value2 == "MM2")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM2")
                {
                    hasil = angka / 1000000000000;
                }
                else if (value2 == "HM2")
                {
                    hasil = angka / 10000000000;
                }
                else if (value2 == "DAM2")
                {
                    hasil = angka / 100000000;
                }
                else if (value2 == "M2")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "DM2")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "CM2")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "HA")
                {
                    hasil = angka / 10000000000;
                }
            }

            if (value1 == "HA")
            {
                if (value2 == "HA")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM2")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "HM2")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "DAM2")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "M2")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "DM2")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "CM2")
                {
                    hasil = angka * 100000000;
                }
                else if (value2 == "MM2")
                {
                    hasil = angka * 10000000000;
                }
            }

            label4.Text = ("hasil = " + hasil);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Click += new
                      EventHandler(button2_Click);
            Controls.Add(button2);
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
            this.Hide();
        }
    }
}
