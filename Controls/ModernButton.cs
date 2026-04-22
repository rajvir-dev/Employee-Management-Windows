using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.CustomControls
{
    public class ModernButton : Button
    {
        public int BorderRadius { get; set; } = 10;
        public Color GradientStart { get; set; } = Color.FromArgb(142, 45, 226); // Purple
        public Color GradientEnd { get; set; } = Color.FromArgb(74, 0, 224);   // Deep Purple
        
        private bool _isHovered = false;

        public ModernButton()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | 
                          ControlStyles.UserPaint | 
                          ControlStyles.AllPaintingInWmPaint | 
                          ControlStyles.OptimizedDoubleBuffer, true);
            
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.Size = new Size(150, 40);
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

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Force clear the background with the actual solid color of the parent
            Color backColor = GetEffectiveBackColor();
            using (var brush = new SolidBrush(backColor))
            {
                g.Clear(backColor); // Completely clear the surface
            }

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            if (rect.Width <= 1 || rect.Height <= 1) return;

            using (GraphicsPath path = GetRoundedRect(rect, BorderRadius))
            {
                this.Region = new Region(path);

                Color start = _isHovered ? LightenColor(GradientStart, 10) : GradientStart;
                Color end = _isHovered ? LightenColor(GradientEnd, 10) : GradientEnd;

                if (start != Color.Transparent || end != Color.Transparent)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect, start, end, LinearGradientMode.Vertical))
                    {
                        g.FillPath(brush, path);
                    }
                }

                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
                TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor, flags);
            }
        }

        private Color GetEffectiveBackColor()
        {
            Control parent = this.Parent;
            while (parent != null && parent.BackColor == Color.Transparent)
            {
                // If it's a CardPanel, use its CardColor instead of BackColor
                if (parent is CardPanel card) return card.CardColor;
                parent = parent.Parent;
            }
            return parent?.BackColor ?? Color.White;
        }

        private Color LightenColor(Color color, int percent)
        {
            if (color == Color.Transparent) return Color.Transparent;
            return Color.FromArgb(
                Math.Min(255, color.R + (255 - color.R) * percent / 100),
                Math.Min(255, color.G + (255 - color.G) * percent / 100),
                Math.Min(255, color.B + (255 - color.B) * percent / 100)
            );
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = Math.Min(radius * 2, Math.Min(rect.Width, rect.Height));
            if (d < 1) d = 1;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
