using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "Admin" && password == "Grifindo")
            {
                Form1 obj1 = new Form1();
                this.Hide();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials , Please Try Again.", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
            txtusername.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
