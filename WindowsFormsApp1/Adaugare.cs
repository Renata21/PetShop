using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Adaugare : Form
    {
        public Adaugare()
        {
            InitializeComponent();
        }
        readonly MySqlConnection con = new MySqlConnection("server = mysql.freehostia.com; port = 3306; username=fincri_petshop; password=f._qDNdNMf-#6e@; database=fincri_petshop; connect timeout=5; convert zero datetime=True");

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Nume_txt.Text != null && Prenume_txt != null && (baiat_btn.Checked || fata_btn.Checked))
                {
                    string gen;
                    if (baiat_btn.Checked)
                        gen = "baiat";
                    else
                        gen = "fata";

                    MySqlCommand cmd = new MySqlCommand("insert into PartnersTbl (Nume, Prenume, Gen) values(@N, @P, @G)", con);
                    cmd.Parameters.AddWithValue("@N", Nume_txt.Text);
                    cmd.Parameters.AddWithValue("@P", Prenume_txt.Text);
                    cmd.Parameters.AddWithValue("@G", gen);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Persoana adaugata");

                    Partners_examen obj = new Partners_examen();
                    obj.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nu ati introdus datele.");
                }

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

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Partners_examen obj = new Partners_examen();
            obj.Show();
            this.Close();
        }

        private void baiat_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (baiat_btn.Checked)
                fata_btn.Checked = false;
        }

        private void fata_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (fata_btn.Checked)
                baiat_btn.Checked = false;
        }
    }
}
