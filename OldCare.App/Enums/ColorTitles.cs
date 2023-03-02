using System.ComponentModel;

namespace OldCare.App.Enums;

public enum ColorTitles
{
    [Description("Primary")] Primary,
    [Description("Secondary")] Secondary,
    [Description("Tertiary")] Tertiary,
    [Description("Info")] Info,
    [Description("Success")] Success,
    [Description("Warning")] Warning,
    [Description("Error")] Error,
    [Description("Dark")] Dark,
}