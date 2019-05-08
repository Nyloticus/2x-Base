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
    public partial class Form10 : Form
    {
        public Form10()
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
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Injection
            this.Hide();
            Form11 f11 = new Form11();
            f11.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            //staff
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = @"insert into cosmetics values (@co_id,@prod_name,@exp_date,@quan,@distrib_name,@p_price,@s_price)";
            cmd.Parameters.Add("@co_id", SqlDbType.BigInt);
            cmd.Parameters.Add("@prod_name", SqlDbType.VarChar);
            cmd.Parameters.Add("@exp_date", SqlDbType.Date);
            cmd.Parameters.Add("@quan", SqlDbType.Int);
            cmd.Parameters.Add("@distrib_name", SqlDbType.VarChar);
            cmd.Parameters.Add("@p_price", SqlDbType.Decimal);
            cmd.Parameters.Add("@s_price", SqlDbType.Decimal);


            cmd.Parameters[0].Value = textBox2.Text;
            cmd.Parameters[1].Value = textBox1.Text;
            cmd.Parameters[2].Value = dateTimePicker1.Text;
            cmd.Parameters[3].Value = textBox6.Text;
            cmd.Parameters[4].Value = textBox7.Text;
            cmd.Parameters[5].Value = textBox3.Text;
            cmd.Parameters[6].Value = textBox4.Text;


            cmd.ExecuteNonQuery();
            MessageBox.Show("Added");
            con.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 f16 = new Form16();
            f16.ShowDialog();
        }
    }
}
