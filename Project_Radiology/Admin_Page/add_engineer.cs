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
    public partial class add_engineer : Form
    {
        public add_engineer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Engineer_1(ID, FirstName, LastName, Login, Password, LaboratoryID, HospitalID) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox6.Text + "') ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show("Changes Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Engineer_1 WHERE (ID='" + textBox1.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show("Record delete");
        }
    }
}
