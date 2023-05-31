using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HMS
{
    public partial class NurseFindings : Form
    {
        public NurseFindings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = GlobalVars.con;

            if (con.State == ConnectionState.Closed) { con.Open(); }

            SqlCommand cmm = new SqlCommand("Update ptab Set temp=@temp, height=@height, bp=@bp, hr=@hr, weight=@weight, allergy=@allergy, [medical illnesses]=@medicalillnesses, [previous hospitalization]=@previoushospitalization, [needed specialization]=@neededspecialization where id=@id", con);

            cmm.Parameters.AddWithValue("@id", int.Parse(txtPId.Text));
            cmm.Parameters.AddWithValue("@temp", (txtTemp.Text));
            cmm.Parameters.AddWithValue("@height", (txtHeight.Text));
            cmm.Parameters.AddWithValue("@bp", (txtBP.Text));
            cmm.Parameters.AddWithValue("@hr", (txtHR.Text));
            cmm.Parameters.AddWithValue("@weight", int.Parse(txtWeight.Text));
            cmm.Parameters.AddWithValue("@allergy", (txtAllergy.Text));
            cmm.Parameters.AddWithValue("@medicalillnesses", (txtMI.Text));
            cmm.Parameters.AddWithValue("@previoushospitalization", (txtPrev.Text));
            cmm.Parameters.AddWithValue("@neededspecialization", (cmbNS.Text));

            cmm.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnNRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nurse ns = new Nurse();
            ns.Show();
        }

        private void btnNinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseInfo ni = new NurseInfo();
            ni.Show();
        }

        private void btnFindings_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseFindings nf = new NurseFindings();
            nf.Show();
        }

        private void btnDF_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataFindings df = new DataFindings();
            df.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
