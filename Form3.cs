using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertercleoshelomitha
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;

            if(value1 == "KM")
            {
                if (value2 == "KM")
                {
                    hasil = angka * 1;
                }
                else  if (value2 == "HM")
                {
                    hasil = angka * 10;
                }
                else  if (value2 == "DAM")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "M")
                {
                    hasil = angka * 1000;
                }
                else if(value2 == "DM")
                {
                    hasil = angka * 10000;
                }
                else if(value2 == "CM")
                {
                    hasil = angka * 100000;
                }
                else if(value2 == "MM")
                {
                    hasil = angka * 1000000;
                }
            }
            if(value1 == "HM")
            {
                if (value2 == "KM")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "HM")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "DAM")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "M")
                {
                    hasil = angka * 100;
                }
                else if(value2 == "DM")
                {
                    hasil = angka * 1000;
                }
                else if(value2 == "CM")
                {
                    hasil = angka * 10000;
                }
                else if(value2 == "MM")
                {
                    hasil = angka * 100000;
                }
            }

            if (value1 == "DAM")
            {
                if (value2 == "KM")
                {
                    hasil = angka / 100;
                }
                else if(value2 == "HM")
                {
                    hasil = angka / 10;
                }
                else if(value2 == "DAM")
                {
                    hasil = angka * 1;
                }
                else if(value2 == "M")
                {
                    hasil = angka * 10;
                }
                else if(value2 == "DM")
                {
                    hasil = angka * 100;
                }
                else if(value2 == "CM")
                {
                    hasil = angka * 1000;
                }
                else if(value2 == "MM")
                {
                    hasil = angka * 10000;
                }
            }

            if (value1 == "M")
            {
                if (value2 == "KM")
                {
                    hasil = angka / 1000;
                }
                else if(value2 == "HM")
                {
                    hasil = angka / 100;
                }
                else if(value2 == "DAM")
                {
                    hasil = angka / 10;
                }
                else if(value2 == "M")
                {
                    hasil = angka * 1; 
                }
                else if(value2 == "DM")
                {
                    hasil = angka * 100;
                }
                else if(value2 == "CM")
                {
                    hasil = angka * 1000;
                }
                else if(value2 == "MM")
                {
                    hasil = angka * 10000;
                }

                if(value1 == "DM")
                {
                    if(value2 == "KM")
                    {
                        hasil = angka / 10000;
                    }
                    else if(value2 == "HM")
                    {
                        hasil = angka / 1000;
                    }
                    else if(value2 == "DAM")
                    {
                        hasil = angka / 100;
                    }
                    else if(value2 == "M")
                    {
                        hasil = angka / 10;
                    }
                    else if(value2 == "DM")
                    {
                        hasil = angka * 1;
                    }
                    else if(value2 == "CM")
                    {
                        hasil = angka * 10;
                    }
                    else if(value2 == "MM")
                    {
                        hasil = angka * 100;
                    }
                }

                if (value1 == "CM")
                {
                    if (value2 == "KM")
                    {
                        hasil = angka / 100000;
                    }
                    else if (value2 == "HM")
                    {
                        hasil = angka / 10000;
                    }
                    else if (value2 == "DAM")
                    {
                        hasil = angka / 1000;
                    }
                    else if (value2 == "M")
                    {
                        hasil = angka / 100;
                    }
                    else if (value2 == "DM")
                    {
                        hasil = angka / 10;
                    }
                    else if (value2 == "CM")
                    {
                        hasil = angka * 1;
                    }
                    else if (value2 == "MM")
                    {
                        hasil = angka * 10;
                    }
                }

                if (value1 == "MM")
                {
                    if (value2 == "KM")
                    {
                        hasil = angka / 1000000;
                    }
                    else if (value2 == "HM")
                    {
                        hasil = angka / 100000;
                    }
                    else if (value2 == "DAM")
                    {
                        hasil = angka / 10000;
                    }
                    else if (value2 == "M")
                    {
                        hasil = angka / 1000;
                    }
                    else if (value2 == "DM")
                    {
                        hasil = angka / 100;
                    }
                    else if (value2 == "CM")
                    {
                        hasil = angka / 10;
                    }
                    else if (value2 == "MM")
                    {
                        hasil = angka * 1;
                    }
                }
            }

            label3.Text = ("hasil = " + hasil);
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
