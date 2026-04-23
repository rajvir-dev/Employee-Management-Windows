namespace EmployeeManagement_Windows.Views
{
    partial class LeaveHistoryView
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.flowLeaveHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRequestLeave = new EmployeeManagement_Windows.CustomControls.ModernButton();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(190, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "My Leaves";
            // 
            // flowLeaveHistory
            // 
            this.flowLeaveHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLeaveHistory.AutoScroll = true;
            this.flowLeaveHistory.Location = new System.Drawing.Point(20, 80);
            this.flowLeaveHistory.Name = "flowLeaveHistory";
            this.flowLeaveHistory.Size = new System.Drawing.Size(760, 500);
            this.flowLeaveHistory.TabIndex = 1;
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequestLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnRequestLeave.BorderRadius = 10;
            this.btnRequestLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestLeave.FlatAppearance.BorderSize = 0;
            this.btnRequestLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestLeave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRequestLeave.ForeColor = System.Drawing.Color.White;
            this.btnRequestLeave.GradientEnd = EmployeeManagement_Windows.Helpers.ThemeColors.PrimaryDark;
            this.btnRequestLeave.GradientStart = EmployeeManagement_Windows.Helpers.ThemeColors.Primary;
            this.btnRequestLeave.Location = new System.Drawing.Point(630, 25);
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.Size = new System.Drawing.Size(150, 35);
            this.btnRequestLeave.TabIndex = 2;
            this.btnRequestLeave.Text = "+ Request Leave";
            this.btnRequestLeave.UseVisualStyleBackColor = true;
            this.btnRequestLeave.Click += new System.EventHandler(this.btnRequestLeave_Click);
            // 
            // LeaveHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRequestLeave);
            this.Controls.Add(this.flowLeaveHistory);
            this.Controls.Add(this.lblHeader);
            this.Name = "LeaveHistoryView";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLeaveHistory;
        private EmployeeManagement_Windows.CustomControls.ModernButton btnRequestLeave;
    }
}
