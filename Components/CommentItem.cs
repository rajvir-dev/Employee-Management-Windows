using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Core;
using EmployeeManagement_Windows.Models;

namespace EmployeeManagement_Windows.Components
{
    public partial class CommentItem : UserControl
    {
        private CommentDto _comment;

        public CommentItem(CommentDto comment)
        {
            _comment = comment;
            InitializeComponent();
            this.Margin = new Padding(0, 0, 0, 15);
            LoadData();
        }

        private void LoadData()
        {
            lblText.Text = _comment.CommentText ?? "No content";
            lblTime.Text = _comment.CreatedDate.HasValue ? _comment.CreatedDate.Value.ToString("hh:mm tt") : "";
            lblAuthor.Text = _comment.AuthorName ?? "Unknown";

            if (!string.IsNullOrEmpty(_comment.PhotoBase64))
            {
                picAvatar.SetImageFromBase64(_comment.PhotoBase64);
            }

            // Check if this comment is from the current user
            string currentUser = SessionManager.FullName ?? "";
            bool isMe = (_comment.AuthorName ?? "").Equals(currentUser, StringComparison.OrdinalIgnoreCase);

            // Display Work Log
            if (_comment.HoursWorked > 0 || _comment.MinutesWorked > 0)
            {
                lblWorked.Text = $"🕒 {(_comment.HoursWorked ?? 0)}hrs {(_comment.MinutesWorked ?? 0)}min worked";
                lblWorked.Visible = true;
            }
            else
            {
                lblWorked.Visible = false;
            }

            // Apply Layout & Themes
            int maxBubbleWidth = (int)(pnlMain.Width * 0.7);
            lblText.MaximumSize = new Size(maxBubbleWidth - 24, 0);
            cardBubble.Width = lblText.PreferredWidth + 24;
            cardBubble.Height = lblText.PreferredHeight + 16;

            if (isMe)
            {
                // RIGHT SIDE (Me)
                lblAuthor.Visible = false; // Usually don't show your own name in chat bubbles
                
                lblTime.Location = new Point(pnlMain.Width - lblTime.Width - 45, 0);
                lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                cardBubble.Location = new Point(pnlMain.Width - cardBubble.Width - 45, 15);
                cardBubble.CardColor = Color.FromArgb(99, 102, 241); // Indigo 500
                lblText.ForeColor = Color.White;
                cardBubble.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                picAvatar.Location = new Point(pnlMain.Width - picAvatar.Width - 5, 15);
                picAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                if (lblWorked.Visible)
                {
                    lblWorked.Location = new Point(cardBubble.Right - lblWorked.Width, cardBubble.Bottom + 4);
                    lblWorked.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
            }
            else
            {
                // LEFT SIDE (Others)
                lblAuthor.Visible = true;
                lblAuthor.Text = $"{_comment.AuthorName} , {lblTime.Text}";
                lblTime.Visible = false; // Combined with author label

                picAvatar.Location = new Point(5, 0);
                picAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                lblAuthor.Location = new Point(picAvatar.Right + 8, 5);
                lblAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                cardBubble.Location = new Point(picAvatar.Right + 8, lblAuthor.Bottom + 5);
                cardBubble.CardColor = Color.FromArgb(243, 244, 246); // Gray 100
                lblText.ForeColor = Color.FromArgb(31, 41, 55); // Gray 800
                cardBubble.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                if (lblWorked.Visible)
                {
                    lblWorked.Location = new Point(cardBubble.Left, cardBubble.Bottom + 4);
                    lblWorked.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }
            }

            // Final Height
            int bottomMost = cardBubble.Bottom;
            if (lblWorked.Visible) bottomMost = lblWorked.Bottom;
            this.Height = bottomMost + 15;
        }
    }
}
