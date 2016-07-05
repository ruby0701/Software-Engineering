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
    public partial class TimeCount : Form
    {
        #region

        private int hr, min, sec,year,mon,day;
        private int lastd, lastm, lasty;

        Main main = new Main();

        public TimeCount()
        {
            InitializeComponent();
            hr = DateTime.UtcNow.Hour;
            min = DateTime.UtcNow.Minute;
            sec = DateTime.UtcNow.Second;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(227, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Remind";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "課程名稱：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "任務類型：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(21, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "期限：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "代辦任務事項";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classname,
            this.classtype,
            this.dueday});
            this.dataGridView1.Location = new System.Drawing.Point(370, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(442, 320);
            this.dataGridView1.TabIndex = 14;
            // 
            // classname
            // 
            this.classname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classname.HeaderText = "Class";
            this.classname.Name = "classname";
            // 
            // classtype
            // 
            this.classtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classtype.HeaderText = "Type";
            this.classtype.Name = "classtype";
            // 
            // dueday
            // 
            this.dueday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueday.HeaderText = "Due";
            this.dueday.Name = "dueday";
            // 
            // TimeCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimeCount";
            this.Text = "待辦事項提醒";
            this.Load += new System.EventHandler(this.time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void TimeCount_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
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
                label1.Text = hr + " : " + min + " : " + sec;
                label2.Text = year + "/" + mon + "/" + day;
            }
            else
            {
                label1.Text = hr + " : " + min + " : " + sec + "  ";
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void time_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subject, type;
            int date, month, year, last;

            subject = textBox2.Text;
            type = textBox1.Text;
            date = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
            last = 30 * lastm + lastd + 365 * lasty ;

            DataGridViewRowCollection rows = dataGridView1.Rows;

            if(last>0)
                rows.Add(new Object[] { subject, type, month + "- " + date + " - " + year });//, last + "-days"

            textBox1.Clear();
            textBox2.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
