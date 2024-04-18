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
    public partial class OPD_Dashboard : Form
    {
        public OPD_Dashboard()
        {
            InitializeComponent();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check_Patient f1 = new Check_Patient();
            f1.Show();
            this.Hide();
        }
    }
}
