using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cahatol_Joshua_LabExam
{
    public partial class Student_Page : Form
    {
        private readonly string connectionString;
        private FlowLayoutPanel studentsFlowPanel;

        public Student_Page()
        {
            InitializeComponent();

            // Set up connection string
            connectionString = "server=localhost;port=3307;database=studentinfodb;uid=root;pwd=;";

            try
            {
                using (MySqlConnection testConn = new MySqlConnection(connectionString))
                {
                    testConn.Open();
                }
                InitializeFlowPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}\nPlease check your database connection settings.",
                              "Connection Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void InitializeFlowPanel()
        {
            // Remove existing controls if any
            if (dataGridView1 != null) this.Controls.Remove(dataGridView1);
            if (btnView != null) this.Controls.Remove(btnView);

            // Initialize and configure FlowLayoutPanel
            studentsFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(20),
                Width = 650,
                Height = 350,
                Location = new Point(25, 25)
            };

            this.Controls.Add(studentsFlowPanel);
        }

        private void Student_Page_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT studentId, 
                                   CONCAT(firstName, ' ', COALESCE(NULLIF(middleName, ''), ''), ' ', lastName) AS FullName 
                                   FROM StudentRecordTB 
                                   ORDER BY studentId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        studentsFlowPanel.Controls.Clear();

                        while (reader.Read())
                        {
                            Panel studentPanel = new Panel
                            {
                                Width = 600,
                                Height = 40,
                                Margin = new Padding(0, 5, 0, 5),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            Label studentLabel = new Label
                            {
                                Text = $"ID: {reader["studentId"]} - {reader["FullName"]}",
                                Location = new Point(20, 10),
                                AutoSize = true,
                                Font = new Font("Arial", 10, FontStyle.Regular)
                            };

                            Button viewBtn = new Button
                            {
                                Text = "VIEW",
                                Name = $"ViewBtn_{reader["studentId"]}",
                                Tag = reader["studentId"],
                                Size = new Size(75, 25),
                                Location = new Point(500, 7),
                                BackColor = Color.LightBlue,
                                FlatStyle = FlatStyle.Flat
                            };
                            viewBtn.Click += ViewBtn_Click;

                            studentPanel.Controls.Add(studentLabel);
                            studentPanel.Controls.Add(viewBtn);
                            studentsFlowPanel.Controls.Add(studentPanel);
                        }

                        if (studentsFlowPanel.Controls.Count == 0)
                        {
                            Label noDataLabel = new Label
                            {
                                Text = "No student records found.",
                                AutoSize = true,
                                Location = new Point(20, 20),
                                Font = new Font("Arial", 12, FontStyle.Regular)
                            };
                            studentsFlowPanel.Controls.Add(noDataLabel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = (Button)sender;
                int studentId = Convert.ToInt32(clickedButton.Tag);

                StudentPage_Individual individualForm = new StudentPage_Individual(studentId);
                individualForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening student details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

