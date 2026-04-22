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
            LoadData();
        }

        private void LoadData()
        {
            string author = _comment.AuthorName ?? "Unknown User";
            lblAuthor.Text = author;
            lblText.Text = _comment.CommentText ?? "No content";
            lblTime.Text = _comment.CreatedDate.HasValue ? _comment.CreatedDate.Value.ToString("hh:mm tt") : "";

            // Check if this comment is from the current user
            string currentUser = SessionManager.FullName ?? "";
            bool isMe = author.Equals(currentUser, StringComparison.OrdinalIgnoreCase);

            if (isMe)
            {
                this.Padding = new Padding(80, 5, 5, 5);
                cardBubble.CardColor = Color.FromArgb(243, 230, 255); // Light Purple
                lblAuthor.ForeColor = Color.FromArgb(74, 0, 224);
                lblAuthor.Text = "You";
            }
            else
            {
                this.Padding = new Padding(5, 5, 80, 5);
                cardBubble.CardColor = Color.White;
                lblAuthor.ForeColor = Color.FromArgb(142, 45, 226);
            }
        }
    }
}
