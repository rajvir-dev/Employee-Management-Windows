using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Helpers
{
    public static class ThemeColors
    {
        // Modern SaaS Purple Theme
        public static Color Primary = Color.FromArgb(142, 45, 226);
        public static Color PrimaryDark = Color.FromArgb(74, 0, 224);
        
        public static Color Background = Color.FromArgb(248, 249, 250);
        public static Color Surface = Color.FromArgb(255, 255, 255);
        
        public static Color TextPrimary = Color.FromArgb(45, 52, 54);
        public static Color TextSecondary = Color.FromArgb(99, 110, 114);

        // Status Colors
        public static Color Success = Color.FromArgb(0, 184, 148);
        public static Color Warning = Color.FromArgb(253, 203, 110);
        public static Color Danger = Color.FromArgb(214, 48, 49);

        // Backward Compatibility Aliases (Catppuccin to SaaS Purple)
        public static Color Base => Background;
        public static Color Mantle => Color.FromArgb(241, 242, 246);
        public static Color Crust => Color.FromArgb(223, 228, 234);
        public static Color Surface0 => Color.FromArgb(255, 255, 255);
        public static Color Surface1 => Color.FromArgb(241, 242, 246);
        public static Color Text => TextPrimary;
        public static Color Subtext1 => TextSecondary;
        public static Color Overlay0 => Color.FromArgb(116, 125, 140);
        public static Color Overlay1 => Color.FromArgb(164, 176, 190);
        public static Color Mauve => Primary;
        public static Color Red => Danger;
        public static Color Green => Success;
        public static Color Yellow => Warning;
        public static Color Peach => Color.FromArgb(255, 127, 80);
        public static Color Sapphire => PrimaryDark;

        public static void ApplyTheme(Form form)
        {
            // Dummy for compatibility, we are moving to custom painting
        }

        public static Color GetStatusColor(int? statusId)
        {
            switch (statusId)
            {
                case 1: return Color.FromArgb(108, 92, 231); // To Do
                case 2: return Warning; // In Progress
                case 3: return Success; // Completed
                default: return TextSecondary;
            }
        }
    }
}
