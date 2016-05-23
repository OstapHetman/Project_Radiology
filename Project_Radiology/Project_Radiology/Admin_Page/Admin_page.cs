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
            add_doctor doc = new add_doctor();
            doc.Show();
        }
        private void addengineer_btn_Click(object sender, EventArgs e)
        {
            add_engineer eng = new add_engineer();
            eng.Show();
        }

        private void addlaborator_btn_Click(object sender, EventArgs e)
        {
            add_laboratory lab = new add_laboratory();
            lab.Show();
        }
        private void addhospital_btn_Click(object sender, EventArgs e)
        {
            add_hospital hosp = new add_hospital();
            hosp.Show();
        }
        private void statistic_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            statis_adm r = new statis_adm();
            r.Show();
        }
        private void Admin_pages_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.DOCTORS_1". При необходимости она может быть перемещена или удалена.
            this.dOCTORS_1TableAdapter.Fill(this.hospitalDataSet.DOCTORS_1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_items vv = new view_items();
            vv.Show();
        }
        private void Admin_pages_FormClosed(object sender, FormClosedEventArgs e)
        {
    
        }
        private void Admin_pages_FormClosing(object sender, FormClosingEventArgs e)
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
