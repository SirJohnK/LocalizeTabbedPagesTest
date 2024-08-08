using System.Globalization;

namespace LocalizeTabbedPagesTest;

public partial class ThirdTabPage : ContentPage
{
    public ThirdTabPage()
    {
        InitializeComponent();
    }

    private void OnToggleLanguage(object sender, EventArgs e)
    {
        var languages = new List<string>() { "en", "fr", "de", "es", "sv" };
        var culture = MauiProgram.ResourceManager.CurrentCulture;
        var index = languages.IndexOf(culture.TwoLetterISOLanguageName);
        MauiProgram.ResourceManager.CurrentCulture = new CultureInfo(languages[++index < languages.Count ? index : 0]);
    }
}