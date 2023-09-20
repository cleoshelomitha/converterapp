using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertercleoshelomitha
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;

            if (value1 == "CELCIUS")
            {
                if (value2 == "CELCIUS")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "REAMUR")
                {
                    hasil = angka / 5 * 4;
                }
                else if (value2 == "FARENHEIT")
                {
                    hasil = angka / 5 * 9 + 32;
                }
                else if (value2 == "KELVIN")
                {
                    hasil = angka + 273;
                }
            }
            if (value1 == "REAMUR")
            {
                if (value2 == "REAMUR")
                {
                    hasil = angka / 1;
                }
                else if (value2 == "CELCIUS")
                {
                    hasil = angka / 4 * 5;
                }
                else if (value2 == "FARENHEIT")
                {
                    hasil = angka / 4 * 9 + 32;
                }
                else if (value2 == "KELVIN")
                {
                    hasil = angka / 4* 5 + 273;
                }
            }

            if (value1 == "FARENHEIT")
            {
                if (value2 == "FARENHEIT")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "CELCIUS")
                {
                    hasil = angka - 32 / 9 * 5;
                }
                else if (value2 == "REAMUR")
                {
                    hasil = angka - 32 / 9 * 4;
                }
                else if (value2 == "KELVIN")
                {
                    hasil = angka - 32 / 9 * 5 + 273;
                }
            }

            if (value1 == "KELVIN")
            {
                if (value2 == "KELVIN")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "CELCIUS")
                {
                    hasil = angka - 273;
                }
                else if (value2 == "REAMUR")
                {
                    hasil = angka - 273 / 5 * 4;
                }
                else if (value2 == "FARENHEIT")
                {
                    hasil = angka - 273 / 5 * 9 + 32;
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
