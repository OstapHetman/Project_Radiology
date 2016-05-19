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
    public partial class Start_page : Form
    {
        public Start_page()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void docpage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_page doc = new Doctors_page();
            doc.Show();
        }

        private void adminpage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_pages adm = new Admin_pages();
            adm.Show();
        }

        private void engineerpage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Engineer_page eng = new Engineer_page();
            eng.Show();
        }

        private void Start_page_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("No problem, it happens :D");
        }
    }
}
