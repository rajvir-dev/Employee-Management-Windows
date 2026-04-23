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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnRequestLeave = new EmployeeManagement_Windows.Controls.ModernButton();
            this.flowLeaveHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnRequestLeave);
            this.pnlHeader.Controls.Add(this.lblBreadcrumb);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBreadcrumb.Location = new System.Drawing.Point(20, 15);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(400, 30);
            this.lblBreadcrumb.TabIndex = 0;
            this.lblBreadcrumb.Text = "Home / Leave Requests / History";
            this.lblBreadcrumb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(190, 37);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Leave History";
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequestLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnRequestLeave.BorderRadius = 8;
            this.btnRequestLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestLeave.FlatAppearance.BorderSize = 0;
            this.btnRequestLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestLeave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRequestLeave.ForeColor = System.Drawing.Color.White;
            this.btnRequestLeave.Location = new System.Drawing.Point(1110, 45);
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.Size = new System.Drawing.Size(150, 45);
            this.btnRequestLeave.Style = EmployeeManagement_Windows.Controls.ButtonStyle.Primary;
            this.btnRequestLeave.TabIndex = 2;
            this.btnRequestLeave.Text = "+ Request Leave";
            this.btnRequestLeave.UseVisualStyleBackColor = false;
            this.btnRequestLeave.Click += new System.EventHandler(this.btnRequestLeave_Click);
            // 
            // flowLeaveHistory
            // 
            this.flowLeaveHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLeaveHistory.AutoScroll = true;
            this.flowLeaveHistory.Location = new System.Drawing.Point(0, 100);
            this.flowLeaveHistory.Name = "flowLeaveHistory";
            this.flowLeaveHistory.Padding = new System.Windows.Forms.Padding(20);
            this.flowLeaveHistory.Size = new System.Drawing.Size(1280, 540);
            this.flowLeaveHistory.TabIndex = 1;
            // 
            // LeaveHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLeaveHistory);
            this.Controls.Add(this.pnlHeader);
            this.Name = "LeaveHistoryView";
            this.Size = new System.Drawing.Size(1280, 640);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLeaveHistory;
        private EmployeeManagement_Windows.Controls.ModernButton btnRequestLeave;
    }
}
