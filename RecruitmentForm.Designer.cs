using System.Windows.Forms;

namespace PostalDepHrSystem
{
    partial class RecruitmentForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_back;

        // Post Job Section - ALL FILLABLE FIELDS
        private System.Windows.Forms.GroupBox groupBox_postJob;
        private System.Windows.Forms.Label lbl_jobTitle;
        private System.Windows.Forms.TextBox txt_jobTitle;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Label lbl_salaryRange;
        private System.Windows.Forms.TextBox txt_salaryRange;
        private System.Windows.Forms.Label lbl_jobDesc;
        private System.Windows.Forms.TextBox txt_jobDesc;
        private System.Windows.Forms.Label lbl_requirements;
        private System.Windows.Forms.TextBox txt_requirements;
        private System.Windows.Forms.Button btn_postJob;

        // Job List
        private System.Windows.Forms.Label lbl_jobList;
        private System.Windows.Forms.DataGridView dataGridView_jobs;

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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();

            this.groupBox_postJob = new System.Windows.Forms.GroupBox();
            this.lbl_jobTitle = new System.Windows.Forms.Label();
            this.txt_jobTitle = new System.Windows.Forms.TextBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.lbl_salaryRange = new System.Windows.Forms.Label();
            this.txt_salaryRange = new System.Windows.Forms.TextBox();
            this.lbl_jobDesc = new System.Windows.Forms.Label();
            this.txt_jobDesc = new System.Windows.Forms.TextBox();
            this.lbl_requirements = new System.Windows.Forms.Label();
            this.txt_requirements = new System.Windows.Forms.TextBox();
            this.btn_postJob = new System.Windows.Forms.Button();

            this.lbl_jobList = new System.Windows.Forms.Label();
            this.dataGridView_jobs = new System.Windows.Forms.DataGridView();

