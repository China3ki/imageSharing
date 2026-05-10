using imageSharing.Shared.Services;
using Microsoft.AspNetCore.Components;

namespace imageSharing.Client.Pages
{
    public partial class Home
    {
        [Inject]
        protected ThemeService ThemeService { get; private set; } = default!;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender) await ThemeService.LoadTheme();
        }
        protected override async Task OnInitializedAsync()
        {
            ThemeService.OnChange += StateHasChanged;
        }
        public void Dispose()
        {
            ThemeService.OnChange -= StateHasChanged;
        }
    }
}
