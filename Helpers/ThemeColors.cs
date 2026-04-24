using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement_Windows.Helpers
{
    public static class ThemeColors
    {
        // New Modern Light Web-Inspired Theme
        public static Color Background = ColorTranslator.FromHtml("#F3F4F6"); // Light gray-blue page bg
        public static Color Surface = ColorTranslator.FromHtml("#FFFFFF"); // White card surface
        public static Color Surface1 = ColorTranslator.FromHtml("#F8F9FA"); // Light alternate surface
        
        public static Color TextPrimary = ColorTranslator.FromHtml("#111827"); // Dark gray
        public static Color TextSecondary = ColorTranslator.FromHtml("#6B7280"); // Muted gray
        public static Color BorderColor = ColorTranslator.FromHtml("#E5E7EB"); // 1px flat borders

        public static Color Primary = ColorTranslator.FromHtml("#6B5FE4"); // Purple primary accent
        public static Color PrimaryDark = ColorTranslator.FromHtml("#534AB7"); // Darker purple for active states
        
        public static Color DarkButton = ColorTranslator.FromHtml("#374151"); // Dark button fill
        
        // Status Colors (Solid colors for badges)
        public static Color Success = ColorTranslator.FromHtml("#10B981"); // Green
        public static Color Warning = ColorTranslator.FromHtml("#F59E0B"); // Amber/Yellow
        public static Color Danger = ColorTranslator.FromHtml("#E24B4A"); // Red

        // Status Badge Tokens
        public static class StatusBadgeColors
        {
            public static (Color bg, Color text) Scheduled = (ColorTranslator.FromHtml("#EEEDFE"), ColorTranslator.FromHtml("#534AB7"));
            public static (Color bg, Color text) Assigned = (ColorTranslator.FromHtml("#E0F2FE"), ColorTranslator.FromHtml("#0369A1")); // Blue
            public static (Color bg, Color text) Concluded = (ColorTranslator.FromHtml("#374151"), ColorTranslator.FromHtml("#D1D5DB"));
            public static (Color bg, Color text) Cancelled = (ColorTranslator.FromHtml("#E24B4A"), Color.White);
            public static (Color bg, Color text) Pending = (ColorTranslator.FromHtml("#FEF3C7"), ColorTranslator.FromHtml("#92400E"));
            public static (Color bg, Color text) Approved = (ColorTranslator.FromHtml("#D1FAE5"), ColorTranslator.FromHtml("#065F46"));
            public static (Color bg, Color text) Rejected = (ColorTranslator.FromHtml("#FEE2E2"), ColorTranslator.FromHtml("#991B1B"));
            public static (Color bg, Color text) InProgress = (ColorTranslator.FromHtml("#FEF3C7"), ColorTranslator.FromHtml("#D97706")); // Amber/Yellow
        }

        // Backward Compatibility Aliases (Map old Catppuccin aliases to new theme)
        public static Color Base => Background;
        public static Color Mantle => Surface1;
        public static Color Crust => Surface;
        public static Color Surface0 => Surface;
        public static Color Text => TextPrimary;
        public static Color Subtext1 => TextSecondary;
        public static Color Overlay0 => BorderColor;
        public static Color Overlay1 => TextSecondary;
        public static Color Mauve => Primary;
        public static Color Red => Danger;
        public static Color Green => Success;
        public static Color Yellow => Warning;
        public static Color Peach => Warning;
        public static Color Sapphire => Primary;

        public static void ApplyTheme(Form form)
        {
            // Custom painting logic handles theme application via controls
        }

        public static Color GetStatusColor(int? statusId)
        {
            switch (statusId)
            {
                case 1: return TextSecondary; // To Do
                case 2: return Warning; // In Progress
                case 3: return Success; // Completed
                default: return TextSecondary;
            }
        }
    }
}
