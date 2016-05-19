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
    public partial class Doctors_page_STATISTIC : Form
    {
        HospitalEntities hos;
        SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
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

        private void analysisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Doctors_page_STATISTIC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Analysis". При необходимости она может быть перемещена или удалена.
            this.analysisTableAdapter.Fill(this.hospitalDataSet.Analysis);
            hos = new HospitalEntities();
            analysisBindingSource.DataSource = hos.Analysis;
             

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Analysis WHERE Patient_SSN like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            analysisBindingSource.DataSource = dt;
            conn.Close();
        }
    }
}
