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
using System.Data.SqlClient;

namespace Grifindo.Forms
{
    public partial class DateRange : Form

    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;";
        SqlConnection cnn = new SqlConnection(connectionstr);

        public DateRange()
        {
            InitializeComponent();
        }

        private void txtHolidays_Leave(object sender, EventArgs e)
        {
            decimal total_days = decimal.Parse(txtTotalDays.Text);
            decimal holidays = decimal.Parse(txtHolidays.Text);

            decimal date_range = total_days - holidays;

            txtDateRange.Text = date_range.ToString();
        }//calculate working days

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMonth.ResetText();
            dtpBeginDate.ResetText();
            dtpEndDate.ResetText();
            txtTotalDays.Clear();
            txtHolidays.Clear();
            txtDateRange.Clear();
        }//clear all fields

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Month VALUES (@month , @startdate , @enddate , @total , @holidays , @daterange);", cnn);
                cmd.Parameters.AddWithValue("@month", cmbMonth.Text);
                cmd.Parameters.AddWithValue("@startdate", dtpBeginDate.Value);
                cmd.Parameters.AddWithValue("@enddate", dtpEndDate.Value);
                cmd.Parameters.AddWithValue("@total", txtTotalDays.Text);
                cmd.Parameters.AddWithValue("@holidays", txtHolidays.Text);
                cmd.Parameters.AddWithValue("@daterange", txtDateRange.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbMonth.ResetText();
                dtpBeginDate.ResetText();
                dtpEndDate.ResetText();
                txtDateRange.Clear();
                txtHolidays.Clear();
                txtTotalDays.Clear();

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//add month records

        private void load_details()
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Month WHERE month=@month", cnn);
                cmd.Parameters.AddWithValue("@month", cmbMonth.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dtpBeginDate.Text = dr[1].ToString();
                    dtpEndDate.Text = dr[2].ToString();
                    txtTotalDays.Text = dr[3].ToString();
                    txtHolidays.Text = dr[4].ToString();
                    txtDateRange.Text = dr[5].ToString();

                    btnupdate.Enabled = true;
                    btnAdd.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Please add new details");
                    btnupdate.Enabled= false;
                    btnAdd.Enabled= true;
                    txtTotalDays.Clear();
                    txtHolidays.Clear();
                    txtDateRange.Clear();
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//Load details to form

        private void cmbMonth_Leave(object sender, EventArgs e)
        {
            load_details();
        }//load details when leave combo boxx

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Month SET begin_date=@begindate,end_date=@enddate,total_days=@totaldays,holidays=@holidays,date_range=@daterange WHERE month=@month", cnn);

                    cmd.Parameters.AddWithValue("@month", cmbMonth.Text);
                    cmd.Parameters.AddWithValue("@begindate", dtpBeginDate.Text);
                    cmd.Parameters.AddWithValue("@enddate", dtpEndDate.Text);
                    cmd.Parameters.AddWithValue("@totaldays", txtTotalDays.Text);
                    cmd.Parameters.AddWithValue("@holidays", txtHolidays.Text);
                    cmd.Parameters.AddWithValue("@daterange", txtDateRange.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Details Update Successfully!", "Details Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear
                    cmbMonth.ResetText();
                    dtpBeginDate.ResetText();
                    dtpEndDate.ResetText(); 
                    txtTotalDays.ResetText();
                    txtHolidays.ResetText();
                    txtDateRange.ResetText();


                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }//update date range
    }
}
