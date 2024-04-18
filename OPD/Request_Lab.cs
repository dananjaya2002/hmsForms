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
    public partial class Request_Lab : Form
    {
        public Request_Lab()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Issue_Prescription f4 = new Issue_Prescription();
            f4.Show();
            this.Hide();
        }
    }
}
