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
    public partial class add_laboratory : Form
    {
        public add_laboratory()
        {
            InitializeComponent();
        }

        private void save_btn4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Laboratory(ID, [№ room], [Type of research], [Who works], HospitalID) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            MessageBox.Show("Changes Saved");
        }
    }
}
