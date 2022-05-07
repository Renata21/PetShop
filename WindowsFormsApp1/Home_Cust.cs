using MySql.Data.MySqlClient;
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
            label7.Text = temp.client;
            CountDogs();
            CountCats();
            CountBirds();
        }

        MySqlConnection con = new MySqlConnection("server = mysql.freehostia.com; port = 3306; username=fincri_petshop; password=f._qDNdNMf-#6e@; database=fincri_petshop; connect timeout=5; convert zero datetime=True");

        private void CountDogs()
        {
            string dog = "Caine";
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select sum(PrQty) from ProductTbl where PrType = '" + dog + "'", con);
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
                MySqlDataAdapter sda = new MySqlDataAdapter("select sum(PrQty) from ProductTbl where PrType = '" + cat + "'", con);
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
                MySqlDataAdapter sda = new MySqlDataAdapter("select sum(PrQty) from ProductTbl where PrType = '" + cat + "'", con);
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

        private void label2_Click(object sender, EventArgs e)
        {
            ProductsCustomer obj = new ProductsCustomer();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BillingsCustomer obj = new BillingsCustomer();
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
