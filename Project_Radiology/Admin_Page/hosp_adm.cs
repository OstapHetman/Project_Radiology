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
    public partial class hosp_adm : Form
    {
        HospitalEntities hos;

        public hosp_adm()
        {
            InitializeComponent();
        }

        private void log_btn3z_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_pages ww = new Admin_pages();
            ww.Show();
        }

        private void hospitalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hospitalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void hosp_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Hospital". При необходимости она может быть перемещена или удалена.
            this.hospitalTableAdapter.Fill(this.hospitalDataSet.Hospital);
            hos = new HospitalEntities();
            hospitalBindingSource.DataSource = hos.Laboratory;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_hospital add5 = new add_hospital();
            add5.Show();
        }
    }
}
