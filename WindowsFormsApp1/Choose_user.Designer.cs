﻿namespace WindowsFormsApp1
{
    partial class Choose_user
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
            this.label_emp = new System.Windows.Forms.Label();
            this.panel_emp = new System.Windows.Forms.Panel();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.bunifuElipse_emp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_cost = new System.Windows.Forms.Panel();
            this.label_cost = new System.Windows.Forms.Label();
            this.pictureBox_cost = new System.Windows.Forms.PictureBox();
            this.bunifuElipse_cost = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.panel_emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            this.panel_cost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_emp
            // 
            this.label_emp.AutoSize = true;
            this.label_emp.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emp.Location = new System.Drawing.Point(47, 95);
            this.label_emp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emp.Name = "label_emp";
            this.label_emp.Size = new System.Drawing.Size(142, 32);
            this.label_emp.TabIndex = 21;
            this.label_emp.Text = "Employees";
            this.label_emp.Click += new System.EventHandler(this.label_emp_Click);
            // 
            // panel_emp
            // 
            this.panel_emp.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel_emp.Controls.Add(this.label_emp);
            this.panel_emp.Controls.Add(this.pictureBox_emp);
            this.panel_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_emp.Location = new System.Drawing.Point(148, 140);
            this.panel_emp.Margin = new System.Windows.Forms.Padding(4);
            this.panel_emp.Name = "panel_emp";
            this.panel_emp.Size = new System.Drawing.Size(231, 171);
            this.panel_emp.TabIndex = 34;
            this.panel_emp.Click += new System.EventHandler(this.panel_emp_Click);
            this.panel_emp.MouseLeave += new System.EventHandler(this.panel_emp_MouseLeave);
            this.panel_emp.MouseHover += new System.EventHandler(this.panel_emp_MouseHover);
            // 
            // pictureBox_emp
            // 
            this.pictureBox_emp.Image = global::WindowsFormsApp1.Properties.Resources.employee;
            this.pictureBox_emp.Location = new System.Drawing.Point(81, 26);
            this.pictureBox_emp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(77, 65);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_emp.TabIndex = 20;
            this.pictureBox_emp.TabStop = false;
            this.pictureBox_emp.Click += new System.EventHandler(this.pictureBox_emp_Click);
            // 
            // bunifuElipse_emp
            // 
            this.bunifuElipse_emp.ElipseRadius = 50;
            this.bunifuElipse_emp.TargetControl = this.panel_emp;
            // 
            // panel_cost
            // 
            this.panel_cost.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel_cost.Controls.Add(this.label_cost);
            this.panel_cost.Controls.Add(this.pictureBox_cost);
            this.panel_cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_cost.Location = new System.Drawing.Point(428, 140);
            this.panel_cost.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cost.Name = "panel_cost";
            this.panel_cost.Size = new System.Drawing.Size(231, 171);
            this.panel_cost.TabIndex = 35;
            this.panel_cost.Click += new System.EventHandler(this.panel_cost_Click);
            this.panel_cost.MouseLeave += new System.EventHandler(this.panel_cost_MouseLeave);
            this.panel_cost.MouseHover += new System.EventHandler(this.panel_cost_MouseHover);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(46, 96);
            this.label_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(142, 32);
            this.label_cost.TabIndex = 21;
            this.label_cost.Text = "Customers";
            this.label_cost.Click += new System.EventHandler(this.label_cost_Click);
            // 
            // pictureBox_cost
            // 
            this.pictureBox_cost.Image = global::WindowsFormsApp1.Properties.Resources.customer;
            this.pictureBox_cost.Location = new System.Drawing.Point(78, 27);
            this.pictureBox_cost.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_cost.Name = "pictureBox_cost";
            this.pictureBox_cost.Size = new System.Drawing.Size(79, 65);
            this.pictureBox_cost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cost.TabIndex = 36;
            this.pictureBox_cost.TabStop = false;
            this.pictureBox_cost.Click += new System.EventHandler(this.pictureBox_cost_Click);
            // 
            // bunifuElipse_cost
            // 
            this.bunifuElipse_cost.ElipseRadius = 50;
            this.bunifuElipse_cost.TargetControl = this.panel_cost;
            // 
            // bunifuElipse_form
            // 
            this.bunifuElipse_form.ElipseRadius = 40;
            this.bunifuElipse_form.TargetControl = this;
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.Image = global::WindowsFormsApp1.Properties.Resources.marca_x;
            this.pictureBox_exit.Location = new System.Drawing.Point(730, 12);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(47, 41);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 37;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Choose_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.panel_cost);
            this.Controls.Add(this.panel_emp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Choose_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose_user";
            this.panel_emp.ResumeLayout(false);
            this.panel_emp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.panel_cost.ResumeLayout(false);
            this.panel_cost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_emp;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Panel panel_emp;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_emp;
        private System.Windows.Forms.Panel panel_cost;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.PictureBox pictureBox_cost;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_cost;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_form;
        private System.Windows.Forms.PictureBox pictureBox_exit;
    }
}