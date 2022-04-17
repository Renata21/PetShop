using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btlReset_Click(object sender, EventArgs e)
        {
            Nametxt.Text = "";
            Passwordtxt.Text = "";
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text == "admin" && Passwordtxt.Text == "admin")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
        }
    }
}
