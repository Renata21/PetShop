using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Choose_user : Form
    {
        public Choose_user()
        {
            InitializeComponent();
        }

        private void panel_emp_Click(object sender, EventArgs e)
        {
            Login_Emp obj = new Login_Emp();
            obj.Show();
            this.Hide();
        }

        private void pictureBox_emp_Click(object sender, EventArgs e)
        {
            Login_Emp obj = new Login_Emp();
            obj.Show();
            this.Hide();
        }

        private void label_emp_Click(object sender, EventArgs e)
        {
            Login_Emp obj = new Login_Emp();
            obj.Show();
            this.Hide();
        }

        private void panel_emp_MouseHover(object sender, EventArgs e)
        {
            panel_emp.BackColor = System.Drawing.Color.Orchid;

        }

        private void panel_emp_MouseLeave(object sender, EventArgs e)
        {
            panel_emp.BackColor = System.Drawing.Color.MediumVioletRed;
        }

        private void panel_cost_Click(object sender, EventArgs e)
        {
            Login_Cust obj = new Login_Cust();
            obj.Show();
            this.Hide();
        }

        private void pictureBox_cost_Click(object sender, EventArgs e)
        {
            Login_Cust obj = new Login_Cust();
            obj.Show();
            this.Hide();
        }

        private void label_cost_Click(object sender, EventArgs e)
        {
            Login_Cust obj = new Login_Cust();
            obj.Show();
            this.Hide();
        }

        private void panel_cost_MouseHover(object sender, EventArgs e)
        {
            panel_cost.BackColor = System.Drawing.Color.Orchid;
        }

        private void panel_cost_MouseLeave(object sender, EventArgs e)
        {
            panel_cost.BackColor = System.Drawing.Color.MediumVioletRed;
        }

       

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
