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
    public partial class Form2 : Form
    {
        [Obsolete]
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Click += new EventHandler(bunifuImageButton1_Click);
            Controls.Add(bunifuImageButton1);
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuImageButton2.Click += new EventHandler(bunifuImageButton2_Click);
            Controls.Add(bunifuImageButton2);
            Form4 fm4 = new Form4();
            fm4.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuImageButton3.Click += new EventHandler(bunifuImageButton3_Click);
            Controls.Add(bunifuImageButton3);
            Form5 fm5 = new Form5();
            fm5.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            bunifuImageButton4.Click += new EventHandler(bunifuImageButton4_Click);
            Controls.Add(bunifuImageButton4);
            Form6 fm6 = new Form6();
            fm6.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            bunifuImageButton5.Click += new EventHandler(bunifuImageButton5_Click);
            Controls.Add(bunifuImageButton5);
            Form7 fm7 = new Form7();
            fm7.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            bunifuImageButton6.Click += new EventHandler(bunifuImageButton6_Click);
            Controls.Add(bunifuImageButton6);
            Form8 fm8 = new Form8();
            fm8.ShowDialog();
            this.Hide();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
