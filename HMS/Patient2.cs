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
    public partial class Patient2 : Form
    {
        public Patient2()
        {
            InitializeComponent();
        }

        private void Patient2_Load(object sender, EventArgs e)
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
            if (con.State == ConnectionState.Closed)
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
            }
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;

            cmm.CommandText = "select * from ptab where Id="+Id+"";
            SqlDataAdapter dap = new SqlDataAdapter(cmm);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAge.Text = ds.Tables[0].Rows[0][2].ToString();
            cmbGender.Text = ds.Tables[0].Rows[0][3].ToString();
            txtDOB.Text = ds.Tables[0].Rows[0][4].ToString();
            cmbBT.Text = ds.Tables[0].Rows[0][5].ToString();
            txtCN.Text = ds.Tables[0].Rows[0][6].ToString();
            txtAddress.Text = ds.Tables[0].Rows[0][7].ToString();
            txtDId.Text = ds.Tables[0].Rows[0][17].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {
            if(txtPName.Text != "")
            {
                SqlConnection con = GlobalVars.con;
                if (con.State == ConnectionState.Closed) { if (con.State == ConnectionState.Closed) { con.Open(); } }
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "select * from ptab where Name LIKE '"+txtPName.Text+ "%'";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPName.Clear();
            panel4.Visible = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Data will be updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
                String dateofbirth = txtDOB.Text;
                String bloodtype = cmbBT.Text;
                String contactnumber = txtCN.Text;
                String address = txtAddress.Text;
                String doctorid = txtDId.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-0AIDSV1\\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                //Test
                string columnName = "Patient Load";
                string tableName = "dtab";
                int rowId = 9; // Assuming the row ID you want to update is 1

                // Check if the column exists in the table
                string checkColumnQuery = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}' AND COLUMN_NAME = '{columnName}'";
                SqlCommand checkColumnCommand = new SqlCommand(checkColumnQuery, con);
                object columnExists = checkColumnCommand.ExecuteScalar();

                if (columnExists != null)
                {
                    // Column exists, so increment its value in the specified row
                    string updateQuery = $"UPDATE {tableName} SET {columnName} = {columnName} + 1 WHERE id = {rowId}";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Update successful
                        MessageBox.Show("Column value incremented.");
                    }
                    else
                    {
                        // Row ID not found
                        MessageBox.Show("Row ID not found in the table.");
                    }
                }
                else
                {
                    // Column does not exist
                    MessageBox.Show("Column does not exist in the table.");
                }

                //Test

                cmm.CommandText = "update ptab set Id='" + id + "', Name='" + name + "', Age='" + age + "', Gender= '"+gender+"', [Date of Birth]='" + dateofbirth + "', [Blood Type]='" + bloodtype + "', [Contact Number]='" + contactnumber + "', Address='" + address + "', [Doctor's Id]='"+doctorid+"' where Id=" + rowid + "";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                txtId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                txtDOB.Clear();
                txtAddress.Clear();
                cmbBT.Text = string.Empty;
                cmbGender.Text = string.Empty;
                txtDId.Clear();

                MessageBox.Show("Data Updated!");

                disp();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=DESKTOP-0AIDSV1\\SQLEXPRESS;Initial Catalog=hosysdb;Integrated Security=True");
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = con;

                cmm.CommandText = "delete from ptab where Id=" + rowid + "";
                SqlDataAdapter dap = new SqlDataAdapter(cmm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                txtId.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtCN.Clear();
                txtDOB.Clear();
                txtAddress.Clear();
                cmbBT.Text = string.Empty;
                cmbGender.Text = string.Empty;
                txtDId.Clear() ;

                disp();
            }
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
