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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Grifindo.Forms
{
    public partial class CalculateSalary : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;";
        SqlConnection cnn = new SqlConnection(connectionstr);

        public CalculateSalary()
        {
            InitializeComponent();
            fillcombobox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                decimal monthly_salary = decimal.Parse(txtmonthlySalary.Text);
                decimal allowances = decimal.Parse(txtallowances.Text);
                decimal ot_rate = decimal.Parse(txtotRate.Text);
                decimal normal_ot_hrs = decimal.Parse(txtnormalOT.Text);
                decimal double_ot_hrs = decimal.Parse(txtdoubleOT.Text);
                decimal triple_ot_hrs = decimal.Parse(txttripleOT.Text);
                decimal absent_days = decimal.Parse(txtAbsentDays.Text);
                decimal date_range = decimal.Parse(txtDateRange.Text);
                decimal tax_rate = decimal.Parse(txtTaxRate.Text);

                // Calculate Overtime
                decimal normal_ot_value = decimal.Round(normal_ot_hrs * ot_rate, 2);
                decimal double_ot_value = decimal.Round((ot_rate * 2) * double_ot_hrs, 2);
                decimal triple_ot_value = decimal.Round((ot_rate * 3) * triple_ot_hrs, 2);
                decimal ot_total = decimal.Round(normal_ot_value + double_ot_value + triple_ot_value, 2);

                // Calculate Basepay
                decimal base_pay = decimal.Round(monthly_salary + ot_total + allowances, 2);

                // Calculate Nopay Value
                decimal no_pay_value = decimal.Round(monthly_salary / date_range * absent_days, 2);

                // Calculate Tax
                decimal tax_value = decimal.Round(base_pay * tax_rate / 100, 2);

                // Calculate Deductions
                decimal deductions = decimal.Round(no_pay_value + tax_value, 2);

                // Calculate Grosspay
                decimal gross_pay = decimal.Round(base_pay - deductions, 2);

                // Update textboxes
                txtnormalOTvalue.Text = normal_ot_value.ToString();
                txtdoubleOTvalue.Text = double_ot_value.ToString();
                txttripleOTvalue.Text = triple_ot_value.ToString();
                txtOTTotal.Text = ot_total.ToString();
                txtnoPayValue.Text = no_pay_value.ToString();
                txtTaxValue.Text = tax_value.ToString();
                txtBasePay.Text = base_pay.ToString();
                txtDeductions.Text = deductions.ToString();
                txtGrossPay.Text = gross_pay.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Input value is too large: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//calculations

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

        private void cmbemployee_ID_Leave(object sender, EventArgs e)
        {
            load_employee();
        }//load employee details when leave combo employee

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
                    txtmonthlySalary.Text = dr[9].ToString();
                    txtotRate.Text = dr[10].ToString();
                    txtallowances.Text = dr[11].ToString();
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

        private void cmbMonth_Leave(object sender, EventArgs e)
        {
            load_daterange();
            load_ot();

        }//load date range and ot total when leave month combo

        private void load_daterange()
        {
            try
            {

                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Month WHERE month=@month", cnn);
                cmd.Parameters.AddWithValue("@month", cmbMonth.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtDateRange.Text = dr[5].ToString();
                    dtpBeginDate.Text = dr[1].ToString();
                    dtpEndDate.Text = dr[2].ToString();
                }

                else
                {
                    MessageBox.Show("Date Range ERROR!");
                }
                cnn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//load date range from month table

        private void load_ot()
        {

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT SUM(normal_ot) AS normal_ot_total,SUM(double_ot) AS double_ot_total,SUM(triple_ot) AS triple_ot_total FROM  Overtime WHERE employee_ID = @employee_ID AND ot_date BETWEEN @startdate AND @enddate;", cnn);

                cmd.Parameters.AddWithValue("@employee_ID", cmbemployee_ID.Text);
                cmd.Parameters.AddWithValue("@startdate", dtpBeginDate.Value);
                cmd.Parameters.AddWithValue("@enddate", dtpEndDate.Value);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtnormalOT.Text = dr[0].ToString();
                    txtdoubleOT.Text = dr[1].ToString();
                    txttripleOT.Text = dr[2].ToString();
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

        }//load ot sum to ot fields

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Salary VALUES(@employee_ID , @month , @monthly_salary , @allowances , @ot_rate , @normal_ot_hrs , @normal_ot_value , @double_ot_hrs , @double_ot_value , @triple_ot_hrs , @triple_ot_value , @ot_total , @date_range , @absent_days , @no_pay_value , @tax_value , @base_pay , @gross_pay)", cnn);

                    cmd.Parameters.AddWithValue("@employee_ID", cmbemployee_ID.Text);
                    cmd.Parameters.AddWithValue("@month", cmbMonth.Text);
                    cmd.Parameters.AddWithValue("@monthly_salary", Convert.ToDecimal(txtmonthlySalary.Text));
                    cmd.Parameters.AddWithValue("@allowances", Convert.ToDecimal(txtallowances.Text));
                    cmd.Parameters.AddWithValue("@ot_rate", Convert.ToDecimal(txtotRate.Text));
                    cmd.Parameters.AddWithValue("@normal_ot_hrs", Convert.ToDecimal(txtnormalOT.Text));
                    cmd.Parameters.AddWithValue("@normal_ot_value", Convert.ToDecimal(txtnormalOTvalue.Text));
                    cmd.Parameters.AddWithValue("@double_ot_hrs", Convert.ToDecimal(txtdoubleOT.Text));
                    cmd.Parameters.AddWithValue("@double_ot_value", Convert.ToDecimal(txtdoubleOTvalue.Text));
                    cmd.Parameters.AddWithValue("@triple_ot_hrs", Convert.ToDecimal(txttripleOT.Text));
                    cmd.Parameters.AddWithValue("@triple_ot_value", Convert.ToDecimal(txttripleOTvalue.Text));
                    cmd.Parameters.AddWithValue("@ot_total", Convert.ToDecimal(txtOTTotal.Text));
                    cmd.Parameters.AddWithValue("@date_range", Convert.ToDecimal(txtDateRange.Text));
                    cmd.Parameters.AddWithValue("@absent_days", Convert.ToDecimal(txtAbsentDays.Text));
                    cmd.Parameters.AddWithValue("@no_pay_value", Convert.ToDecimal(txtnoPayValue.Text));
                    cmd.Parameters.AddWithValue("@tax_value", Convert.ToDecimal(txtTaxValue.Text));
                    cmd.Parameters.AddWithValue("@base_pay", Convert.ToDecimal(txtBasePay.Text));
                    cmd.Parameters.AddWithValue("@gross_pay", Convert.ToDecimal(txtGrossPay.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Details Saved!", "Details Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear
                    cmbemployee_ID.ResetText();
                    cmbMonth.ResetText();
                    dtpBeginDate.ResetText();
                    dtpEndDate.ResetText();
                    txtmonthlySalary.Clear();
                    txtallowances.Clear();
                    txtotRate.Clear();
                    txtnormalOT.Clear();
                    txtnormalOTvalue.Clear();
                    txtdoubleOT.Clear();
                    txtdoubleOTvalue.Clear();
                    txttripleOT.Clear();
                    txttripleOTvalue.Clear();
                    txtOTTotal.Clear();
                    txtDateRange.Clear();
                    txtAbsentDays.Clear();
                    txtnoPayValue.Clear();
                    txtTaxValue.Clear();
                    txtBasePay.Clear();
                    txtGrossPay.Clear();

                    cnn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//save salary details

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbemployee_ID.ResetText();
            cmbMonth.ResetText();
            txtmonthlySalary.Clear();
            txtallowances.Clear();
            txtotRate.Clear();
            txtnormalOT.Clear();
            txtnormalOTvalue.Clear();
            txtdoubleOT.Clear();
            txtdoubleOTvalue.Clear();
            txttripleOT.Clear();
            txttripleOTvalue.Clear();
            txtOTTotal.Clear();
            txtDateRange.Clear();
            txtAbsentDays.Clear();
            txtnoPayValue.Clear();
            txtTaxValue.Clear();
            txtBasePay.Clear();
            txtGrossPay.Clear();
        }//clear all fields
    }
}
