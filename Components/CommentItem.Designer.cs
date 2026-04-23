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
            this.cardBubble = new CardPanel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblWorked = new System.Windows.Forms.Label();
            this.cardBubble.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardBubble
            // 
            this.cardBubble.BackColor = System.Drawing.Color.Transparent;
            this.cardBubble.BorderRadius = 15;
            this.cardBubble.CardColor = System.Drawing.Color.White;
            this.cardBubble.Controls.Add(this.lblWorked);
            this.cardBubble.Controls.Add(this.lblTime);
            this.cardBubble.Controls.Add(this.lblText);
            this.cardBubble.Controls.Add(this.lblAuthor);
            this.cardBubble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBubble.Location = new System.Drawing.Point(0, 0);
            this.cardBubble.Name = "cardBubble";
            this.cardBubble.Padding = new System.Windows.Forms.Padding(10);
            this.cardBubble.ShadowSize = 3;
            this.cardBubble.Size = new System.Drawing.Size(400, 100);
            this.cardBubble.TabIndex = 0;
            // 
            // lblWorked
            // 
            this.lblWorked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorked.AutoSize = true;
            this.lblWorked.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblWorked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.lblWorked.Location = new System.Drawing.Point(280, 75);
            this.lblWorked.Name = "lblWorked";
            this.lblWorked.Size = new System.Drawing.Size(100, 13);
            this.lblWorked.TabIndex = 3;
            this.lblWorked.Text = "🕒 2hrs 30min worked";
            this.lblWorked.Visible = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(226)))));
            this.lblAuthor.Location = new System.Drawing.Point(12, 10);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 15);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author Name";
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblText.Location = new System.Drawing.Point(12, 30);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(370, 40);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Comment content goes here...";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.lblTime.Location = new System.Drawing.Point(330, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "10:30 AM";
            // 
            // CommentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardBubble);
            this.Name = "CommentItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(400, 100);
            this.cardBubble.ResumeLayout(false);
            this.cardBubble.PerformLayout();
            this.ResumeLayout(false);

        }

        private CardPanel cardBubble;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWorked;
    }
}
