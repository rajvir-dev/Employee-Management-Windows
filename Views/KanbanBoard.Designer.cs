namespace EmployeeManagement_Windows.Views
{
    partial class KanbanBoard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPending = new System.Windows.Forms.Panel();
            this.flowPending = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPending = new System.Windows.Forms.Label();
            this.pnlInProgress = new System.Windows.Forms.Panel();
            this.flowInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.pnlCompleted = new System.Windows.Forms.Panel();
            this.flowCompleted = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.btnRefresh = new EmployeeManagement_Windows.Controls.ModernButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPending.SuspendLayout();
            this.pnlInProgress.SuspendLayout();
            this.pnlCompleted.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPending, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlInProgress, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCompleted, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 580);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlPending
            // 
            this.pnlPending.Controls.Add(this.flowPending);
            this.pnlPending.Controls.Add(this.lblPending);
            this.pnlPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPending.Location = new System.Drawing.Point(10, 10);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(406, 560);
            this.pnlPending.TabIndex = 0;
            // 
            // flowPending
            // 
            this.flowPending.AutoScroll = true;
            this.flowPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPending.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPending.Location = new System.Drawing.Point(0, 40);
            this.flowPending.Name = "flowPending";
            this.flowPending.Padding = new System.Windows.Forms.Padding(10);
            this.flowPending.Size = new System.Drawing.Size(406, 520);
            this.flowPending.TabIndex = 1;
            this.flowPending.WrapContents = false;
            // 
            // lblPending
            // 
            this.lblPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPending.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblPending.Location = new System.Drawing.Point(0, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(406, 40);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "PENDING";
            this.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.Controls.Add(this.flowInProgress);
            this.pnlInProgress.Controls.Add(this.lblInProgress);
            this.pnlInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInProgress.Location = new System.Drawing.Point(436, 10);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(406, 560);
            this.pnlInProgress.TabIndex = 1;
            // 
            // flowInProgress
            // 
            this.flowInProgress.AutoScroll = true;
            this.flowInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowInProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowInProgress.Location = new System.Drawing.Point(0, 40);
            this.flowInProgress.Name = "flowInProgress";
            this.flowInProgress.Padding = new System.Windows.Forms.Padding(10);
            this.flowInProgress.Size = new System.Drawing.Size(406, 520);
            this.flowInProgress.TabIndex = 1;
            this.flowInProgress.WrapContents = false;
            // 
            // lblInProgress
            // 
            this.lblInProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblInProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblInProgress.Location = new System.Drawing.Point(0, 0);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(406, 40);
            this.lblInProgress.TabIndex = 0;
            this.lblInProgress.Text = "IN PROGRESS";
            this.lblInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCompleted
            // 
            this.pnlCompleted.Controls.Add(this.flowCompleted);
            this.pnlCompleted.Controls.Add(this.lblCompleted);
            this.pnlCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompleted.Location = new System.Drawing.Point(862, 10);
            this.pnlCompleted.Name = "pnlCompleted";
            this.pnlCompleted.Size = new System.Drawing.Size(408, 560);
            this.pnlCompleted.TabIndex = 2;
            // 
            // flowCompleted
            // 
            this.flowCompleted.AutoScroll = true;
            this.flowCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCompleted.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowCompleted.Location = new System.Drawing.Point(0, 40);
            this.flowCompleted.Name = "flowCompleted";
            this.flowCompleted.Padding = new System.Windows.Forms.Padding(10);
            this.flowCompleted.Size = new System.Drawing.Size(408, 520);
            this.flowCompleted.TabIndex = 1;
            this.flowCompleted.WrapContents = false;
            // 
            // lblCompleted
            // 
            this.lblCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblCompleted.Location = new System.Drawing.Point(0, 0);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(408, 40);
            this.lblCompleted.TabIndex = 0;
            this.lblCompleted.Text = "COMPLETED";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblBreadcrumb);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBreadcrumb.Location = new System.Drawing.Point(20, 15);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(300, 30);
            this.lblBreadcrumb.TabIndex = 0;
            this.lblBreadcrumb.Text = "Home / Tasks / Overview";
            this.lblBreadcrumb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnRefresh.Location = new System.Drawing.Point(1130, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.Style = EmployeeManagement_Windows.Controls.ButtonStyle.Outline;
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // KanbanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "KanbanBoard";
            this.Size = new System.Drawing.Size(1280, 640);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlPending.ResumeLayout(false);
            this.pnlInProgress.ResumeLayout(false);
            this.pnlCompleted.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlPending;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.FlowLayoutPanel flowPending;
        private System.Windows.Forms.Panel pnlInProgress;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.FlowLayoutPanel flowInProgress;
        private System.Windows.Forms.Panel pnlCompleted;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.FlowLayoutPanel flowCompleted;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBreadcrumb;
        private EmployeeManagement_Windows.Controls.ModernButton btnRefresh;
    }
}
