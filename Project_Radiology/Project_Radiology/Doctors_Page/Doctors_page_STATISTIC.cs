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
    public partial class Doctors_page_STATISTIC : Form
    {
        public Doctors_page_STATISTIC()
        {
            InitializeComponent();
        }

        private void back_btn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_page back4 = new Doctors_page();
            back4.Show();
        }

        private void Doctors_page_STATISTIC_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
