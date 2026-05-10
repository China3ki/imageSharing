using imageSharing.Client.Services;
using imageSharing.Shared.Services;
using Microsoft.AspNetCore.Components;

namespace imageSharing.Client.Components
{
    public partial class Header
    {
        [Inject]
        protected ThemeService ThemeService { get; private set; } = default!;
        [Inject]
        protected SearchService SearchService { get; private set; } = default!;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender) await ThemeService.LoadTheme();
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
