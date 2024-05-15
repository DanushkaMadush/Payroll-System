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
    public partial class Overtime : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;";
        SqlConnection cnn = new SqlConnection(connectionstr);

        public Overtime()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                decimal normalOT = decimal.Parse(txtnormalOT.Text);
                decimal doubleOT = decimal.Parse(txtdoubleOT.Text);
                decimal tripleOT = decimal.Parse(txttripleOT.Text);

                SqlCommand cmd = new SqlCommand("INSERT INTO Overtime VALUES (@employee_ID, @ot_date, @normal_ot, @double_ot, @triple_ot);", cnn);
                cmd.Parameters.AddWithValue("@employee_ID", Convert.ToInt32(cmbemployee_ID.SelectedValue));
                cmd.Parameters.AddWithValue("@ot_date", dtpot.Value.Date);
                cmd.Parameters.AddWithValue("@normal_ot", normalOT);
                cmd.Parameters.AddWithValue("@double_ot", doubleOT);
                cmd.Parameters.AddWithValue("@triple_ot", tripleOT);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbemployee_ID.ResetText();
                dtpot.ResetText();
                txtnormalOT.Clear();
                txtdoubleOT.Clear();
                txttripleOT.Clear();
                txtnormalOT.Text = "0";
                txtdoubleOT.Text = "0";
                txttripleOT.Text = "0";


                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//Add details to database

        private void load_details()
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Overtime WHERE ot_date=@ot_date AND employee_ID=@employee_ID", cnn);
                cmd.Parameters.AddWithValue("@ot_date", dtpot.Text);
                cmd.Parameters.AddWithValue("@employee_ID", cmbemployee_ID.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtnormalOT.Text = dr[2].ToString();
                    txtdoubleOT.Text = dr[3].ToString();
                    txttripleOT.Text = dr[4].ToString();

                    btnUpdate.Enabled = true;
                    btnAdd.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Please add new details");
                    btnUpdate.Enabled = false;
                    btnAdd.Enabled = true;
                    txtnormalOT.Clear();
                    txtdoubleOT.Clear();
                    txttripleOT.Clear();
                    txtnormalOT.Text = "0";
                    txtdoubleOT.Text = "0";
                    txttripleOT.Text = "0";
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//Load details to form

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Overtime SET normal_ot=@normal_ot,double_ot=@double_ot,triple_ot=@triple_ot WHERE employee_ID=@employee_ID AND ot_date=@ot_date", cnn);

                    cmd.Parameters.AddWithValue("@employee_ID", cmbemployee_ID.Text);
                    cmd.Parameters.AddWithValue("@ot_date", dtpot.Text);
                    cmd.Parameters.AddWithValue("@normal_ot", txtnormalOT.Text);
                    cmd.Parameters.AddWithValue("@double_ot", txtdoubleOT.Text);
                    cmd.Parameters.AddWithValue("@triple_ot", txttripleOT.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Details Update Successfully!", "Details Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear
                    cmbemployee_ID.ResetText();
                    dtpot.ResetText();
                    txtnormalOT.Clear();
                    txtdoubleOT.Clear();
                    txttripleOT.Clear();
                    txtnormalOT.Text = "0";
                    txtdoubleOT.Text = "0";
                    txttripleOT.Text = "0";


                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//update records

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbemployee_ID.ResetText();
            dtpot.ResetText();
            txtnormalOT.Clear();
            txtdoubleOT.Clear();
            txttripleOT.Clear();
            txtnormalOT.Text = "0";
            txtdoubleOT.Text="0";
            txttripleOT.Text = "0";
        }//clear all fifelds

        private void dtpot_Leave(object sender, EventArgs e)
        {
            load_details();
        }//load details when leave date 
    }
}
