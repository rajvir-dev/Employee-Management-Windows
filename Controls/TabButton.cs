using EmployeeManagement_Windows.Helpers;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Controls
{
    public class TabButton : Control
    {
        private bool _isActive = false;
        private bool _isHovered = false;

        public bool IsActive
        {
            get => _isActive;
            set { _isActive = value; this.Invalidate(); }
        }

        public TabButton()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.Size = new Size(100, 40);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color backColor = GetEffectiveBackColor();
            g.Clear(backColor);

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            Color textColor = _isActive ? ThemeColors.Primary : ThemeColors.TextSecondary;
            if (_isHovered && !_isActive) textColor = ThemeColors.TextPrimary;

            TextRenderer.DrawText(g, this.Text, this.Font, rect, textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);

            if (_isActive)
            {
                using (Pen pen = new Pen(ThemeColors.Primary, 3))
                    g.DrawLine(pen, 0, this.Height - 2, this.Width, this.Height - 2);
            }
            else if (_isHovered)
            {
                using (Pen pen = new Pen(ThemeColors.BorderColor, 2))
                    g.DrawLine(pen, 0, this.Height - 2, this.Width, this.Height - 2);
            }
        }

        private Color GetEffectiveBackColor()
        {
            Control parent = this.Parent;
            while (parent != null && parent.BackColor == Color.Transparent)
            {
                if (parent is CardPanel card) return card.CardColor;
                parent = parent.Parent;
            }
            return parent?.BackColor ?? Color.White;
        }
    }
}