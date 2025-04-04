namespace Cahatol_Joshua_LabExam
{
    partial class StudentPage_Individual
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
            // Initialize all TextBoxes
            StudentIdTxt = new System.Windows.Forms.TextBox();
            FirstNameTxt = new System.Windows.Forms.TextBox();
            LastNameTxt = new System.Windows.Forms.TextBox();
            MiddleNameTxt = new System.Windows.Forms.TextBox();
            HouseNoTxt = new System.Windows.Forms.TextBox();
            BrgyNameTxt = new System.Windows.Forms.TextBox();
            MunicipalityTxt = new System.Windows.Forms.TextBox();
            ProvinceTxt = new System.Windows.Forms.TextBox();
            RegionTxt = new System.Windows.Forms.TextBox();
            CountryTxt = new System.Windows.Forms.TextBox();
            BirthdateTxt = new System.Windows.Forms.TextBox();
            AgeTxt = new System.Windows.Forms.TextBox();
            StudContactTxt = new System.Windows.Forms.TextBox();
            EmailAddressTxt = new System.Windows.Forms.TextBox();
            GuardianFirstNameTxt = new System.Windows.Forms.TextBox();
            GuardianLastNameTxt = new System.Windows.Forms.TextBox();
            HobbiesTxt = new System.Windows.Forms.TextBox();
            NicknameTxt = new System.Windows.Forms.TextBox();
            CourseIdTxt = new System.Windows.Forms.TextBox();
            YearIdTxt = new System.Windows.Forms.TextBox();

            // Initialize all Labels
            StudentIdLbl = new System.Windows.Forms.Label();
            FirstNameLbl = new System.Windows.Forms.Label();
            LastNameLbl = new System.Windows.Forms.Label();
            MiddleNameLbl = new System.Windows.Forms.Label();
            HouseNoLbl = new System.Windows.Forms.Label();
            BrgyNameLbl = new System.Windows.Forms.Label();
            MunicipalityLbl = new System.Windows.Forms.Label();
            ProvinceLbl = new System.Windows.Forms.Label();
            RegionLbl = new System.Windows.Forms.Label();
            CountryLbl = new System.Windows.Forms.Label();
            BirthdateLbl = new System.Windows.Forms.Label();
            AgeLbl = new System.Windows.Forms.Label();
            StudContactLbl = new System.Windows.Forms.Label();
            EmailAddressLbl = new System.Windows.Forms.Label();
            GuardianFirstNameLbl = new System.Windows.Forms.Label();
            GuardianLastNameLbl = new System.Windows.Forms.Label();
            HobbiesLbl = new System.Windows.Forms.Label();
            NicknameLbl = new System.Windows.Forms.Label();
            CourseIdLbl = new System.Windows.Forms.Label();
            YearIdLbl = new System.Windows.Forms.Label();

            SuspendLayout();

            // Form properties
            this.Text = "Student Individual Form";
            this.Size = new System.Drawing.Size(800, 800);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AutoScroll = true;

            // Layout configuration
            int startX = 50;
            int startY = 30;
            int spacing = 35;
            int labelWidth = 150;
            int textBoxWidth = 250;
            int currentY = startY;

            // Set up all controls with proper positioning
            // Personal Information Section
            AddSectionLabel("Personal Information", startX, ref currentY);

            SetupLabelAndTextBox(StudentIdLbl, StudentIdTxt, "Student ID:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(FirstNameLbl, FirstNameTxt, "First Name:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(LastNameLbl, LastNameTxt, "Last Name:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(MiddleNameLbl, MiddleNameTxt, "Middle Name:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(NicknameLbl, NicknameTxt, "Nickname:", startX, ref currentY, labelWidth, textBoxWidth);

            currentY += spacing; // Add extra space before next section

            // Address Information Section
            AddSectionLabel("Address Information", startX, ref currentY);

            SetupLabelAndTextBox(HouseNoLbl, HouseNoTxt, "House No:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(BrgyNameLbl, BrgyNameTxt, "Barangay:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(MunicipalityLbl, MunicipalityTxt, "Municipality:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(ProvinceLbl, ProvinceTxt, "Province:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(RegionLbl, RegionTxt, "Region:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(CountryLbl, CountryTxt, "Country:", startX, ref currentY, labelWidth, textBoxWidth);

            currentY += spacing;

            // Contact Information Section
            AddSectionLabel("Contact Information", startX, ref currentY);

            SetupLabelAndTextBox(StudContactLbl, StudContactTxt, "Contact Number:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(EmailAddressLbl, EmailAddressTxt, "Email Address:", startX, ref currentY, labelWidth, textBoxWidth);

            currentY += spacing;

            // Personal Details Section
            AddSectionLabel("Additional Information", startX, ref currentY);

            SetupLabelAndTextBox(BirthdateLbl, BirthdateTxt, "Birthdate:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(AgeLbl, AgeTxt, "Age:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(HobbiesLbl, HobbiesTxt, "Hobbies:", startX, ref currentY, labelWidth, textBoxWidth);

            currentY += spacing;

            // Guardian Information Section
            AddSectionLabel("Guardian Information", startX, ref currentY);

            SetupLabelAndTextBox(GuardianFirstNameLbl, GuardianFirstNameTxt, "Guardian First Name:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(GuardianLastNameLbl, GuardianLastNameTxt, "Guardian Last Name:", startX, ref currentY, labelWidth, textBoxWidth);

            currentY += spacing;

            // Academic Information Section
            AddSectionLabel("Academic Information", startX, ref currentY);

            SetupLabelAndTextBox(CourseIdLbl, CourseIdTxt, "Course:", startX, ref currentY, labelWidth, textBoxWidth);
            SetupLabelAndTextBox(YearIdLbl, YearIdTxt, "Year Level:", startX, ref currentY, labelWidth, textBoxWidth);

            // Make all textboxes read-only
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)control).ReadOnly = true;
                }
            }

            ResumeLayout(false);
            PerformLayout();
        }

        private void AddSectionLabel(string text, int x, ref int y)
        {
            System.Windows.Forms.Label sectionLabel = new System.Windows.Forms.Label();
            sectionLabel.Text = text;
            sectionLabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            sectionLabel.Location = new System.Drawing.Point(x, y);
            sectionLabel.AutoSize = true;
            this.Controls.Add(sectionLabel);
            y += 30; // Add space after section label
        }

        private void SetupLabelAndTextBox(System.Windows.Forms.Label label, System.Windows.Forms.TextBox textBox,
            string labelText, int startX, ref int currentY, int labelWidth, int textBoxWidth)
        {
            label.Text = labelText;
            label.Location = new System.Drawing.Point(startX, currentY);
            label.Size = new System.Drawing.Size(labelWidth, 23);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            textBox.Location = new System.Drawing.Point(startX + labelWidth + 10, currentY);
            textBox.Size = new System.Drawing.Size(textBoxWidth, 23);
            textBox.ReadOnly = true;

            this.Controls.Add(label);
            this.Controls.Add(textBox);
            currentY += 30;
        }

        #endregion

        private System.Windows.Forms.TextBox StudentIdTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox MiddleNameTxt;
        private System.Windows.Forms.TextBox HouseNoTxt;
        private System.Windows.Forms.TextBox BrgyNameTxt;
        private System.Windows.Forms.TextBox MunicipalityTxt;
        private System.Windows.Forms.TextBox ProvinceTxt;
        private System.Windows.Forms.TextBox RegionTxt;
        private System.Windows.Forms.TextBox CountryTxt;
        private System.Windows.Forms.TextBox BirthdateTxt;
        private System.Windows.Forms.TextBox AgeTxt;
        private System.Windows.Forms.TextBox StudContactTxt;
        private System.Windows.Forms.TextBox EmailAddressTxt;
        private System.Windows.Forms.TextBox GuardianFirstNameTxt;
        private System.Windows.Forms.TextBox GuardianLastNameTxt;
        private System.Windows.Forms.TextBox HobbiesTxt;
        private System.Windows.Forms.TextBox NicknameTxt;
        private System.Windows.Forms.TextBox CourseIdTxt;
        private System.Windows.Forms.TextBox YearIdTxt;

        private System.Windows.Forms.Label StudentIdLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label MiddleNameLbl;
        private System.Windows.Forms.Label HouseNoLbl;
        private System.Windows.Forms.Label BrgyNameLbl;
        private System.Windows.Forms.Label MunicipalityLbl;
        private System.Windows.Forms.Label ProvinceLbl;
        private System.Windows.Forms.Label RegionLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label BirthdateLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label StudContactLbl;
        private System.Windows.Forms.Label EmailAddressLbl;
        private System.Windows.Forms.Label GuardianFirstNameLbl;
        private System.Windows.Forms.Label GuardianLastNameLbl;
        private System.Windows.Forms.Label HobbiesLbl;
        private System.Windows.Forms.Label NicknameLbl;
        private System.Windows.Forms.Label CourseIdLbl;
        private System.Windows.Forms.Label YearIdLbl;
    }
}