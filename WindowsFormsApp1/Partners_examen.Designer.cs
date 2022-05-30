namespace WindowsFormsApp1
{
    partial class Partners_examen
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
            this.Baieti_DGV = new System.Windows.Forms.DataGridView();
            this.Fete_DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.baiat_sel_txt = new System.Windows.Forms.TextBox();
            this.fata_sel_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Baieti_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fete_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Baieti_DGV
            // 
            this.Baieti_DGV.AllowUserToAddRows = false;
            this.Baieti_DGV.AllowUserToDeleteRows = false;
            this.Baieti_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Baieti_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Baieti_DGV.ColumnHeadersVisible = false;
            this.Baieti_DGV.Location = new System.Drawing.Point(59, 134);
            this.Baieti_DGV.Name = "Baieti_DGV";
            this.Baieti_DGV.ReadOnly = true;
            this.Baieti_DGV.RowHeadersVisible = false;
            this.Baieti_DGV.RowHeadersWidth = 51;
            this.Baieti_DGV.RowTemplate.Height = 24;
            this.Baieti_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Baieti_DGV.Size = new System.Drawing.Size(286, 193);
            this.Baieti_DGV.TabIndex = 0;
            this.Baieti_DGV.SelectionChanged += new System.EventHandler(this.Baieti_DGV_SelectionChanged);
            // 
            // Fete_DGV
            // 
            this.Fete_DGV.AllowUserToAddRows = false;
            this.Fete_DGV.AllowUserToDeleteRows = false;
            this.Fete_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Fete_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Fete_DGV.ColumnHeadersVisible = false;
            this.Fete_DGV.Location = new System.Drawing.Point(394, 134);
            this.Fete_DGV.Name = "Fete_DGV";
            this.Fete_DGV.ReadOnly = true;
            this.Fete_DGV.RowHeadersVisible = false;
            this.Fete_DGV.RowHeadersWidth = 51;
            this.Fete_DGV.RowTemplate.Height = 24;
            this.Fete_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Fete_DGV.Size = new System.Drawing.Size(318, 193);
            this.Fete_DGV.TabIndex = 1;
            this.Fete_DGV.SelectionChanged += new System.EventHandler(this.Fete_DGV_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista baieti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista fete";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adaugare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Afisare baiat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(753, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Afisare fata";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // baiat_sel_txt
            // 
            this.baiat_sel_txt.Location = new System.Drawing.Point(72, 415);
            this.baiat_sel_txt.Name = "baiat_sel_txt";
            this.baiat_sel_txt.Size = new System.Drawing.Size(190, 22);
            this.baiat_sel_txt.TabIndex = 7;
            // 
            // fata_sel_txt
            // 
            this.fata_sel_txt.Location = new System.Drawing.Point(402, 410);
            this.fata_sel_txt.Name = "fata_sel_txt";
            this.fata_sel_txt.Size = new System.Drawing.Size(170, 22);
            this.fata_sel_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Baiatul selectat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fata selectata";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(752, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 45);
            this.button4.TabIndex = 11;
            this.button4.Text = "Export";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(761, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 37);
            this.button5.TabIndex = 12;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Partners_examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 493);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fata_sel_txt);
            this.Controls.Add(this.baiat_sel_txt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fete_DGV);
            this.Controls.Add(this.Baieti_DGV);
            this.Name = "Partners_examen";
            this.Text = "Partners_examen";
            ((System.ComponentModel.ISupportInitialize)(this.Baieti_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fete_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Baieti_DGV;
        private System.Windows.Forms.DataGridView Fete_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox baiat_sel_txt;
        private System.Windows.Forms.TextBox fata_sel_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}