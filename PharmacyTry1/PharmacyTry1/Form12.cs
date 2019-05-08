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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            UpdateFont();
            UpdateData();
        }
        private void UpdateFont()
        {
            //this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            //this.dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(62, 120, 138);
            //this.dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(41, 44, 51);
            //this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            //this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.BackgroundColor = Color.FromArgb(41, 44, 51);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);

        }
        void UpdateData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from medicine", con);
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = cmd;
                DataTable dt = new DataTable();
                ad.Fill(dt);

                BindingSource b = new BindingSource();
                b.DataSource = dt;
                dataGridView1.DataSource = dt;
                ad.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-A1BNHN2;Initial Catalog=ph;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from medicine", con);
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = cmd;
                DataTable dt = new DataTable();
                ad.Fill(dt);

                BindingSource b = new BindingSource();
                b.DataSource = dt;
                dataGridView1.DataSource = dt;
                ad.Update(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
