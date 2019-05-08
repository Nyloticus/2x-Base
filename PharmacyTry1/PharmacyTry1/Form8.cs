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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dashboard
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
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

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = @"insert into employee values (@emp_name,@email,@phone,@address,@username,@password,@job_title)";
            cmd.Parameters.Add("@emp_name", SqlDbType.VarChar);
            cmd.Parameters.Add("@email", SqlDbType.VarChar);
            cmd.Parameters.Add("@phone", SqlDbType.Int);
            cmd.Parameters.Add("@address", SqlDbType.VarChar);
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters.Add("@password", SqlDbType.VarChar);
            cmd.Parameters.Add("@job_title", SqlDbType.VarChar);


            cmd.Parameters[0].Value = textBox1.Text;
            cmd.Parameters[1].Value = textBox2.Text;
            cmd.Parameters[2].Value = textBox3.Text;
            cmd.Parameters[3].Value = textBox4.Text;
            cmd.Parameters[4].Value = textBox5.Text;
            cmd.Parameters[5].Value = textBox6.Text;
            cmd.Parameters[6].Value = textBox8.Text;


            cmd.ExecuteNonQuery();
            MessageBox.Show("Added");
            con.Close();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 f14 = new Form14();
            f14.ShowDialog();
        }
    }
}
