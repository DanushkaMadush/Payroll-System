using System.Data;
using System.Data.SqlClient;

namespace Grifindo.Forms
{
    public partial class Leave : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;";
        SqlConnection cnn = new SqlConnection(connectionstr);

        public Leave()
        {
            InitializeComponent();
            fillcombobox();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            decimal leaves_per_year = decimal.Parse(txtleavesperyear.Text);
            decimal utilized_leaves = decimal.Parse(txtutilized.Text);

            decimal balance = leaves_per_year - utilized_leaves;

            txtbalance.Text = balance.ToString();
        }

        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployee_ID.DataSource = dt;
            cmbemployee_ID.DisplayMember = "Employee_ID";
            cmbemployee_ID.ValueMember = "Employee_ID";

            SqlDataAdapter da1 = new SqlDataAdapter("SELECT month from Month", cnn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbMonth.DataSource = dt1;
            cmbMonth.DisplayMember = "month";
            cmbMonth.ValueMember = "month";
        }//populate combo box

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Leaves_per_year VALUES (@employee_ID, @leaves);", cnn);
                cmd.Parameters.AddWithValue("@employee_ID", Convert.ToInt32(cmbemployee_ID.SelectedValue));
                cmd.Parameters.AddWithValue("@leaves", Convert.ToDecimal(txtleavesperyear.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbemployee_ID.ResetText();
                txtleavesperyear.Clear();


                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//Add leaves

        private void load_details()
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Leaves_per_year WHERE employee_ID=@employee_ID", cnn);
                cmd.Parameters.AddWithValue("@employee_ID", cmbemployee_ID.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtleavesperyear.Text = dr[1].ToString();

                    btnupdateleaveayear.Enabled = true;
                    btnAdd.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Please add new details");
                    txtleavesperyear.Clear();
                    btnupdateleaveayear.Enabled = false;
                    btnAdd.Enabled = true;
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//Load details to form

        private void btnupdateleaveayear_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Leaves_per_year SET leaves=@leaves WHERE employee_ID=@employee_ID", cnn);

                    cmd.Parameters.AddWithValue("@employee_ID", cmbemployee_ID.Text);
                    cmd.Parameters.AddWithValue("@leaves", Convert.ToDecimal(txtleavesperyear.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Details Update Successfully!", "Details Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear
                    cmbemployee_ID.ResetText();
                    txtleavesperyear.Clear();


                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//update leaves per year

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbemployee_ID.ResetText();
            txtleavesperyear.Clear();
            cmbMonth.ResetText();
            txtutilized.Clear();
            txtbalance.Clear();
        }//clear leaves per year fields

        private void cmbemployee_ID_Leave(object sender, EventArgs e)
        {
            load_details();
        }//load details when leave combo box

        private void load_leaves()
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT SUM(absent_days) AS absent_days FROM Salary WHERE employee_ID = @employee_ID AND month = @month;", cnn);

                cmd.Parameters.AddWithValue("@employee_ID", cmbemployee_ID.Text);
                cmd.Parameters.AddWithValue("@month", cmbMonth.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtutilized.Text = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("No Overtime Found!");
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void cmbMonth_Leave(object sender, EventArgs e)
        {
            load_leaves();
        }

        private void load_utilized_leaves()
        {

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT SUM(absent_days) AS absent_day FROM  Salary WHERE employee_ID = @employee_ID AND month = @month;", cnn);

                cmd.Parameters.AddWithValue("@employee_ID", cmbemployee_ID.Text);
                cmd.Parameters.AddWithValue("@month", cmbMonth.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtutilized.Text = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("No Leaves Found!");
                    txtutilized.Text = "0";
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }

        }//load total absent days from Salary table

        
    }
}
