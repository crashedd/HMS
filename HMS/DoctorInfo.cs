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
    public partial class DoctorInfo : Form
    {
        public DoctorInfo()
        {
            InitializeComponent();
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

        private void DoctorInfo_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0AIDSV1\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
            con.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;

            cmm.CommandText = "select * from dtab";
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0AIDSV1\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
            con.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;

            cmm.CommandText = "select * from dtab where DId=" + Id + "";
            SqlDataAdapter dap = new SqlDataAdapter(cmm);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtDId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAge.Text = ds.Tables[0].Rows[0][2].ToString();
            cmbGender.Text = ds.Tables[0].Rows[0][3].ToString();
            txtCN.Text = ds.Tables[0].Rows[0][4].ToString();
            txtExp.Text = ds.Tables[0].Rows[0][5].ToString();
            cmbSpecialization.Text = ds.Tables[0].Rows[0][6].ToString();
            cmbAva.Text = ds.Tables[0].Rows[0][7].ToString();
            txtRN.Text = ds.Tables[0].Rows[0][8].ToString();
            txtFN.Text = ds.Tables[0].Rows[0][9].ToString();
        }

        private void txtNAva_TextChanged(object sender, EventArgs e)
        {
            if (txtNAva.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0AIDSV1\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
                con.Open();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "select * from dtab where Availability LIKE '" + txtNAva.Text + "%'";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0AIDSV1\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
                con.Open();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "select * from dtab";
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

        public void disp()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0AIDSV1\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
            con.Open();
            SqlCommand cmm = con.CreateCommand();
            cmm.CommandType = CommandType.Text;
            cmm.CommandText = "select * from dtab";
            cmm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmm);
            dap.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
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
            Application.Exit();
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

                String id = txtDId.Text;
                String name = txtName.Text;
                String age = txtAge.Text;
                String gender = cmbGender.Text;
                String contactnumber = txtCN.Text;
                String experience = txtExp.Text;
                String specialization = cmbSpecialization.Text;
                String availability = cmbAva.Text;
                String rn = txtRN.Text;
                String fn = txtFN.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-0AIDSV1\\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "update dtab set DId='" + id + "', Name='" + name + "', Age='" + age + "', Gender= '" + gender + "', [Contact Number]='" + contactnumber + "', Experience='"+experience+"', Specialization='"+specialization+"', Availability='" + availability + "', [Room Number]= '"+rn+"', [Floor Number]= '"+fn+"' where DId=" + rowid + "";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                txtDId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                txtExp.Clear();
                cmbSpecialization.Text = string.Empty;
                cmbAva.Text = string.Empty;
                cmbGender.Text = string.Empty;
                txtFN.Clear();
                txtRN.Clear();

                MessageBox.Show("Data Updated!");

                disp();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-0AIDSV1\\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "delete from dtab where DId=" + rowid + "";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                txtDId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                txtExp.Clear();
                cmbSpecialization.Text = string.Empty;
                cmbAva.Text = string.Empty;
                cmbGender.Text = string.Empty;
                txtRN.Clear();
                txtFN.Clear();  

                disp();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }
    }
}
