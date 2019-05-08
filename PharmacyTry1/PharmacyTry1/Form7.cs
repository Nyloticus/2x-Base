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
    public partial class Form7 : Form
    {
        public Form7()
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

        private void Form7_Load(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            //Expenses
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //staff
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Medicine
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
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

        private void button10_Click(object sender, EventArgs e)
        {
            
           
            if (String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Please Enter The Date ");
                this.dateTimePicker1.Focus();
                return;
            }
            else
            {

                string ondate = dateTimePicker1.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from expenses where added_date = @ondate ", con);
                cmd.Parameters.Add("ondate", SqlDbType.Date).Value = Convert.ToString(dateTimePicker1.Text);
                SqlDataReader AltReader = null;
                AltReader = cmd.ExecuteReader();
                while(AltReader.Read())
                {
                    string first = (AltReader["amount"].ToString());
                    string seconed = (AltReader["expenses_criteria"].ToString());
                    int one = Convert.ToInt32(first);
                    decimal two = Convert.ToDecimal(seconed);
                    decimal three = one * two;
                    textBox3.Text = three.ToString();

                    /* string value = AltReader["added_date"].ToString();
                     //textBox3.Text = (AltReader["amount"].ToString());
                     if(ondate == value)
                     {
                         SqlConnection con1 = new SqlConnection();
                         con1.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
                         con1.Open();
                         DataTable DT = new DataTable();
                         SqlDataReader FirstReader = null;
                         //SqlCommand cmd1 = new SqlCommand(String.Format("select * from medicine where medicine_name = 'Travix' "), con1);
                         SqlCommand cmd1 = new SqlCommand("select * from expenses where added_date = @ondate", con1);
                         cmd1.Parameters.Add("ondate", SqlDbType.Date).Value = Convert.ToString(dateTimePicker1.Text);
                         FirstReader = cmd1.ExecuteReader();

                         while(FirstReader.Read())
                         {
                             textBox3.Text = (FirstReader["amount"].ToString());
                         }
                     }
                     else
                     {
                         MessageBox.Show("Looks Like no expenses have been added on this date");
                     }
                     */
                }
                con.Close();

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
