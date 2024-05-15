namespace Grifindo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnExit = new Button();
            btnLeave = new Button();
            btnDateRange = new Button();
            label5 = new Label();
            btnViewPaysheet = new Button();
            btnCalculate = new Button();
            btnOvertime = new Button();
            label4 = new Label();
            btnSearch = new Button();
            btnRegister = new Button();
            label3 = new Label();
            panelDesktopPane = new Panel();
            label6 = new Label();
            label2 = new Label();
            panellogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            lblTitle = new Label();
            panelMenu.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            panellogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(39, 39, 58);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnLeave);
            panelMenu.Controls.Add(btnDateRange);
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(btnViewPaysheet);
            panelMenu.Controls.Add(btnCalculate);
            panelMenu.Controls.Add(btnOvertime);
            panelMenu.Controls.Add(label4);
            panelMenu.Controls.Add(btnSearch);
            panelMenu.Controls.Add(btnRegister);
            panelMenu.Controls.Add(label3);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 69);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(216, 539);
            panelMenu.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 14.25F);
            btnExit.ForeColor = Color.MistyRose;
            btnExit.Location = new Point(0, 493);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(216, 43);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLeave
            // 
            btnLeave.Dock = DockStyle.Top;
            btnLeave.FlatStyle = FlatStyle.Popup;
            btnLeave.Font = new Font("Segoe UI", 14.25F);
            btnLeave.ForeColor = Color.MistyRose;
            btnLeave.Location = new Point(0, 422);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(216, 43);
            btnLeave.TabIndex = 12;
            btnLeave.Text = "Leave";
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnDateRange
            // 
            btnDateRange.Dock = DockStyle.Top;
            btnDateRange.FlatStyle = FlatStyle.Popup;
            btnDateRange.Font = new Font("Segoe UI", 14.25F);
            btnDateRange.ForeColor = Color.MistyRose;
            btnDateRange.Location = new Point(0, 379);
            btnDateRange.Name = "btnDateRange";
            btnDateRange.Size = new Size(216, 43);
            btnDateRange.TabIndex = 11;
            btnDateRange.Text = "Date Range";
            btnDateRange.UseVisualStyleBackColor = true;
            btnDateRange.Click += btnDateRange_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(39, 39, 58);
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(0, 321);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 20, 0, 10);
            label5.Size = new Size(94, 58);
            label5.TabIndex = 10;
            label5.Text = "Setting";
            // 
            // btnViewPaysheet
            // 
            btnViewPaysheet.Dock = DockStyle.Top;
            btnViewPaysheet.FlatStyle = FlatStyle.Popup;
            btnViewPaysheet.Font = new Font("Segoe UI", 14.25F);
            btnViewPaysheet.ForeColor = Color.MistyRose;
            btnViewPaysheet.Location = new Point(0, 278);
            btnViewPaysheet.Name = "btnViewPaysheet";
            btnViewPaysheet.Size = new Size(216, 43);
            btnViewPaysheet.TabIndex = 9;
            btnViewPaysheet.Text = "View Paysheet";
            btnViewPaysheet.UseVisualStyleBackColor = true;
            btnViewPaysheet.Click += btnViewPaysheet_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Dock = DockStyle.Top;
            btnCalculate.FlatStyle = FlatStyle.Popup;
            btnCalculate.Font = new Font("Segoe UI", 14.25F);
            btnCalculate.ForeColor = Color.MistyRose;
            btnCalculate.Location = new Point(0, 235);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(216, 43);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Salary";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnOvertime
            // 
            btnOvertime.Dock = DockStyle.Top;
            btnOvertime.FlatStyle = FlatStyle.Popup;
            btnOvertime.Font = new Font("Segoe UI", 14.25F);
            btnOvertime.ForeColor = Color.MistyRose;
            btnOvertime.Location = new Point(0, 192);
            btnOvertime.Name = "btnOvertime";
            btnOvertime.Size = new Size(216, 43);
            btnOvertime.TabIndex = 7;
            btnOvertime.Text = "Overtime";
            btnOvertime.UseVisualStyleBackColor = true;
            btnOvertime.Click += btnOvertime_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(39, 39, 58);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(0, 134);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 20, 0, 10);
            label4.Size = new Size(87, 58);
            label4.TabIndex = 6;
            label4.Text = "Salary";
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 14.25F);
            btnSearch.ForeColor = Color.MistyRose;
            btnSearch.Location = new Point(0, 91);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(216, 43);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search Employee";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRegister
            // 
            btnRegister.Dock = DockStyle.Top;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Segoe UI", 14.25F);
            btnRegister.ForeColor = Color.MistyRose;
            btnRegister.Location = new Point(0, 48);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(216, 43);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register Employee";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(39, 39, 58);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 10, 0, 10);
            label3.Size = new Size(126, 48);
            label3.TabIndex = 3;
            label3.Text = "Employee";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = Color.FromArgb(64, 64, 64);
            panelDesktopPane.Controls.Add(label6);
            panelDesktopPane.Controls.Add(label2);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelDesktopPane.Location = new Point(216, 69);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1053, 539);
            panelDesktopPane.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(64, 64, 64);
            label6.Font = new Font("Monotype Corsiva", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(351, 235);
            label6.Name = "label6";
            label6.Size = new Size(335, 45);
            label6.TabIndex = 1;
            label6.Text = "Grifindo Payroll System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Monotype Corsiva", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(401, 113);
            label2.Name = "label2";
            label2.Size = new Size(255, 79);
            label2.TabIndex = 0;
            label2.Text = "Welcome!";
            // 
            // panellogo
            // 
            panellogo.BackColor = Color.FromArgb(39, 39, 58);
            panellogo.Controls.Add(label1);
            panellogo.Controls.Add(panelTitleBar);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(1269, 69);
            panellogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(51, 22);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 2;
            label1.Text = "Grifindo";
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Location = new Point(213, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1055, 69);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(449, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 608);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelMenu);
            Controls.Add(panellogo);
            Name = "Form1";
            Text = "System";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            panelDesktopPane.PerformLayout();
            panellogo.ResumeLayout(false);
            panellogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Panel panelDesktopPane;
        private Button btnViewPaysheet;
        private Button btnCalculate;
        private Button btnOvertime;
        private Label label4;
        private Button btnSearch;
        private Button btnRegister;
        private Label label3;
        private Button btnLeave;
        private Button btnDateRange;
        private Label label5;
        private Button btnExit;
        private Panel panellogo;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Label label6;
        private Label label2;
    }
}
