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
    public partial class Doctors_page_NEW_PATIENT : Form
    {
        HospitalEntities pat;
        SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public Doctors_page_NEW_PATIENT()
        {
            InitializeComponent();
        }

        private void back_btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_page back3 = new Doctors_page();
            back3.Show();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Doctors_page_NEW_PATIENT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);
            pat = new HospitalEntities();
            patientBindingSource.DataSource = pat.Patient;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            DataTable dta = new DataTable();
            SqlDataAdapter SD = new SqlDataAdapter("SELECT * FROM Patient where SSN = "+ textBox1.Text , conn);
            SD.Fill(dta);
            patientDataGridView.DataSource = dta;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Patient WHERE SSN like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            patientDataGridView.DataSource = dt;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Display_btn3_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter SDA = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Patient ", conn);
            SDA.Fill(dt);
            patientDataGridView.DataSource = dt;
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("INSERT INTO Patient(SSN, FirstName, LastName, DocrotsID) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ", conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    MessageBox.Show("Changes Saved");
        //}

        private void add_pat_btn_Click(object sender, EventArgs e)
        {
            add_patient add = new add_patient();
            add.Show();
        }
    }
}
