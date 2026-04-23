using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Controls
{
    public class CardPanel : Panel
    {
        public int BorderRadius { get; set; } = 8;
        public Color CardColor { get; set; } = Color.White;
        public int ShadowSize { get; set; } = 5;

        public CardPanel()
        {
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color backColor = GetEffectiveBackColor();
            g.Clear(backColor);

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            if (rect.Width <= 1 || rect.Height <= 1) return;

            using (GraphicsPath path = GetRoundedRect(rect, BorderRadius))
            {
                using (SolidBrush brush = new SolidBrush(CardColor))
                    g.FillPath(brush, path);

                using (Pen pen = new Pen(EmployeeManagement_Windows.Helpers.ThemeColors.BorderColor, 1))
                    g.DrawPath(pen, path);
            }
        }

        private Color GetEffectiveBackColor()
        {
            Control parent = this.Parent;
            while (parent != null && parent.BackColor == Color.Transparent)
            {
                if (parent is CardPanel card && card != this) return card.CardColor;
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