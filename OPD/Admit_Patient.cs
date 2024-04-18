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
    public partial class Admit_Patient : Form
    {
        public Admit_Patient()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Request_Lab f3 = new Request_Lab();
            f3.Show();
            this.Hide();
        }
    }
}
