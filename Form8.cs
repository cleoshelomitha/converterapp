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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;

            if(value1 == "KM3")
            {
                if(value2 == "KM3")
                {
                    hasil = angka * 1;
                }
                else if(value2 == "HM3")
                {
                    hasil = angka * 1000;
                }
                else if(value2 == "DAM3")
                {
                    hasil = angka * 1000000;
                }
                else if(value2 == "M3")
                {
                    hasil = angka * 1000000000;
                }
                else if(value2 == "DM3")
                {
                    hasil = angka * 1000000000000;
                }
                else if(value2 == "CM3")
                {
                    hasil = angka * 1000000000000000;
                }
                else if(value2 == "MM3")
                {
                    hasil = angka * 1000000000000000000;
                }
                else if(value2 == "KL")
                {
                    hasil = angka * 1000000000;
                }
                else if(value2 == "HL")
                {
                    hasil = angka * 10000000000;
                }
                else if(value2 == "L")
                {
                    hasil = angka * 1000000000000;
                }
                else if(value2 == "DL")
                {
                    hasil = angka * 10000000000000;
                }
                else if(value2 == "CL")
                {
                    hasil = angka * 100000000000000;
                }
                else if(value2 == "ML")
                {
                    hasil = angka * 1000000000000000;
                }
            }

            if (value1 == "HM3")
            {
                if (value2 == "HM3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka * 10000000000000000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka * 1000000000;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 1000000000000;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 1000000000000000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka * 10000000;
                }
                else if (value2 == "L")
                {
                    hasil = angka * 1000000000;
                }
                else if (value2 == "DL")
                {
                    hasil = angka * 10000000000;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 100000000000;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 1000000000000;
                }
            }

            if (value1 == "DAM3")
            {
                if (value2 == "DAM3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 1000000000;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 1000000000000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "L")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "DL")
                {
                    hasil = angka * 10000000;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 100000000;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 1000000000;
                }
            }

            if (value1 == "M3")
            {
                if (value2 == "M3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 1000000000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "HL")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "L")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "DL")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 1000000;
                }
            }

            if (value1 == "DM3")
            {
                if (value2 == "DM3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 1000000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "L")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "DL")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 1000;
                }
            }

            if (value1 == "CM3")
            {
                if (value2 == "CM3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000000000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 1000000000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 1000000000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "HL")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "L")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "DL")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 1;
                }
            }

            if (value1 == "MM3")
            {
                if (value2 == "MM3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000000000000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 1000000000000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 1000000000000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka / 1000000000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka / 1000000000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka / 100000000;
                }
                else if (value2 == "L")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "DL")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "CL")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "ML")
                {
                    hasil = angka / 1000;
                }
            }

            if (value1 == "KL")
            {
                if (value2 == "KL")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 1000000000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "L")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "DL")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 1000000;
                }
            }

            if (value1 == "HL")
            {
                if (value2 == "HL")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 10000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 10000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 100000000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "L")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "DL")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 100000;
                }
            }

            if (value1 == "L")
            {
                if (value2 == "L")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 1000000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 1000000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "DL")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 1000;
                }
            }

            if (value1 == "DL")
            {
                if (value2 == "DL")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 10000000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 10000000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 10000000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "L")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "CL")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 100;
                }
            }

            if (value1 == "CL")
            {
                if (value2 == "CL")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 100000000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 100000000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 100000000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "L")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "DL")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "ML")
                {
                    hasil = angka * 10;
                }
            }

            if (value1 == "ML")
            {
                if (value2 == "ML")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "KM3")
                {
                    hasil = angka / 1000000000000000;
                }
                else if (value2 == "HM3")
                {
                    hasil = angka / 1000000000000;
                }
                else if (value2 == "DAM3")
                {
                    hasil = angka / 1000000000;
                }
                else if (value2 == "M3")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "DM3")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "CM3")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "MM3")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "KL")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "HL")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "L")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "DL")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "CL")
                {
                    hasil = angka / 10;
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
