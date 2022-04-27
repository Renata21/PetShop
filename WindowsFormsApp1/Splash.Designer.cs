
namespace WindowsFormsApp1
{
    partial class Splash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblPet = new System.Windows.Forms.Label();
            this.MyProgress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.mascota_amigable_2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblPet
            // 
            this.LblPet.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPet.Location = new System.Drawing.Point(69, 30);
            this.LblPet.Name = "LblPet";
            this.LblPet.Size = new System.Drawing.Size(464, 80);
            this.LblPet.TabIndex = 1;
            this.LblPet.Text = "Administrarea Magazinului de Animale \"Pet House\"";
            this.LblPet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyProgress
            // 
            this.MyProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.MyProgress.BorderRadius = 10;
            this.MyProgress.ForeColor = System.Drawing.SystemColors.Window;
            this.MyProgress.Location = new System.Drawing.Point(151, 289);
            this.MyProgress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MyProgress.MaximumValue = 100;
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.ProgressColor = System.Drawing.Color.DarkRed;
            this.MyProgress.Size = new System.Drawing.Size(430, 18);
            this.MyProgress.TabIndex = 2;
            this.MyProgress.Value = 0;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPorcentaje.Location = new System.Drawing.Point(272, 152);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(108, 52);
            this.lblPorcentaje.TabIndex = 3;
            this.lblPorcentaje.Text = "%%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(146, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Încărcare...";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(182)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(594, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.LblPet);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblPet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPorcentaje;
        private Bunifu.Framework.UI.BunifuProgressBar MyProgress;
        private System.Windows.Forms.Timer timer;
    }
}

