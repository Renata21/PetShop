namespace WindowsFormsApp1
{
    partial class Adaugare
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
            this.Nume_txt = new System.Windows.Forms.TextBox();
            this.Prenume_txt = new System.Windows.Forms.TextBox();
            this.baiat_btn = new System.Windows.Forms.RadioButton();
            this.fata_btn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nume_txt
            // 
            this.Nume_txt.Location = new System.Drawing.Point(122, 112);
            this.Nume_txt.Name = "Nume_txt";
            this.Nume_txt.Size = new System.Drawing.Size(175, 22);
            this.Nume_txt.TabIndex = 0;
            // 
            // Prenume_txt
            // 
            this.Prenume_txt.Location = new System.Drawing.Point(121, 170);
            this.Prenume_txt.Name = "Prenume_txt";
            this.Prenume_txt.Size = new System.Drawing.Size(175, 22);
            this.Prenume_txt.TabIndex = 1;
            // 
            // baiat_btn
            // 
            this.baiat_btn.AutoSize = true;
            this.baiat_btn.Location = new System.Drawing.Point(33, 32);
            this.baiat_btn.Name = "baiat_btn";
            this.baiat_btn.Size = new System.Drawing.Size(58, 20);
            this.baiat_btn.TabIndex = 2;
            this.baiat_btn.TabStop = true;
            this.baiat_btn.Text = "baiat";
            this.baiat_btn.UseVisualStyleBackColor = true;
            this.baiat_btn.CheckedChanged += new System.EventHandler(this.baiat_btn_CheckedChanged);
            // 
            // fata_btn
            // 
            this.fata_btn.AutoSize = true;
            this.fata_btn.Location = new System.Drawing.Point(33, 84);
            this.fata_btn.Name = "fata_btn";
            this.fata_btn.Size = new System.Drawing.Size(50, 20);
            this.fata_btn.TabIndex = 3;
            this.fata_btn.TabStop = true;
            this.fata_btn.Text = "fata";
            this.fata_btn.UseVisualStyleBackColor = true;
            this.fata_btn.CheckedChanged += new System.EventHandler(this.fata_btn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fata_btn);
            this.panel1.Controls.Add(this.baiat_btn);
            this.panel1.Location = new System.Drawing.Point(389, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 130);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenume";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(98, 265);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(115, 39);
            this.Save_btn.TabIndex = 7;
            this.Save_btn.Text = "Adaugare";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(373, 271);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(127, 32);
            this.Cancel_btn.TabIndex = 8;
            this.Cancel_btn.Text = "Refuz";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 343);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Prenume_txt);
            this.Controls.Add(this.Nume_txt);
            this.Name = "Adaugare";
            this.Text = "Adaugare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nume_txt;
        private System.Windows.Forms.TextBox Prenume_txt;
        private System.Windows.Forms.RadioButton baiat_btn;
        private System.Windows.Forms.RadioButton fata_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}