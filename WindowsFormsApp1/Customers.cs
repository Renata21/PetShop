using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            label7.Text = temp.angajat;
            DisplayCustomers();
        }
        MySqlConnection con = new MySqlConnection("server = mysql.freehostia.com; port = 3306; username=fincri_petshop; password=f._qDNdNMf-#6e@; database=fincri_petshop; connect timeout=5; convert zero datetime=True");
        int key = 0;
        //listaremos los empleados una vez agreguemos uno y cuando se inicie el formulario
        private void DisplayCustomers()
        {
            try
            {
                con.Open();
                string Query = " select *" +
                               " from CustomerTbl";
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
                MySqlCommandBuilder Builder = new MySqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CustomerDGV.DataSource = ds.Tables[0];
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
        private void Clear()
        {
            CustomerName.Text = "";
            CustomerSurname.Text = "";
            CustomerLogin.Text = "";
            CustomerPhone.Text = "";
            CustomerAddress.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CustomerLogin.Text == "")
            {
                MessageBox.Show("Adaugati numele de utilizator");
                return;
            }
            if (CustomerPass.Text == "")
            {
                MessageBox.Show("Adaugati parola");
                return;
            }
            if (CustomerName.Text == "")
            {
                MessageBox.Show("Adaugati numele");
                return;
            }
            if (CustomerSurname.Text == "")
            {
                MessageBox.Show("Adaugati prenumele");
                return;
            }
            else if (CustomerLogin.Text != "" && CustomerPass.Text != "" && CustomerName.Text != "" && CustomerSurname.Text != "")
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into CustomerTbl (CustLogin, CustPass, CustName, CustSurname,CustPhone, CustAdd) values(@CL, @CPA, @CN, @CS,@CP,@CA)", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@CL", CustomerLogin.Text);
                    cmd.Parameters.AddWithValue("@CPa", CustomerPass.Text);
                    cmd.Parameters.AddWithValue("@CN", CustomerName.Text);
                    cmd.Parameters.AddWithValue("@CS", CustomerSurname.Text);
                    cmd.Parameters.AddWithValue("@CP", CustomerPhone.Text);
                    cmd.Parameters.AddWithValue("@CA", CustomerAddress.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clientul : " + CustomerLogin.Text + " a fost adaugat");
                    con.Close();
                    DisplayCustomers();
                    Clear();
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

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
            CustomerLogin.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPass.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustomerName.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
            CustomerSurname.Text = CustomerDGV.SelectedRows[0].Cells[4].Value.ToString();
            CustomerPhone.Text = CustomerDGV.SelectedRows[0].Cells[5].Value.ToString();
            CustomerAddress.Text = CustomerDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Selectati un client");
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from CustomerTbl where CustId = @CustId", con);
                    cmd.Parameters.AddWithValue("@CustId", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client sters");
                    con.Close();
                    DisplayCustomers();
                    key = 0;
                    Clear();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CustomerLogin.Text == "")
            {
                MessageBox.Show("Adaugati numele de utilizator");
                return;
            }
            if (CustomerPass.Text == "")
            {
                MessageBox.Show("Adaugati parola");
                return;
            }
            if (CustomerName.Text == "")
            {
                MessageBox.Show("Adaugati numele");
                return;
            }
            if (CustomerSurname.Text == "")
            {
                MessageBox.Show("Adaugati prenumele");
                return;
            }
            else if (CustomerLogin.Text != "" && CustomerPass.Text != "" && CustomerName.Text != "" && CustomerSurname.Text != "")
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("update CustomerTbl set" +
                                                    " CustLogin = @CL ," +
                                                    " CustomerPass = @CPa ," +
                                                    " CustomerName = @CN ," +
                                                    " CustomerSurname = @CS ," +
                                                    " CustPhone = @CP " +
                                                    " CustAdd = @CA  ," +
                                                    " where CustId =@CustId ", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@CL", CustomerLogin.Text);
                    cmd.Parameters.AddWithValue("@CPa", CustomerPass.Text);
                    cmd.Parameters.AddWithValue("@CN", CustomerName.Text);
                    cmd.Parameters.AddWithValue("@CS", CustomerSurname.Text);
                    cmd.Parameters.AddWithValue("@CP", CustomerPhone.Text);
                    cmd.Parameters.AddWithValue("@CA", CustomerAddress.Text);
                    cmd.Parameters.AddWithValue("@CustId", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost modificate.");
                    con.Close();
                    DisplayCustomers();
                    key = 0;
                    Clear();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Home_Emp obj = new Home_Emp();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
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