using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Helpers
{
    public static class ThemeColors
    {
        // Catppuccin Mocha Dark Mode Palette
        public static Color Background = ColorTranslator.FromHtml("#1e1e2e");
        public static Color Surface = ColorTranslator.FromHtml("#313244");
        public static Color Surface1 = ColorTranslator.FromHtml("#45475a");
        
        public static Color TextPrimary = ColorTranslator.FromHtml("#cdd6f4");
        public static Color TextSecondary = ColorTranslator.FromHtml("#a6adc8");

        public static Color Primary = ColorTranslator.FromHtml("#cba6f7"); // Mauve
        public static Color PrimaryDark = ColorTranslator.FromHtml("#b4befe"); // Lavender
        
        // Status Colors
        public static Color Success = ColorTranslator.FromHtml("#a6e3a1"); // Green
        public static Color Warning = ColorTranslator.FromHtml("#f9e2af"); // Yellow
        public static Color Danger = ColorTranslator.FromHtml("#f38ba8"); // Red

        // Backward Compatibility Aliases (Catppuccin Mocha)
        public static Color Base => Background;
        public static Color Mantle => ColorTranslator.FromHtml("#181825");
        public static Color Crust => ColorTranslator.FromHtml("#11111b");
        public static Color Surface0 => ColorTranslator.FromHtml("#313244");
        public static Color Text => TextPrimary;
        public static Color Subtext1 => TextSecondary;
        public static Color Overlay0 => ColorTranslator.FromHtml("#6c7086");
        public static Color Overlay1 => ColorTranslator.FromHtml("#7f849c");
        public static Color Mauve => Primary;
        public static Color Red => Danger;
        public static Color Green => Success;
        public static Color Yellow => Warning;
        public static Color Peach => ColorTranslator.FromHtml("#fab387");
        public static Color Sapphire => ColorTranslator.FromHtml("#74c7ec");

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
