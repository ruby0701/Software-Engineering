namespace SchoolHelper
{
    partial class Main
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
            this.ExeName = new System.Windows.Forms.Label();
            this.ToClassButton = new System.Windows.Forms.Button();
            this.ToTimeTableButton = new System.Windows.Forms.Button();
            this.ToAbsentCountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ToMain2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExeName
            // 
            this.ExeName.AutoSize = true;
            this.ExeName.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExeName.Location = new System.Drawing.Point(186, 28);
            this.ExeName.Name = "ExeName";
            this.ExeName.Size = new System.Drawing.Size(362, 56);
            this.ExeName.TabIndex = 0;
            this.ExeName.Text = "School Helper";
            this.ExeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // ToClassButton
            // 
            this.ToClassButton.Font = new System.Drawing.Font("DFYuanMedium-B5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ToClassButton.Location = new System.Drawing.Point(136, 178);
            this.ToClassButton.Name = "ToClassButton";
            this.ToClassButton.Size = new System.Drawing.Size(140, 39);
            this.ToClassButton.TabIndex = 1;
            this.ToClassButton.Text = "課程表";
            this.ToClassButton.UseVisualStyleBackColor = true;
            this.ToClassButton.Click += new System.EventHandler(this.ToClassButton_Click);
            // 
            // ToTimeTableButton
            // 
            this.ToTimeTableButton.Font = new System.Drawing.Font("DFYuanMedium-B5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ToTimeTableButton.Location = new System.Drawing.Point(136, 235);
            this.ToTimeTableButton.Name = "ToTimeTableButton";
            this.ToTimeTableButton.Size = new System.Drawing.Size(140, 39);
            this.ToTimeTableButton.TabIndex = 2;
            this.ToTimeTableButton.Text = "待辦事項";
            this.ToTimeTableButton.UseVisualStyleBackColor = true;
            this.ToTimeTableButton.Click += new System.EventHandler(this.ToTimeTableButton_Click);
            // 
            // ToAbsentCountButton
            // 
            this.ToAbsentCountButton.Font = new System.Drawing.Font("DFYuanMedium-B5", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ToAbsentCountButton.Location = new System.Drawing.Point(136, 295);
            this.ToAbsentCountButton.Name = "ToAbsentCountButton";
            this.ToAbsentCountButton.Size = new System.Drawing.Size(140, 41);
            this.ToAbsentCountButton.TabIndex = 3;
            this.ToAbsentCountButton.Text = "出缺席統計";
            this.ToAbsentCountButton.UseVisualStyleBackColor = true;
            this.ToAbsentCountButton.Click += new System.EventHandler(this.ToAbsentCountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("DFYuanMedium-B5", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(115, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "初始化選項";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ToMain2Button
            // 
            this.ToMain2Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToMain2Button.Font = new System.Drawing.Font("DFPYuanMedium-B5", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ToMain2Button.Location = new System.Drawing.Point(442, 200);
            this.ToMain2Button.Name = "ToMain2Button";
            this.ToMain2Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToMain2Button.Size = new System.Drawing.Size(197, 96);
            this.ToMain2Button.TabIndex = 5;
            this.ToMain2Button.Text = "第二頁面";
            this.ToMain2Button.UseVisualStyleBackColor = false;
            this.ToMain2Button.Click += new System.EventHandler(this.ToMain2Button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 383);
            this.Controls.Add(this.ToMain2Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToAbsentCountButton);
            this.Controls.Add(this.ToTimeTableButton);
            this.Controls.Add(this.ToClassButton);
            this.Controls.Add(this.ExeName);
            this.Font = new System.Drawing.Font("DFYuanMedium-B5", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Main";
            this.Text = "你最貼心的的學習幫手!";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExeName;
        private System.Windows.Forms.Button ToClassButton;
        private System.Windows.Forms.Button ToTimeTableButton;
        private System.Windows.Forms.Button ToAbsentCountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToMain2Button;
    }
}

