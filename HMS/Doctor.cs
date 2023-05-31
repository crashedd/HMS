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

namespace HMS
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtDId.Text != "" && txtName.Text != "" && txtAge.Text != "" && txtCN.Text != "" && txtExp.Text != "" && cmbGender.Text != string.Empty && cmbAva.Text != string.Empty && cmbSpecialization.Text != string.Empty)
            {
                string cn = new string(txtCN.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", "").Where(char.IsDigit).ToArray());
                if (cn.Length != 11)
                {
                    MessageBox.Show("Please enter a valid contact number with 11 digits.");
                    return;
                }

                SqlConnection con = GlobalVars.con;

                if (con.State == ConnectionState.Closed) { con.Open(); }

                SqlCommand cmm = new SqlCommand("Insert into dtab(DId, Name, Age, Gender, [Contact Number], Experience, Specialization, Availability, [Room Number], [Floor Number], [Patient Load]) Values(@Did, @name, @age, @gender, @contactnumber, @experience, @specialization, @availability, @roomnumber, @floornumber, 0)", con);

                cmm.Parameters.AddWithValue("@Did", int.Parse(txtDId.Text));
                cmm.Parameters.AddWithValue("@name", (txtName.Text));
                cmm.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmm.Parameters.AddWithValue("@gender", (cmbGender.Text));
                cmm.Parameters.AddWithValue("@contactnumber", (txtCN.Text));
                cmm.Parameters.AddWithValue("@experience", (txtExp.Text));
                cmm.Parameters.AddWithValue("@specialization", (cmbSpecialization.Text));
                cmm.Parameters.AddWithValue("@availability", (cmbAva.Text));
                cmm.Parameters.AddWithValue("@roomnumber", (txtRN.Text));
                cmm.Parameters.AddWithValue("@floornumber", (txtFN.Text));

                cmm.ExecuteNonQuery();

                con.Close();


                DoctorClass doc = new DoctorClass(int.Parse(txtDId.Text), txtName.Text, int.Parse(txtAge.Text), cmbGender.Text, txtCN.Text, txtExp.Text, cmbSpecialization.Text);
                GlobalVars.Record(doc);
                MessageBox.Show("Data inserted successfully!");

                txtDId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                txtExp.Clear();
                cmbGender.Text = string.Empty;
                cmbSpecialization.Text = string.Empty;
                cmbAva.Text = string.Empty;
                txtRN.Clear();
                txtFN.Clear();
            }
            else
            {
                MessageBox.Show("Dont leave it blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor dc = new Doctor();   
            dc.Show();
        }

        private void btnNinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorInfo di = new DoctorInfo();   
            di.Show();
        }
    }
}
