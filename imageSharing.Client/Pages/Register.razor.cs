using imageSharing.Shared.Dto;
using imageSharing.Shared.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace imageSharing.Client.Pages
{
    public partial class Register
    {
        [Inject]
        protected ThemeService ThemeService { get; set; } = default!;
        [Inject]
        protected HttpClient HttpClient { get; set; } = default!;
        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;
        private RegisterDto _registerDto = new();
        private EditContext? _registerContext;       
        public Register()
        {
            _registerContext = new(_registerDto);
        }
        private async Task Submit()
        {
            string api = $"{NavigationManager.BaseUri}api/Register";
            string registerDtoToJson = JsonSerializer.Serialize(_registerDto);
            try
            {
                var response = await HttpClient.PostAsJsonAsync(api, _registerDto);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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
