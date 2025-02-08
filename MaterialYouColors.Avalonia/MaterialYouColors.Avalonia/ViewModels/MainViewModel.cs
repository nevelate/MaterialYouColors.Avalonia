using Avalonia;
using Avalonia.Styling;
using ReactiveUI;

namespace MaterialYouColors.Avalonia.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private bool isDarkTheme;

        public bool IsDarkTheme
        {
            get => isDarkTheme;
            set
            {
                if (value) Application.Current.RequestedThemeVariant = ThemeVariant.Dark;
                else Application.Current.RequestedThemeVariant = ThemeVariant.Light;
                this.RaiseAndSetIfChanged(ref isDarkTheme, value);
            }
        }

        public MainViewModel()
        {
            IsDarkTheme = Application.Current.ActualThemeVariant == ThemeVariant.Dark;
        }
    }
}
