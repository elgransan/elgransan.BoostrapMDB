using Oqtane.Models;
using Oqtane.Themes;

namespace elgransan.BoostrapMDB
{
    public class ThemeInfo : ITheme
    {
        public Theme Theme => new Theme
        {
            Name = "BoostrapMDB",
            Version = "1.0.0",
            PackageName = "elgransan.BoostrapMDB"
        };

    }
}
