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
    public partial class Doctors_page_CREARE_ANALYSIS : Form
    {
        public Doctors_page_CREARE_ANALYSIS()
        {
            InitializeComponent();
        }

        private void back_btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_page back1 = new Doctors_page();
            back1.Show();
        }

        private void crt_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Analysis(ID, [Type of analysis],[State of analysis],  [Date created], Author, Patient_SSN) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + textBox4.Text + "','" + textBox5.Text + "') ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Changes Saved");
        }

        private void Doctors_page_CREARE_ANALYSIS_FormClosing(object sender, FormClosingEventArgs e)
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
