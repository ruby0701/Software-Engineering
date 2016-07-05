namespace SchoolHelper
{
    partial class StillWorking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StillWorking));
            this.labelStillWorking = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStillWorking
            // 
            this.labelStillWorking.AutoSize = true;
            this.labelStillWorking.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelStillWorking.Location = new System.Drawing.Point(57, 62);
            this.labelStillWorking.Name = "labelStillWorking";
            this.labelStillWorking.Size = new System.Drawing.Size(165, 80);
            this.labelStillWorking.TabIndex = 0;
            this.labelStillWorking.Text = "  開發中...\r\n敬請期待!!\r\n";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClose.Location = new System.Drawing.Point(82, 174);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(99, 31);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "了解了!";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // StillWorking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelStillWorking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StillWorking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We are sorry! ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStillWorking;
        private System.Windows.Forms.Button buttonClose;
    }
}