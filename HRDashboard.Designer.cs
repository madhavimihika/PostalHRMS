using System.Windows.Forms;

namespace PostalDepHrSystem
{
    partial class HRDashboard
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_welcome;

        // Stats Panel
        private System.Windows.Forms.Panel panel_stats;
        private System.Windows.Forms.Label lbl_totalEmployees;
        private System.Windows.Forms.Label lbl_totalEmployeesLabel;
        private System.Windows.Forms.Label lbl_openJobs;
        private System.Windows.Forms.Label lbl_openJobsLabel;
        private System.Windows.Forms.Label lbl_pendingApps;
        private System.Windows.Forms.Label lbl_pendingAppsLabel;
        private System.Windows.Forms.Label lbl_newHires;
        private System.Windows.Forms.Label lbl_newHiresLabel;
        private System.Windows.Forms.Label lbl_pendingReviews;
        private System.Windows.Forms.Label lbl_pendingReviewsLabel;
        private System.Windows.Forms.Label lbl_avgSatisfaction;
        private System.Windows.Forms.Label lbl_avgSatisfactionLabel;

        // Buttons Panel
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_recruitment;
        private System.Windows.Forms.Button btn_performance;
        private System.Windows.Forms.Button btn_engagement;
        private System.Windows.Forms.Button btn_onboarding;
        private System.Windows.Forms.Button btn_generateReport;
        private System.Windows.Forms.Button btn_logout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel_stats = new System.Windows.Forms.Panel();
            this.lbl_totalEmployeesLabel = new System.Windows.Forms.Label();
            this.lbl_totalEmployees = new System.Windows.Forms.Label();
            this.lbl_openJobsLabel = new System.Windows.Forms.Label();
            this.lbl_openJobs = new System.Windows.Forms.Label();
            this.lbl_pendingAppsLabel = new System.Windows.Forms.Label();
            this.lbl_pendingApps = new System.Windows.Forms.Label();
            this.lbl_newHiresLabel = new System.Windows.Forms.Label();
            this.lbl_newHires = new System.Windows.Forms.Label();
            this.lbl_pendingReviewsLabel = new System.Windows.Forms.Label();
            this.lbl_pendingReviews = new System.Windows.Forms.Label();
            this.lbl_avgSatisfactionLabel = new System.Windows.Forms.Label();
            this.lbl_avgSatisfaction = new System.Windows.Forms.Label();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_recruitment = new System.Windows.Forms.Button();
            this.btn_performance = new System.Windows.Forms.Button();
            this.btn_engagement = new System.Windows.Forms.Button();
            this.btn_onboarding = new System.Windows.Forms.Button();
            this.btn_generateReport = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_stats.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Brown;
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.lbl_title);
            this.panel_header.Controls.Add(this.lbl_welcome);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1000, 70);
            this.panel_header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PostalDepHrSystem.Properties.Resources.employee_icon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(77, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(203, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "HR Dashboard";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_welcome.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_welcome.Location = new System.Drawing.Point(824, 20);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(150, 23);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome, HR User";
            // 
            // panel_stats
            // 
            this.panel_stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel_stats.Controls.Add(this.lbl_totalEmployeesLabel);
            this.panel_stats.Controls.Add(this.lbl_totalEmployees);
            this.panel_stats.Controls.Add(this.lbl_openJobsLabel);
            this.panel_stats.Controls.Add(this.lbl_openJobs);
            this.panel_stats.Controls.Add(this.lbl_pendingAppsLabel);
            this.panel_stats.Controls.Add(this.lbl_pendingApps);
            this.panel_stats.Controls.Add(this.lbl_newHiresLabel);
            this.panel_stats.Controls.Add(this.lbl_newHires);
            this.panel_stats.Controls.Add(this.lbl_pendingReviewsLabel);
            this.panel_stats.Controls.Add(this.lbl_pendingReviews);
            this.panel_stats.Controls.Add(this.lbl_avgSatisfactionLabel);
            this.panel_stats.Controls.Add(this.lbl_avgSatisfaction);
            this.panel_stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stats.Location = new System.Drawing.Point(0, 70);
            this.panel_stats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_stats.Name = "panel_stats";
            this.panel_stats.Size = new System.Drawing.Size(1000, 130);
            this.panel_stats.TabIndex = 1;
            // 
            // lbl_totalEmployeesLabel
            // 
            this.lbl_totalEmployeesLabel.AutoSize = true;
            this.lbl_totalEmployeesLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_totalEmployeesLabel.Location = new System.Drawing.Point(29, 25);
            this.lbl_totalEmployeesLabel.Name = "lbl_totalEmployeesLabel";
            this.lbl_totalEmployeesLabel.Size = new System.Drawing.Size(118, 20);
            this.lbl_totalEmployeesLabel.TabIndex = 0;
            this.lbl_totalEmployeesLabel.Text = "Total Employees";
            // 
            // lbl_totalEmployees
            // 
            this.lbl_totalEmployees.AutoSize = true;
            this.lbl_totalEmployees.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_totalEmployees.ForeColor = System.Drawing.Color.Navy;
            this.lbl_totalEmployees.Location = new System.Drawing.Point(29, 46);
            this.lbl_totalEmployees.Name = "lbl_totalEmployees";
            this.lbl_totalEmployees.Size = new System.Drawing.Size(43, 50);
            this.lbl_totalEmployees.TabIndex = 1;
            this.lbl_totalEmployees.Text = "0";
            // 
            // lbl_openJobsLabel
            // 
            this.lbl_openJobsLabel.AutoSize = true;
            this.lbl_openJobsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_openJobsLabel.Location = new System.Drawing.Point(200, 25);
            this.lbl_openJobsLabel.Name = "lbl_openJobsLabel";
            this.lbl_openJobsLabel.Size = new System.Drawing.Size(78, 20);
            this.lbl_openJobsLabel.TabIndex = 2;
            this.lbl_openJobsLabel.Text = "Open Jobs";
            // 
            // lbl_openJobs
            // 
            this.lbl_openJobs.AutoSize = true;
            this.lbl_openJobs.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_openJobs.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_openJobs.Location = new System.Drawing.Point(200, 46);
            this.lbl_openJobs.Name = "lbl_openJobs";
            this.lbl_openJobs.Size = new System.Drawing.Size(43, 50);
            this.lbl_openJobs.TabIndex = 3;
            this.lbl_openJobs.Text = "0";
            // 
            // lbl_pendingAppsLabel
            // 
            this.lbl_pendingAppsLabel.AutoSize = true;
            this.lbl_pendingAppsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_pendingAppsLabel.Location = new System.Drawing.Point(371, 25);
            this.lbl_pendingAppsLabel.Name = "lbl_pendingAppsLabel";
            this.lbl_pendingAppsLabel.Size = new System.Drawing.Size(149, 20);
            this.lbl_pendingAppsLabel.TabIndex = 4;
            this.lbl_pendingAppsLabel.Text = "Pending Applications";
            // 
            // lbl_pendingApps
            // 
            this.lbl_pendingApps.AutoSize = true;
            this.lbl_pendingApps.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_pendingApps.ForeColor = System.Drawing.Color.Orange;
            this.lbl_pendingApps.Location = new System.Drawing.Point(371, 46);
            this.lbl_pendingApps.Name = "lbl_pendingApps";
            this.lbl_pendingApps.Size = new System.Drawing.Size(43, 50);
            this.lbl_pendingApps.TabIndex = 5;
            this.lbl_pendingApps.Text = "0";
            // 
            // lbl_newHiresLabel
            // 
            this.lbl_newHiresLabel.AutoSize = true;
            this.lbl_newHiresLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_newHiresLabel.Location = new System.Drawing.Point(560, 25);
            this.lbl_newHiresLabel.Name = "lbl_newHiresLabel";
            this.lbl_newHiresLabel.Size = new System.Drawing.Size(116, 20);
            this.lbl_newHiresLabel.TabIndex = 6;
            this.lbl_newHiresLabel.Text = "New Hires (30d)";
            // 
            // lbl_newHires
            // 
            this.lbl_newHires.AutoSize = true;
            this.lbl_newHires.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_newHires.ForeColor = System.Drawing.Color.Purple;
            this.lbl_newHires.Location = new System.Drawing.Point(560, 46);
            this.lbl_newHires.Name = "lbl_newHires";
            this.lbl_newHires.Size = new System.Drawing.Size(43, 50);
            this.lbl_newHires.TabIndex = 7;
            this.lbl_newHires.Text = "0";
            // 
            // lbl_pendingReviewsLabel
            // 
            this.lbl_pendingReviewsLabel.AutoSize = true;
            this.lbl_pendingReviewsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_pendingReviewsLabel.Location = new System.Drawing.Point(749, 25);
            this.lbl_pendingReviewsLabel.Name = "lbl_pendingReviewsLabel";
            this.lbl_pendingReviewsLabel.Size = new System.Drawing.Size(119, 20);
            this.lbl_pendingReviewsLabel.TabIndex = 8;
            this.lbl_pendingReviewsLabel.Text = "Pending Reviews";
            // 
            // lbl_pendingReviews
            // 
            this.lbl_pendingReviews.AutoSize = true;
            this.lbl_pendingReviews.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_pendingReviews.ForeColor = System.Drawing.Color.Red;
            this.lbl_pendingReviews.Location = new System.Drawing.Point(749, 46);
            this.lbl_pendingReviews.Name = "lbl_pendingReviews";
            this.lbl_pendingReviews.Size = new System.Drawing.Size(43, 50);
            this.lbl_pendingReviews.TabIndex = 9;
            this.lbl_pendingReviews.Text = "0";
            // 
            // lbl_avgSatisfactionLabel
            // 
            this.lbl_avgSatisfactionLabel.AutoSize = true;
            this.lbl_avgSatisfactionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_avgSatisfactionLabel.Location = new System.Drawing.Point(29, 100);
            this.lbl_avgSatisfactionLabel.Name = "lbl_avgSatisfactionLabel";
            this.lbl_avgSatisfactionLabel.Size = new System.Drawing.Size(116, 20);
            this.lbl_avgSatisfactionLabel.TabIndex = 10;
            this.lbl_avgSatisfactionLabel.Text = "Avg Satisfaction";
            // 
            // lbl_avgSatisfaction
            // 
            this.lbl_avgSatisfaction.AutoSize = true;
            this.lbl_avgSatisfaction.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_avgSatisfaction.ForeColor = System.Drawing.Color.Teal;
            this.lbl_avgSatisfaction.Location = new System.Drawing.Point(29, 118);
            this.lbl_avgSatisfaction.Name = "lbl_avgSatisfaction";
            this.lbl_avgSatisfaction.Size = new System.Drawing.Size(65, 41);
            this.lbl_avgSatisfaction.TabIndex = 11;
            this.lbl_avgSatisfaction.Text = "0/5";
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.pictureBox3);
            this.panel_buttons.Controls.Add(this.pictureBox2);
            this.panel_buttons.Controls.Add(this.btn_back);
            this.panel_buttons.Controls.Add(this.btn_logout);
            this.panel_buttons.Controls.Add(this.btn_recruitment);
            this.panel_buttons.Controls.Add(this.btn_performance);
            this.panel_buttons.Controls.Add(this.btn_engagement);
            this.panel_buttons.Controls.Add(this.btn_onboarding);
            this.panel_buttons.Controls.Add(this.btn_generateReport);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_buttons.Location = new System.Drawing.Point(0, 200);
            this.panel_buttons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(1000, 300);
            this.panel_buttons.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PostalDepHrSystem.Properties.Resources.report_Icon;
            this.pictureBox3.Location = new System.Drawing.Point(51, 34);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 35);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PostalDepHrSystem.Properties.Resources.employee_icon;
            this.pictureBox2.Location = new System.Drawing.Point(669, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 51);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gray;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(3, 261);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 38);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "<-Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Crimson;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(871, 255);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(127, 42);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = " LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_recruitment
            // 
            this.btn_recruitment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_recruitment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_recruitment.ForeColor = System.Drawing.Color.White;
            this.btn_recruitment.Location = new System.Drawing.Point(51, 50);
            this.btn_recruitment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_recruitment.Name = "btn_recruitment";
            this.btn_recruitment.Size = new System.Drawing.Size(280, 80);
            this.btn_recruitment.TabIndex = 0;
            this.btn_recruitment.Text = " RECRUITMENT & TRACKING";
            this.btn_recruitment.UseVisualStyleBackColor = false;
            this.btn_recruitment.Click += new System.EventHandler(this.btn_recruitment_Click);
            // 
            // btn_performance
            // 
            this.btn_performance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_performance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_performance.ForeColor = System.Drawing.Color.White;
            this.btn_performance.Location = new System.Drawing.Point(360, 50);
            this.btn_performance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_performance.Name = "btn_performance";
            this.btn_performance.Size = new System.Drawing.Size(280, 80);
            this.btn_performance.TabIndex = 1;
            this.btn_performance.Text = " PERFORMANCE MANAGEMENT";
            this.btn_performance.UseVisualStyleBackColor = false;
            // 
            // btn_engagement
            // 
            this.btn_engagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btn_engagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_engagement.ForeColor = System.Drawing.Color.White;
            this.btn_engagement.Location = new System.Drawing.Point(669, 50);
            this.btn_engagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_engagement.Name = "btn_engagement";
            this.btn_engagement.Size = new System.Drawing.Size(280, 80);
            this.btn_engagement.TabIndex = 2;
            this.btn_engagement.Text = " EMPLOYEE ENGAGEMENT";
            this.btn_engagement.UseVisualStyleBackColor = false;
            // 
            // btn_onboarding
            // 
            this.btn_onboarding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_onboarding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_onboarding.ForeColor = System.Drawing.Color.White;
            this.btn_onboarding.Location = new System.Drawing.Point(209, 160);
            this.btn_onboarding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_onboarding.Name = "btn_onboarding";
            this.btn_onboarding.Size = new System.Drawing.Size(280, 80);
            this.btn_onboarding.TabIndex = 3;
            this.btn_onboarding.Text = " ONBOARDING";
            this.btn_onboarding.UseVisualStyleBackColor = false;
            // 
            // btn_generateReport
            // 
            this.btn_generateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_generateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_generateReport.ForeColor = System.Drawing.Color.White;
            this.btn_generateReport.Location = new System.Drawing.Point(529, 160);
            this.btn_generateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generateReport.Name = "btn_generateReport";
            this.btn_generateReport.Size = new System.Drawing.Size(280, 80);
            this.btn_generateReport.TabIndex = 4;
            this.btn_generateReport.Text = " GENERATE HR REPORT";
            this.btn_generateReport.UseVisualStyleBackColor = false;
            // 
            // HRDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.panel_stats);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HRDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Dashboard";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_stats.ResumeLayout(false);
            this.panel_stats.PerformLayout();
            this.panel_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox pictureBox1;
        private Button btn_back;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}