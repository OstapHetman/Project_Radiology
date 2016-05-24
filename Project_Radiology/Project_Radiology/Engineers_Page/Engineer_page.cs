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

        private void Engineer_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            eng_statistic ff = new eng_statistic();
            ff.Show();
        }
    }
}
