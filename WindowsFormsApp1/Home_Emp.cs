using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home_Emp : Form
    {
        
        public Home_Emp()
        {
            InitializeComponent();
            label7.Text = temp.angajat;
            CountDogs();
            CountCats();
            CountBirds();
            Finance();
        }
        Point lastPoint;
        private void top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void top_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = PetShopDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void CountDogs()
        {
            string dog = "Caine";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrType = '" + dog + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DogsLbl.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o problema ==>" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void CountCats()
        {
            string cat = "Pisica";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrType = '" + cat + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblCat.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o problema ==>" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void CountBirds()
        {
            string cat = "Pasare";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrType = '" + cat + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BirdLbl.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o problema ==>" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Finance()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select sum(Amt) from BillTbl", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                lblFinance.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o problema ==>" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Billings obj = new Billings();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Choose_user obj = new Choose_user();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
