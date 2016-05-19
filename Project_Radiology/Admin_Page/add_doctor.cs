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
    public partial class add_doctor : Form
    {
        public add_doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO DOCTORS_1(ID, FirstName, LastName, HospitalID, Login, Password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show("Changes Saved");
        }

        private void btn_del2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM DOCTORS_1 WHERE (ID='" + textBox1.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show("Record delete");
        }
    }
}
