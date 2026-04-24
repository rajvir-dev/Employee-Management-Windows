namespace EmployeeManagement_Windows.Components
{
    using EmployeeManagement_Windows.Controls;

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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.picAvatar = new EmployeeManagement_Windows.Controls.AvatarCircle();
            this.cardBubble = new EmployeeManagement_Windows.Controls.CardPanel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblWorked = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.cardBubble.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblTime);
            this.pnlMain.Controls.Add(this.picAvatar);
            this.pnlMain.Controls.Add(this.cardBubble);
            this.pnlMain.Controls.Add(this.lblWorked);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(390, 90);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblTime.Location = new System.Drawing.Point(280, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 12);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "04:03 PM";
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Location = new System.Drawing.Point(340, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(40, 40);
            this.picAvatar.TabIndex = 1;
            // 
            // cardBubble
            // 
            this.cardBubble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblText.Size = new System.Drawing.Size(126, 17);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "task fully compiled";
            // 
            // lblWorked
            // 
            this.lblWorked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorked.AutoSize = true;
            this.lblWorked.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblWorked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblWorked.Location = new System.Drawing.Point(235, 58);
            this.lblWorked.Name = "lblWorked";
            this.lblWorked.Size = new System.Drawing.Size(95, 12);
            this.lblWorked.TabIndex = 3;
            this.lblWorked.Text = "🕒 3hrs 00min worked";
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
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMain;
        private AvatarCircle picAvatar;
        private CardPanel cardBubble;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWorked;
    }
}
