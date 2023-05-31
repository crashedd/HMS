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
    public partial class DataFindings : Form
    {
        public DataFindings()
        {
            InitializeComponent();
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

        private void DataFindings_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;

            SqlConnection con = GlobalVars.con;
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;

            cmm.CommandText = "select * from ptab";
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

            cmm.CommandText = "select * from ptab where Id=" + Id + "";
            SqlDataAdapter dap = new SqlDataAdapter(cmm);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtPId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtTemp.Text = ds.Tables[0].Rows[0][10].ToString();
            txtHeight.Text = ds.Tables[0].Rows[0][11].ToString();
            txtBP.Text = ds.Tables[0].Rows[0][8].ToString();
            txtHR.Text = ds.Tables[0].Rows[0][9].ToString();
            txtWeight.Text = ds.Tables[0].Rows[0][12].ToString();
            txtAllergy.Text = ds.Tables[0].Rows[0][13].ToString();
            txtMI.Text = ds.Tables[0].Rows[0][14].ToString();
            txtPrev.Text = ds.Tables[0].Rows[0][15].ToString();
            cmbNS.Text = ds.Tables[0].Rows[0][16].ToString();
        }

        private void txtNName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPName.Clear();
            panel4.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        public void disp()
        {
            SqlConnection con = GlobalVars.con;
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlCommand cmm = con.CreateCommand();
            cmm.CommandType = CommandType.Text;
            cmm.CommandText = "select * from ptab";
            cmm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmm);
            dap.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = GlobalVars.con;
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "delete from ptab where Id=" + rowid + "";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                txtPId.Clear();
                txtTemp.Clear();
                txtHeight.Clear();
                txtBP.Clear();
                txtHR.Clear();
                txtWeight.Clear();
                txtAllergy.Clear();
                txtMI.Clear();
                txtPrev.Clear();
                cmbNS.Text = string.Empty;

                disp();
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

        private void txtPName_TextChanged(object sender, EventArgs e)
        {
            if (txtPName.Text != "")
            {
                SqlConnection con = GlobalVars.con;
                if (con.State == ConnectionState.Closed) { con.Open(); }
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "select * from ptab where Name LIKE '" + txtPName.Text + "%'";
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

                cmm.CommandText = "select * from ptab";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be save. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String id = txtPId.Text;
                String temp = txtTemp.Text;
                String height = txtHeight.Text;
                String bp = txtBP.Text;
                String hr = txtHR.Text;
                String weight = txtWeight.Text;
                String allergy = txtAllergy.Text;
                String medicalillnesses = txtMI.Text;
                String prevhospitalization = txtPrev.Text;
                String ns = cmbNS.Text;

                SqlConnection con = GlobalVars.con;
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "update ptab set Id='" + id + "', Temp='" + temp + "', Height='" + height + "', BP='" + bp + "', HR='" + hr + "', Weight='" + weight + "', [Medical Illnesses]='" + medicalillnesses + "', Allergy='" + allergy + "', [Previous Hospitalization]='" + prevhospitalization + "', Needed Specialization='" + ns + "' where Id=" + rowid + "";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                txtPId.Clear();
                txtTemp.Clear();
                txtHeight.Clear();
                txtBP.Clear();
                txtHR.Clear();
                txtWeight.Clear();
                txtAllergy.Clear();
                txtMI.Clear();
                txtPrev.Clear();
                cmbNS.Text = string.Empty;

                disp();
            }
        }
    }
}
