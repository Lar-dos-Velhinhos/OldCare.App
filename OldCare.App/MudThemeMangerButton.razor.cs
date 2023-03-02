using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace OldCare.App;

public partial class MudThemeManagerButton
{
    /// <summary>
    ///     Action to be executed when the button is clicked.
    /// </summary>
    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }
}