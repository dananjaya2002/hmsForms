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
    public partial class Check_Patient : Form
    {
        public Check_Patient()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admit_Patient f2 = new Admit_Patient();
            f2.Show();
            this.Hide();
        }
    }
}
