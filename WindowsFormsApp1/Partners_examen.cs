using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Partners_examen : Form
    {
        public Partners_examen()
        {
            InitializeComponent();


        }
        readonly MySqlConnection con = new MySqlConnection("server = mysql.freehostia.com; port = 3306; username=fincri_petshop; password=f._qDNdNMf-#6e@; database=fincri_petshop; connect timeout=5; convert zero datetime=True");

        private void Display_Baieti()
        {
            try
            {
                con.Open();
                string Query = " select Nume, Prenume" +
                               " from PartnersTbl where Gen = 'baiat'";
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
                MySqlCommandBuilder Builder = new MySqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Baieti_DGV.DataSource = ds.Tables[0];
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

        private void Display_Fete()
        {
            try
            {
                con.Open();
                string Query = " select Nume, Prenume" +
                               " from PartnersTbl where Gen = 'fata'";
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, con);
                MySqlCommandBuilder Builder = new MySqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Fete_DGV.DataSource = ds.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            Adaugare obj = new Adaugare();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display_Baieti();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display_Fete();
        }

        private void Baieti_DGV_SelectionChanged(object sender, EventArgs e)
        {
            baiat_sel_txt.Text = Baieti_DGV.SelectedRows[0].Cells[0].Value.ToString() + " " + Baieti_DGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Fete_DGV_SelectionChanged(object sender, EventArgs e)
        {
            fata_sel_txt.Text = Fete_DGV.SelectedRows[0].Cells[0].Value.ToString() + " " + Fete_DGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
               
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM PartnersTbl"))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);

                                //Build the Text file data.
                                string txt = string.Empty;

                                foreach (DataColumn column in dt.Columns)
                                {
                                    //Add the Header row for Text file.
                                    txt += column.ColumnName + "\t\t";
                                }

                                //Add new line.
                                txt += "\r\n";

                                foreach (DataRow row in dt.Rows)
                                {
                                    foreach (DataColumn column in dt.Columns)
                                    {
                                        //Add the Data rows.
                                        txt += row[column.ColumnName].ToString() + "\t\t";
                                    }

                                    //Add new line.
                                    txt += "\r\n";
                                }

                                //Download the Text file.
                                
                                Response.Clear();
                                Response.Buffer = true;
                                Response.AddHeader("content-disposition", "attachment;filename=SqlExport.txt");
                                Response.Charset = "";
                                Response.ContentType = "application/text";
                                Response.Output.Write(txt);
                                Response.Flush();
                                Response.End();
                            
                        }
                    }
                }
            }
        }
    }

