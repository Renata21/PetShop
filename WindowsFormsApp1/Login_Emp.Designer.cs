
namespace WindowsFormsApp1
{
    partial class Login_Emp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Emp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblPet = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btlReset = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblPet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.marca_x;
            this.pictureBox2.Location = new System.Drawing.Point(265, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.mascota_amigable_2_;
            this.pictureBox1.Location = new System.Drawing.Point(120, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LblPet
            // 
            this.LblPet.AutoSize = true;
            this.LblPet.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPet.ForeColor = System.Drawing.Color.Black;
            this.LblPet.Location = new System.Drawing.Point(102, 22);
            this.LblPet.Name = "LblPet";
            this.LblPet.Size = new System.Drawing.Size(102, 28);
            this.LblPet.TabIndex = 2;
            this.LblPet.Text = "Pet Shop";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(55, 204);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(188, 32);
            this.Nametxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(55, 267);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '.';
            this.Passwordtxt.Size = new System.Drawing.Size(188, 32);
            this.Passwordtxt.TabIndex = 5;
            // 
            // Loginbtn
            // 
            this.Loginbtn.ActiveBorderThickness = 1;
            this.Loginbtn.ActiveCornerRadius = 20;
            this.Loginbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Loginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Loginbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Loginbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loginbtn.BackgroundImage")));
            this.Loginbtn.ButtonText = "Login";
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Loginbtn.IdleBorderThickness = 1;
            this.Loginbtn.IdleCornerRadius = 20;
            this.Loginbtn.IdleFillColor = System.Drawing.Color.MediumVioletRed;
            this.Loginbtn.IdleForecolor = System.Drawing.Color.Black;
            this.Loginbtn.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.Loginbtn.Location = new System.Drawing.Point(56, 348);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(188, 41);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // btlReset
            // 
            this.btlReset.AutoSize = true;
            this.btlReset.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlReset.ForeColor = System.Drawing.Color.Black;
            this.btlReset.Location = new System.Drawing.Point(115, 394);
            this.btlReset.Name = "btlReset";
            this.btlReset.Size = new System.Drawing.Size(59, 26);
            this.btlReset.TabIndex = 8;
            this.btlReset.Text = "Reset";
            this.btlReset.Click += new System.EventHandler(this.btlReset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 18);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(115, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Signin";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btlReset);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label LblPet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label btlReset;
        private Bunifu.Framework.UI.BunifuThinButton2 Loginbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}