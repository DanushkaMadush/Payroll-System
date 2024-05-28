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
    public partial class ViewPaysheet : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;";
        SqlConnection cnn = new SqlConnection(connectionstr);

        public ViewPaysheet()
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

            SqlDataAdapter da1 = new SqlDataAdapter("SELECT month from Month", cnn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbMonth.DataSource = dt1;
            cmbMonth.DisplayMember = "month";
            cmbMonth.ValueMember = "month";
        }//populate combo box

        private void load_details()
        {
            try
            {

                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Salary WHERE employee_ID=@Employee_ID AND month=@month", cnn);
                cmd.Parameters.AddWithValue("@Employee_ID", cmbemployee_ID.Text);
                cmd.Parameters.AddWithValue("@month", cmbMonth.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txthead.Text = dr[1].ToString();
                    txtmonthlysalary.Text = dr[2].ToString();
                    txtallowances.Text = dr[3].ToString();
                    txtnormalot.Text = dr[5].ToString();
                    txtnormalotvalue.Text = dr[6].ToString();
                    txtdoubleot.Text = dr[7].ToString();
                    txtdoubleotvalue.Text = dr[8].ToString();
                    txttripleot.Text = dr[9].ToString();
                    txttripleotvalue.Text = dr[10].ToString();
                    txttotalot.Text = dr[11].ToString();
                    txtbasepay.Text = dr[16].ToString();
                    txtnopayvalue.Text = dr[14].ToString();
                    txttaxvalue.Text = dr[15].ToString();
                    txtgrosspayment.Text = dr[17].ToString();
                    txtabsentdays.Text = dr[13].ToString();

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
        }//load details from Salary table

        private void cmbMonth_Leave(object sender, EventArgs e)
        {
            load_details();
            load_employee();
        }

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
                    txtemployee_ID.Text = dr[0].ToString();
                    txtfname.Text = dr[1].ToString();
                    txtlname.Text = dr[2].ToString();
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthead.Clear();
            txtemployee_ID.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtmonthlysalary.Clear();
            txtallowances.Clear();
            txtnormalot.Clear();
            txtdoubleot.Clear();
            txttripleot.Clear();
            txtnormalotvalue.Clear();
            txtdoubleotvalue.Clear();
            txttripleotvalue.Clear();
            txttotalot.Clear();
            txtbasepay.Clear();
            txtabsentdays.Clear();
            txtnopayvalue.Clear();
            txttaxvalue.Clear();
            txtgrosspayment.Clear();
            cmbMonth.ResetText();
            cmbemployee_ID.ResetText();
        }//clear fields
    }
}
