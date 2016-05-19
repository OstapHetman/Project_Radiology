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
    public partial class Formdsdas1 : Form
    {
        HospitalEntities doc;
        public Formdsdas1()
        {
            InitializeComponent();
        }

        private void log_btn3z_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_pages zx = new Admin_pages();
            zx.Show();
        }

        private void dOCTORS_1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORS_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Formdsdas1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.DOCTORS_1". При необходимости она может быть перемещена или удалена.
            this.dOCTORS_1TableAdapter.Fill(this.hospitalDataSet.DOCTORS_1);
            doc = new HospitalEntities();
            dOCTORS_1BindingSource.DataSource = doc.DOCTORS_1;

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("INSERT INTO DOCTORS_1(ID, FirstName, LastName, HospitalID, Login, Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ", conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    MessageBox.Show("Changes Saved");
        //}

        private void add_btn_2_Click(object sender, EventArgs e)
        {
            add_doctor add1 = new add_doctor();
            add1.Show();
        }
    }
}
