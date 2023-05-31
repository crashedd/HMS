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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        
    private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtName.Text != "" && txtAge.Text != "" && txtDOB.Text != "" && txtCN.Text != "" && txtAddress.Text != "" && cmbBT.Text != string.Empty && cmbGender.Text != string.Empty)
            {
                string cn = new string(txtCN.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", "").Where(char.IsDigit).ToArray());
                if (cn.Length != 11)
                {
                    MessageBox.Show("Please enter a valid contact number with 11 digits.");
                    return;
                }

                SqlConnection con = GlobalVars.con;

                con.Open();

                SqlCommand cmm = new SqlCommand("Insert into ptab(Id, Name, Age, Gender, [Contact Number], [Blood Type], [Date of Birth], Address) Values(@id, @name, @age, @gender, @contactnumber, @bloodtype, @dateofbirth, @address)", con);

                cmm.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmm.Parameters.AddWithValue("@name", (txtName.Text));
                cmm.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmm.Parameters.AddWithValue("@gender", (cmbGender.Text));
                cmm.Parameters.AddWithValue("@contactnumber", (txtCN.Text));
                cmm.Parameters.AddWithValue("@bloodtype", (cmbBT.Text));
                cmm.Parameters.AddWithValue("@dateofbirth", (txtDOB.Text));
                cmm.Parameters.AddWithValue("@address", (txtAddress.Text));

                cmm.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data inserted successfully!");

                txtId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                txtDOB.Clear();
                txtAddress.Clear();
                cmbBT.Text = string.Empty;
                cmbGender.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Dont leave it blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will delete your unsaved data.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
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

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient pt = new Patient();
            pt.Show();
        }

        private void btnRegistered_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient2 pt2 = new Patient2();
            pt2.Show();
        }
    }
}
