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
    public partial class Start_page : Form
    {
        public Start_page()
        {
            InitializeComponent();
            textBox2.PasswordChar='*';

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void docpage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctors_page doc = new Doctors_page();
            doc.Show();
        }

        private void adminpage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_pages adm = new Admin_pages();
            adm.Show();
        }

        private void engineerpage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Engineer_page eng = new Engineer_page();
            eng.Show();
        }

        private void Start_page_Load(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("No problem, it happens :D");
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Role FROM Login2 WHERE Username='" + textBox1.Text + "'and Password='" + textBox2.Text + "' ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                if(dt.Rows[0][0].ToString()=="Admin")
                {
                    this.Hide();
                    Admin_pages adm = new Admin_pages();
                    adm.Show();
                }
                else if(dt.Rows[0][0].ToString()=="Doctor")
                {
                    this.Hide();
                    Doctors_page doc = new Doctors_page();
                    doc.Show();
                }
                else if (dt.Rows[0][0].ToString() == "Engineer")
                {
                    this.Hide();
                    Engineer_page eng = new Engineer_page();
                    eng.Show();
                }
            }
            else
            {
                MessageBox.Show("      Incorrect Login or Password!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_page_FormClosing(object sender, FormClosingEventArgs e)
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
