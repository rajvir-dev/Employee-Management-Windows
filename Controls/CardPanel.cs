using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.CustomControls
{
    public class CardPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;
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

            // 1. Force clear background with actual parent color
            Color backColor = GetEffectiveBackColor();
            g.Clear(backColor);

            Rectangle rect = new Rectangle(0, 0, this.Width - ShadowSize - 1, this.Height - ShadowSize - 1);
            
            if (rect.Width <= 1 || rect.Height <= 1) return;

            // 2. Draw Shadow
            if (ShadowSize > 0)
            {
                for (int i = 1; i <= ShadowSize; i++)
                {
                    Rectangle shadowRect = new Rectangle(i, i, rect.Width, rect.Height);
                    using (GraphicsPath shadowPath = GetRoundedRect(shadowRect, BorderRadius))
                    {
                        using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(10 / i, Color.Black)))
                        {
                            g.FillPath(shadowBrush, shadowPath);
                        }
                    }
                }
            }

            // 3. Draw Card Body
            using (GraphicsPath path = GetRoundedRect(rect, BorderRadius))
            {
                using (SolidBrush brush = new SolidBrush(CardColor))
                {
                    g.FillPath(brush, path);
                }
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
