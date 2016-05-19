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
    public partial class Patient_Diagnosis : Form
    {
        HospitalEntities hos;
        SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public Patient_Diagnosis()
        {
            InitializeComponent();
        }

        private void back_btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_page_DATABASE dd = new Doctors_page_DATABASE();
            dd.Show();

        }

        private void diagnosisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diagnosisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Patient_Diagnosis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Diagnosis". При необходимости она может быть перемещена или удалена.
            this.diagnosisTableAdapter.Fill(this.hospitalDataSet.Diagnosis);
            hos = new HospitalEntities();
            diagnosisBindingSource.DataSource = hos.Diagnosis;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.diagnosisBindingSource.EndEdit();
            this.diagnosisTableAdapter.Update(this.hospitalDataSet.Diagnosis);
            MessageBox.Show("Changes Saved");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Diagnosis WHERE AnalysisID like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            diagnosisBindingSource.DataSource = dt;
            conn.Close();
        }
    }
}
