
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            label7.Text = temp.angajat;
            DisplayCustomers();
            Clear();
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
                               " from ProductTbl";
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
                MySqlCommandBuilder Builder = new MySqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductDGV.DataSource = ds.Tables[0];
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
        private void Clear()
        {
            ProductName_tb.Text = "";
            ProductoPrice.Text = "";
            ProductQuantity.Text = "";
            cboProductCategory.SelectedIndex = 0;
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (ProductName_tb.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
            if (ProductoPrice.Text == "")
            {
                MessageBox.Show("Please Add a Price");
                return;
            }
            if (ProductQuantity.Text == "")
            {
                MessageBox.Show("Please Add a Quantity");
                return;
            }
            else if (ProductName_tb.Text != "" && ProductoPrice.Text != "" && ProductQuantity.Text != "")
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into ProductTbl (PrName,PrType,PrQty,PrPrice) values(@PN,@PC,@PQ,@PP)", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@PN", ProductName_tb.Text);
                    cmd.Parameters.AddWithValue("@PC", cboProductCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", ProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@PP", ProductoPrice.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product : " + ProductName_tb.Text + " Added");
                    con.Close();
                    DisplayCustomers();
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
                }
            }
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            ProductName_tb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            cboProductCategory.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductQuantity.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            ProductoPrice.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("You nedd select a Product");
            }
            else
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from ProductTbl where PrID = @PKey", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@PKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted");
                    con.Close();
                    DisplayCustomers();
                    key = 0;
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
                }
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (ProductName_tb.Text == "")
            {
                MessageBox.Show("Please Add a Name");
                return;
            }
            if (ProductoPrice.Text == "")
            {
                MessageBox.Show("Please Add a Price");
                return;
            }
            if (ProductQuantity.Text == "")
            {
                MessageBox.Show("Please Add a Quantity");
                return;
            }
            else if (ProductName_tb.Text != "" && ProductoPrice.Text != "" && ProductQuantity.Text != "")
            {
                try
                {
                    //abrimos la conexion a la base de datos
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("update ProductTbl set" +
                                                    " PrName = @PN ," +
                                                    " PrType = @PC  ," +
                                                    " PrQty = @PQ  ," +
                                                    " PrPrice = @PP " +
                                                    " where PrID = @PKey ", con);
                    //asignamos los valores a la sentencia para evitar la concatenacion por seguridad   
                    cmd.Parameters.AddWithValue("@PN", ProductName_tb.Text);
                    cmd.Parameters.AddWithValue("@PC", cboProductCategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", ProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@PP", ProductoPrice.Text);
                    cmd.Parameters.AddWithValue("@PKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prodcut Updated");
                    con.Close();
                    DisplayCustomers();
                    key = 0;
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
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home_Emp obj = new Home_Emp();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
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
