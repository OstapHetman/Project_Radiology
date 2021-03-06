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
        //SqlDataAdapter sda;
        //SqlCommandBuilder scb;
        //DataTable dt;

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
            //scb = new SqlCommandBuilder(sda);
            //sda.Update(dt);
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(); //(@"Data Source=DELL/SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            //con.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Hospital;Data Source=DELL/SQLEXPRESS";
            //con.Open();
            //SqlDataAdapter  sda = new SqlDataAdapter(@"SELECT * FROM Analysis", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
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
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Analysis([State of analysis]) VALUES ('" + dataGridViewTextBoxColumn3 + "') ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Changes Saved");
        }

        private void btn_del6_Click(object sender, EventArgs e)
        {
        //    SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("DELETE FROM Analysis VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ", conn);
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //    this.Hide();
        //    MessageBox.Show("Changes Saved");
        }
    }
}
