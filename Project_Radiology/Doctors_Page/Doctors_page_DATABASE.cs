using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Radiology
{
    public partial class Doctors_page_DATABASE : Form
    {
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
    }
}
