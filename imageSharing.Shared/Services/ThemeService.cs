namespace imageSharing.Shared.Services
{
    public class ThemeService
    {
        public Theme Theme { get; private set; } = Theme.Light;
        public event Action? OnChange;
        public void ToogleTheme()
        {
            Theme = Theme == Theme.Light ? Theme.Dark : Theme.Light;
            ModifyStateChanged();
            Console.WriteLine("ab");
        }
        private void ModifyStateChanged() => OnChange?.Invoke();
    }
}
