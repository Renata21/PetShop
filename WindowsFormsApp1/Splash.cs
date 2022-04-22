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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start();
        }
        int starP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starP += 50;
            MyProgress.Value = starP;
            lblPorcentaje.Text = starP + "%";
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                Choose_user obj = new Choose_user();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
