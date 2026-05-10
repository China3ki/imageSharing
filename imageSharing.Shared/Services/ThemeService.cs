using Majorsoft.Blazor.Extensions.BrowserStorage;

namespace imageSharing.Shared.Services
{
    public class ThemeService(ILocalStorageService localService)
    {
        public Theme Theme { get; private set; } = Theme.Light;
        public event Action? OnChange;
        public async Task ToogleTheme()
        {
            Theme = Theme == Theme.Light ? Theme.Dark : Theme.Light;
            await SetThemeCookies();
            ModifyStateChanged();
        }
        public async Task LoadTheme()
        {
            string loadedTheme = await GetThemeFromCookies();
            Theme = loadedTheme == "dark" ? Theme.Dark : Theme.Light;
            ModifyStateChanged();
        }
        private async Task SetThemeCookies()
        {
            switch (Theme)
            {
                case Theme.Dark:
                    await localService.SetItemAsync<string>("theme", "dark");
                    break;
                case Theme.Light:
                    await localService.SetItemAsync<string>("theme", "light");
                    break;
            }

        }
        private async Task<string> GetThemeFromCookies() => await localService.GetItemAsync<string>("theme");
        private void ModifyStateChanged() => OnChange?.Invoke();
    }
}
