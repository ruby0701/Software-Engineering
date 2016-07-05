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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void ToClassButton_Click(object sender, EventArgs e)
        {
            Class jumpToClass = new Class();
            jumpToClass.ShowDialog(this);
        }

        private void ToAbsentCountButton_Click(object sender, EventArgs e)
        {

        }

        private void ToTimeTableButton_Click(object sender, EventArgs e)
        {
            TimeCount jumpToTimeCount = new TimeCount();
            jumpToTimeCount.ShowDialog(this);
        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ToMain2Button_Click(object sender, EventArgs e)
        {
            Main2 jumpToMain2 = new Main2();
            jumpToMain2.ShowDialog();           
        }

    }
}
