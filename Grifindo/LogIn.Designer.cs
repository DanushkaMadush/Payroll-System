namespace Grifindo
{
    partial class LogIn
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            btnexit = new Button();
            btnclear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(530, 98);
            label1.Name = "label1";
            label1.Size = new Size(257, 43);
            label1.TabIndex = 0;
            label1.Text = "Grifindo Toys";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 20.25F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(307, 262);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 20.25F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(307, 196);
            label3.Name = "label3";
            label3.Size = new Size(150, 32);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(64, 64, 64);
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.ForeColor = SystemColors.ActiveCaption;
            txtusername.Location = new Point(498, 196);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(289, 39);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(64, 64, 64);
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = SystemColors.ActiveCaption;
            txtpassword.Location = new Point(498, 262);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(289, 39);
            txtpassword.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Gray;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.FromArgb(128, 64, 64);
            btnlogin.Location = new Point(471, 360);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(117, 42);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Log In";
            btnlogin.UseMnemonic = false;
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Gray;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.FromArgb(128, 64, 64);
            btnexit.Location = new Point(1055, 532);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(117, 42);
            btnexit.TabIndex = 6;
            btnexit.Text = "Exit";
            btnexit.UseMnemonic = false;
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Gray;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclear.ForeColor = Color.FromArgb(128, 64, 64);
            btnclear.Location = new Point(932, 532);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(117, 42);
            btnclear.TabIndex = 7;
            btnclear.Text = "Clear";
            btnclear.UseMnemonic = false;
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1269, 608);
            Controls.Add(btnclear);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private Button btnexit;
        private Button btnclear;
    }
}