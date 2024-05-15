namespace Grifindo.Forms
{
    partial class Leave
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
            txtleavesperyear = new TextBox();
            label5 = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            btnupdateleaveayear = new Button();
            label1 = new Label();
            txtutilized = new TextBox();
            label2 = new Label();
            txtbalance = new TextBox();
            btnUpdate = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            cmbMonth = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbemployee_ID
            // 
            cmbemployee_ID.FormattingEnabled = true;
            cmbemployee_ID.Location = new Point(482, 34);
            cmbemployee_ID.Name = "cmbemployee_ID";
            cmbemployee_ID.Size = new Size(121, 23);
            cmbemployee_ID.TabIndex = 53;
            cmbemployee_ID.Leave += cmbemployee_ID_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(360, 34);
            label12.Name = "label12";
            label12.Size = new Size(99, 23);
            label12.TabIndex = 52;
            label12.Text = "Employee ID";
            // 
            // txtleavesperyear
            // 
            txtleavesperyear.Location = new Point(159, 40);
            txtleavesperyear.Name = "txtleavesperyear";
            txtleavesperyear.Size = new Size(139, 23);
            txtleavesperyear.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 40);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 54;
            label5.Text = "Leaves Per Year";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(913, 437);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 38);
            btnClear.TabIndex = 65;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(25, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 38);
            btnAdd.TabIndex = 64;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnupdateleaveayear);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtleavesperyear);
            groupBox1.Location = new Point(45, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 151);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Leaves Per Year";
            // 
            // btnupdateleaveayear
            // 
            btnupdateleaveayear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdateleaveayear.Location = new Point(120, 90);
            btnupdateleaveayear.Name = "btnupdateleaveayear";
            btnupdateleaveayear.Size = new Size(86, 38);
            btnupdateleaveayear.TabIndex = 72;
            btnupdateleaveayear.Text = "Update";
            btnupdateleaveayear.UseVisualStyleBackColor = true;
            btnupdateleaveayear.Click += btnupdateleaveayear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 106);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 66;
            label1.Text = "Utilized Leaves";
            // 
            // txtutilized
            // 
            txtutilized.Location = new Point(183, 106);
            txtutilized.Name = "txtutilized";
            txtutilized.Size = new Size(139, 23);
            txtutilized.TabIndex = 67;
            txtutilized.Text = "0";
            txtutilized.Leave += textBox1_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 146);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 68;
            label2.Text = "Balance Leaves";
            // 
            // txtbalance
            // 
            txtbalance.Location = new Point(183, 146);
            txtbalance.Name = "txtbalance";
            txtbalance.Size = new Size(139, 23);
            txtbalance.TabIndex = 69;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(158, 218);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 38);
            btnUpdate.TabIndex = 70;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbMonth);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(txtutilized);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtbalance);
            groupBox2.Location = new Point(422, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 294);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Leave Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 61);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 74;
            label3.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(133, 61);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(189, 23);
            cmbMonth.TabIndex = 73;
            cmbMonth.Leave += cmbMonth_Leave;
            // 
            // Leave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 500);
            Controls.Add(cmbemployee_ID);
            Controls.Add(btnClear);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Leave";
            Text = "Leave";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbemployee_ID;
        private Label label12;
        private TextBox txtleavesperyear;
        private Label label5;
        private Button btnClear;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtutilized;
        private Label label2;
        private TextBox txtbalance;
        private Button btnUpdate;
        private GroupBox groupBox2;
        private Button btnupdateleaveayear;
        private Label label3;
        private ComboBox cmbMonth;
    }
}