            this.panel_header.SuspendLayout();
            this.groupBox_postJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_jobs)).BeginInit();
            this.SuspendLayout();

            // ========== HEADER PANEL ==========
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.panel_header.Controls.Add(this.lbl_title);
            this.panel_header.Controls.Add(this.btn_back);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1100, 60);
            this.panel_header.TabIndex = 0;

            // Title
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(100, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(343, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "📋 Recruitment & Tracking";

            // Back Button
            this.btn_back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(15, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(80, 35);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "← Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);

            // ========== GROUP BOX ==========
            this.groupBox_postJob.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox_postJob.Location = new System.Drawing.Point(20, 80);
            this.groupBox_postJob.Name = "groupBox_postJob";
            this.groupBox_postJob.Size = new System.Drawing.Size(480, 390);
            this.groupBox_postJob.TabIndex = 1;
            this.groupBox_postJob.TabStop = false;
            this.groupBox_postJob.Text = "📢 Post New Job";

            // ========== ADD ALL CONTROLS TO GROUPBOX ==========
            // Job Title
            this.lbl_jobTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_jobTitle.Location = new System.Drawing.Point(20, 35);
            this.lbl_jobTitle.Name = "lbl_jobTitle";
            this.lbl_jobTitle.Size = new System.Drawing.Size(100, 20);
            this.lbl_jobTitle.TabIndex = 0;
            this.lbl_jobTitle.Text = "Job Title:";
            this.groupBox_postJob.Controls.Add(this.lbl_jobTitle);

            this.txt_jobTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_jobTitle.Location = new System.Drawing.Point(130, 32);
            this.txt_jobTitle.Name = "txt_jobTitle";
            this.txt_jobTitle.Size = new System.Drawing.Size(320, 27);
            this.txt_jobTitle.TabIndex = 1;
            this.groupBox_postJob.Controls.Add(this.txt_jobTitle);

            // Department
            this.lbl_department.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_department.Location = new System.Drawing.Point(20, 75);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(100, 20);
            this.lbl_department.TabIndex = 2;
            this.lbl_department.Text = "Department:";
            this.groupBox_postJob.Controls.Add(this.lbl_department);

            this.txt_department.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_department.Location = new System.Drawing.Point(130, 72);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(320, 27);
            this.txt_department.TabIndex = 3;
            this.groupBox_postJob.Controls.Add(this.txt_department);

            // Salary Range
            this.lbl_salaryRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_salaryRange.Location = new System.Drawing.Point(20, 115);
            this.lbl_salaryRange.Name = "lbl_salaryRange";
            this.lbl_salaryRange.Size = new System.Drawing.Size(100, 20);
            this.lbl_salaryRange.TabIndex = 4;
            this.lbl_salaryRange.Text = "Salary Range:";
            this.groupBox_postJob.Controls.Add(this.lbl_salaryRange);

            this.txt_salaryRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_salaryRange.Location = new System.Drawing.Point(130, 112);
            this.txt_salaryRange.Name = "txt_salaryRange";
            this.txt_salaryRange.Size = new System.Drawing.Size(320, 27);
            this.txt_salaryRange.TabIndex = 5;
            this.groupBox_postJob.Controls.Add(this.txt_salaryRange);

            // Job Description
            this.lbl_jobDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_jobDesc.Location = new System.Drawing.Point(20, 155);
            this.lbl_jobDesc.Name = "lbl_jobDesc";
            this.lbl_jobDesc.Size = new System.Drawing.Size(100, 20);
            this.lbl_jobDesc.TabIndex = 6;
            this.lbl_jobDesc.Text = "Description:";
            this.groupBox_postJob.Controls.Add(this.lbl_jobDesc);

            this.txt_jobDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_jobDesc.Location = new System.Drawing.Point(130, 152);
            this.txt_jobDesc.Multiline = true;
            this.txt_jobDesc.Name = "txt_jobDesc";
            this.txt_jobDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_jobDesc.Size = new System.Drawing.Size(320, 70);
            this.txt_jobDesc.TabIndex = 7;
            this.groupBox_postJob.Controls.Add(this.txt_jobDesc);

            // Requirements
            this.lbl_requirements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_requirements.Location = new System.Drawing.Point(20, 240);
            this.lbl_requirements.Name = "lbl_requirements";
            this.lbl_requirements.Size = new System.Drawing.Size(100, 20);
            this.lbl_requirements.TabIndex = 8;
            this.lbl_requirements.Text = "Requirements:";
            this.groupBox_postJob.Controls.Add(this.lbl_requirements);

            this.txt_requirements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_requirements.Location = new System.Drawing.Point(130, 237);
            this.txt_requirements.Multiline = true;
            this.txt_requirements.Name = "txt_requirements";
            this.txt_requirements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_requirements.Size = new System.Drawing.Size(320, 70);
            this.txt_requirements.TabIndex = 9;
            this.groupBox_postJob.Controls.Add(this.txt_requirements);

            // Post Job Button
            this.btn_postJob.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btn_postJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_postJob.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_postJob.ForeColor = System.Drawing.Color.White;
            this.btn_postJob.Location = new System.Drawing.Point(130, 330);
            this.btn_postJob.Name = "btn_postJob";
            this.btn_postJob.Size = new System.Drawing.Size(160, 35);
            this.btn_postJob.TabIndex = 10;
            this.btn_postJob.Text = " POST JOB";
            this.btn_postJob.UseVisualStyleBackColor = false;
            this.btn_postJob.Click += new System.EventHandler(this.btn_postJob_Click);
            this.groupBox_postJob.Controls.Add(this.btn_postJob);

            // ========== JOB LIST ==========
            this.lbl_jobList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_jobList.Location = new System.Drawing.Point(520, 85);
            this.lbl_jobList.Name = "lbl_jobList";
            this.lbl_jobList.Size = new System.Drawing.Size(250, 25);
            this.lbl_jobList.TabIndex = 4;
            this.lbl_jobList.Text = "📋 Recent Job Postings";

            this.dataGridView_jobs.AllowUserToAddRows = false;
            this.dataGridView_jobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_jobs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_jobs.Location = new System.Drawing.Point(520, 115);
            this.dataGridView_jobs.Name = "dataGridView_jobs";
            this.dataGridView_jobs.ReadOnly = true;
            this.dataGridView_jobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_jobs.Size = new System.Drawing.Size(550, 355);
            this.dataGridView_jobs.TabIndex = 3;

            // ========== FORM ==========
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.dataGridView_jobs);
            this.Controls.Add(this.lbl_jobList);
            this.Controls.Add(this.groupBox_postJob);
            this.Controls.Add(this.panel_header);
            this.Name = "RecruitmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recruitment & Tracking";

            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.groupBox_postJob.ResumeLayout(false);
            this.groupBox_postJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_jobs)).EndInit();
            this.ResumeLayout(false);
        }
    }
}