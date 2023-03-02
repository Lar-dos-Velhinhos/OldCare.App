using Microsoft.AspNetCore.Components;
using OldCare.App.Models.Sections;

namespace OldCare.App.Components;

public partial class MudTmSection
{
    private bool _open;

    [EditorRequired] [Parameter] public string? Title { set; get; }
    [EditorRequired] [Parameter] public SectionOptions? SectionOptions { set; get; }
    [Parameter] public RenderFragment? ChildContent { get; set; }

    protected override void OnInitialized()
    {
        if (SectionOptions is {DefaultOpen: true})
            _open = true;
    }
}