using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Login_Emp : Form
    {

        public Login_Emp()
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
                cmd.CommandText = "SELECT* FROM EmployeeTbl where EmpLogin = '" + user + "' AND EmpPass = '" + pass + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Home_Emp obj = new Home_Emp();
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

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            temp.angajat = Nametxt.Text;
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
    }
}