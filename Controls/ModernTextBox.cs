using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagement_Windows.Helpers;

namespace EmployeeManagement_Windows.CustomControls
{
    public class ModernTextBox : UserControl
    {
        private TextBox _textBox;
        private Label _lblLabel;
        private bool _isFocused = false;

        public event EventHandler TextChanged;

        public ModernTextBox()
        {
            this.Size = new Size(250, 45);
            this.BackColor = Color.White;
            
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
                Location = new Point(5, 20),
                Width = this.Width - 10,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            };

            _textBox.GotFocus += (s, e) => { _isFocused = true; this.Invalidate(); };
            _textBox.LostFocus += (s, e) => { _isFocused = false; this.Invalidate(); };
            _textBox.TextChanged += (s, e) => TextChanged?.Invoke(this, e);

            this.Controls.Add(_lblLabel);
            this.Controls.Add(_textBox);
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
                    _textBox.Height = this.Height - 30;
                    _textBox.ScrollBars = ScrollBars.Vertical;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            
            Color lineColor = _isFocused ? ThemeColors.Primary : Color.FromArgb(223, 228, 234);
            int lineHeight = _isFocused ? 2 : 1;

            using (Pen pen = new Pen(lineColor, lineHeight))
            {
                g.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_textBox != null)
            {
                _textBox.Width = this.Width - 10;
                if (_textBox.Multiline) _textBox.Height = this.Height - 30;
            }
        }
    }
}
