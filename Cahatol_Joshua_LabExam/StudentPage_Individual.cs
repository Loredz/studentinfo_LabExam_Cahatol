using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cahatol_Joshua_LabExam
{
    public partial class StudentPage_Individual : Form
    {
        private readonly string connectionString = "server=localhost;port=3307;database=studentinfodb;uid=root;pwd=;";
        private readonly int studentId;

        public StudentPage_Individual(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM StudentRecordTB WHERE studentId = @StudentId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Personal Information
                                StudentIdTxt.Text = reader["studentId"].ToString();
                                FirstNameTxt.Text = reader["firstName"].ToString();
                                LastNameTxt.Text = reader["lastName"].ToString();
                                MiddleNameTxt.Text = reader["middleName"].ToString();
                                NicknameTxt.Text = reader["nickname"].ToString();

                                // Address Information
                                HouseNoTxt.Text = reader["houseNo"].ToString();
                                BrgyNameTxt.Text = reader["brgyName"].ToString();
                                MunicipalityTxt.Text = reader["municipality"].ToString();
                                ProvinceTxt.Text = reader["province"].ToString();
                                RegionTxt.Text = reader["region"].ToString();
                                CountryTxt.Text = reader["country"].ToString();

                                // Contact Information
                                StudContactTxt.Text = reader["studContactNo"].ToString();
                                EmailAddressTxt.Text = reader["emailAddress"].ToString();

                                // Additional Information
                                DateTime birthdate;
                                if (DateTime.TryParse(reader["birthdate"].ToString(), out birthdate))
                                {
                                    BirthdateTxt.Text = birthdate.ToShortDateString();
                                }
                                AgeTxt.Text = reader["age"].ToString();
                                HobbiesTxt.Text = reader["hobbies"].ToString();

                                // Guardian Information
                                GuardianFirstNameTxt.Text = reader["guardianFirstName"].ToString();
                                GuardianLastNameTxt.Text = reader["guardianLastName"].ToString();

                                // Academic Information
                                CourseIdTxt.Text = reader["courseId"].ToString();
                                YearIdTxt.Text = reader["yearId"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
