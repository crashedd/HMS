using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class NurseInfo : Form
    {
        public NurseInfo()
        {
            InitializeComponent();
        }

        private void NurseInfo_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;

            SqlConnection con = GlobalVars.con;
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;

            cmm.CommandText = "select * from ntab";
            SqlDataAdapter dap = new SqlDataAdapter(cmm);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int Id;
        Int64 rowid; 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel4.Visible = true;
            SqlConnection con = GlobalVars.con;
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;

            cmm.CommandText = "select * from ntab where Id=" + Id + "";
            SqlDataAdapter dap = new SqlDataAdapter(cmm);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAge.Text = ds.Tables[0].Rows[0][2].ToString();
            cmbGender.Text = ds.Tables[0].Rows[0][3].ToString();
            txtCN.Text = ds.Tables[0].Rows[0][4].ToString();
            cmbAva.Text = ds.Tables[0].Rows[0][5].ToString();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void txtNAva_TextChanged(object sender, EventArgs e)
        {
            if (txtNAva.Text != "")
            {
                SqlConnection con = GlobalVars.con;
                if (con.State == ConnectionState.Closed) { con.Open(); }
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "select * from ntab where Availability LIKE '" + txtNAva.Text + "%'";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = GlobalVars.con;
                if (con.State == ConnectionState.Closed) { con.Open(); }
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "select * from ntab";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNAva.Clear();
            panel4.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string cn = new string(txtCN.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", "").Where(char.IsDigit).ToArray());
                if (cn.Length != 11)
                {
                    MessageBox.Show("Please enter a valid contact number with 11 digits.");
                    return;
                }

                String id = txtId.Text;
                String name = txtName.Text;
                String age = txtAge.Text;
                String gender = cmbGender.Text;
                String contactnumber = txtCN.Text;
                String availability = cmbAva.Text;

                SqlConnection con = GlobalVars.con;
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "update ntab set Id='" + id + "', Name='" + name + "', Age='" + age + "', Gender= '" + gender + "', [Contact Number]='" + contactnumber + "', Availability='" + availability + "' where Id=" + rowid + "";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                txtId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                cmbAva.Text = string.Empty;
                cmbGender.Text = string.Empty;

                MessageBox.Show("Data Updated!");

                disp();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = GlobalVars.con;
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "delete from ntab where Id=" + rowid + "";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                txtId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                cmbAva.Text = string.Empty;
                cmbGender.Text = string.Empty;

                disp();
            }
        }

        public void disp()
        {
            SqlConnection con = GlobalVars.con;
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlCommand cmm = con.CreateCommand();
            cmm.CommandType = CommandType.Text;
            cmm.CommandText = "select * from ntab";
            cmm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmm);
            dap.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
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
    }
}
