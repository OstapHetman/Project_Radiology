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
    public partial class eng_adm : Form
    {
        HospitalEntities eng;
        public eng_adm()
        {
            InitializeComponent();
        }

        private void log_btn3z_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_pages uu = new Admin_pages();
            uu.Show();
        }

        private void engineer_1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.engineer_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void eng_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Engineer_1". При необходимости она может быть перемещена или удалена.
            this.engineer_1TableAdapter.Fill(this.hospitalDataSet.Engineer_1);
            eng = new HospitalEntities();
            engineer_1BindingSource.DataSource = eng.Engineer_1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            add_engineer add2 = new add_engineer();
            add2.Show();

        }
    }
}
