using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login_Emp : Form
    {
        public Login_Emp()
        {
            InitializeComponent();
            
        }
        
       SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PetShopDb.mdf;Integrated Security=True;Asynchronous Processing=True;User Instance=False;Context Connection=False");
        SqlCommand cmd;
        
        SqlDataReader dr;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btlReset_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Passwordtxt.Text = "";
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string user = Nametxt.Text;
                string pass = Passwordtxt.Text;

                //ceva
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT* FROM EmployeeTbl where EmpName = '" + user + "' AND EmpPass = '" + pass + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {                 
                    Home obj = new Home();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
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
    }
}