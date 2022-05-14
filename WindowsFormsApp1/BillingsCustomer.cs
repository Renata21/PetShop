using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BillingsCustomer : Form
    {
        public BillingsCustomer()
        {
            InitializeComponent();
            label7.Text = temp.client;
            DisplayProduct();
        }

        readonly MySqlConnection con = new MySqlConnection("server = mysql.freehostia.com; port = 3306; username=fincri_petshop; password=f._qDNdNMf-#6e@; database=fincri_petshop; connect timeout=5; convert zero datetime=True");

        int key = 0;
        int Stock = 0;


        private void DisplayProduct()
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
                ProductsDGV.DataSource = ds.Tables[0];

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o problema" + ex.Message);
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
                con.Open();
                int NewQty = Stock - Convert.ToInt32(QtyTb.Text);

                MySqlCommand cmd = new MySqlCommand("Update ProductTbl set PrQty = @PQ where PrID = @PKey", con);
                cmd.Parameters.AddWithValue("@PQ", NewQty);
                cmd.Parameters.AddWithValue("@PKey", key);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produs adaugat si modificat.");
                con.Close();
                DisplayProduct();
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

        private void Bill()
        {
            try
            {
                con.Open();
                MySqlCommand cmd_id = new MySqlCommand("select CustID from CustomerTbl where CustLogin = @CustLog", con);

                cmd_id.Parameters.AddWithValue("@CustLog", temp.client);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd_id);
                sda.Fill(dt);
                string custID = "";
                foreach (DataRow dr in dt.Rows)
                {
                    custID = dr["CustID"].ToString();
                }

                MySqlCommand cmd = new MySqlCommand("insert into BillTbl (BDate,CustId,CustLogin,EmpLogin,Amt) values(@BD,@CI,@CN,@EN,@AT)", con);

                cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                cmd.Parameters.AddWithValue("@CI", int.Parse(custID));
                cmd.Parameters.AddWithValue("@CN", label7.Text);
                cmd.Parameters.AddWithValue("@EN", "");
                cmd.Parameters.AddWithValue("@AT", GrdTotal);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Chitanta adaugata");
                con.Close();
                DisplayProduct();
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
        private void Reset()
        {
            key = 0;
            Stock = 0;
            PrNameTb.Text = "";
            PrPriceTb.Text = string.Empty;
            QtyTb.Text = "";
        }

        int n = 0, GrdTotal = 0;
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text) > Stock)
            {
                MessageBox.Show("Stoc insuficient");
            }
            else if (QtyTb.Text == "" || key == 0)
            {
                MessageBox.Show("Nu ati introdus destule informatii");
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
            // BillDGV.Rows.Clear();
            // BillDGV.Refresh();
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTb.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Stock = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[3].Value.ToString());
            PrPriceTb.Text = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();
            QtyTb.Text = "1";

            if (PrNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ProductsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrNameTb.Text != "")
                {
                    con.Open();
                    string Query = " select * from ProductTbl where PrName like @PN";
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@PN", "%" + PrNameTb.Text + "%");
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    adp.Fill(dt);

                    ProductsDGV.DataSource = dt.Tables[0];

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Adaugati numele produsului cautat.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("A aparut o problema" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //PRINTARE
        private void Printbtn_Click(object sender, EventArgs e)
        {
            Bill();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 840, 1188);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            BillDGV.Rows.Clear();
            BillDGV.Refresh();

            TotalLbl.Text = "";
            GrdTotal = 0;
            n = 0;
        }
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int pos = 10;

            e.Graphics.DrawString("PetHouse", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Red, new Point(350, pos));
            pos += 50;

            e.Graphics.DrawString("NR   PRODUCT \t \t \t \t \t PRICE \t QUANTITY   TOTAL", new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Red, new Point(5, pos));
            pos += 50;

            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                int prodid = Convert.ToInt32(row.Cells["Id"].Value);
                string prodname = "" + row.Cells["Nombre"].Value;
                int prodprice = Convert.ToInt32(row.Cells["ProductPrice"].Value);
                int prodqty = Convert.ToInt32(row.Cells["Quantity"].Value);
                int total = Convert.ToInt32(row.Cells["Total"].Value);

                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(5, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(50, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(520, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(620, pos));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(730, pos));
                pos += 20;
            }
            e.Graphics.DrawString("Total: $ " + GrdTotal, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("\t \t     ***************  PetHouse  ***************", new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Crimson, new Point(0, pos + 85));
            e.Graphics.DrawString("\t \t \t     " + DateTime.Now, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Crimson, new Point(0, pos + 120));

        }

        //MISCARE FEREASTRA
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

        //MENIU
        private void label6_Click(object sender, EventArgs e)
        {
            Choose_user obj = new Choose_user();
            obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ProductsCustomer obj = new ProductsCustomer();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home_Cust obj = new Home_Cust();
            obj.Show();
            this.Hide();
        }
    }
}
