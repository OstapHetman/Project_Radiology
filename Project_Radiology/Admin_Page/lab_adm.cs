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
    public partial class lab_adm : Form
    {
        HospitalEntities lab;
        public lab_adm()
        {
            InitializeComponent();
        }

        private void log_btn3z_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_pages www = new Admin_pages();
            www.Show();


        }

        private void laboratoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laboratoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void lab_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Laboratory". При необходимости она может быть перемещена или удалена.
            this.laboratoryTableAdapter.Fill(this.hospitalDataSet.Laboratory);
            lab = new HospitalEntities();
            laboratoryBindingSource.DataSource = lab.Laboratory;


                 

        }

        private void add_btn4_Click(object sender, EventArgs e)
        {
            add_laboratory add4 = new add_laboratory();
            add4.Show();
        }
    }
}
