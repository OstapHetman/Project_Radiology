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
    public partial class add_hospital : Form
    {
        public add_hospital()
        {
            InitializeComponent();
        }

        private void save_btn5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Hospital(ID, Name, Adress, [№ of workers]) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show("Changes Saved");
        }
    }
}
