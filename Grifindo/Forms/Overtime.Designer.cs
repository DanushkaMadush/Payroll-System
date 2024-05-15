namespace Grifindo.Forms
{
    partial class Overtime
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
            dtpot = new DateTimePicker();
            label10 = new Label();
            txtnormalOT = new TextBox();
            txtdoubleOT = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txttripleOT = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // cmbemployee_ID
            // 
            cmbemployee_ID.FormattingEnabled = true;
            cmbemployee_ID.Location = new Point(502, 76);
            cmbemployee_ID.Name = "cmbemployee_ID";
            cmbemployee_ID.Size = new Size(121, 23);
            cmbemployee_ID.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(377, 76);
            label12.Name = "label12";
            label12.Size = new Size(99, 23);
            label12.TabIndex = 52;
            label12.Text = "Employee ID";
            // 
            // dtpot
            // 
            dtpot.Format = DateTimePickerFormat.Short;
            dtpot.Location = new Point(502, 141);
            dtpot.Name = "dtpot";
            dtpot.Size = new Size(200, 23);
            dtpot.TabIndex = 55;
            dtpot.Leave += dtpot_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(432, 142);
            label10.Name = "label10";
            label10.Size = new Size(44, 23);
            label10.TabIndex = 54;
            label10.Text = "Date";
            // 
            // txtnormalOT
            // 
            txtnormalOT.Location = new Point(502, 176);
            txtnormalOT.Name = "txtnormalOT";
            txtnormalOT.Size = new Size(136, 23);
            txtnormalOT.TabIndex = 59;
            txtnormalOT.Text = "0";
            // 
            // txtdoubleOT
            // 
            txtdoubleOT.Location = new Point(502, 207);
            txtdoubleOT.Name = "txtdoubleOT";
            txtdoubleOT.Size = new Size(136, 23);
            txtdoubleOT.TabIndex = 58;
            txtdoubleOT.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(342, 176);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 57;
            label4.Text = "Normal OT Hours";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(345, 207);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 56;
            label3.Text = "Double OT Hours";
            // 
            // txttripleOT
            // 
            txttripleOT.Location = new Point(502, 239);
            txttripleOT.Name = "txttripleOT";
            txttripleOT.Size = new Size(136, 23);
            txttripleOT.TabIndex = 61;
            txttripleOT.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 239);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 60;
            label1.Text = "Triple OT Hours";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(487, 358);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 38);
            btnUpdate.TabIndex = 64;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(579, 358);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 38);
            btnClear.TabIndex = 63;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(395, 358);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 38);
            btnAdd.TabIndex = 62;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Overtime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 500);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txttripleOT);
            Controls.Add(label1);
            Controls.Add(txtnormalOT);
            Controls.Add(txtdoubleOT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpot);
            Controls.Add(label10);
            Controls.Add(cmbemployee_ID);
            Controls.Add(label12);
            Name = "Overtime";
            Text = "Overtime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbemployee_ID;
        private Label label12;
        private DateTimePicker dtpot;
        private Label label10;
        private TextBox txtnormalOT;
        private TextBox txtdoubleOT;
        private Label label4;
        private Label label3;
        private TextBox txttripleOT;
        private Label label1;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnAdd;
    }
}