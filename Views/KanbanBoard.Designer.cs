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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPending.SuspendLayout();
            this.pnlInProgress.SuspendLayout();
            this.pnlCompleted.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlPending
            // 
            this.pnlPending.Controls.Add(this.flowPending);
            this.pnlPending.Controls.Add(this.lblPending);
            this.pnlPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPending.Location = new System.Drawing.Point(3, 3);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(260, 554);
            this.pnlPending.TabIndex = 0;
            // 
            // flowPending
            // 
            this.flowPending.AutoScroll = true;
            this.flowPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPending.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPending.Location = new System.Drawing.Point(0, 40);
            this.flowPending.Name = "flowPending";
            this.flowPending.Padding = new System.Windows.Forms.Padding(5);
            this.flowPending.Size = new System.Drawing.Size(260, 514);
            this.flowPending.TabIndex = 1;
            this.flowPending.WrapContents = false;
            // 
            // lblPending
            // 
            this.lblPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPending.Location = new System.Drawing.Point(0, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(260, 40);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "PENDING";
            this.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.Controls.Add(this.flowInProgress);
            this.pnlInProgress.Controls.Add(this.lblInProgress);
            this.pnlInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInProgress.Location = new System.Drawing.Point(269, 3);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(260, 554);
            this.pnlInProgress.TabIndex = 1;
            // 
            // flowInProgress
            // 
            this.flowInProgress.AutoScroll = true;
            this.flowInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowInProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowInProgress.Location = new System.Drawing.Point(0, 40);
            this.flowInProgress.Name = "flowInProgress";
            this.flowInProgress.Padding = new System.Windows.Forms.Padding(5);
            this.flowInProgress.Size = new System.Drawing.Size(260, 514);
            this.flowInProgress.TabIndex = 1;
            this.flowInProgress.WrapContents = false;
            // 
            // lblInProgress
            // 
            this.lblInProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInProgress.Location = new System.Drawing.Point(0, 0);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(260, 40);
            this.lblInProgress.TabIndex = 0;
            this.lblInProgress.Text = "IN PROGRESS";
            this.lblInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCompleted
            // 
            this.pnlCompleted.Controls.Add(this.flowCompleted);
            this.pnlCompleted.Controls.Add(this.lblCompleted);
            this.pnlCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompleted.Location = new System.Drawing.Point(535, 3);
            this.pnlCompleted.Name = "pnlCompleted";
            this.pnlCompleted.Size = new System.Drawing.Size(262, 554);
            this.pnlCompleted.TabIndex = 2;
            // 
            // flowCompleted
            // 
            this.flowCompleted.AutoScroll = true;
            this.flowCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCompleted.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowCompleted.Location = new System.Drawing.Point(0, 40);
            this.flowCompleted.Name = "flowCompleted";
            this.flowCompleted.Padding = new System.Windows.Forms.Padding(5);
            this.flowCompleted.Size = new System.Drawing.Size(262, 514);
            this.flowCompleted.TabIndex = 1;
            this.flowCompleted.WrapContents = false;
            // 
            // lblCompleted
            // 
            this.lblCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompleted.Location = new System.Drawing.Point(0, 0);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(262, 40);
            this.lblCompleted.TabIndex = 0;
            this.lblCompleted.Text = "COMPLETED";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(800, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Board";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // KanbanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRefresh);
            this.Name = "KanbanBoard";
            this.Size = new System.Drawing.Size(800, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlPending.ResumeLayout(false);
            this.pnlInProgress.ResumeLayout(false);
            this.pnlCompleted.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnRefresh;
    }
}
