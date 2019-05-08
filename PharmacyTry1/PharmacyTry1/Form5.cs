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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            updateCal();
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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //cosmetics
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Injection
            this.Hide();
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = @"insert into medicine values (@med_id,@medicine_name,@category,@selling_price,@purchase_price,@quantity,@company_name,@expire_date,@sold_quantity)";
            cmd.Parameters.Add("@med_id", SqlDbType.BigInt);
            cmd.Parameters.Add("@medicine_name", SqlDbType.VarChar);
            cmd.Parameters.Add("@category", SqlDbType.VarChar);
            cmd.Parameters.Add("@selling_price", SqlDbType.Decimal);
            cmd.Parameters.Add("@purchase_price", SqlDbType.Decimal);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters.Add("@company_name", SqlDbType.VarChar);
            cmd.Parameters.Add("@expire_date", SqlDbType.Date);
            cmd.Parameters.Add("@sold_quantity", SqlDbType.Int);

            cmd.Parameters[0].Value = textBox5.Text;
            cmd.Parameters[1].Value = textBox1.Text;
            cmd.Parameters[2].Value = textBox2.Text;
            cmd.Parameters[3].Value = textBox3.Text;
            cmd.Parameters[4].Value = textBox4.Text;
            cmd.Parameters[5].Value = textBox6.Text;
            cmd.Parameters[6].Value = textBox7.Text;
            cmd.Parameters[7].Value = dateTimePicker1.Text;
            cmd.Parameters[8].Value = 0;

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

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f12 = new Form12();
            f12.ShowDialog();

        }
        void updateCal()
        {
            this.dateTimePicker1.Font = new Font("Cambria", 12);
            this.dateTimePicker1.CalendarForeColor = Color.FromArgb(41, 44, 51);
            this.dateTimePicker1.CalendarMonthBackground = Color.FromArgb(41, 44, 51);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
