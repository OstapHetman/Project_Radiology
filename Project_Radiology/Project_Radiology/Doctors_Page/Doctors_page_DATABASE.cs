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
    public partial class Doctors_page_DATABASE : Form
    {
        HospitalEntities hos;
        SqlConnection conn = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");

        public Doctors_page_DATABASE()
        {
            InitializeComponent();
        }

        private void back_btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_page back2 = new Doctors_page();
            back2.Show();
        }

        private void analysisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Doctors_page_DATABASE_Load(object sender, EventArgs e)
        {
            notifyIcon2.Text = "Healthcare - Radiology";
            notifyIcon2.BalloonTipText = "To make a diagnosis after receving results!";
            notifyIcon2.BalloonTipTitle = "REMINDER";
            notifyIcon2.Icon = SystemIcons.Application;
            notifyIcon2.ShowBalloonTip(1000);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Analysis". При необходимости она может быть перемещена или удалена.
            this.analysisTableAdapter.Fill(this.hospitalDataSet.Analysis);
            hos = new HospitalEntities();
            analysisBindingSource.DataSource = hos.Analysis;

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Distinct [State of analysis] FROM Analysis WHERE [State of analysis] like('" + dataGridViewTextBoxColumn3.CellType + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            analysisBindingSource1.DataSource = dt;
            conn.Close();
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
           
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
            analysisBindingSource2.DataSource = dt;
            conn.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysisBindingSource.EndEdit();
            this.analysisTableAdapter.Update(this.hospitalDataSet.Analysis);
            MessageBox.Show("Changes Saved");
        }

        private void Doctors_page_DATABASE_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Diagnosis pp = new Patient_Diagnosis();
            pp.Show();
        }

        private void Doctors_page_DATABASE_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void analysisDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            notifyIcon2.Text = "Healthcare - Radiology";
            notifyIcon2.BalloonTipText = "To make a diagnosis after receving results!";
            notifyIcon2.BalloonTipTitle = "REMINDER";
            notifyIcon2.Icon = SystemIcons.Application;
            notifyIcon2.ShowBalloonTip(1000);
        }

        private void Doctors_page_DATABASE_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void notifyIcon2_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

       
    }
}
