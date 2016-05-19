using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Radiology
{
    public partial class view_items : Form
    {
        public view_items()
        {
            InitializeComponent();
        }

        private void log_btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_pages back = new Admin_pages();
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formdsdas1 ff = new Formdsdas1();
            ff.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            eng_adm ae = new eng_adm();
            ae.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab_adm la = new lab_adm();
            la.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            hosp_adm ho = new hosp_adm();
            ho.Show();

        }

        private void view_items_FormClosing(object sender, FormClosingEventArgs e)
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
