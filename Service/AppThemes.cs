namespace BlazorApp12.Service;

using MudBlazor;

public static class AppThemes
{
    public static readonly MudTheme KargardoonTheme = new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#2563EB",
            Secondary = "#0EA5A6",
            Info = "#0284C7",
            Success = "#16A34A",
            Warning = "#F59E0B",
            Error = "#DC2626",
            AppbarBackground = "#FFFFFF",
            AppbarText = "#0F172A",
            Background = "#F6F7FB",
            Surface = "#FFFFFF",
            TextPrimary = "#0F172A",
            TextSecondary = "#475569",
            ActionDefault = "#EEF2F6",
            //ActionDefaultHover = "#E3E8EF",
            DrawerBackground = "#FFFFFF",
            DrawerText = "#0F172A",
            DrawerIcon = "#64748B"
        },
        PaletteDark = new PaletteDark
        {
            Primary = "#60A5FA",
            Secondary = "#2DD4BF",
            Info = "#38BDF8",
            Success = "#22C55E",
            Warning = "#FBBF24",
            Error = "#F87171",
            AppbarBackground = "#101114",
            AppbarText = "#FFFFFF",
            Background = "#0C0D10",
            Surface = "#14161A",
            TextPrimary = "#FFFFFF",
            TextSecondary = "#B0B3B8",
            ActionDefault = "#1F232A",
            //ActionDefaultHover = "#262B34",
            DrawerBackground = "#14161A",
            DrawerText = "#E5E7EB",
            DrawerIcon = "#B0B3B8"
        }
    };
}
