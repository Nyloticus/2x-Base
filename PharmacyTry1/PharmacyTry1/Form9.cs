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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sold;
            string all;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter The Medicine name");
                this.textBox1.Focus();
                return;
            }
            else
            {

                string MedicineName = textBox1.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("select medicine_name from medicine where med_id = 1",con);
                SqlDataReader AltReader = null;
                AltReader = cmd.ExecuteReader();
                while (AltReader.Read())
                {
                    string value = AltReader["medicine_name"].ToString();
                    //con.Close();


                    if (textBox1.Text.Equals(value))
                    {
                        SqlConnection con1 = new SqlConnection();
                        con1.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
                        con1.Open();
                        DataTable DT = new DataTable();
                        SqlDataReader FirstReader = null;
                        //SqlCommand cmd1 = new SqlCommand(String.Format("select * from medicine where medicine_name = 'Travix' "), con1);
                        SqlCommand cmd1 = new SqlCommand("select * from medicine where medicine_name = @MedicineName",con1);
                        cmd1.Parameters.Add("MedicineName", SqlDbType.VarChar).Value = Convert.ToString(textBox1.Text);
                        FirstReader = cmd1.ExecuteReader();
                        int allX;
                        int soldx;
                        while (FirstReader.Read())
                        {
                            textBox2.Text = (FirstReader["expire_date"].ToString());
                            textBox3.Text = (FirstReader["quantity"].ToString());
                            textBox5.Text = (FirstReader["selling_price"].ToString());
                            textBox4.Text = (FirstReader["sold_quantity"].ToString());
                            all = (FirstReader["quantity"].ToString());
                            sold = (FirstReader["sold_quantity"].ToString());
                            allX = Convert.ToInt32(all);
                            soldx = Convert.ToInt32(sold);
                            int avaliable = allX - soldx;
                            textBox3.Text = avaliable.ToString();




                        }

                        con1.Close();

                    }
                    else
                    {
                        MessageBox.Show("wether medicine name is wrong or the medicine doesn't exist");
                    }
                }
                con.Close();

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

            string quan = textBox8.Text.ToString();
            string MedicineName = textBox7.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from medicine where med_id = 1", con);

            SqlDataReader AltReader = null;
            AltReader = cmd.ExecuteReader();
            while (AltReader.Read())
            {
                string value = AltReader["medicine_name"].ToString();
                string quanUltra = AltReader["sold_quantity"].ToString();
                //con.Close();


                if (textBox7.Text.Equals(value))
                {
                    int quan3 = Convert.ToInt32(quan);
                    int quan4 = Convert.ToInt32(quanUltra);
                    int quan5 = quan3 + quan4;
                    string LastQuan = quan5.ToString();
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
                    con1.Open();
                    DataTable DT = new DataTable();
                    //SqlCommand cmd1 = new SqlCommand(String.Format("update medicine set sold_quantity = 1 where medicine_name = 'Travix'"), con1);
                    SqlCommand cmd1 = new SqlCommand("update medicine set sold_quantity = @LastQuan where medicine_name = @MedicineName", con1);
                    cmd1.Parameters.Add("MedicineName", SqlDbType.VarChar).Value = Convert.ToString(textBox7.Text);
                    cmd1.Parameters.Add("LastQuan", SqlDbType.Int).Value = quan5.ToString();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                  

                    con1.Close();

                }
                else
                {
                    MessageBox.Show("wether medicine name is wrong or the medicine doesn't exist");
                }
            }
            con.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
