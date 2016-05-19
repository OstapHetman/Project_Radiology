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
    public partial class statistic_eng : Form
    {
        public statistic_eng()
        {
            InitializeComponent();
        }

        private void log_btn3z_Click(object sender, EventArgs e)
        {
            this.Hide();
            Engineer_page h = new Engineer_page();
            h.Show();
        }

       

        private void statistic_eng_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Analysis". При необходимости она может быть перемещена или удалена.
            this.analysisTableAdapter.Fill(this.hospitalDataSet.Analysis);

        }

        private void grouped_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            grouped_doc hh = new grouped_doc();
            hh.Show();

        }

        private void groped_btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            grouped_pat hh = new grouped_pat();
            hh.Show();
        }
    }
}
