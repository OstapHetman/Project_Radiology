﻿using System;
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
        SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public hosp_adm()
        {
            InitializeComponent();
        }

        private void log_btn3z_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_items ww = new view_items();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Hospital WHERE ID like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            hospitalBindingSource.DataSource = dt;
            conn.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hospitalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
            MessageBox.Show("Changes Saved");
        }

        private void hosp_adm_FormClosing(object sender, FormClosingEventArgs e)
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
