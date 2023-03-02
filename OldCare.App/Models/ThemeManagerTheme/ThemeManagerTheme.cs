using MudBlazor;
using OldCare.App.Enums;

namespace OldCare.App.Models.ThemeManagerTheme;

internal class ThemeManagerTheme
{
    public string PresetThemes { get; set; }
    public Modes Mode { get; set; }
    public ThemeManagerThemePalette Palette { get; set; } = new();
    public int DefaultBorderRadiusAsInt { get; set; }
    public LayoutProperties LayoutProperties { get; set; }
}