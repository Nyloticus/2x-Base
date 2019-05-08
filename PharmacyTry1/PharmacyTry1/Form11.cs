using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyTry1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            updateCal();
        }
        void updateCal()
        {
            this.dateTimePicker1.Font = new Font("Cambria", 12);
            this.dateTimePicker1.CalendarForeColor = Color.FromArgb(41, 44, 51);
            this.dateTimePicker1.CalendarMonthBackground = Color.FromArgb(41, 44, 51);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //cosmetics
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dashboard
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
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

        private void button5_Click(object sender, EventArgs e)
        {
            //sales
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = @"insert into injection values (@shift_mang,@doc_name,@inj_name,@shot_date)";
            cmd.Parameters.Add("@shift_mang", SqlDbType.VarChar);
            cmd.Parameters.Add("@doc_name", SqlDbType.VarChar);
            cmd.Parameters.Add("@inj_name", SqlDbType.VarChar);
            cmd.Parameters.Add("@shot_date", SqlDbType.Date);
            

            cmd.Parameters[0].Value = textBox2.Text;
            cmd.Parameters[1].Value = textBox3.Text;
            cmd.Parameters[2].Value = textBox1.Text;
            cmd.Parameters[3].Value = dateTimePicker1.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Added");
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f15 = new Form15();
            f15.ShowDialog();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
