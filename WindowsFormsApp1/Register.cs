using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = mysql.freehostia.com; port = 3306; username=fincri_petshop; password=f._qDNdNMf-#6e@; database=fincri_petshop; connect timeout=5; convert zero datetime=True");
     
        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (Login_txt.Text == "")
            {
                MessageBox.Show("Adaugati numele de utilizator");
                return;
            }
            if (Password_txt.Text == "")
            {
                MessageBox.Show("Adaugati parola");
                return;
            }
            if (Name_txt.Text == "")
            {
                MessageBox.Show("Adaugati numele");
                return;
            }
            if (Surname_txt.Text == "")
            {
                MessageBox.Show("Adaugati prenumele");
                return;
            }
            else if (Login_txt.Text != "" && Password_txt.Text != "" && Name_txt.Text != "" && Surname_txt.Text != "")
            {
                try
                {
                    //deschiderea conexiunii cu baza de date
                    con.Open();
                   
                    MySqlCommand cmd = new MySqlCommand("insert into CustomerTbl (CustLogin, CustPass, CustName, CustSurname,CustPhone, CustAdd) values(@CL, @CPA, @CN, @CS,@CP,@CA)", con);
                    
                    //atribuim valorile instrucțiunii pentru a evita concatenarea valorilor
                    cmd.Parameters.AddWithValue("@CL", Login_txt.Text);
                    cmd.Parameters.AddWithValue("@CPa", Password_txt.Text);
                    cmd.Parameters.AddWithValue("@CN", Name_txt.Text);
                    cmd.Parameters.AddWithValue("@CS", Surname_txt.Text);
                    cmd.Parameters.AddWithValue("@CP", Phone_txt.Text);
                    cmd.Parameters.AddWithValue("@CA", Adress_txt.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Clientul : " + Login_txt.Text + " a fost adaugat");
                    con.Close();        

                    Login_Cust login = new Login_Cust();
                    login.Show();
                    this.Close();
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           Application.Exit();
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
