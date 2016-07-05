namespace SchoolHelper
{
    partial class Instruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instruction));
            this.label1 = new System.Windows.Forms.Label();
            this.EndInstruction = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labellllll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(246, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 400);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // EndInstruction
            // 
            this.EndInstruction.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndInstruction.Location = new System.Drawing.Point(362, 468);
            this.EndInstruction.Name = "EndInstruction";
            this.EndInstruction.Size = new System.Drawing.Size(121, 22);
            this.EndInstruction.TabIndex = 1;
            this.EndInstruction.Text = "了解了!";
            this.EndInstruction.UseVisualStyleBackColor = true;
            this.EndInstruction.Click += new System.EventHandler(this.EndInstruction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolHelper.Properties.Resources._1420774360_Book_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labellllll
            // 
            this.labellllll.AutoSize = true;
            this.labellllll.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labellllll.Location = new System.Drawing.Point(38, 319);
            this.labellllll.Name = "labellllll";
            this.labellllll.Size = new System.Drawing.Size(143, 16);
            this.labellllll.TabIndex = 3;
            this.labellllll.Text = "School Helper Beta 11.0";
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 502);
            this.Controls.Add(this.labellllll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EndInstruction);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Instruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "軟體說明";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EndInstruction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labellllll;

    }
}