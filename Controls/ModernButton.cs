using EmployeeManagement_Windows.Controls;
using EmployeeManagement_Windows.Helpers;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Controls
{
    public enum ButtonStyle
    {
        Primary,
        Dark,
        Outline
    }

    public class ModernButton : Button
    {
        public int BorderRadius { get; set; } = 8;

        // Dummy properties to prevent Designer from crashing on older forms
        public Color GradientStart { get; set; }
        public Color GradientEnd { get; set; }

        public ButtonStyle Style { get; set; } = ButtonStyle.Primary;

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

            // Force clear the background with the actual solid color of the parent
            Color backColor = GetEffectiveBackColor();
            using (var brush = new SolidBrush(backColor))
            {
                g.Clear(backColor);
            }

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            if (rect.Width <= 1 || rect.Height <= 1) return;

            using (GraphicsPath path = GetRoundedRect(rect, BorderRadius))
            {
                this.Region = new Region(GetRoundedRect(new Rectangle(0, 0, this.Width, this.Height), BorderRadius));

                Color fillColor = ThemeColors.Primary;
                Color textColor = Color.White;
                Color borderColor = Color.Transparent;

                switch (Style)
                {
                    case ButtonStyle.Primary:
                        fillColor = _isHovered ? ThemeColors.PrimaryDark : ThemeColors.Primary;
                        textColor = Color.White;
                        break;
                    case ButtonStyle.Dark:
                        fillColor = _isHovered ? LightenColor(ThemeColors.DarkButton, 20) : ThemeColors.DarkButton;
                        textColor = Color.White;
                        break;
                    case ButtonStyle.Outline:
                        fillColor = _isHovered ? Color.FromArgb(10, ThemeColors.Primary) : Color.White;
                        textColor = ThemeColors.Primary;
                        borderColor = ThemeColors.Primary;
                        break;
                }

                // Fill background
                using (SolidBrush brush = new SolidBrush(fillColor))
                {
                    g.FillPath(brush, path);
                }

                // Draw border for Outline style
                if (Style == ButtonStyle.Outline)
                {
                    using (Pen pen = new Pen(borderColor, 1))
                    {
                        g.DrawPath(pen, path);
                    }
                }

                // Draw Text
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
                TextRenderer.DrawText(g, this.Text, this.Font, rect, textColor, flags);
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

        private Color LightenColor(Color color, int percent)
        {
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
