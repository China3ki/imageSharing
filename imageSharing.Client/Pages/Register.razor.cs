using imageSharing.Shared.Dto;
using imageSharing.Shared.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace imageSharing.Client.Pages
{
    public partial class Register
    {
        [Inject]
        protected ThemeService ThemeService { get; set; } = default!;
        private RegisterDto _loginDto = new();
        private EditContext? _loginContext;       
        public Register()
        {
            _loginContext = new(new RegisterDto());
        }
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
