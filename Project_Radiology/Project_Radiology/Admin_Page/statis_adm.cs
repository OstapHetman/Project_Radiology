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
    public partial class statis_adm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public statis_adm()
        {
            InitializeComponent();
        }

        private void log_btn3z_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_pages ee = new Admin_pages();
            ee.Show();
        }

        private void statis_adm_FormClosing(object sender, FormClosingEventArgs e)
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

       

        private void statis_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Analysis". При необходимости она может быть перемещена или удалена.
            this.analysisTableAdapter.Fill(this.hospitalDataSet.Analysis);

        }

       
    }
}
