namespace Grifindo
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {

            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }//Changing panel Colors

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }//Changing disable botton Colors

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panellogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);


                }
            }
        }//Changing Activate button color

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }//Open Activate Panel



        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }//Exit BUtton

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RegisterEmployee(), sender);
        }//Register Employee Panel

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SearchEmployee(), sender);
        }//Search Employee Panel

        private void btnOvertime_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Overtime(), sender);
        }//Overtime Panel

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CalculateSalary(), sender);
        }//Calculate Salary Panel

        private void btnViewPaysheet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ViewPaysheet(), sender);
        }//Paysheet View Pael

        private void btnDateRange_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DateRange(), sender);
        }//Date Range Panel

        private void btnLeave_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Leave(), sender);
        }//Leave Panel

    }
}
