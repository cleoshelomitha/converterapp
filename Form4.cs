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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;


            if (value1 == "KG")
            {
                if (value2 == "KG")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "HG")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "DAG")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "G")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "DG")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "CG")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "MG")
                {
                    hasil = angka * 1000000;
                }
            }

            if (value1 == "HG")
            {
                if (value2 == "KG")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "HG")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "DAG")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "G")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "DG")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "CG")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "MG")
                {
                    hasil = angka * 100000;
                }
            }

            if (value1 == "DAG")
            {
                if (value2 == "KG")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "HG")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "DAG")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "G")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "DG")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "CG")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "MG")
                {
                    hasil = angka * 10000;
                }
            }

            if (value1 == "G")
            {
                if (value2 == "KG")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "HG")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "DAG")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "G")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "DG")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "CG")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "MG")
                {
                    hasil = angka * 10000;
                }
            }

            if (value1 == "DG")
            {
                if (value2 == "KG")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "HG")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "DAG")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "G")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "DG")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "CG")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "MG")
                {
                    hasil = angka * 100;
                }
            }

            if (value1 == "CG")
            {
                if (value2 == "KG")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "HG")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "DAG")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "G")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "DG")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "CG")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "MG")
                {
                    hasil = angka * 10;
                }
            }

            if (value1 == "MG")
            {
                if (value2 == "KG")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "HG")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "DAG")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "G")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "DG")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "CG")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "MG")
                {
                    hasil = angka * 1;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
