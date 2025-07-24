namespace BlazorApp12.Service;   // <-- این خط را اضافه کن (file‑scoped namespace)

using MudBlazor;

public static class AppThemes
{
    public static readonly MudTheme KargardoonTheme = new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = Colors.Orange.Darken1,
            Secondary = Colors.Pink.Accent2,
            AppbarBackground = Colors.DeepPurple.Darken2,
            AppbarText = Colors.Shades.Black,
            Background = Colors.Gray.Darken1,
            Surface = Colors.Shades.White,
            TextPrimary = Colors.Gray.Darken4,
            TextSecondary = Colors.Gray.Darken1
        },
        PaletteDark = new PaletteDark
        {
            Primary = Colors.Orange.Darken4,
            Secondary = Colors.Pink.Lighten1,
            AppbarBackground = Colors.DeepPurple.Darken4,
            AppbarText = Colors.Shades.White,
            Background = Colors.Gray.Darken4,
            Surface = Colors.Gray.Darken3,
            TextPrimary = Colors.Shades.White,
            TextSecondary = Colors.Gray.Lighten1
        }
    };
}
