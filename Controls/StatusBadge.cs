using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.CustomControls
{
    public class StatusBadge : Control
    {
        public Color BadgeColor { get; set; } = Color.FromArgb(142, 45, 226);
        public override string Text { get; set; } = "STATUS";

        public StatusBadge()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | 
                          ControlStyles.UserPaint | 
                          ControlStyles.AllPaintingInWmPaint | 
                          ControlStyles.OptimizedDoubleBuffer, true);
            
            this.BackColor = Color.Transparent;
            this.Size = new Size(100, 25);
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Force clear background with actual parent color
            Color backColor = GetEffectiveBackColor();
            g.Clear(backColor);

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            if (rect.Width <= 1 || rect.Height <= 1) return;

            int radius = this.Height / 2;

            // 2. Draw Background
            using (GraphicsPath path = GetRoundedRect(rect, radius))
            {
                this.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(30, BadgeColor)))
                {
                    g.FillPath(brush, path);
                }
                
                using (Pen pen = new Pen(BadgeColor, 1))
                {
                    g.DrawPath(pen, path);
                }
            }

            // 3. Draw Text
            TextRenderer.DrawText(g, this.Text.ToUpper(), new Font("Segoe UI", 8F, FontStyle.Bold), rect, BadgeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
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
