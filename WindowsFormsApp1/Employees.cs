using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PetShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        int key = 0;
        //listaremos los empleados una vez agreguemos uno y cuando se inicie el formulario
        private void DisplayEmployees()
        {
            try
            {
                con.Open();
                string Query = " select *" +
                               " from EmployeeTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query,con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                EmployeeDGV.DataSource = ds.Tables[0];
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EmployeName.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
            if (EmployePhone.Text == "")
            {
                MessageBox.Show("Please Add a Number Phone");
                return;
            }
            if (EmployeeAddress.Text == "")
            {
                MessageBox.Show("Please Add a Address");
                return;
            }
            if (EmployeePassword.Text == "")
            {
                MessageBox.Show("Please Add a Password");
                return;
            }
            else if(EmployeName.Text != "" && EmployePhone.Text != "" && EmployeeAddress.Text != "" && EmployeePassword.Text != "")
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl (EmpName,EmpAdd,EmpDOB,EmpPhone,EmpPass) " +
                                                    "values(@EN,@EA,@ED,@EP,@EPa)",con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@EN",EmployeName.Text);
                    cmd.Parameters.AddWithValue("@EA", EmployeeAddress.Text);
                    cmd.Parameters.AddWithValue("@ED", cboDateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmployePhone.Text);
                    cmd.Parameters.AddWithValue("@EPa", EmployeePassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee : " + EmployeName.Text + " Added");
                    con.Close();
                    DisplayEmployees();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There's been a problem ==>" + ex.Message);
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
            EmployeName.Text = "";
            EmployeeAddress.Text = "";
            EmployePhone.Text = "";
            EmployeePassword.Text = "";
        }

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            EmployeName.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmployeeAddress.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            cboDateOfBirth.Value = Convert.ToDateTime(EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString());
            EmployePhone.Text = EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmployeePassword.Text = EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (EmployeName.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
            if (EmployePhone.Text == "")
            {
                MessageBox.Show("Please Add a Number Phone");
                return;
            }
            if (EmployeeAddress.Text == "")
            {
                MessageBox.Show("Please Add a Address");
                return;
            }
            if (EmployeePassword.Text == "")
            {
                MessageBox.Show("Please Add a Password");
                return;
            }
            else if (EmployeName.Text != "" && EmployePhone.Text != "" && EmployeeAddress.Text != "" && EmployeePassword.Text != "")
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update EmployeeTbl set" +
                                                    "  EmpName = @EN  ," +
                                                    "  EmpAdd = @EA   ," +
                                                    "  EmpDOB = @ED   ," +
                                                    "  EmpPhone = @EP ," +
                                                    "  EmpPass = @EPa " +
                                                    "  where EmpNum = @EKey", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@EN", EmployeName.Text);
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
                    MessageBox.Show("There's been a problem ==>" + ex.Message);
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
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EmpNum = @EmpKey", con);
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
                    MessageBox.Show("There's been a problem ==>" + ex.Message);
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
