using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EmployeeManagement_Windows.Helpers;

namespace EmployeeManagement_Windows.CustomControls
{
    public class ModernCard : Panel
    {
        public int BorderRadius { get; set; } = 15;
        public int ShadowSize { get; set; } = 5;
        public Color CardColor { get; set; } = Color.White;
        public string Title { get; set; } = "";
        
        private Label _lblTitle;

        public ModernCard()
        {
            this.SetStyle(ControlStyles.UserPaint | 
                          ControlStyles.AllPaintingInWmPaint | 
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.SupportsTransparentBackColor, true);
            
            this.BackColor = Color.Transparent;
            this.Padding = new Padding(20, 45, 20, 20); // Top padding leaves space for title
            
            _lblTitle = new Label
            {
                Text = this.Title,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = ThemeColors.TextPrimary,
                Location = new Point(20, 15),
                AutoSize = true,
                BackColor = Color.Transparent
            };
            this.Controls.Add(_lblTitle);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (_lblTitle != null) _lblTitle.Text = this.Text;
        }

        public override string Text
        {
            get => base.Text;
            set { base.Text = value; if (_lblTitle != null) _lblTitle.Text = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(ShadowSize, ShadowSize, this.Width - (ShadowSize * 2) - 1, this.Height - (ShadowSize * 2) - 1);

            // Draw Shadow (Soft simulation)
            for (int i = 1; i <= ShadowSize; i++)
            {
                using (GraphicsPath shadowPath = GetRoundedRect(new Rectangle(rect.X - i, rect.Y - i, rect.Width + (i * 2), rect.Height + (i * 2)), BorderRadius + i))
                {
                    using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(10 / i, Color.Black)))
                    {
                        g.FillPath(shadowBrush, shadowPath);
                    }
                }
            }

            // Draw Card Body
            using (GraphicsPath path = GetRoundedRect(rect, BorderRadius))
            {
                using (SolidBrush brush = new SolidBrush(CardColor))
                {
                    g.FillPath(brush, path);
                }
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
