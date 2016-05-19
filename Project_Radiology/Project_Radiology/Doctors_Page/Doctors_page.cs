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
    public partial class Doctors_page : Form
    {
        public Doctors_page()
        {
            InitializeComponent();
        }

        private void log_btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_page st2 = new Start_page();
            st2.Show();
        }

        private void newpatient_btn_Click(object sender, System.EventArgs e)
        {
            add_patient ad1 = new add_patient();
            ad1.Show();
        }

        private void databse_btn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Doctors_page_DATABASE dcdt = new Doctors_page_DATABASE();
            dcdt.Show();
        }

        private void createanalysis_btn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
             Doctors_page_CREARE_ANALYSIS dcst= new Doctors_page_CREARE_ANALYSIS ();
            dcst.Show();
        }

        private void statistic_btn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
              Doctors_page_STATISTIC dcstat= new  Doctors_page_STATISTIC();
            dcstat.Show();
        }

        private void Doctors_page_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_page_NEW_PATIENT pat = new Doctors_page_NEW_PATIENT();
            pat.Show();
        }

        private void Doctors_page_FormClosing(object sender, FormClosingEventArgs e)
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
