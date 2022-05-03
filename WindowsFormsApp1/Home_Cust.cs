using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home_Cust : Form
    {

        public Home_Cust()
        {
            InitializeComponent();
            CountDogs();
            CountCats();
            CountBirds();
            Finance();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PetShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void CountDogs()
        {
            string dog = "Dog";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrCat = '" + dog + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DogsLbl.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's been a problem ==>" + ex.Message);
            }
            finally
            {
                
                con.Close();
            }
        }
        private void CountCats()
        {
            string cat = "Cat";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrCat = '" + cat + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                LblCat.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's been a problem ==>" + ex.Message);
            }
            finally
            {
               
                con.Close();
            }
        }
        private void CountBirds()
        {
            string cat = "Bird";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ProductTbl where PrCat = '" + cat + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BirdLbl.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's been a problem ==>" + ex.Message);
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
                MessageBox.Show("There's been a problem ==>" + ex.Message);
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
    }
}
