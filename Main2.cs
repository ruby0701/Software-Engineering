using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolHelper
{
    public partial class Main2 : Form
    {
        Main main = new Main();

        private int hr, min, sec, year, mon, day;
        private int lastd, lastm, lasty;

        public Main2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labellllll = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labellllll
            // 
            this.labellllll.AutoSize = true;
            this.labellllll.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labellllll.Location = new System.Drawing.Point(60, 220);
            this.labellllll.Name = "labellllll";
            this.labellllll.Size = new System.Drawing.Size(143, 16);
            this.labellllll.TabIndex = 5;
            this.labellllll.Text = "School Helper Beta 11.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolHelper.Properties.Resources._1420774360_Book_512;
            this.pictureBox1.Location = new System.Drawing.Point(34, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelText.Location = new System.Drawing.Point(32, 254);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(200, 64);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "軟體名稱 : School Helper\r\n類型 : Windows Form 桌面應用程式\r\n製作語言/環境 : C# , Visual Studio\r\n製作 " +
    ": 軟體工程課第六小組";
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 347);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labellllll);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Helper";
            this.Load += new System.EventHandler(this.Main2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Main2_Load(object sender, EventArgs e)
        {

        }

        /* int absent=0;
        string[] temp= new string[20] ;
        private void button1_Click(object sender, EventArgs e)
        {
            absent++;
            textBox1.Text = (absent).ToString();
           
            temp[absent] = dateTimePicker1.Text;
            string collecttemp = "";

            for (int i = absent; i > 0; i--)
            {
                collecttemp = collecttemp + temp[i] + "\n";
            }
            label22.Text = collecttemp;
            
        }*/

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
           // tableLayoutPanel1_Paint_1.Text = "星期一";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
          
            
            e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            ControlPaint.DrawBorder(e.Graphics, (sender as Control).DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);

            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            ControlPaint.DrawBorder(e.Graphics, (sender as Control).DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

       /* private void timer1_Tick(object sender, EventArgs e)
        {
            hr = DateTime.UtcNow.Hour - 4;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
            mon = DateTime.UtcNow.Month;
            year = DateTime.UtcNow.Year;
            day = DateTime.UtcNow.Day;


            lastd = dateTimePicker1.Value.Day - DateTime.UtcNow.Day;
            lastm = dateTimePicker1.Value.Month - DateTime.UtcNow.Month;
            lasty = dateTimePicker1.Value.Year - DateTime.UtcNow.Year;


            if (hr >= 12)
                hr = hr - 12;
            else if (hr < 12)
                hr = hr + 12;
            if (sec % 2 == 0)
            {
                DateLabel.Text = hr + " : " + min + " : " + sec;
                TimeLabel.Text = year + "/" + mon + "/" + day;
            }
            else
            {
                DateLabel.Text = hr + " : " + min + " : " + sec + "  ";
            }
        }*/

        private void Main2_Load_1(object sender, EventArgs e)
        {

        }

   
    }
    
}
