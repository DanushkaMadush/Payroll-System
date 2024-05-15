namespace Grifindo.Forms
{
    partial class CalculateSalary
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
            cmbemployee_ID = new ComboBox();
            label12 = new Label();
            txtmonthlySalary = new TextBox();
            txtotRate = new TextBox();
            txtallowances = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txttripleOT = new TextBox();
            label1 = new Label();
            txtnormalOT = new TextBox();
            txtdoubleOT = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbMonth = new ComboBox();
            label7 = new Label();
            txtDateRange = new TextBox();
            label8 = new Label();
            txtnoPayValue = new TextBox();
            label9 = new Label();
            txtAbsentDays = new TextBox();
            label10 = new Label();
            txttripleOTvalue = new TextBox();
            txtnormalOTvalue = new TextBox();
            txtdoubleOTvalue = new TextBox();
            txtOTTotal = new TextBox();
            label11 = new Label();
            txtTaxRate = new TextBox();
            label13 = new Label();
            txtGrossPay = new TextBox();
            label14 = new Label();
            txtDeductions = new TextBox();
            label15 = new Label();
            txtBasePay = new TextBox();
            label16 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dtpBeginDate = new DateTimePicker();
            label18 = new Label();
            label19 = new Label();
            dtpEndDate = new DateTimePicker();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            txtTaxValue = new TextBox();
            label17 = new Label();
            button1 = new Button();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // cmbemployee_ID
            // 
            cmbemployee_ID.FormattingEnabled = true;
            cmbemployee_ID.Location = new Point(177, 25);
            cmbemployee_ID.Name = "cmbemployee_ID";
            cmbemployee_ID.Size = new Size(121, 23);
            cmbemployee_ID.TabIndex = 55;
            cmbemployee_ID.Leave += cmbemployee_ID_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightGray;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(55, 25);
            label12.Name = "label12";
            label12.Size = new Size(97, 21);
            label12.TabIndex = 54;
            label12.Text = "Employee ID";
            // 
            // txtmonthlySalary
            // 
            txtmonthlySalary.Enabled = false;
            txtmonthlySalary.Location = new Point(177, 59);
            txtmonthlySalary.Name = "txtmonthlySalary";
            txtmonthlySalary.Size = new Size(121, 23);
            txtmonthlySalary.TabIndex = 61;
            // 
            // txtotRate
            // 
            txtotRate.Enabled = false;
            txtotRate.Location = new Point(177, 146);
            txtotRate.Name = "txtotRate";
            txtotRate.Size = new Size(225, 23);
            txtotRate.TabIndex = 60;
            // 
            // txtallowances
            // 
            txtallowances.Enabled = false;
            txtallowances.Location = new Point(177, 91);
            txtallowances.Name = "txtallowances";
            txtallowances.Size = new Size(121, 23);
            txtallowances.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 59);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 58;
            label4.Text = "Monthly Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 146);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 57;
            label3.Text = "O T Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 91);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 56;
            label2.Text = "Allowances";
            // 
            // txttripleOT
            // 
            txttripleOT.Enabled = false;
            txttripleOT.Location = new Point(177, 239);
            txttripleOT.Name = "txttripleOT";
            txttripleOT.Size = new Size(51, 23);
            txttripleOT.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 239);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 66;
            label1.Text = "Triple OT Hours";
            // 
            // txtnormalOT
            // 
            txtnormalOT.Enabled = false;
            txtnormalOT.Location = new Point(177, 178);
            txtnormalOT.Name = "txtnormalOT";
            txtnormalOT.Size = new Size(51, 23);
            txtnormalOT.TabIndex = 65;
            // 
            // txtdoubleOT
            // 
            txtdoubleOT.Enabled = false;
            txtdoubleOT.Location = new Point(177, 209);
            txtdoubleOT.Name = "txtdoubleOT";
            txtdoubleOT.Size = new Size(51, 23);
            txtdoubleOT.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 178);
            label5.Name = "label5";
            label5.Size = new Size(132, 21);
            label5.TabIndex = 63;
            label5.Text = "Normal OT Hours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 209);
            label6.Name = "label6";
            label6.Size = new Size(129, 21);
            label6.TabIndex = 62;
            label6.Text = "Double OT Hours";
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(518, 31);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(200, 23);
            cmbMonth.TabIndex = 69;
            cmbMonth.Leave += cmbMonth_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGray;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(441, 31);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 68;
            label7.Text = "Month";
            // 
            // txtDateRange
            // 
            txtDateRange.Enabled = false;
            txtDateRange.Location = new Point(850, 31);
            txtDateRange.Name = "txtDateRange";
            txtDateRange.Size = new Size(84, 23);
            txtDateRange.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightGray;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(742, 31);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 70;
            label8.Text = "Date Range";
            // 
            // txtnoPayValue
            // 
            txtnoPayValue.Enabled = false;
            txtnoPayValue.Location = new Point(850, 148);
            txtnoPayValue.Name = "txtnoPayValue";
            txtnoPayValue.Size = new Size(128, 23);
            txtnoPayValue.TabIndex = 75;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightGray;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(731, 149);
            label9.Name = "label9";
            label9.Size = new Size(101, 21);
            label9.TabIndex = 74;
            label9.Text = "No Pay Value";
            // 
            // txtAbsentDays
            // 
            txtAbsentDays.Location = new Point(555, 151);
            txtAbsentDays.Name = "txtAbsentDays";
            txtAbsentDays.Size = new Size(103, 23);
            txtAbsentDays.TabIndex = 73;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LightGray;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(441, 150);
            label10.Name = "label10";
            label10.Size = new Size(96, 21);
            label10.TabIndex = 72;
            label10.Text = "Absent Days";
            // 
            // txttripleOTvalue
            // 
            txttripleOTvalue.Enabled = false;
            txttripleOTvalue.Location = new Point(234, 239);
            txttripleOTvalue.Name = "txttripleOTvalue";
            txttripleOTvalue.Size = new Size(128, 23);
            txttripleOTvalue.TabIndex = 78;
            // 
            // txtnormalOTvalue
            // 
            txtnormalOTvalue.Enabled = false;
            txtnormalOTvalue.Location = new Point(234, 178);
            txtnormalOTvalue.Name = "txtnormalOTvalue";
            txtnormalOTvalue.Size = new Size(128, 23);
            txtnormalOTvalue.TabIndex = 77;
            // 
            // txtdoubleOTvalue
            // 
            txtdoubleOTvalue.Enabled = false;
            txtdoubleOTvalue.Location = new Point(234, 209);
            txtdoubleOTvalue.Name = "txtdoubleOTvalue";
            txtdoubleOTvalue.Size = new Size(128, 23);
            txtdoubleOTvalue.TabIndex = 76;
            // 
            // txtOTTotal
            // 
            txtOTTotal.Enabled = false;
            txtOTTotal.Location = new Point(177, 270);
            txtOTTotal.Name = "txtOTTotal";
            txtOTTotal.Size = new Size(185, 23);
            txtOTTotal.TabIndex = 80;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LightGray;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(85, 270);
            label11.Name = "label11";
            label11.Size = new Size(65, 21);
            label11.TabIndex = 79;
            label11.Text = "OT Total";
            // 
            // txtTaxRate
            // 
            txtTaxRate.Enabled = false;
            txtTaxRate.Location = new Point(618, 214);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(74, 23);
            txtTaxRate.TabIndex = 82;
            txtTaxRate.Text = "1.1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LightGray;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(441, 214);
            label13.Name = "label13";
            label13.Size = new Size(157, 21);
            label13.TabIndex = 81;
            label13.Text = "Government Tax Rate";
            // 
            // txtGrossPay
            // 
            txtGrossPay.Enabled = false;
            txtGrossPay.Location = new Point(618, 327);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.Size = new Size(200, 23);
            txtGrossPay.TabIndex = 84;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(520, 329);
            label14.Name = "label14";
            label14.Size = new Size(78, 21);
            label14.TabIndex = 83;
            label14.Text = "Gross Pay";
            // 
            // txtDeductions
            // 
            txtDeductions.Enabled = false;
            txtDeductions.Location = new Point(618, 295);
            txtDeductions.Name = "txtDeductions";
            txtDeductions.Size = new Size(200, 23);
            txtDeductions.TabIndex = 86;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(510, 295);
            label15.Name = "label15";
            label15.Size = new Size(88, 21);
            label15.TabIndex = 85;
            label15.Text = "Deductions";
            // 
            // txtBasePay
            // 
            txtBasePay.Enabled = false;
            txtBasePay.Location = new Point(618, 263);
            txtBasePay.Name = "txtBasePay";
            txtBasePay.Size = new Size(200, 23);
            txtBasePay.TabIndex = 88;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(486, 261);
            label16.Name = "label16";
            label16.Size = new Size(112, 21);
            label16.TabIndex = 87;
            label16.Text = "Base Pay Value";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(656, 436);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 38);
            btnCalculate.TabIndex = 91;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(932, 436);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 38);
            btnClear.TabIndex = 90;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(748, 436);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 38);
            btnAdd.TabIndex = 89;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Location = new Point(2, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 179);
            groupBox1.TabIndex = 92;
            groupBox1.TabStop = false;
            groupBox1.Text = "Overtime";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Location = new Point(2, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 116);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Payments";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(dtpBeginDate);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(dtpEndDate);
            groupBox3.Location = new Point(427, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(564, 116);
            groupBox3.TabIndex = 93;
            groupBox3.TabStop = false;
            groupBox3.Text = "Date Range";
            // 
            // dtpBeginDate
            // 
            dtpBeginDate.CalendarFont = new Font("Segoe UI", 8.25F);
            dtpBeginDate.Enabled = false;
            dtpBeginDate.Location = new Point(191, 55);
            dtpBeginDate.Name = "dtpBeginDate";
            dtpBeginDate.Size = new Size(316, 23);
            dtpBeginDate.TabIndex = 99;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(14, 55);
            label18.Name = "label18";
            label18.Size = new Size(173, 21);
            label18.TabIndex = 98;
            label18.Text = "Salary Cycle Begin Date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(14, 85);
            label19.Name = "label19";
            label19.Size = new Size(160, 21);
            label19.TabIndex = 96;
            label19.Text = "Salary Cycle End Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarFont = new Font("Segoe UI", 8.25F);
            dtpEndDate.Enabled = false;
            dtpEndDate.Location = new Point(191, 85);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(316, 23);
            dtpEndDate.TabIndex = 97;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightGray;
            groupBox4.Location = new Point(427, 127);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(564, 59);
            groupBox4.TabIndex = 94;
            groupBox4.TabStop = false;
            groupBox4.Text = "Leave Details";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.LightGray;
            groupBox5.Controls.Add(txtTaxValue);
            groupBox5.Controls.Add(label17);
            groupBox5.Location = new Point(427, 192);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(564, 56);
            groupBox5.TabIndex = 95;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tax";
            // 
            // txtTaxValue
            // 
            txtTaxValue.Enabled = false;
            txtTaxValue.Location = new Point(370, 22);
            txtTaxValue.Name = "txtTaxValue";
            txtTaxValue.Size = new Size(181, 23);
            txtTaxValue.TabIndex = 97;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(291, 22);
            label17.Name = "label17";
            label17.Size = new Size(73, 21);
            label17.TabIndex = 96;
            label17.Text = "Tax Value";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(486, 436);
            button1.Name = "button1";
            button1.Size = new Size(164, 38);
            button1.TabIndex = 96;
            button1.Text = "Payment Gateway";
            button1.UseVisualStyleBackColor = false;
            // 
            // CalculateSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 500);
            Controls.Add(button1);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtBasePay);
            Controls.Add(label16);
            Controls.Add(txtDeductions);
            Controls.Add(label15);
            Controls.Add(txtGrossPay);
            Controls.Add(label14);
            Controls.Add(txtTaxRate);
            Controls.Add(label13);
            Controls.Add(txtOTTotal);
            Controls.Add(label11);
            Controls.Add(txttripleOTvalue);
            Controls.Add(txtnormalOTvalue);
            Controls.Add(txtdoubleOTvalue);
            Controls.Add(txtnoPayValue);
            Controls.Add(label9);
            Controls.Add(txtAbsentDays);
            Controls.Add(label10);
            Controls.Add(txtDateRange);
            Controls.Add(label8);
            Controls.Add(cmbMonth);
            Controls.Add(label7);
            Controls.Add(txttripleOT);
            Controls.Add(label1);
            Controls.Add(txtnormalOT);
            Controls.Add(txtdoubleOT);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtmonthlySalary);
            Controls.Add(txtotRate);
            Controls.Add(txtallowances);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbemployee_ID);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Name = "CalculateSalary";
            Text = "CalculateSalary";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbemployee_ID;
        private Label label12;
        private TextBox txtmonthlySalary;
        private TextBox txtotRate;
        private TextBox txtallowances;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txttripleOT;
        private Label label1;
        private TextBox txtnormalOT;
        private TextBox txtdoubleOT;
        private Label label5;
        private Label label6;
        private ComboBox cmbMonth;
        private Label label7;
        private TextBox txtDateRange;
        private Label label8;
        private TextBox txtnoPayValue;
        private Label label9;
        private TextBox txtAbsentDays;
        private Label label10;
        private TextBox txttripleOTvalue;
        private TextBox txtnormalOTvalue;
        private TextBox txtdoubleOTvalue;
        private TextBox txtOTTotal;
        private Label label11;
        private TextBox txtTaxRate;
        private Label label13;
        private TextBox txtGrossPay;
        private Label label14;
        private TextBox txtDeductions;
        private Label label15;
        private TextBox txtBasePay;
        private Label label16;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnAdd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox txtTaxValue;
        private Label label17;
        private DateTimePicker dtpBeginDate;
        private Label label18;
        private Label label19;
        private DateTimePicker dtpEndDate;
        private Button button1;
    }
}