namespace Grifindo.Forms
{
    partial class SearchEmployee
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
            btnClear = new Button();
            btnUpdate = new Button();
            rbfemale = new RadioButton();
            rbmale = new RadioButton();
            dtpbirthday = new DateTimePicker();
            txtaddress = new RichTextBox();
            txtlname = new TextBox();
            txtemail = new TextBox();
            txtcontact = new TextBox();
            txtnic = new TextBox();
            txtmonthlySalary = new TextBox();
            txtotRate = new TextBox();
            txtallowances = new TextBox();
            txtfname = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            cmbemployee_ID = new ComboBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(598, 436);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 38);
            btnClear.TabIndex = 49;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(409, 436);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 38);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // rbfemale
            // 
            rbfemale.AutoSize = true;
            rbfemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbfemale.Location = new Point(741, 129);
            rbfemale.Name = "rbfemale";
            rbfemale.Size = new Size(78, 25);
            rbfemale.TabIndex = 47;
            rbfemale.TabStop = true;
            rbfemale.Text = "Female";
            rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            rbmale.AutoSize = true;
            rbmale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbmale.Location = new Point(662, 129);
            rbmale.Name = "rbmale";
            rbmale.Size = new Size(62, 25);
            rbmale.TabIndex = 46;
            rbmale.TabStop = true;
            rbmale.Text = "Male";
            rbmale.UseVisualStyleBackColor = true;
            // 
            // dtpbirthday
            // 
            dtpbirthday.CalendarFont = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpbirthday.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpbirthday.Format = DateTimePickerFormat.Short;
            dtpbirthday.Location = new Point(255, 128);
            dtpbirthday.Name = "dtpbirthday";
            dtpbirthday.Size = new Size(225, 22);
            dtpbirthday.TabIndex = 45;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Calibri", 9.75F);
            txtaddress.Location = new Point(255, 164);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(225, 62);
            txtaddress.TabIndex = 44;
            txtaddress.Text = "";
            // 
            // txtlname
            // 
            txtlname.Font = new Font("Calibri", 9.75F);
            txtlname.Location = new Point(623, 93);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(225, 23);
            txtlname.TabIndex = 43;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Calibri", 9.75F);
            txtemail.Location = new Point(623, 240);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(225, 23);
            txtemail.TabIndex = 42;
            // 
            // txtcontact
            // 
            txtcontact.Font = new Font("Calibri", 9.75F);
            txtcontact.Location = new Point(255, 242);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(225, 23);
            txtcontact.TabIndex = 41;
            // 
            // txtnic
            // 
            txtnic.Font = new Font("Calibri", 9.75F);
            txtnic.Location = new Point(255, 271);
            txtnic.Name = "txtnic";
            txtnic.Size = new Size(225, 23);
            txtnic.TabIndex = 40;
            // 
            // txtmonthlySalary
            // 
            txtmonthlySalary.Font = new Font("Calibri", 9.75F);
            txtmonthlySalary.Location = new Point(255, 326);
            txtmonthlySalary.Name = "txtmonthlySalary";
            txtmonthlySalary.Size = new Size(225, 23);
            txtmonthlySalary.TabIndex = 39;
            // 
            // txtotRate
            // 
            txtotRate.Font = new Font("Calibri", 9.75F);
            txtotRate.Location = new Point(255, 359);
            txtotRate.Name = "txtotRate";
            txtotRate.Size = new Size(225, 23);
            txtotRate.TabIndex = 38;
            // 
            // txtallowances
            // 
            txtallowances.Font = new Font("Calibri", 9.75F);
            txtallowances.Location = new Point(623, 326);
            txtallowances.Name = "txtallowances";
            txtallowances.Size = new Size(225, 23);
            txtallowances.TabIndex = 37;
            // 
            // txtfname
            // 
            txtfname.Font = new Font("Calibri", 9.75F);
            txtfname.Location = new Point(255, 93);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(225, 23);
            txtfname.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(531, 93);
            label11.Name = "label11";
            label11.Size = new Size(86, 23);
            label11.TabIndex = 35;
            label11.Text = "Last Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(167, 126);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 34;
            label10.Text = "Birthday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(554, 129);
            label9.Name = "label9";
            label9.Size = new Size(63, 23);
            label9.TabIndex = 33;
            label9.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(169, 164);
            label8.Name = "label8";
            label8.Size = new Size(68, 23);
            label8.TabIndex = 32;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(567, 240);
            label7.Name = "label7";
            label7.Size = new Size(50, 23);
            label7.TabIndex = 31;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(147, 240);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 30;
            label6.Text = "Contact No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(191, 269);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 29;
            label5.Text = "N I C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(120, 326);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 28;
            label4.Text = "Monthly Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 359);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 27;
            label3.Text = "O T Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(527, 326);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 26;
            label2.Text = "Allowances";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 93);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 25;
            label1.Text = "First Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(374, 28);
            label12.Name = "label12";
            label12.Size = new Size(99, 23);
            label12.TabIndex = 50;
            label12.Text = "Employee ID";
            // 
            // cmbemployee_ID
            // 
            cmbemployee_ID.FormattingEnabled = true;
            cmbemployee_ID.Location = new Point(496, 28);
            cmbemployee_ID.Name = "cmbemployee_ID";
            cmbemployee_ID.Size = new Size(121, 23);
            cmbemployee_ID.TabIndex = 51;
            cmbemployee_ID.SelectedValueChanged += cmbemployee_ID_SelectedValueChanged;
            cmbemployee_ID.TextChanged += cmbemployee_ID_TextChanged;
            cmbemployee_ID.Leave += cmbemployee_ID_Leave;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(506, 436);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 38);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // SearchEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 500);
            Controls.Add(btnDelete);
            Controls.Add(cmbemployee_ID);
            Controls.Add(label12);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(rbfemale);
            Controls.Add(rbmale);
            Controls.Add(dtpbirthday);
            Controls.Add(txtaddress);
            Controls.Add(txtlname);
            Controls.Add(txtemail);
            Controls.Add(txtcontact);
            Controls.Add(txtnic);
            Controls.Add(txtmonthlySalary);
            Controls.Add(txtotRate);
            Controls.Add(txtallowances);
            Controls.Add(txtfname);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchEmployee";
            Text = "SearchEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnUpdate;
        private RadioButton rbfemale;
        private RadioButton rbmale;
        private DateTimePicker dtpbirthday;
        private RichTextBox txtaddress;
        private TextBox txtlname;
        private TextBox txtemail;
        private TextBox txtcontact;
        private TextBox txtnic;
        private TextBox txtmonthlySalary;
        private TextBox txtotRate;
        private TextBox txtallowances;
        private TextBox txtfname;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label12;
        private ComboBox cmbemployee_ID;
        private Button btnDelete;
    }
}