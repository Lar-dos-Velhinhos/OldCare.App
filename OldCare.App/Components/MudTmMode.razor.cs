using Microsoft.AspNetCore.Components;
using OldCare.App.Enums;

namespace OldCare.App.Components;

public partial class MudTmMode
{
    [EditorRequired] [Parameter] public Modes Mode { get; set; }
    [EditorRequired] [Parameter] public EventCallback<Modes> ModeChanged { get; set; }

    private void UpdateMode(Modes mode)
    {
        Mode = mode;
        ModeChanged.InvokeAsync(mode);
    }
}