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
    public partial class Adm_add_doc : Form
    {
        public Adm_add_doc()
        {
            InitializeComponent();
        }

        private void back_btn1222_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adm_page ass = new Adm_page();
            ass.Show();
        }
    }
}
