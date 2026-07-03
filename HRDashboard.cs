using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PostalDepHrSystem
{
    public partial class HRDashboard : Form
    {
        private string connStr = "server=localhost;port=3306;username=root;password=;database=Postal_HR_System;";

        public HRDashboard()
        {
            InitializeComponent();
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM employees", conn))
                        lbl_totalEmployees.Text = cmd.ExecuteScalar().ToString();

                    
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM jobs WHERE Status = 'Open'", conn))
                        lbl_openJobs.Text = cmd.ExecuteScalar().ToString();

                    
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE Status = 'Pending'", conn))
                        lbl_pendingApps.Text = cmd.ExecuteScalar().ToString();

                    
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM employees WHERE JoinDate >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)", conn))
                        lbl_newHires.Text = cmd.ExecuteScalar().ToString();

                   
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM performanceeviews WHERE ReviewDate >= CURDATE()", conn))
                        lbl_pendingReviews.Text = cmd.ExecuteScalar().ToString();

                   
                    using (MySqlCommand cmd = new MySqlCommand("SELECT AVG(SatisfactionRating) FROM engagementsurveys", conn))
                    {
                        object result = cmd.ExecuteScalar();
                        lbl_avgSatisfaction.Text = result != DBNull.Value ? Convert.ToDecimal(result).ToString("F1") + "/5" : "N/A";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stats: {ex.Message}");
            }
        }

        private void btn_recruitment_Click(object sender, EventArgs e)
        {
            RecruitmentForm recruitmentForm = new RecruitmentForm();
            recruitmentForm.Show();
            this.Hide();
        }

        private void btn_performance_Click(object sender, EventArgs e)
        {
            //PerformanceForm performanceForm = new PerformanceForm();
            //performanceForm.Show();
            //this.Hide();
        }

        private void btn_engagement_Click(object sender, EventArgs e)
        {
            //EngagementForm engagementForm = new EngagementForm();
            //engagementForm.Show();
            //this.Hide();
        }

        private void btn_onboarding_Click(object sender, EventArgs e)
        {
            //OnboardingForm onboardingForm = new OnboardingForm();
            //onboardingForm.Show();
            //this.Hide();
        }

        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.Show();
            //this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            adminDashboard adminDash = new adminDashboard();
            adminDash.Show();
            this.Hide();
        }
    }
}