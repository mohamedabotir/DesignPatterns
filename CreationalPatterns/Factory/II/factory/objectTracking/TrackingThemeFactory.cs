

namespace factory.objectTracking
{
    public class TrackingThemeFactory
    {
        private readonly List<WeakReference<ITheme>> themes = new();
        public ITheme CreateTheme(bool dark)
        {
            ITheme theme = dark ? new DarkTheme() : new LightTheme();
            themes.Add(new WeakReference<ITheme>(theme));
            return theme;
        }
        public string Info
        {
            get
            {
                return "Theme Created";
            }
        }
    }
}