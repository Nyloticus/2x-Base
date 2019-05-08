using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyTry1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //sales
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Medicine
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Expenses
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reports
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //staff
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //cosmetics
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Injection
            this.Hide();
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }
    }
}
