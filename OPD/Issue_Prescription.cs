using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmsForms.OPD
{
    public partial class Issue_Prescription : Form
    {
        public Issue_Prescription()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OPD_Dashboard f5 = new OPD_Dashboard();
            f5.Show();
            this.Hide();
        }
    }
}
