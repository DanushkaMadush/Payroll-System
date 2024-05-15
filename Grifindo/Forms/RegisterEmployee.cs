using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo.Forms
{
    public partial class RegisterEmployee : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;";
        SqlConnection cnn = new SqlConnection(connectionstr);

        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            txtemail.Clear();
            txtmonthlySalary.Clear();
            txtallowances.Clear();
            txtnic.Clear();
            txtotRate.Clear();
            dtpbirthday.ResetText();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            txtfname.Focus();
        }//clear all fields

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    //Register
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES(@fname,@lname,@dob,@gender,@address,@contactno,@email,@nic,@monthlysalary,@allowances,@otrate)", cnn);

                    cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                    cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                    cmd.Parameters.AddWithValue("@dob", dtpbirthday.Value);
                    string gender;
                    if (rbmale.Checked) gender = "Male"; else gender = "Female";
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@contactno", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@nic", txtnic.Text);
                    cmd.Parameters.AddWithValue("@monthlysalary", txtmonthlySalary.Text);
                    cmd.Parameters.AddWithValue("@otrate", txtotRate.Text);
                    cmd.Parameters.AddWithValue("@allowances", txtallowances.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Employee Registered Successfully!", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear
                    txtfname.Clear();
                    txtlname.Clear();
                    txtaddress.Clear();
                    txtcontact.Clear();
                    txtemail.Clear();
                    txtnic.Clear();
                    dtpbirthday.ResetText();
                    rbmale.Checked = false;
                    rbfemale.Checked = false;
                    txtmonthlySalary.Clear();
                    txtotRate.Clear();
                    txtallowances.Clear();
                    txtfname.Focus();

                    cnn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//register employee
    }
}
