using EmployeeManagement_Windows.Helpers;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Controls
{
    public class AvatarCircle : Control
    {
        private Image _image;
        public Image Image
        {
            get => _image;
            set { _image = value; this.Invalidate(); }
        }
        
        private string _initials = "U";
        public string Initials
        {
            get => _initials;
            set { _initials = value; this.Invalidate(); }
        }

        public AvatarCircle()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.BackColor = Color.Transparent;
            this.Size = new Size(40, 40);
            this.Cursor = Cursors.Hand;
        }

        public void SetImageFromBase64(string base64)
        {
            if (string.IsNullOrEmpty(base64))
            {
                this.Image = null;
                return;
            }

            try
            {
                if (base64.Contains(",")) base64 = base64.Split(',')[1];
                byte[] imageBytes = System.Convert.FromBase64String(base64);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    var loadedImg = Image.FromStream(ms);
                    this.Image = new Bitmap(loadedImg); // Create a copy so we can dispose the stream
                    loadedImg.Dispose();
                }
            }
            catch { this.Image = null; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color backColor = GetEffectiveBackColor();
            g.Clear(backColor);

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            if (rect.Width <= 1 || rect.Height <= 1) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path);

                if (_image != null)
                {
                    g.SetClip(path);
                    g.DrawImage(_image, rect);
                    g.ResetClip();
                }
                else
                {
                    using (SolidBrush brush = new SolidBrush(ThemeColors.Primary))
                        g.FillPath(brush, path);

                    TextRenderer.DrawText(g, _initials, new Font("Segoe UI", 12F, FontStyle.Bold),
                        rect, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }

                using (Pen pen = new Pen(ThemeColors.BorderColor, 1))
                    g.DrawEllipse(pen, rect);
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