namespace Grifindo.Forms
{
    partial class DateRange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbMonth = new ComboBox();
            label12 = new Label();
            dtpEndDate = new DateTimePicker();
            label10 = new Label();
            dtpBeginDate = new DateTimePicker();
            label1 = new Label();
            txtDateRange = new TextBox();
            label2 = new Label();
            txtHolidays = new TextBox();
            label3 = new Label();
            txtTotalDays = new TextBox();
            label4 = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            btnupdate = new Button();
            SuspendLayout();
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { "January 2024", "February 2024", "March 2024", "April 2024", "May 2024", "June 2024", "July 2024", "August 2024", "September 2024", "October 2024", "November 2024", "December 2024" });
            cmbMonth.Location = new Point(574, 57);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(200, 23);
            cmbMonth.TabIndex = 55;
            cmbMonth.Leave += cmbMonth_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(363, 57);
            label12.Name = "label12";
            label12.Size = new Size(58, 23);
            label12.TabIndex = 54;
            label12.Text = "Month";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(574, 143);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(363, 143);
            label10.Name = "label10";
            label10.Size = new Size(162, 23);
            label10.TabIndex = 56;
            label10.Text = "Salary Cycle End Date";
            // 
            // dtpBeginDate
            // 
            dtpBeginDate.Format = DateTimePickerFormat.Short;
            dtpBeginDate.Location = new Point(574, 96);
            dtpBeginDate.Name = "dtpBeginDate";
            dtpBeginDate.Size = new Size(200, 23);
            dtpBeginDate.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 96);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 58;
            label1.Text = "Salary Cycle Begin Date";
            // 
            // txtDateRange
            // 
            txtDateRange.Location = new Point(574, 279);
            txtDateRange.Name = "txtDateRange";
            txtDateRange.Size = new Size(200, 23);
            txtDateRange.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(363, 279);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 62;
            label2.Text = "Date Range";
            // 
            // txtHolidays
            // 
            txtHolidays.Location = new Point(574, 235);
            txtHolidays.Name = "txtHolidays";
            txtHolidays.Size = new Size(200, 23);
            txtHolidays.TabIndex = 65;
            txtHolidays.Leave += txtHolidays_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(363, 235);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 64;
            label3.Text = "Holidays";
            // 
            // txtTotalDays
            // 
            txtTotalDays.Location = new Point(574, 187);
            txtTotalDays.Name = "txtTotalDays";
            txtTotalDays.Size = new Size(200, 23);
            txtTotalDays.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(363, 187);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 66;
            label4.Text = "Total Days";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(609, 372);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 38);
            btnClear.TabIndex = 69;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(425, 372);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 38);
            btnAdd.TabIndex = 68;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(517, 372);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(86, 38);
            btnupdate.TabIndex = 70;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // DateRange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 500);
            Controls.Add(btnupdate);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtTotalDays);
            Controls.Add(label4);
            Controls.Add(txtHolidays);
            Controls.Add(label3);
            Controls.Add(txtDateRange);
            Controls.Add(label2);
            Controls.Add(dtpBeginDate);
            Controls.Add(label1);
            Controls.Add(dtpEndDate);
            Controls.Add(label10);
            Controls.Add(cmbMonth);
            Controls.Add(label12);
            Name = "DateRange";
            Text = "DateRange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMonth;
        private Label label12;
        private DateTimePicker dtpEndDate;
        private Label label10;
        private DateTimePicker dtpBeginDate;
        private Label label1;
        private TextBox txtDateRange;
        private Label label2;
        private TextBox txtHolidays;
        private Label label3;
        private TextBox txtTotalDays;
        private Label label4;
        private Button btnClear;
        private Button btnAdd;
        private Button btnupdate;
    }
}