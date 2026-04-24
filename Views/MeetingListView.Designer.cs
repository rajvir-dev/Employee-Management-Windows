namespace EmployeeManagement_Windows.Views
{
    partial class MeetingListView
    {
        private System.ComponentModel.IContainer components = null;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.cardFilters = new EmployeeManagement_Windows.Controls.CardPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new EmployeeManagement_Windows.Controls.ModernDatePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new EmployeeManagement_Windows.Controls.ModernDatePicker();
            this.btnSearch = new EmployeeManagement_Windows.Controls.ModernButton();
            this.btnReset = new EmployeeManagement_Windows.Controls.ModernButton();
            this.flowMeetings = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.cardFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblBreadcrumb);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.AutoSize = true;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBreadcrumb.Location = new System.Drawing.Point(20, 15);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(161, 19);
            this.lblBreadcrumb.TabIndex = 0;
            this.lblBreadcrumb.Text = "Home / Tasks / Meetings";
            // 
            // cardFilters
            // 
            this.cardFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardFilters.BackColor = System.Drawing.Color.Transparent;
            this.cardFilters.BorderRadius = 15;
            this.cardFilters.CardColor = System.Drawing.Color.White;
            this.cardFilters.Controls.Add(this.btnReset);
            this.cardFilters.Controls.Add(this.btnSearch);
            this.cardFilters.Controls.Add(this.dtpTo);
            this.cardFilters.Controls.Add(this.lblTo);
            this.cardFilters.Controls.Add(this.dtpFrom);
            this.cardFilters.Controls.Add(this.lblFrom);
            this.cardFilters.Controls.Add(this.cmbStatus);
            this.cardFilters.Controls.Add(this.lblStatus);
            this.cardFilters.Location = new System.Drawing.Point(20, 60);
            this.cardFilters.Name = "cardFilters";
            this.cardFilters.Padding = new System.Windows.Forms.Padding(15);
            this.cardFilters.ShadowSize = 2;
            this.cardFilters.Size = new System.Drawing.Size(1240, 100);
            this.cardFilters.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(25, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(87, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Meeting Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(25, 45);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(220, 23);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(265, 20);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(63, 15);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From Date";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(265, 40);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(220, 40);
            this.dtpFrom.TabIndex = 3;
            this.dtpFrom.PlaceholderText = "Select date";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(505, 20);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(48, 15);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To Date";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(505, 40);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(220, 40);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.PlaceholderText = "Select date";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(745, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 8;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(855, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // flowMeetings
            // 
            this.flowMeetings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowMeetings.AutoScroll = true;
            this.flowMeetings.Location = new System.Drawing.Point(20, 190);
            this.flowMeetings.Name = "flowMeetings";
            this.flowMeetings.Padding = new System.Windows.Forms.Padding(10);
            this.flowMeetings.Size = new System.Drawing.Size(1240, 430);
            this.flowMeetings.TabIndex = 2;
            // 
            // MeetingListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowMeetings);
            this.Controls.Add(this.cardFilters);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MeetingListView";
            this.Size = new System.Drawing.Size(1280, 640);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cardFilters.ResumeLayout(false);
            this.cardFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBreadcrumb;
        private EmployeeManagement_Windows.Controls.CardPanel cardFilters;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblFrom;
        private EmployeeManagement_Windows.Controls.ModernDatePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private EmployeeManagement_Windows.Controls.ModernDatePicker dtpTo;
        private EmployeeManagement_Windows.Controls.ModernButton btnSearch;
        private EmployeeManagement_Windows.Controls.ModernButton btnReset;
        private System.Windows.Forms.FlowLayoutPanel flowMeetings;
    }
}
