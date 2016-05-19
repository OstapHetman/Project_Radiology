using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.Drawing.Design;



namespace Project_Radiology
{
    public partial class Admin_pages : Form
    {
        public Admin_pages()
        {
            InitializeComponent();
        }

        private void log_btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start_page st3 = new Start_page();
            st3.Show();
        }

        private void adddoc_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formdsdas1 k = new Formdsdas1();
            k.Show();
        }

        private void addengineer_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            eng_adm m = new eng_adm();
            m.Show();

        }

        private void addlaborator_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            lab_adm q = new lab_adm();
            q.Show();
        }

        private void addhospital_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            hosp_adm w = new hosp_adm();
            w.Show();
        }

        private void statistic_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            statis_adm r = new statis_adm();
            r.Show();
        }
    }
}
