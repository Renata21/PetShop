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
    public partial class Billings : Form
    {
        public Billings()
        {
            InitializeComponent();
            DisplayProduct();
            GetCustomers();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\Pet-Shop-Management-System-Using-C-.Net-and-SQL-Server-master\Pet-Shop-Management-System-Using-C-.Net-and-SQL-Server-master\PetShop\WindowsFormsApp1\BaseDeDatos\PetShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        int key = 0;
        int Stock = 0;
        private void GetCustomers() 
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select CustId from CustomerTbl",con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CustId", typeof(int));
                dt.Load(rdr);
                CustIdCb.ValueMember = "CustId";
                CustIdCb.DataSource = dt;
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
        private void GetCustName()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from CustomerTbl where CustId = @CustId", con);
                cmd.Parameters.AddWithValue("@CustId", CustIdCb.SelectedValue);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    custNameTb.Text = dr["CustName"].ToString();
                }
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
        private void DisplayProduct()
        {
            try
            {
                con.Open();
                string Query = " select *" +
                               " from ProductTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductsDGV.DataSource = ds.Tables[0];
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
        private void DisplayBills()
        {
            try
            {
                con.Open();
                string Query = " select *" +
                               " from BillTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                TransactionsDGV.DataSource = ds.Tables[0];
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
        private void UpdateStock()
        {
            try
            {
                int NewQty = Stock - Convert.ToInt32(QtyTb.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTbl set PrQty = @PQ where PrId = @PKey",con);
                cmd.Parameters.AddWithValue("@PQ", NewQty);
                cmd.Parameters.AddWithValue("@PKey", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Edited");
                con.Close();
                DisplayProduct();
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
        private void Bill()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into BillTbl (BDate,CustId,CustName,EmpName,Amt) values(@BD,@CI,@CN,@EN,@AT)", con);
                cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                cmd.Parameters.AddWithValue("@CI", CustIdCb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@CN", custNameTb.Text);
                cmd.Parameters.AddWithValue("@EN", "");
                cmd.Parameters.AddWithValue("@AT", GrdTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Added");
                con.Close();
                DisplayProduct();
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
        private void Reset() 
        {
            key = 0;
            Stock = 0;
            PrNameTb.Text = "";
            QtyTb.Text = "";
        }
        int n = 0, GrdTotal = 0;

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text) > Stock)
            {
                MessageBox.Show("No Enough In House");
            }
            else if (QtyTb.Text == "" || key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PrPriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = PrNameTb.Text;
                newRow.Cells[2].Value = PrPriceTb.Text;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = total;
                GrdTotal = GrdTotal + total;
                BillDGV.Rows.Add(newRow);
                n++;
                TotalLbl.Text = "$" + GrdTotal;
                UpdateStock();
                Reset();
            }
        }
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTb.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Stock = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[3].Value.ToString());
            PrPriceTb.Text = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (PrNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        
        private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustName();
        }
        private void Printbtn_Click(object sender, EventArgs e)
        {
            Bill();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            DisplayBills();
        }
        int prodid,prodqty,prodprice,total,pos = 60;

        private void label4_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Products obj = new Products();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("My CodeSpace PetShop",new Font("Century Gothic",12,FontStyle.Bold),Brushes.Red, new Point(50));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(5,20));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Id"].Value);
                prodname = "" + row.Cells["Nombre"].Value;
                prodprice = Convert.ToInt32(row.Cells["ProductPrice"].Value);
                prodqty = Convert.ToInt32(row.Cells["Quantity"].Value);
                total = Convert.ToInt32(row.Cells["Total"].Value);

                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26,pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45,pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(110, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235  , pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total: $ " + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50 , pos + 50));
            e.Graphics.DrawString("***************PetShop***************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(0, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;

        }

    }
}
