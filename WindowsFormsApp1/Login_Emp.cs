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

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string user = Nametxt.Text;
                string pass = Passwordtxt.Text;

                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT* FROM EmployeeTbl where EmpName = '" + user + "' AND EmpPass = '" + pass + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Home_Cust obj = new Home_Cust();
                    ((Home_Cust)obj).label_emp_name.Text = user;

                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Logare invalidă! Verificați dacă datele sunt introduse corect și încercați din nou");
                    Nametxt.Text = "";
                    Passwordtxt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o excepție ==>" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}