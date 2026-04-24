using EmployeeManagement_Windows.Helpers;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Controls
{
    public class ModernDatePicker : UserControl
    {
        private Label _lblValue;
        private Label _lblLabel;
        private bool _isFocused = false;
        private string _placeholderText = "Select date";
        private DateTime? _value = null;
        private MonthCalendar _calendar;
        private ToolStripDropDown _popup;

        public event EventHandler ValueChanged;

        public ModernDatePicker()
        {
            this.Size = new Size(250, 40); // Height matched to buttons
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.Cursor = Cursors.Hand;

            _lblLabel = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeColors.TextSecondary,
                Location = new Point(0, 0),
                AutoSize = true,
                Visible = false
            };

            _lblValue = new Label
            {
                Text = _placeholderText,
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.Gray,
                BackColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false
            };

            _calendar = new MonthCalendar
            {
                MaxSelectionCount = 1,
                TitleBackColor = ThemeColors.Primary,
                TitleForeColor = Color.White,
                TrailingForeColor = Color.Gray
            };

            _calendar.DateSelected += (s, e) => {
                Value = _calendar.SelectionStart;
                _popup.Close();
            };

            _popup = new ToolStripDropDown();
            ToolStripControlHost host = new ToolStripControlHost(_calendar);
            host.Margin = Padding.Empty;
            host.Padding = Padding.Empty;
            _popup.Items.Add(host);

            this.Controls.Add(_lblLabel);
            this.Controls.Add(_lblValue);

            this.Click += (s, e) => ShowCalendar();
            _lblValue.Click += (s, e) => ShowCalendar();

            UpdateLayout();
        }

        public DateTime? Value
        {
            get => _value;
            set
            {
                _value = value;
                if (_value.HasValue)
                {
                    _lblValue.Text = _value.Value.ToString("dd-MM-yyyy");
                    _lblValue.ForeColor = ThemeColors.TextPrimary;
                }
                else
                {
                    _lblValue.Text = _placeholderText;
                    _lblValue.ForeColor = Color.Gray;
                }
                ValueChanged?.Invoke(this, EventArgs.Empty);
                this.Invalidate();
            }
        }

        public string LabelText
        {
            get => _lblLabel.Text;
            set
            {
                _lblLabel.Text = value;
                _lblLabel.Visible = !string.IsNullOrEmpty(value);
                UpdateLayout();
            }
        }

        public string PlaceholderText
        {
            get => _placeholderText;
            set
            {
                _placeholderText = value;
                if (!_value.HasValue) _lblValue.Text = value;
                this.Invalidate();
            }
        }

        private void ShowCalendar()
        {
            if (_value.HasValue) _calendar.SetDate(_value.Value);
            _popup.Show(this, new Point(0, this.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int topOffset = _lblLabel.Visible ? _lblLabel.Height + 4 : 0;
            Rectangle rect = new Rectangle(0, topOffset, this.Width - 1, this.Height - topOffset - 1);
            if (rect.Width <= 1 || rect.Height <= 1) return;

            // Draw Background
            using (GraphicsPath path = GetRoundedRect(rect, 8))
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

            // Draw Calendar Icon
            int iconSize = 16;
            int iconX = this.Width - 30;
            int iconY = topOffset + (this.Height - topOffset - iconSize) / 2;
            
            using (Pen iconPen = new Pen(ThemeColors.TextSecondary, 1.5f))
            {
                g.DrawRectangle(iconPen, iconX, iconY + 2, iconSize, iconSize - 2);
                g.DrawLine(iconPen, iconX, iconY + 6, iconX + iconSize, iconY + 6);
                g.DrawLine(iconPen, iconX + 4, iconY, iconX + 4, iconY + 4);
                g.DrawLine(iconPen, iconX + 12, iconY, iconX + 12, iconY + 4);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            if (_lblValue == null || _lblLabel == null) return;

            int topOffset = _lblLabel.Visible ? _lblLabel.Height + 4 : 0;
            _lblValue.Location = new Point(10, topOffset + 1);
            _lblValue.Size = new Size(this.Width - 40, this.Height - topOffset - 2);
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
