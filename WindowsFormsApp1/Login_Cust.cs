using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login_Cust : Form
    {
        public Login_Cust()
        {
            InitializeComponent();
           
        }

        MySqlConnection con = new MySqlConnection("server = mysql.freehostia.com; port = 3306; username=fincri_petshop; password=f._qDNdNMf-#6e@; database=fincri_petshop; connect timeout=5;");
        MySqlCommand cmd;

        MySqlDataReader dr;
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
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT* FROM CustomerTbl where CustLogin = '" + user + "' AND CustPass = '" + pass + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Home_Cust obj = new Home_Cust();
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

        private void Register_Click(object sender, EventArgs e)
        {
            //va urma
        }

        private void Register_MouseEnter(object sender, EventArgs e)
        {
            Register_btn.ForeColor = System.Drawing.Color.SeaGreen;
        }

        private void Register_btn_MouseLeave(object sender, EventArgs e)
        {
            Register_btn.ForeColor = System.Drawing.Color.Black;
        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            temp.client = Nametxt.Text;
        }
    }
}