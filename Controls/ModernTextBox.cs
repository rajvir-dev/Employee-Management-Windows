using EmployeeManagement_Windows.Helpers;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Controls
{
    public class ModernTextBox : UserControl
    {
        private TextBox _textBox;
        private Label _lblLabel;
        private bool _isFocused = false;

        public event EventHandler TextChanged;

        public ModernTextBox()
        {
            this.Size = new Size(250, 60);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            _lblLabel = new Label
            {
                Text = "Label",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextSecondary,
                Location = new Point(0, 0),
                AutoSize = true
            };

            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 10F),
                ForeColor = ThemeColors.TextPrimary,
                BackColor = Color.White
            };

            _textBox.GotFocus += (s, e) => { _isFocused = true; this.Invalidate(); };
            _textBox.LostFocus += (s, e) => { _isFocused = false; this.Invalidate(); };
            _textBox.TextChanged += (s, e) => TextChanged?.Invoke(this, e);

            this.Controls.Add(_lblLabel);
            this.Controls.Add(_textBox);

            UpdateLayout();
        }

        public override string Text
        {
            get => _textBox.Text;
            set => _textBox.Text = value;
        }

        public string LabelText
        {
            get => _lblLabel.Text;
            set => _lblLabel.Text = value;
        }

        public bool PasswordChar
        {
            get => _textBox.UseSystemPasswordChar;
            set => _textBox.UseSystemPasswordChar = value;
        }

        public char PasswordCharValue
        {
            get => _textBox.PasswordChar;
            set => _textBox.PasswordChar = value;
        }

        public bool Multiline
        {
            get => _textBox.Multiline;
            set
            {
                _textBox.Multiline = value;
                if (value)
                {
                    _textBox.ScrollBars = ScrollBars.Vertical;
                }
                UpdateLayout();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int labelHeight = _lblLabel.Height > 0 ? _lblLabel.Height : 20;
            int topOffset = string.IsNullOrEmpty(_lblLabel.Text) ? 0 : labelHeight + 4;

            Rectangle rect = new Rectangle(0, topOffset, this.Width - 1, this.Height - topOffset - 1);
            if (rect.Width <= 1 || rect.Height <= 1) return;

            // Draw Background of input box
            using (GraphicsPath path = GetRoundedRect(rect, 6))
            {
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    g.FillPath(brush, path);
                }

                Color borderColor = _isFocused ? ThemeColors.Primary : ThemeColors.BorderColor;
                using (Pen pen = new Pen(borderColor, 1))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            if (_textBox == null || _lblLabel == null) return;

            int labelHeight = _lblLabel.Height > 0 ? _lblLabel.Height : 20;
            int topOffset = string.IsNullOrEmpty(_lblLabel.Text) ? 0 : labelHeight + 4;

            if (Multiline)
            {
                _textBox.Location = new Point(8, topOffset + 8);
                _textBox.Size = new Size(this.Width - 16, this.Height - topOffset - 16);
            }
            else
            {
                int textBoxTop = topOffset + ((this.Height - topOffset - _textBox.Height) / 2);
                _textBox.Location = new Point(8, textBoxTop);
                _textBox.Size = new Size(this.Width - 16, _textBox.Height);
            }
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
