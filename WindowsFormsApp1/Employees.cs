using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Employees : Form
    {

        public Employees()
        {

            InitializeComponent();
            label7.Text = temp.angajat;
            DisplayEmployees();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = PetShopDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int key = 0;
        //listaremos los empleados una vez agreguemos uno y cuando se inicie el formulario
        private void DisplayEmployees()
        {
            try
            {
                con.Open();
                string Query = " select *" +
                               " from EmployeeTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                EmployeeDGV.DataSource = ds.Tables[0];
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EmployeLogin.Text == "")
            {
                MessageBox.Show("Adaugati numele de utilizator");
                return;
            }

            if (EmployeePassword.Text == "")
            {
                MessageBox.Show("Please Add a Password");
                return;
            }
            if (EmployeName.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
            if (EmployeSurname.Text == "")
            {
                MessageBox.Show("Please Add a SurName");
                return;
            }
             if (EmployeLogin.Text != "" && EmployeePassword.Text != "" && EmployeName.Text != "" && EmployeSurname.Text != "")
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl (EmpLogin,EmpPass,EmpName,EmpSurname,EmpAdd,EmpDOB,EmpPhone) " +
                                                    "values(@EL,@EPa,@EN, @ES,@EA,@ED,@EP)", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@EL", EmployeLogin.Text); 
                    cmd.Parameters.AddWithValue("@EPa", EmployeePassword.Text);
                    cmd.Parameters.AddWithValue("@EN", EmployeName.Text);
                    cmd.Parameters.AddWithValue("@ES", EmployeSurname.Text);
                    cmd.Parameters.AddWithValue("@EA", EmployeeAddress.Text);
                    cmd.Parameters.AddWithValue("@ED", cboDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmployePhone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee : " + EmployeLogin.Text + " Added");
                    con.Close();
                    DisplayEmployees();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A aparut o problema ==>" + ex.Message);
                }
                finally
                {
                    //cerramos la cadena independientemente si la sentencia se ejecuta d emanera exitosa o no
                    con.Close();
                    Clear();
                }
            }
        }
        //metodo para limpiar los campos del formulario
        private void Clear()
        {
            EmployeLogin.Text = "";
            EmployeName.Text = "";
            EmployeSurname.Text = "";
            EmployeeAddress.Text = "";
            EmployePhone.Text = "";
            EmployeePassword.Text = "";
        }

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            EmployeLogin.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmployeePassword.Text  = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmployeName.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmployeSurname.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            cboDateOfBirth.Value = Convert.ToDateTime(EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString());
            EmployePhone.Text = EmployeeDGV.SelectedRows[0].Cells[6].Value.ToString();
            EmployeeAddress.Text = EmployeeDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (EmployeLogin.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
           
            if (EmployeePassword.Text == "")
            {
                MessageBox.Show("Please Add a Password");
                return;
            }
            if (EmployeName.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
            if (EmployeSurname.Text == "")
            {
                MessageBox.Show("Please Add a SurName");
                return;
            }
             if (EmployeLogin.Text != "" &&  EmployeePassword.Text != "" && EmployeName.Text != "" && EmployeSurname.Text != "")
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update EmployeeTbl set" +
                                                    "  EmpLogin = @EL  ," +
                                                    "  EmpName = @EN  ," +
                                                    "  EmpSurname = @ES  ,"+
                                                    "  EmpAdd = @EA   ," +
                                                    "  EmpDOB = @ED   ," +
                                                    "  EmpPhone = @EP ," +
                                                    "  EmpPass = @EPa " +
                                                    "  where EmpID = @EKey", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@EL", EmployeLogin.Text);
                    cmd.Parameters.AddWithValue("@EN", EmployeName.Text);
                    cmd.Parameters.AddWithValue("@ES", EmployeSurname.Text);
                    cmd.Parameters.AddWithValue("@EA", EmployeeAddress.Text);                  
                    cmd.Parameters.AddWithValue("@ED", cboDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmployePhone.Text);
                    cmd.Parameters.AddWithValue("@EPa", EmployeePassword.Text);
                    cmd.Parameters.AddWithValue("@EKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");
                    con.Close();
                    DisplayEmployees();
                    Clear();
                    key = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A aparut o problema ==>" + ex.Message);
                }
                finally
                {
                    //cerramos la cadena independientemente si la sentencia se ejecuta d emanera exitosa o no
                    con.Close();
                    Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("You nedd select a employeen");
            }
            else
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EmpID = @EmpKey", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@EmpKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");
                    con.Close();
                    DisplayEmployees();
                    Clear();
                    key = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A aparut o problema ==>" + ex.Message);
                }
                finally
                {
                    //cerramos la cadena independientemente si la sentencia se ejecuta d emanera exitosa o no
                    con.Close();
                    Clear();
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Home_Emp obj = new Home_Emp();
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
