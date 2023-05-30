using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Patient pt = new Patient();
            pt.Show();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            Nurse ns = new Nurse();
            ns.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Doctor dc = new Doctor();
            dc.Show();
        }
    }
}
