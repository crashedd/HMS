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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count;
        int attempt;

        void disable()
        {
            if (attempt == 3)
            {
                MessageBox.Show("You've succeeded that maximum (3) attempts! \nPlease try again later.", "Attempts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                attempt = 0;
                count = 10;

                timerlogin.Enabled = true;
                txtUsername.Enabled = false;
                txtPass.Enabled = false;
                btnLOG.Enabled = false;
            }
        }

        private void timerlogin_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timerlogin.Enabled = false;
                btnLOG.Enabled = true;
                txtUsername.Enabled = true;
                txtPass.Enabled = true;
                btnLOG.Text = "LOG IN";
                txtUsername.Focus();
            }
            else
            {
                btnLOG.Text = "LOG IN " + count;
                count = count - 1;
            }
        }

        private void btnLOG_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPass.Text == "admin123")
            {
                MessageBox.Show("Welcome Admin!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Dashboard fm2 = new Dashboard();
                fm2.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPass.Clear();
                txtUsername.Focus();
                attempt = attempt + 1;
                disable();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            attempt = 0;
        }
    }
}
