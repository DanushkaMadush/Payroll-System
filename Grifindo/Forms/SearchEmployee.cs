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

    public partial class SearchEmployee : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;";
        SqlConnection cnn = new SqlConnection(connectionstr);

        public SearchEmployee()
        {
            InitializeComponent();
            fillcombobox();

        }

        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployee_ID.DataSource = dt;
            cmbemployee_ID.DisplayMember = "Employee_ID";
            cmbemployee_ID.ValueMember = "Employee_ID";
        }//populate combo box

        private void load_employee()
        {
            try
            {

                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE employee_ID=@Employee_ID", cnn);
                cmd.Parameters.AddWithValue("@Employee_ID", cmbemployee_ID.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtfname.Text = dr[1].ToString();
                    txtlname.Text = dr[2].ToString();
                    dtpbirthday.Text = dr[3].ToString();

                    string gender = dr[4].ToString().Trim();
                    if (string.Equals(gender, "Female"))
                        rbfemale.Checked = true;
                    else
                        rbmale.Checked = true;


                    txtaddress.Text = dr[5].ToString();
                    txtemail.Text = dr[7].ToString();
                    txtcontact.Text = dr[6].ToString();
                    txtnic.Text = dr[8].ToString();
                    txtmonthlySalary.Text = dr[9].ToString();
                    txtotRate.Text = dr[11].ToString();
                    txtallowances.Text = dr[10].ToString();
                }

                else
                {
                    MessageBox.Show("Employee Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




                cnn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }

        }//load details

        private void cmbemployee_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            //load_employee();
        }//not worked

        private void cmbemployee_ID_Leave(object sender, EventArgs e)
        {
            load_employee();
        }//load details when leave combo box

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
            cmbemployee_ID.Focus();
        }//Clear All fields 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Employee SET first_name=@fname,last_name=@lname,dob=@dob,gender=@gender,address=@address,email=@email,contact_no=@contactno,nic=@nic,monthly_salary=@monthlysalary,ot_rate=@otrate,allowances=@allowances WHERE employee_ID=@Eno", cnn);

                    cmd.Parameters.AddWithValue("@Eno", cmbemployee_ID.Text);
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
                    MessageBox.Show("Employee Details Update Successfully!", "Details Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    cmbemployee_ID.ResetText();
                    //this.ActiveControl = cmbemployee_ID;


                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//Update Records

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE employee_ID=@Eno", cnn);

                    cmd.Parameters.AddWithValue("@Eno", cmbemployee_ID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Record Delete Successfully!", "Record Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    cmbemployee_ID.ResetText();
                    //this.ActiveControl = cmbemployee_ID;


                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Delete records

        private void cmbemployee_ID_TextChanged(object sender, EventArgs e)
        {
            //load_employee();
        }//not worked
    }
}
