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
    public partial class Analysis_Engineer : Form
    {
        

        HospitalEntities we;

        SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        public Analysis_Engineer()
        {
            InitializeComponent();
        }

        private void back_btn12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Engineer_page engp = new Engineer_page();
            engp.Show();

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
       
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Analysis_Engineer_Load(object sender, EventArgs e)
            
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Type_of_analysis". При необходимости она может быть перемещена или удалена.
            this.type_of_analysisTableAdapter.Fill(this.hospitalDataSet.Type_of_analysis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Type_of_analysis". При необходимости она может быть перемещена или удалена.
            this.type_of_analysisTableAdapter.Fill(this.hospitalDataSet.Type_of_analysis);
            this.analysisTableAdapter.Fill(this.hospitalDataSet.Analysis);
           
            we  = new HospitalEntities();
            analysisBindingSource1.DataSource = we.Analysis;
           
        }

        private void analysisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Analysis where ID = " + textBox1.Text, conn);
            SDA.Fill(dt);
            analysisDataGridView.DataSource = dt;
        }

        private void Display_btn2_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter SDA = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Analysis ", conn);
            SDA.Fill(dt);
            analysisDataGridView.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Analysis WHERE ID like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            analysisDataGridView.DataSource = dt;
            conn.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {

            this.Validate();

            this.analysisBindingSource.EndEdit();
            this.analysisTableAdapter.Update(this.hospitalDataSet.Analysis);
            this.diagnosisBindingSource.EndEdit();
            this.diagnosisTableAdapter.Update(this.hospitalDataSet.Diagnosis);
            this.patientBindingSource.EndEdit();
            this.patientTableAdapter.Update(this.hospitalDataSet.Patient);

            MessageBox.Show("Changes Saved");
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void analysisDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Analysis_Engineer_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
