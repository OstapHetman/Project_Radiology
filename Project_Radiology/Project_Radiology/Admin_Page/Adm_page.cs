using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Radiology.Admin_Page
{
    public partial class Adm_page : Form
    {
        public Adm_page()
        {
            InitializeComponent();
        }

        private void adddoc_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adm_add_doc qw = new Adm_add_doc();
            qw.Show();


        }
    }
}
