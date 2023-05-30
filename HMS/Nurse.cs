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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtName.Text != "" && txtAge.Text != "" && txtCN.Text != "" && cmbGender.Text != string.Empty && cmbAva.Text != string.Empty)
            {
                string cn = new string(txtCN.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", "").Where(char.IsDigit).ToArray());
                if (cn.Length != 11)
                {
                    MessageBox.Show("Please enter a valid contact number with 11 digits.");
                    return;
                }

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0AIDSV1\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");

                con.Open();

                SqlCommand cmm = new SqlCommand("Insert into ntab(Id, Name, Age, Gender, [Contact Number], Availability) Values(@id, @name, @age, @gender, @contactnumber, @availability)", con);

                cmm.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmm.Parameters.AddWithValue("@name", (txtName.Text));
                cmm.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmm.Parameters.AddWithValue("@gender", (cmbGender.Text));
                cmm.Parameters.AddWithValue("@contactnumber", (txtCN.Text));
                cmm.Parameters.AddWithValue("@availability", (cmbAva.Text));

                cmm.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data inserted successfully!");

                txtId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                cmbAva.Text = string.Empty;
                cmbGender.Text = string.Empty;
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


        private void btnDF_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataFindings df = new DataFindings();
            df.Show();

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
    }
}
