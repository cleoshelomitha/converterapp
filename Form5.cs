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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(textBox1.Text);

            double hasil = 0;

            if (value1 == "DETIK")
            {
                if (value2 == "DETIK")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "MENIT")
                {
                    hasil = angka / 60;
                }
                else if (value2 == "JAM")
                {
                    hasil = angka / 3600;
                }
                else if (value2 == "HARI")
                {
                    hasil = angka / 86400;
                }
                else if(value2 == "MINGGU")
                {
                    hasil = angka / 604800;
                }
                else if(value2 == "BULAN")
                {
                    hasil = angka / 2629800;
                }
                else if(value2 == "TAHUN")
                {
                    hasil = angka / 31557600;
                }
                else if(value2 == "ABAD")
                {
                    hasil = angka / 31356000;
                }
            }
            if (value1 == "MENIT")
            {
                if (value2 == "DETIK")
                {
                    hasil = angka * 60;
                }
                else if (value2 == "MENIT")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "JAM")
                {
                    hasil = angka / 60;
                }
                else if (value2 == "HARI")
                {
                    hasil = angka / 1440;
                }
                else if(value2 == "MINGGU")
                {
                    hasil = angka / 10080;
                }
                else if(value2 == "BULAN")
                {
                    hasil = angka / 43800;
                }
                else if(value2 == "TAHUN")
                {
                    hasil = angka / 525600;
                }
                else if(value2 == "ABAD")
                {
                    hasil = angka / 525600000;
                }
            }

            if (value1 == "JAM")
            {
                if (value2 == "DETIK")
                {
                    hasil = angka * 3600;
                }
                else if (value2 == "MENIT")
                {
                    hasil = angka * 60;
                }
                else if (value2 == "JAM")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "HARI")
                {
                    hasil = angka / 24;
                }
                else if(value2 == "MINGGU")
                {
                    hasil = angka / 168;
                }
                else if(value2 == "BULAN")
                {
                    hasil = angka / 730;
                }
                else if(value2 == "TAHUN")
                {
                    hasil = angka / 8760;
                }
                else if(value2 == "ABAD")
                {
                    hasil = angka / 876000;
                }
            }

            if (value1 == "HARI")
            {
                if (value2 == "DETIK")
                {
                    hasil = angka * 86400;
                }
                else if (value2 == "MENIT")
                {
                    hasil = angka * 1440;
                }
                else if (value2 == "JAM")
                {
                    hasil = angka * 24;
                }
                else if (value2 == "HARI")
                {
                    hasil = angka * 1;
                }
                else if(value2 == "MINGGU")
                {
                    hasil = angka / 7;
                }
                else if(value2 == "BULAN")
                {
                    hasil = angka / 30.417;
                }
                else if(value2 == "TAHUN")
                {
                    hasil = angka / 365;
                }
                else if(value2 == "ABAD")
                {
                    hasil = angka / 36500;
                }

                if (value1 == "MINGGU")
                {
                    if (value2 == "DETIK")
                    {
                        hasil = angka * 604800;
                    }
                    else if (value2 == "MENIT")
                    {
                        hasil = angka * 10080;
                    }
                    else if (value2 == "JAM")
                    {
                        hasil = angka * 168;
                    }
                    else if (value2 == "HARI")
                    {
                        hasil = angka * 7;
                    }
                    else if (value2 == "MINGGU")
                    {
                        hasil = angka * 1;
                    }
                    else if (value2 == "BULAN")
                    {
                        hasil = angka / 4.345;
                    }
                    else if (value2 == "TAHUN")
                    {
                        hasil = angka / 52.143;
                    }
                    else if (value2 == "ABAD")
                    {
                        hasil = angka / 5214;
                    }
                }

                if (value1 == "BULAN")
                {
                    if (value2 == "DETIK")
                    {
                        hasil = angka * 2629800;
                    }
                    else if (value2 == "MENIT")
                    {
                        hasil = angka * 43800;
                    }
                    else if (value2 == "JAM")
                    {
                        hasil = angka * 730;
                    }
                    else if (value2 == "HARI")
                    {
                        hasil = angka * 30.417;
                    }
                    else if (value2 == "MINGGU")
                    {
                        hasil = angka * 4.345;
                    }
                    else if (value2 == "BULAN")
                    {
                        hasil = angka * 1;
                    }
                    else if (value2 == "TAHUN")
                    {
                        hasil = angka / 12;
                    }
                    else if (value2 == "ABAD")
                    {
                        hasil = angka / 1200;
                    }
                }

                if (value1 == "TAHUN")
                {
                    if (value2 == "DETIK")
                    {
                        hasil = angka * 31536000;
                    }
                    else if (value2 == "MENIT")
                    {
                        hasil = angka * 525600;
                    }
                    else if (value2 == "JAM")
                    {
                        hasil = angka * 8760;
                    }
                    else if (value2 == "HARI")
                    {
                        hasil = angka * 365;
                    }
                    else if (value2 == "MINGGU")
                    {
                        hasil = angka * 52.143;
                    }
                    else if (value2 == "BULAN")
                    {
                        hasil = angka * 12;
                    }
                    else if (value2 == "TAHUN")
                    {
                        hasil = angka * 1;
                    }
                    else if (value2 == "ABAD")
                    {
                        hasil = angka / 100;
                    }
                }

                if (value1 == "ABAD")
                {
                    if (value2 == "DETIK")
                    {
                        hasil = angka * 3153600000;
                    }
                    else if (value2 == "MENIT")
                    {
                        hasil = angka * 52560000;
                    }
                    else if (value2 == "JAM")
                    {
                        hasil = angka * 876000;
                    }
                    else if (value2 == "HARI")
                    {
                        hasil = angka * 36500;
                    }
                    else if (value2 == "MINGGU")
                    {
                        hasil = angka * 5200;
                    }
                    else if (value2 == "BULAN")
                    {
                        hasil = angka * 1200;
                    }
                    else if (value2 == "TAHUN")
                    {
                        hasil = angka * 100;
                    }
                    else if (value2 == "ABAD")
                    {
                        hasil = angka * 1;
                    }
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

