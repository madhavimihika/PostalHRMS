using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PostalDepHrSystem
{
    public partial class RecruitmentForm : Form
    {
        private string connStr = "server=localhost;port=3306;username=root;password=;database=Postal_HR_System;";

        public RecruitmentForm()
        {
            InitializeComponent();
            LoadJobs();
        }

        private void LoadJobs()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT JobID, JobTitle, Department, SalaryRange, Status, PostedDate FROM jobs ORDER BY PostedDate DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_jobs.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading jobs: {ex.Message}");
            }
        }

        private void btn_postJob_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrEmpty(txt_jobTitle.Text))
            {
                MessageBox.Show("Please enter Job Title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_jobTitle.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO jobs (JobTitle, Department, JobDescription, Requirements, SalaryRange, Status) 
                                    VALUES (@title, @dept, @desc, @req, @salary, 'Open')";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txt_jobTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@dept", txt_department.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", txt_jobDesc.Text.Trim());
                        cmd.Parameters.AddWithValue("@req", txt_requirements.Text.Trim());
                        cmd.Parameters.AddWithValue("@salary", txt_salaryRange.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Job posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadJobs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txt_jobTitle.Clear();
            txt_department.Clear();
            txt_jobDesc.Clear();
            txt_requirements.Clear();
            txt_salaryRange.Clear();
            txt_jobTitle.Focus();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HRDashboard hrDash = new HRDashboard();
            hrDash.Show();
            this.Hide();
        }

        private void dataGridView_jobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell click - e.g., view application details
        }
    }
}