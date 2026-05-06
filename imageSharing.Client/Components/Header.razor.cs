using imageSharing.Shared.Services;
using Microsoft.AspNetCore.Components;

namespace imageSharing.Client.Components
{
    public partial class Header
    {
        [Inject]
        public ThemeService ThemeService { get; set; } = default!;
        protected override void OnInitialized()
        {
            ThemeService.OnChange += StateHasChanged;
        }
        public void Dispose()
        {
            ThemeService.OnChange -= StateHasChanged;
        }
    }
}
