using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Radiology
{
    public partial class Engineer_page : Form
    {
        public Engineer_page()
        {
            InitializeComponent();
        }

        private void log_btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_page st1 = new Start_page();
            st1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analysis_Engineer ana = new Analysis_Engineer();
            ana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            statistic_eng y = new statistic_eng();
            y.Show();

     
        }
    }
}
