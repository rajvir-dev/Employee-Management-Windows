namespace EmployeeManagement_Windows.Components
{
    using EmployeeManagement_Windows.Controls;
    using System.Windows.Forms;
    using System.Drawing;

    partial class CommentItem
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnMore = new EmployeeManagement_Windows.Controls.ModernButton();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picAvatar = new EmployeeManagement_Windows.Controls.AvatarCircle();
            this.cardBubble = new EmployeeManagement_Windows.Controls.CardPanel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblWorked = new System.Windows.Forms.Label();
            this.cmsComment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.cardBubble.SuspendLayout();
            this.cmsComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnMore);
            this.pnlMain.Controls.Add(this.lblAuthor);
            this.pnlMain.Controls.Add(this.lblTime);
            this.pnlMain.Controls.Add(this.picAvatar);
            this.pnlMain.Controls.Add(this.cardBubble);
            this.pnlMain.Controls.Add(this.lblWorked);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(390, 80);
            this.pnlMain.TabIndex = 0;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnMore.BorderRadius = 14;
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.FlatAppearance.BorderSize = 0;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnMore.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnMore.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnMore.Location = new System.Drawing.Point(0, 0);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(28, 28);
            this.btnMore.TabIndex = 5;
            this.btnMore.Text = "⋮";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblAuthor.Location = new System.Drawing.Point(40, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(58, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "author";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblTime.Location = new System.Drawing.Point(280, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 12);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00 AM";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar.Image = null;
            this.picAvatar.Location = new System.Drawing.Point(350, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(32, 32);
            this.picAvatar.TabIndex = 1;
            // 
            // cardBubble
            // 
            this.cardBubble.BackColor = System.Drawing.Color.Transparent;
            this.cardBubble.BorderRadius = 12;
            this.cardBubble.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.cardBubble.Controls.Add(this.lblText);
            this.cardBubble.Location = new System.Drawing.Point(100, 15);
            this.cardBubble.Name = "cardBubble";
            this.cardBubble.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.cardBubble.ShadowSize = 0;
            this.cardBubble.Size = new System.Drawing.Size(230, 40);
            this.cardBubble.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(12, 8);
            this.lblText.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(100, 17);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "comment";
            // 
            // lblWorked
            // 
            this.lblWorked.AutoSize = true;
            this.lblWorked.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblWorked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblWorked.Location = new System.Drawing.Point(235, 58);
            this.lblWorked.Name = "lblWorked";
            this.lblWorked.Size = new System.Drawing.Size(102, 12);
            this.lblWorked.TabIndex = 3;
            this.lblWorked.Text = "work log";
            // 
            // cmsComment
            // 
            this.cmsComment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsComment.Name = "cmsComment";
            this.cmsComment.Size = new System.Drawing.Size(164, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.copyToolStripMenuItem.Text = "📋  Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteToolStripMenuItem.Text = "🗑️  Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // CommentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMain);
            this.Name = "CommentItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(400, 90);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.cardBubble.ResumeLayout(false);
            this.cardBubble.PerformLayout();
            this.cmsComment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMain;
        private AvatarCircle picAvatar;
        private CardPanel cardBubble;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWorked;
        private System.Windows.Forms.Label lblAuthor;
        private EmployeeManagement_Windows.Controls.ModernButton btnMore;
        private System.Windows.Forms.ContextMenuStrip cmsComment;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
